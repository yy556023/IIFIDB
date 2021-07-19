using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace WorkoutHunter.Models
{
    public class user_Info
    {
        [Key]
        public string UID { get; set; }
        public string Email { get; set; }
        public string PassWord { get; set; }
        public char Role { get; set; }
        public DateTime SignDate { get; set; }
        public char Class { get; set; }
    }
}
