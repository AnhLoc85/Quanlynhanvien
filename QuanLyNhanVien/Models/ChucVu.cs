using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace QuanLyNhanVien.Models
{
    public partial class ChucVu
    {
        public ChucVu()
        {
            QtchucVu = new HashSet<QtchucVu>();
        }

        public int Id { get; set; }
        public string MaCv { get; set; }
        public string TenChucVu { get; set; }

        public virtual ICollection<QtchucVu> QtchucVu { get; set; }
    }
}
