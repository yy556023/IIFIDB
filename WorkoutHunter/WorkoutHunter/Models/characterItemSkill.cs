using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WorkoutHunter.Models
{
    public class characterItemSkill
    {
        [Key]
        public string UID { get; set; }
        public string Items { get; set; }
        public string Skills { get; set; }
        public string ChaPic { get; set; }
        public int Money { get; set; }
    }
}
