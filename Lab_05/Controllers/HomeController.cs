using Lab_05.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using System.Security.Claims;
using Microsoft.Extensions.Caching.Memory;

namespace Lab_05.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private IMemoryCache _cache;
        private readonly ILogger<HomeController> _logger;
        private workouthunterContext _context;

        public HomeController(ILogger<HomeController> logger, workouthunterContext context, IMemoryCache memoryCache)
        {
            _cache = memoryCache;
            _context = context;
            _logger = logger;
        }
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();

            return Redirect("/");
        }
        public IActionResult Index()
        {

            return View();
        }
        [AllowAnonymous]
        public IActionResult Forgot()
        {
            return View();
        }
        [AllowAnonymous]
        public IActionResult Check(string Com)
        {
            MyCache cache;
            if (_cache.TryGetValue("Email", out cache))
            {
                EmailWorker emailwroker = new EmailWorker()
                {
                    Com = Com,
                    Key = cache.K,
                };
                if (emailwroker.disCom() && cache.U == emailwroker.UID)
                {
                    // ================================
                    // ///////////修改密碼//////////////
                    // ================================
                    // 編碼 -> 產生salt > 混和密碼
                    Verifier V = new Verifier();
                    byte[] salt = V.createSalt();
                    string Psw = V.createHash(cache.Password, salt);
                    string Salt = Convert.ToBase64String(salt);
                    // 放入資料庫 -> salt與編碼後的密碼取代原本的資料
                    var query = from o in _context.UserInfos
                                where o.Uid == cache.U
                                select o;
                    UserInfo G = query.FirstOrDefault();
                    
                    if (G != null)
                    {
                        G.PassWord = Psw;
                        G.Salt = Salt;
                        _context.SaveChanges();
                    }
                    // ================================
                    // ////////////////////////////////
                    // ================================
                    _cache.Remove("Email");
                    return Content("認證及修改成功!!");
                }
            }
            return Content("認證失敗");
        }
        [AllowAnonymous]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [AllowAnonymous]
        public IActionResult Forgot(string Email, string Password)
        {
            MyCache myCache;
            // 確認帳號存在
            var user = (from o in _context.UserInfos
                        where o.Email == Email
                        select o).FirstOrDefault();
            if (user == null)
            {
                return Content("無此信箱的使用者資料");
            }
            // 若緩存還存在
            if (_cache.TryGetValue("Email", out myCache))
            {
                return Content("認證信已寄出，不得重複寄出");
            }
            // 若此緩存不存在 > 寄出認證信
            else
            {
                myCache = new MyCache();
                EmailWorker emailworker = new EmailWorker()
                {
                    addressee = "ub1213go@gmail.com",
                    sendEmail = "ub1213gogo@gmail.com",
                    sendPassword = "Online12",
                    subject = "註冊認證",
                    UID = user.Uid,
                };
                emailworker.mixUid();
                string str = emailworker.Com.Replace("+", "%2B");

                emailworker.content = " <a href='https://localhost:44389/home/Check?Com=" + str + "'>認證點我</a> ";

                myCache.C = emailworker.Com;
                myCache.U = emailworker.UID;
                myCache.K = emailworker.Key;
                myCache.Password = Password;
                _cache.Set("Email", myCache, TimeSpan.FromSeconds(60));

                emailworker.MailSend();
                return Content("認證信已寄出");
            }
        }
        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Login(User user)
        {
            // 格式不正確返回錯誤
            if (!ModelState.IsValid)
                return Content("格式錯誤");

            // 宣告變數
            Verifier V = new Verifier();
            UserInfo data = null;
            string userPsw = "";
            var query = from o in _context.UserInfos
                        where o.Email == user.Email
                        select o;

            foreach (UserInfo item in query)
            {
                if (item.Email == user.Email)
                    data = item;
            }
            if (data != null)
            {
                userPsw = V.createHash(user.Password, Convert.FromBase64String(data.Salt));
                if (data.PassWord == userPsw)
                {
                    // 建立Claim
                    Claim[] claims = new Claim[]
                    {
                        new Claim("ID", data.Uid),
                        new Claim("Email", user.Email),
                        new Claim(ClaimTypes.Role, data.Role),

                    };

                    ClaimsIdentity claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                    ClaimsPrincipal principal = new ClaimsPrincipal(claimsIdentity);

                    await HttpContext.SignInAsync(principal, new AuthenticationProperties()
                    {
                        //是否可以被刷新
                        AllowRefresh = false,
                        IsPersistent = true,
                        ExpiresUtc = DateTimeOffset.UtcNow.AddSeconds(10)
                    });
                    
                    // 驗證成功
                    return Redirect("/");

                }
                // 密碼錯誤
                else
                    return Content("密碼錯誤");
            }
            // 帳號不存在
            else
                return Content("帳號不存在");


            //============================================================
            // 顯示結果
            string str = 
                $"Email: {user.Email} Password: {user.Password} {ModelState.IsValid} \n 比對Email: {data.Email} 比對密碼: {data.PassWord} \n 輸入的hash密碼: {userPsw}";
            Console.WriteLine(str);
            //============================================================
        }
        [Authorize(Roles = "C")]
        public IActionResult Privacy()
        {
            return View();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
