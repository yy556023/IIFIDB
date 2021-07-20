using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WorkoutHunter.Models;

namespace WorkoutHunter.Controllers
{
    public class StudentController : Controller
    {
        private readonly userContext _context;

        public StudentController(userContext context)
        {
            _context = context;
        }

        public IActionResult Login()
        {
            return View();
        }

        //學員註冊畫面
        public IActionResult Sign()
        {
            return View();
        }
        
        //學員註冊資料送往後端
        public IActionResult test(string email,string password,string role)
        {
            List<string> ch = new List<string>();

            Random r = new Random();

            string id = "";

            // 產生A-Z a-z 0-9的 字串List
            for (int i = 48 ; i < 123 ; i++)
            {
                if ((i >= 58 && i < 65) || (i >= 91 && i < 97))
                {
                    continue;
                }
                ch.Add(Convert.ToChar(i).ToString());
            }

            // 產生UID
            for (int i = 0 ; i < 10 ; i++)
            {
                id += ch[r.Next(0, 63)];
            }

            // 新增一筆資料的物件
            user_Info sign = new user_Info
            {
                UID = id,
                Email = email,
                PassWord = password,
                Role = role,
                SignDate = DateTime.Now.ToString("d")               
            };

            //_context.Add(sign);
            //_context.SaveChanges();

            //return Content(id);
            return View("Index",_context.user_Info.ToList());
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.testV.ToListAsync());
        }

        //test/Detail/ARRQNF9BCN
        public async Task<IActionResult> Detail(string id)
        {
            var test = await _context.testV.FindAsync(id);

            //var test = from o in _context.testV
            //           where o.UID == id
            //           select o;

            //var test2 = test.FirstOrDefault();

            return View(test);
        }
    }
}
