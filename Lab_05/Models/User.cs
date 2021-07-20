using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;

namespace Lab_05.Models
{
    public class User
    {
        public string UID { get; set; }
        [Required]
        [RegularExpression("[a-zA-Z0-9_]*@.*")]
        public string Email { get; set; }
        [Required]
        [RegularExpression("[a-zA-Z0-9_&%$^#?=]*")]
        public string Password { get; set; }
    }
}
