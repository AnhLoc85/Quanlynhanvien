using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace QuanLyNhanVien.Models
{
    public partial class PhongBan
    {
        public PhongBan()
        {
            QtchucVu = new HashSet<QtchucVu>();
            QtcongTac = new HashSet<QtcongTac>();
        }

        public int Id { get; set; }
        public string MaPb { get; set; }
        public string TenPhongBan { get; set; }

        public virtual ICollection<QtchucVu> QtchucVu { get; set; }
        public virtual ICollection<QtcongTac> QtcongTac { get; set; }
    }
}
