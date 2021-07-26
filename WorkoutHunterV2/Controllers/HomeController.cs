using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using WorkoutHunterV2.Models;
using WorkoutHunterV2.Models.DbModels;
using WorkoutHunterV2.Models.Home;

namespace WorkoutHunterV2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly WorkoutHunterContext _context;
        private IMemoryCache _cache;

        public HomeController(ILogger<HomeController> logger, WorkoutHunterContext context, IMemoryCache cache)
        {
            _logger = logger;
            _context = context;
            _cache = cache;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(User user)
        {
            // 格式不正確返回錯誤
            if (!ModelState.IsValid)
                return Content("格式錯誤的頁面");

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
                        // 設置了一個 1 天 有效期的持久化 cookie
                        IsPersistent = true,
                        ExpiresUtc = DateTimeOffset.UtcNow.AddSeconds(60)
                    });


                    return Redirect("/Student/Index");
                }
                // 密碼錯誤
                else
                    return Content("密碼錯誤的頁面");
            }
            // 帳號不存在
            else
                return Content("帳號不存在的頁面");
        }

        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Register(string email, string password, string repassword, string role)
        {
            if (password != repassword)
            {
                TempData["miss"] = "<script>alert('密碼不一致')</script>";
                return View();
            }

            Verifier V = new Verifier();

            byte[] usersalt = V.createSalt();

            // 新增一筆資料的物件
            UserInfo sign = new UserInfo
            {
                Uid = V.UID(),
                Email = email,
                PassWord = V.createHash(password, usersalt),
                Role = role,
                SignDate = DateTime.Now.ToString("yyyy/MM/dd"),
                Class = "D",
                Salt = Convert.ToBase64String(usersalt)
            };

            _context.Add(sign);
            _context.SaveChanges();

            return Redirect("Login");
        }

        public IActionResult ForgotPassword()
        {
            return View();
        }
        [HttpPost]
        public IActionResult ForgotPassword(string Email)
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
            if (_cache.TryGetValue("UserLoginInfo", out myCache))
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
                
                string str = emailworker.RondomSTR().Replace("+", "%2B");
                emailworker.content = " <a href='https://localhost:44370/home/CheckEmail?Key=" + str + "'>認證點我</a> ";

                
                myCache.U = emailworker.UID;
                myCache.K = emailworker.Key;
                _cache.Set("UserLoginInfo", myCache, TimeSpan.FromSeconds(60));

                emailworker.MailSend();
                return Content("認證信已寄出");
            }
        }
        public IActionResult CheckEmail(string Key)
        {
            MyCache cache;
            if (_cache.TryGetValue("UserLoginInfo", out cache))
            {
                if (Convert.ToBase64String(cache.K) == Key)
                    // 認證許可，修改密碼頁面
                    return Content("認證許可，修改密碼頁面");
            }
            // 認證過期頁面
            return Content("認證過期頁面");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
