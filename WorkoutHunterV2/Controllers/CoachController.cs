using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorkoutHunterV2.Models.DbModels;
using WorkoutHunterV2.Models.Student;

namespace WorkoutHunterV2.Controllers
{
    public class CoachController : Controller
    {
        private readonly WorkoutHunterContext _context;
        public CoachController(WorkoutHunterContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            // 找出身分為學生的資料
            //var query = _context.UserInfos.Where(o => o.Role == "S");
            //// 得到教練的UID
            //string UID = User.Claims.Single(p => p.Type == "ID").Value;
            //// 找出登錄這位教練的學生
            //var query2 = query.Where(o => o.PT == UID);

            //return View(await query2.ToListAsync());
            return View(await _context.UserInfos.ToListAsync());
        }
    }
}
