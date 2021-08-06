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
            if (User.Identity.IsAuthenticated)
                return Redirect("/Student/Index");
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(User user, string ReturnUrl)
        {
            // 格式不正確返回錯誤
            if (!ModelState.IsValid)
                return View("Login", "格式錯誤，請輸入正確格式");

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
                        ExpiresUtc = DateTimeOffset.UtcNow.AddHours(3)
                    });

                    if (!string.IsNullOrEmpty(ReturnUrl) && Url.IsLocalUrl(ReturnUrl))
                    {
                        return Redirect(ReturnUrl);// 導到原始要求網址
                    }
                    else if(data.Role == "C")
                    {
                        return RedirectToAction("Index", "Coach");// 到登入後的第一頁，自行決定
                    }
                    else
                    {
                        return RedirectToAction("Index", "Student");// 到登入後的第一頁，自行決定
                    }

                }
                // 密碼錯誤
                else
                    return View("Login", "帳號或密碼錯誤");
            }
            // 帳號不存在
            else
                return View("Login", "帳號或密碼錯誤");

        }

        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Register(User newUser, string rePassword, string role)
        {
            if (!ModelState.IsValid)
            {
                TempData["errorMsg"] = "帳號或密碼格式錯誤";
                return View();
            }
            if (newUser.Password != rePassword)
            {
                TempData["errorMsg"] = "密碼不一致";
                return View();
            }
            if(role == null)
            {
                TempData["errorMsg"] = "請選擇註冊的角色";
                return View();
            }

            Verifier V = new Verifier();

            byte[] usersalt = V.createSalt();

            // 新增一筆資料的物件
            UserInfo sign = new UserInfo
            {
                Uid = V.UID(),
                Email = newUser.Email,
                PassWord = V.createHash(newUser.Password, usersalt),
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
                return Content("無此信箱或輸入錯誤");
            }
            // 若緩存還存在
            if (_cache.TryGetValue("UserLoginInfo", out myCache))
            {
                
                return Content("認證信已寄出，5分鐘內不得重複寄出");
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
                _cache.Set("UserLoginInfo", myCache, TimeSpan.FromMinutes(5));
                
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
                {
                    // 認證許可，修改密碼頁面
                    return View();
                }

            }
            // 認證過期頁面
            return View("ForgotPassword", "認證頁面已過期");
        }
        [HttpPost]
        public IActionResult CheckEmail(CUserPasswordEdit UserPasswordEdit)
        {
            MyCache cache;
            if (!ModelState.IsValid)
            {
                return View("CheckEmail", "密碼格式錯誤");
            }
            if(_cache.TryGetValue("UserLoginInfo", out cache))
            {
                Verifier V = new Verifier();
                UserPasswordEdit.UID = cache.U;
                var query = (from o in _context.UserInfos
                            where o.Uid == UserPasswordEdit.UID
                            select o).FirstOrDefault();
                byte[] salt = V.createSalt();
                string password = V.createHash(UserPasswordEdit.Password, salt);

                query.Salt = Convert.ToBase64String(salt);
                query.PassWord = password;
                _context.SaveChanges();
                _cache.Remove("UserLoginInfo");
            }
            return Redirect("Login");
        }
        public async Task<IActionResult> Logoff()
        {
            await HttpContext.SignOutAsync();
            return Redirect("index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
