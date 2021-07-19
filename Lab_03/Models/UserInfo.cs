using System;
using System.Collections.Generic;

#nullable disable

namespace Lab_03.Models
{
    public partial class UserInfo
    {
        public string Uid { get; set; }
        public string Email { get; set; }
        public string PassWord { get; set; }
        public string Role { get; set; }
        public DateTime? SignDate { get; set; }
        public string Class { get; set; }
        public string salt { get; set; }
    }
}
