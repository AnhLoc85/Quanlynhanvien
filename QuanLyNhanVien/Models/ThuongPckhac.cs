using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace QuanLyNhanVien.Models
{
    public partial class ThuongPckhac
    {
        public ThuongPckhac()
        {
            QuaTrinhThuongPc = new HashSet<QuaTrinhThuongPc>();
        }

        public int Id { get; set; }
        public string MaThuong { get; set; }
        public string NoiDung { get; set; }
        public bool? Active { get; set; }
        public bool? Tncn { get; set; }
        public bool? Bhxh { get; set; }

        public virtual ICollection<QuaTrinhThuongPc> QuaTrinhThuongPc { get; set; }
    }
}
