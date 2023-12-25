﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace QuanLyNhanVien.Models
{
    public partial class DmheSoPhuCap
    {
        public DmheSoPhuCap()
        {
            QuaTrinhPhuCap = new HashSet<QuaTrinhPhuCap>();
        }

        public int Id { get; set; }
        public string MaHspc { get; set; }
        public bool? Active { get; set; }
        public double? HeSoPhuCap { get; set; }

        public virtual ICollection<QuaTrinhPhuCap> QuaTrinhPhuCap { get; set; }
    }
}
