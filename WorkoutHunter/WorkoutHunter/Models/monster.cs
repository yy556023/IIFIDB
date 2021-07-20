using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WorkoutHunter.Models
{
    public class monster
    {
        [Key]
        public int MID { get; set; }
        public string MonsterName { get; set; }
        public int MonsterDamage { get; set; }
        public bool MonsterClass { get; set; }
        public string MonsterPic { get; set; }
    }
}
