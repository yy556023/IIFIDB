using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WorkoutHunter.Models
{
    public class gameProgress
    {
        [Key]
        public string UID { get; set; }
        public string StartTime { get; set; }
        public int CPoint { get; set; }
    }
}

