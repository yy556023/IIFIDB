using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WorkoutHunter.Models
{
    public class item
    {
        [Key]
        public int IID { get; set; }
        public string ItemName { get; set; }
        public string ItemInfo { get; set; }
        public string ItemPic { get; set; }
    }
}
