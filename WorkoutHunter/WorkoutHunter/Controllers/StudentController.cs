using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WorkoutHunter.Models;
using Microsoft.Data.SqlClient;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using System.Security.Claims;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Http;
using static System.Net.Mime.MediaTypeNames;
using Microsoft.Extensions.Caching.Memory;

namespace WorkoutHunter.Controllers
{
    [Authorize]
    public class StudentController : Controller
    {
        private readonly ILogger<StudentController> _logger;
        private readonly userContext _context;
        private IMemoryCache _cache;

        public StudentController(ILogger<StudentController> logger, userContext context, IMemoryCache memoryCache)
        {
            _context = context;
            _logger = logger;
            _cache = memoryCache;
        }

    //=========================【07/21 註冊登入系統整合】===============================================================================

        [AllowAnonymous]
        public IActionResult Login()
        {
            ForIndex test = (from o in _context.forindex
                             where o.UID == "B5b165PNvx"
                             select o).FirstOrDefault();

            return Content(test.UID.ToString());
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Login(User user)
        {
            // 格式不正確返回錯誤
            if (!ModelState.IsValid)
                return BadRequest();

            // 宣告變數
            Verifier V = new Verifier();
            userInfo data = null;
            string userPsw = "";
            var query = from o in _context.user_info
                        where o.Email == user.Email
                        select o;

            foreach (userInfo item in query)
            {
                if (item.Email == user.Email)
                    data = item;
            }
            if (data != null)
            {
                userPsw = V.createHash(user.Password, Convert.FromBase64String(data.salt));
                if (data.PassWord == userPsw)
                {
                    // 建立Claim
                    Claim[] claims = new Claim[]
                    {
                        new Claim("ID", data.UID),
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
                        ExpiresUtc = DateTimeOffset.UtcNow.AddSeconds(10)
                    });


                    // 驗證成功
                    return Redirect("/Home/Index");

                }
                // 密碼錯誤
                else
                    return BadRequest();
            }
            // 帳號不存在
            else
                return BadRequest();


//============================================================================================================================================================================
            // 顯示結果
            string str =
                $"Email: {user.Email} Password: {user.Password} {ModelState.IsValid} \n 比對Email: {data.Email} 比對密碼: {data.PassWord} \n 輸入的hash密碼: {userPsw}";
            Console.WriteLine(str);
//============================================================================================================================================================================
        }

        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();

            return Redirect("/");
        }

        //學員註冊畫面
        [AllowAnonymous]
        public IActionResult Sign()
        {
            return View();
        }

        //學員註冊資料送往後端
        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Sign(string email, string password, string repassword, string role)
        {
            if (password != repassword)
            {
                TempData["miss"] = "<script>alert('密碼不一致')</script>";
                return View();
            }

            Verifier V = new Verifier();

            byte[] usersalt = V.createSalt();

            // 新增一筆資料的物件
            userInfo sign = new userInfo
            {
                UID = V.UID(),
                Email = email,
                PassWord = V.createHash(password, usersalt),
                Role = role,
                SignDate = DateTime.Now.ToString("yyyy/MM/dd"),
                Class = "D",
                salt = Convert.ToBase64String(usersalt)
            };

            _context.Add(sign);
            _context.SaveChanges();

            //return Content(id);
            return View("Index", await _context.user_info.ToListAsync());
        }
    //=========================【07/21 註冊登入系統整合】===============================================================================

    //=========================【07/24 信箱驗證連結整合】===============================================================================
        [AllowAnonymous]
        public IActionResult Check(string Com)
        {
            MyCache cache;
            if (_cache.TryGetValue("Email", out cache))
            {
                EmailWorker emailworker = new EmailWorker()
                {
                    Com = Com,
                    Key = cache.K,
                };
                if (emailworker.disCom() && cache.U == emailworker.UID)
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
                    var query = from o in _context.user_info
                                where o.UID == cache.U
                                select o;
                    userInfo G = query.FirstOrDefault();

                    if (G != null)
                    {
                        G.PassWord = Psw;
                        G.salt = Salt;
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
        public IActionResult Forgot()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public IActionResult Forgot(string Email, string Password)
        {
            MyCache myCache;
            // 確認帳號存在
            var user = (from o in _context.user_info
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
                    addressee = "yy556023@gmail.com",
                    sendEmail = "yy215308@gmail.com",
                    sendPassword = "kk215308",
                    subject = "註冊認證",
                    UID = user.UID,
                };
                emailworker.mixUid();
                string str = emailworker.Com.Replace("+", "%2B");

                emailworker.content = " <a href='https://localhost:44354/Student/Check?Com=" + str + "'>認證點我</a> ";

                myCache.C = emailworker.Com;
                myCache.U = emailworker.UID;
                myCache.K = emailworker.Key;
                myCache.Password = Password;
                _cache.Set("Email", myCache, TimeSpan.FromSeconds(60));

                emailworker.MailSend();
                return Content("認證信已寄出");
            }
        }

    //=========================【07/24整合】===============================================================================

        public IActionResult Index()
        {
            return View();
        }

        //test/Detail/ARRQNF9BCN
        public IActionResult Detail()
        {
            return View();
        }
    }
}
