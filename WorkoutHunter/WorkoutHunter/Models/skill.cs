using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WorkoutHunter.Models
{
    public class skill
    {
        [Key]
        public int SID { get; set; }
        public string SkillName { get; set; }
        public int SkillDamage { get; set; }
        public int CD { get; set; }
        public string SkillPic { get; set; }
    }
}
