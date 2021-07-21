using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WorkoutHunter.Models
{
    public class user_Status
    {
        [Key]
        public string UID { get; set; }
        public int Strength { get; set; }
        public int Vitality { get; set; }
        public int Agility { get; set; }
        public int PunishDay { get; set; }
    }
}
