using System;
using System.Collections.Generic;

#nullable disable

namespace Lab_ClaimsIdentity.Models
{
    public partial class Skill
    {
        public int Sid { get; set; }
        public string SkillName { get; set; }
        public int? SkillDamage { get; set; }
        public int? Cd { get; set; }
        public string SkillPic { get; set; }
    }
}
