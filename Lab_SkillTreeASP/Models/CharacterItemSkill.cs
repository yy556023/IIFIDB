using System;
using System.Collections.Generic;

#nullable disable

namespace Lab_SkillTreeASP.Models
{
    public partial class CharacterItemSkill
    {
        public string Uid { get; set; }
        public string Items { get; set; }
        public string Skills { get; set; }
        public string ChaPic { get; set; }
        public int? Money { get; set; }
        public int? RawPoint { get; set; }
        public int? nowSkill { get; set; }
    }
}
