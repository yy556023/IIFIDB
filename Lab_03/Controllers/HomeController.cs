using Lab_03.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_03.Controllers
{
    public class HomeController : Controller
    {
        private Verifier _verifier;
        private readonly ILogger<HomeController> _logger;
        private workouthunterContext _DbContext;

        public HomeController(ILogger<HomeController> logger, Verifier verifier, workouthunterContext DbContext)
        {
            _DbContext = DbContext;
            _verifier = verifier;
            _logger = logger;
        }

        public IActionResult Login()
        {
            return View();
        }
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(string userID, string userPassword)
        {
            if (_verifier.SignIn(HttpContext, _DbContext, userID, userPassword))
                return Content("登入成功 <a href='/Home/Login'>返回</a>", "text/html", Encoding.UTF8);
            else
                return Content("登入失敗 <a href='/Home/Login'>返回</a>", "text/html", Encoding.UTF8);
        }
        [HttpPost]
        public IActionResult Register(string userID, string userPassword)
        {
            
            if(_verifier.register(userID, userPassword, _DbContext))
                return Content("註冊成功 <a href='/Home/Login'>返回</a>", "text/html", Encoding.UTF8);
            else
                return Content("註冊失敗 <a href='/Home/Login'>返回</a>", "text/html", Encoding.UTF8);
        }
        public IActionResult Index()
        {
            if (!_verifier.Verification(HttpContext, _DbContext))
                return Redirect("Login");


            return View();
        }
        public IActionResult Privacy()
        {
            if (!_verifier.Verification(HttpContext, _DbContext))
                return Redirect("Login");


            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
