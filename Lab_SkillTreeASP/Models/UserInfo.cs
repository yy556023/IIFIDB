using System;
using System.Collections.Generic;

#nullable disable

namespace Lab_SkillTreeASP.Models
{
    public partial class UserInfo
    {
        public string Uid { get; set; }
        public string Email { get; set; }
        public string PassWord { get; set; }
        public string Role { get; set; }
        public string SignDate { get; set; }
        public string Class { get; set; }
        public string Salt { get; set; }
    }
}
