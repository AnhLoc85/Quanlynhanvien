using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace QuanLyNhanVien.Models
{
    public partial class Phat
    {
        public Phat()
        {
            QuaTrinhPhat = new HashSet<QuaTrinhPhat>();
        }

        public int Id { get; set; }
        public string MaPhat { get; set; }
        public string NoiDung { get; set; }

        public virtual ICollection<QuaTrinhPhat> QuaTrinhPhat { get; set; }
    }
}
