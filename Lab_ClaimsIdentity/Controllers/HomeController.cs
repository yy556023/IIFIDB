using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
//=============================================
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization; // [Authorize]
using Lab_ClaimsIdentity.Models;
//=============================================

namespace Lab_ClaimsIdentity.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [AllowAnonymous]
        public ActionResult Login(db_user _User)
        {

            if (ModelState.IsValid)
            {   // 入門版，先不連結DB，固定帳號密碼來做（微軟範例也是這樣）
                // 線上課程 裡會有連結資料庫，比對帳號與密碼的教材。  初學者不要急，一步一步學習。
                if (_User.UserName != "123" && _User.UserPassword != "123")
                {
                    ViewData["ErrorMessage"] = "帳號與密碼有錯";
                    return View();
                }

                #region ***** 不使用ASP.NET Core Identity的 cookie 驗證 *****
                var claims = new List<Claim>   // 搭配 System.Security.Claims; 命名空間
                {
                    new Claim(ClaimTypes.Name, _User.UserName),
                    // new Claim(ClaimTypes.Role, "Administrator"),
                    // 如果要有「群組、角色、權限」，可以加入這一段
                };

                // 底下的 ** 登入 Login ** 需要下面兩個參數 (1) claimsIdentity  (2) authProperties
                var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);



                var authProperties = new AuthenticationProperties
                {
                    //AllowRefresh = <bool>,
                    // Refreshing the authentication session should be allowed.

                    //ExpiresUtc = DateTimeOffset.UtcNow.AddMinutes(10), 
                    // The time at which the authentication ticket expires. A 
                    // value set here overrides the ExpireTimeSpan option of 
                    // CookieAuthenticationOptions set with AddCookie.

                    //IsPersistent = true,
                    // Whether the authentication session is persisted across 
                    // multiple requests. When used with cookies, controls
                    // whether the cookie's lifetime is absolute (matching the
                    // lifetime of the authentication ticket) or session-based.

                    //IssuedUtc = <DateTimeOffset>,
                    // The time at which the authentication ticket was issued.

                    //RedirectUri = <string>
                    // The full path or absolute URI to be used as an http redirect response value.
                };

                // *** 登入 Login *********
                HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity), authProperties);
                #endregion

                return Content("<h3>恭喜您，登入成功</h3>");
            }

            // Something failed. Redisplay the form.
            return View();
        }
        public async Task<IActionResult> Logout()
        {
            // 自己宣告 Microsoft.AspNetCore.Authentication.Cookies; 命名空間
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);



            return View();  // 回 首頁。 return RedirectToAction("Index", "Home");
        }
        [Authorize]
        public IActionResult Index()
        {
            return View();
        }
        [Authorize]
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
