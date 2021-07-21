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

namespace Lab_05.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private workouthunterContext _context;

        public HomeController(ILogger<HomeController> logger, workouthunterContext context)
        {
            _context = context;
            _logger = logger;
        }
        public IActionResult defense()
        {
            return BadRequest();
        }
        [AllowAnonymous]
        public IActionResult Login()
        {
            return View();
        }

        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();

            return Redirect("/");
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
                        ExpiresUtc = DateTimeOffset.UtcNow.AddSeconds(10)
                    });

                    
                    // 驗證成功
                    return Redirect("/");

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
       
        public IActionResult Index()
        {

            return View();
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
