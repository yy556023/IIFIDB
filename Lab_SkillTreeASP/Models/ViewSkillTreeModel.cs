using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab_SkillTreeASP.Models
{
    public class ViewSkillTreeModel
    {
        public string Rank { get; set; }
        public IQueryable<Skill> Skills { get; set; }
        public int? rawPoint { get; set; }
        public int? Strength { get; set; }
        public int? Vitality { get; set; }
        public int? Agility { get; set; }
        public int? nowSkill { get; set; }
        public List<int> SkillList{ get; set; }
    }
}
