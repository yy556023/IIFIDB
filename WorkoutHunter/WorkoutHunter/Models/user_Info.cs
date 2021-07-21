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
        public string Role { get; set; }
        public string SignDate { get; set; }
        public string Class { get; set; }
        public string salt { get; set; }
    }
}
