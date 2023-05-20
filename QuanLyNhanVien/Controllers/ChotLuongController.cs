using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using QuanLyNhanVien.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace QuanLyNhanVien.Controllers
{
    public class ChotLuongController : Controller
    {
        QuanLyNhanVienContext context = new QuanLyNhanVienContext();
        public IActionResult ChotLuong()
        {
            return View();
        }
        [HttpPost("/loadQTLuong")]

        public IActionResult loadQTLuong(string Ngay)
        {
            DateTime date = DateTime.ParseExact("01-" + Ngay, "dd-MM-yyyy", CultureInfo.InvariantCulture);
            var QTL = context.QuaTrinhLuong.Include(x => x.MaNsNavigation).Include(x => x.MaHslNavigation).Include(x => x.MaMlNavigation).Where(x => x.TgbatDau <= date && date <= x.TgketThuc).ToList();
            ViewBag.QTL = QTL;
            return PartialView();
        }
        [HttpPost("/addQTLuong")]
        public string addQTLuong(string Ngay)
        {
            DateTime date = DateTime.ParseExact("01-" + Ngay, "dd-MM-yyyy", CultureInfo.InvariantCulture);

            List<QuaTrinhLuong> QTL = context.QuaTrinhLuong.Include(x => x.MaHslNavigation).Include(x => x.MaMlNavigation).Where(x => x.TgbatDau <= date && date <= x.TgketThuc).ToList();
            var kt = context.LuongCoBan.Where(x => x.ThoiGian == date).ToList();

            // Nếu đã có, xóa tất cả các record đó
            if (kt.Count > 0)
            {
                context.LuongCoBan.RemoveRange(kt);
                context.SaveChanges();
            }
            foreach (var qtluong in QTL)
            {
                LuongCoBan lcb = new LuongCoBan();
                lcb.MaNs = qtluong.MaNs;
                lcb.ThoiGian = date;
                lcb.Hsl = qtluong.MaHslNavigation.HeSoLuong;
                lcb.Luong = qtluong.MaMlNavigation.TienLuong;
                lcb.LuongNs = Convert.ToDecimal(qtluong.MaHslNavigation.HeSoLuong * (double)qtluong.MaMlNavigation.TienLuong);
                context.LuongCoBan.Add(lcb);
                context.SaveChanges();

            }
            return "thêm thành công";
        }
     
    }
}
