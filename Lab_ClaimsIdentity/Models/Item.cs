﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Lab_ClaimsIdentity.Models
{
    public partial class Item
    {
        public int Iid { get; set; }
        public string ItemName { get; set; }
        public string ItemInfo { get; set; }
        public string ItemPic { get; set; }
    }
}