using System;
using System.Collections.Generic;

#nullable disable

namespace Lab_SkillTreeASP.Models
{
    public partial class Monster
    {
        public int Mid { get; set; }
        public string MonsterName { get; set; }
        public int? MonsterDamage { get; set; }
        public bool? MonsterClass { get; set; }
        public string MonsterPic { get; set; }
    }
}
