using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WorkoutHunter.Models;
using Microsoft.Data.SqlClient;

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
        public async Task<IActionResult> test(string email, string password,string repassword, string role)
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
            userInfo sign = new userInfo
            {
                UID = id,
                Email = email,
                PassWord = password,
                Role = role,
                SignDate = DateTime.Now.ToString("yyyy/MM/dd")
            };

            //SqlConnection cn = new SqlConnection("LinkToDb");

            //SqlTransaction t = cn.BeginTransaction();

            //_context.Add(sign);
            //_context.SaveChanges();

            //if (password == repassword)
            //{              
            //    t.Commit();
            //}
            //else
            //{
            //    t.Rollback();
            //}

            //return Content(id);
            //return View("Index", await _context.user_info.ToListAsync());
            return View(sign);
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
