using System;
using System.Collections.Generic;

#nullable disable

namespace Lab_ClaimsIdentity.Models
{
    public partial class UserStatus
    {
        public string Uid { get; set; }
        public int? Strength { get; set; }
        public int? Vitality { get; set; }
        public int? Agility { get; set; }
        public int? PunishDay { get; set; }
    }
}
