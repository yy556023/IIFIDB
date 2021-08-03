using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkoutHunterV2.Models.DbModels;
using WorkoutHunterV2.Models.Student;
using WorkoutHunterV2.Models.Home;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authentication;
using Newtonsoft.Json.Linq;
using System.Text.RegularExpressions;
using Microsoft.EntityFrameworkCore;

namespace WorkoutHunterV2.Controllers
{
    [Authorize]
    public class StudentController : Controller
    {
        private readonly WorkoutHunterContext _context;
        private ViewSkillTreeModel _skillViewModel;
        public StudentController(WorkoutHunterContext context, ViewSkillTreeModel skillViewModel)
        {
            _skillViewModel = skillViewModel;
            _context = context;
        }
        public IActionResult Index()
        {
            string UID = User.Claims.Where(p => p.Type == "ID").FirstOrDefault().Value;

            ForIndex ViewModel = (from o in _context.forindex
                             where o.Uid == UID
                             select o).FirstOrDefault();

            string ItemStr = ViewModel.Items;
            JObject Jitem = JsonConvert.DeserializeObject<JObject>(ItemStr);
            var queryItems = _context.Items.ToList();
            var querySkills = _context.Skills.ToList();
            var queryNowItem = (from o in _context.CharacterItemSkills
                               where o.Uid == UID
                               select o.NowItem).FirstOrDefault();

            List < MyItem > MyItem = new List<MyItem>();
            foreach (var item in queryItems)
            {
                foreach (var item2 in Jitem)
                {
                    if(item.Iid == int.Parse(item2.Key))
                    {
                        MyItem.Add(new MyItem() {Item = item, quantity = int.Parse(item2.Value.ToString())});
                    }
                }
            }
            for(int i = 0; i < querySkills.Count; i++)
            {
                if (querySkills[i].Sid == ViewModel.nowSkill)
                    ViewBag.SkillPic = querySkills[i].SkillPic;
            }
            // 判斷現在有道具 //
            if(queryNowItem != 0 || queryNowItem != null)
            {
                // 道具清單找道具 //
                for(int i = 0; i < queryItems.Count; i++)
                {
                    // 找到道具放背包 //
                    if (queryItems[i].Iid == queryNowItem)
                        ViewBag.NowItem = queryItems[i];
                }
            }
            ViewBag.Items = MyItem;

            return View(ViewModel);
        }
        public IActionResult SkillTree()
        {
            // 讀取會員UID -> 從 Cookie 取得
            // ============================
            string UID = User.Claims.Where(p => p.Type == "ID").FirstOrDefault().Value;
            // ============================

            // 開始向資料庫抓資料
            // ============================
            // 需要的table: [skills] & [character_item_skill] & [user_info]
            // 使用UID抓資料
            //     抓取Rank，技能清單(未解碼)，未使用的技能點數
            var table = (from o in _context.CharacterItemSkills
                         join s in _context.UserInfos
                         on o.Uid equals s.Uid
                         join u in _context.UserStatuses
                         on o.Uid equals u.Uid
                         where s.Uid == UID
                         select new
                         {
                             Rank = s.Class,
                             rawSkillList = o.Skills,
                             rawPoint = o.RawPoint,
                             Strength = u.Strength,
                             Vitality = u.Vitality,
                             Agility = u.Agility,
                             nowSkill = o.NowSkill
                         }).FirstOrDefault();
            if (table == null)
            {
                return Content("table不存在.");
            }
            //     分析技能清單(解碼)
            List<int> SkillList = new List<int>();
            SkillList = JsonConvert.DeserializeObject<List<int>>(table.rawSkillList);
            //     抓取技能
            var skills = from o in _context.Skills
                         select o;
            //     配置ViewModel
            _skillViewModel.Rank = table.Rank;
            _skillViewModel.rawPoint = table.rawPoint;
            _skillViewModel.Strength = table.Strength;
            _skillViewModel.Vitality = table.Vitality;
            _skillViewModel.Agility = table.Agility;
            _skillViewModel.Skills = skills;
            _skillViewModel.SkillList = SkillList;
            _skillViewModel.nowSkill = table.nowSkill;

            // ============================

            return View(_skillViewModel);
        }
        public IActionResult PasswordChange()
        {
            return View();
        }
        [HttpPost]
        public IActionResult PasswordChange(CUserPasswordChange user)
        {
            string msg;
            if (!ModelState.IsValid)
            {
                msg = "密碼格式不正確";
                TempData["errorMsg"] = msg;
                return PasswordChange();
            }
            if(user.Password != user.rePassword)
            {
                msg = "密碼與確認密碼不一致";
                TempData["errorMsg"] = msg;
                return PasswordChange();
            }
            Verifier V = new Verifier();
            string UID = User.Claims.Where(p => p.Type == "ID").FirstOrDefault().Value;
            var query = (from o in _context.UserInfos
                        where o.Uid == UID
                        select o).FirstOrDefault();
            if(query.PassWord == V.createHash(user.Password, Convert.FromBase64String(query.Salt)))
            {
                msg = "新密碼與原密碼不得重複";
                TempData["errorMsg"] = msg;
                return PasswordChange();
            }
            byte[] b = V.createSalt();
            query.Salt = Convert.ToBase64String(b);
            query.PassWord = V.createHash(user.Password, b);
            _context.SaveChanges();

            return Redirect("/Home/Logoff");
        }
        [HttpPost]
        public async void SkillSaveChange()
        {

            // 讀取會員UID->從 Cookie 取得
            // ============================
            string UID = User.Claims.Where(p => p.Type == "ID").FirstOrDefault().Value;
            // ============================

            var b = await Request.BodyReader.ReadAsync();
            string str = Encoding.UTF8.GetString(b.Buffer);
            newSkills newSkillList = JsonConvert.DeserializeObject<newSkills>(str);

            if (newSkillList.nowSkill != 0 || newSkillList.list.Count() != 0)
            {
                var query = (from o in _context.CharacterItemSkills
                             where o.Uid == UID
                             select o).FirstOrDefault();
                List<int> oldSkillList = JsonConvert.DeserializeObject<List<int>>(query.Skills);
                // 學習新技能 & 扣點 & 驗證 -> 不得有重複技能，不得跳過前置技能學習
                // ===========================================================
                // 混和技能清單，不重覆新增
                foreach (var item in newSkillList.list)
                {
                    if (!oldSkillList.Contains(item))
                        oldSkillList.Add(item);
                }
                // 驗證
                bool jump = false;
                bool valid = true;
                for (int i = 1; i <= 4; i++)
                {
                    if (!jump)
                    {
                        oldSkillList.Contains(i);
                    }
                    else if (oldSkillList.Contains(i))
                    {
                        valid = false;
                        oldSkillList.Remove(i);
                    }
                }
                jump = false;
                for (int i = 5; i <= 7; i++)
                {
                    if (!jump)
                    {
                        oldSkillList.Contains(i);
                    }
                    else if (oldSkillList.Contains(i))
                    {
                        valid = false;
                        oldSkillList.Remove(i);
                    }
                }
                // 序列化
                query.Skills = JsonConvert.SerializeObject(oldSkillList);
                // 扣點
                if (valid)
                {
                    var skills = from o in _context.Skills
                                 where newSkillList.list.Contains(o.Sid)
                                 select o.NeedPoint;
                    valid = !(query.RawPoint - skills.Sum() < 0);

                    query.RawPoint -= skills.Sum();
                }

                // ===========================================================

                // 目前技能 & 驗證 -> 使用目前習得的技能
                // ===========================================================
                if (newSkillList.nowSkill != 0)
                {
                    valid = oldSkillList.Contains(newSkillList.nowSkill);
                    if (valid)
                    {
                        query.NowSkill = newSkillList.nowSkill;
                    }
                }
                // ==========================================================

                if (valid) _context.SaveChanges();
            }
        }

        public async Task<IActionResult> PowerUp()
        {
            string UID = User.Claims.Where(p => p.Type == "ID").FirstOrDefault().Value;

            var query = _context.UserInfos.Where(o => o.Uid == UID);

            return View(await query.FirstOrDefaultAsync());
        }

        public IActionResult Shop()
        {

             List<Item> ViewModel = _context.Items.ToList();

            return View(ViewModel);
        }

        [HttpPost]
        public IActionResult SaveNowItem(string data)
        {
            // 使用者ID //
            string UID = User.Claims.Where(p => p.Type == "ID").FirstOrDefault().Value;
            // 道具清單 //
            var queryItems = _context.Items.ToList();
            // 角色狀態紀錄 //
            var queryCharacter = _context.CharacterItemSkills.Single(p => p.Uid == UID);
            // 判斷傳回字串 //
            if (int.Parse(data) == 0)
            {
                // 取消道具裝備 //
                queryCharacter.NowItem = 0;
                _context.SaveChanges();
                return Content("取消道具裝備");
            }

            // 圖片解析成道具物件 //
            Regex Reg = new Regex("Icon(\\d*).png");
            foreach (var item in queryItems)
            {
                // 用圖片確認道具的ID //
                if (Reg.Match(item.ItemPic).Groups[1].Value == data)
                {
                    // 更新nowItem
                    queryCharacter.NowItem = item.Iid;
                    break;
                }
            }
            _context.SaveChanges();
            return Content($"裝備道具 {data}號藥水");
        }
    }
}