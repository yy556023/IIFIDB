using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WorkoutHunter.Models
{
    public class Student
    {
        [Key]
        public string UID { get; set; }
        public char Class { get; set; }
        public int Strength { get; set; }
        public int Vitality { get; set; }
        public int Agility { get; set; }
        public string Items { get; set; }
        public string Skills { get; set; }
        public int Money { get; set; }
        public string ChaPic { get; set; }
    }
}
