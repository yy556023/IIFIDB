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

namespace WorkoutHunter.Controllers
{
    [Authorize]
    public class StudentController : Controller
    {
        private readonly ILogger<StudentController> _logger;
        private readonly userContext _context;

        public StudentController(ILogger<StudentController> logger, userContext context)
        {
            _context = context;
            _logger = logger;
        }

        [AllowAnonymous]
        public IActionResult Login()
        {
            return View();
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

                    HttpContext.Session.SetString("Role", data.Role);

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


            //============================================================
            // 顯示結果
            string str =
                $"Email: {user.Email} Password: {user.Password} {ModelState.IsValid} \n 比對Email: {data.Email} 比對密碼: {data.PassWord} \n 輸入的hash密碼: {userPsw}";
            Console.WriteLine(str);
            //============================================================
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
