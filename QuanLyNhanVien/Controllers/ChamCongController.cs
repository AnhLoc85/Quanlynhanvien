using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using QuanLyNhanVien.Models;
using System.Threading.Tasks;

namespace QuanLyNhanVien.Controllers
{
    public class ChamCongController : Controller
    {
        QuanLyNhanVienContext context = new QuanLyNhanVienContext();
        public IActionResult ChamCong()
        {
          var chamCongSang = context.ChamCong.Where(cc => cc.GioVaoSang != null).ToList();
          var chamCongChieu = context.ChamCong.Where(cc => cc.GioVaoChieu != null).ToList();
          var chamCongToi = context.ChamCong.Where(cc => cc.GioVaoToi != null).ToList();
           
            return View();
        }
         public IActionResult QuetQRChamCong(string maDD)
        {

            return View();
        }
    }
}
