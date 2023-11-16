using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace QuanLyNhanVien.Models
{
    public partial class Thue
    {
        public Thue()
        {
            QuaTrinhDongThue = new HashSet<QuaTrinhDongThue>();
        }

        public int Id { get; set; }
        public string MaThue { get; set; }
        public int ThueSuat { get; set; }
        public bool? Active { get; set; }

        public virtual ICollection<QuaTrinhDongThue> QuaTrinhDongThue { get; set; }
    }
}
