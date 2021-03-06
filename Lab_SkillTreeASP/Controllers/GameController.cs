using Lab_SkillTreeASP.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Text;

namespace Lab_SkillTreeASP.Controllers
{
    public class GameController : Controller
    {
        private workouthunterContext _context;
        private ViewSkillTreeModel _skillViewModel;

        public GameController(workouthunterContext context, ViewSkillTreeModel skillViewModel)
        {
            _skillViewModel = skillViewModel;
            _context = context;
        }
        public IActionResult SkillView()
        {
            // 讀取會員UID -> 從 Cookie 取得
            // ============================

            // 先假設UID
            string UID = "B5b165PNvx";

            // <<待寫完整 ...>>
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
                             nowSkill = o.nowSkill
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
        [HttpPost]
        public async void SkillSaveChange()
        {

            // 讀取會員UID->從 Cookie 取得
            // ============================

            // 先假設UID
            string UID = "B5b165PNvx";

            // <<待寫完整 ...>>
            // ============================

            var b = await Request.BodyReader.ReadAsync();
            string str = Encoding.UTF8.GetString(b.Buffer);
            newSkills newSkillList = JsonConvert.DeserializeObject<newSkills>(str);

            if(newSkillList.nowSkill != 0 || newSkillList.list.Count() != 0)
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
                    if(!oldSkillList.Contains(item))
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
                    else if(oldSkillList.Contains(i))
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
                if(newSkillList.nowSkill != 0)
                {
                    valid = oldSkillList.Contains(newSkillList.nowSkill);
                    if (valid)
                    {
                        query.nowSkill = newSkillList.nowSkill;
                    }
                }
                // ==========================================================

                if (valid)_context.SaveChanges();
            }
        }
        public IActionResult Test()
        {
            return View();
        }
    }
}