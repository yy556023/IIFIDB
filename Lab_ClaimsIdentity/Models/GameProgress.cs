using System;
using System.Collections.Generic;

#nullable disable

namespace Lab_ClaimsIdentity.Models
{
    public partial class GameProgress
    {
        public string Uid { get; set; }
        public string StartTime { get; set; }
        public int? Cpoint { get; set; }
    }
}
