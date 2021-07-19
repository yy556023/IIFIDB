using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WorkoutHunter.Models;

namespace WorkoutHunter.Controllers
{
    public class testController : Controller
    {
        private readonly userContext _context;

        public testController(userContext context)
        {
            _context = context;
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
