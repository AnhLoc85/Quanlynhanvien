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
    public class ChotPhuCapController : Controller
    {
        public IActionResult ChotPhuCap()
        {
            return View();
        }
        [HttpPost("/loadQTPC")]

        public IActionResult loadQTPC(string Ngay)
        {
            DateTime date = DateTime.ParseExact("01-" + Ngay, "dd-MM-yyyy", CultureInfo.InvariantCulture);

            QuanLyNhanVienContext context = new QuanLyNhanVienContext();
            
                var QTL = context.QuaTrinhPhuCap.Include(x => x.MaHspcNavigation).Include(x => x.MaPcNavigation).Where(x => x.TgbatDau <= date && date <= x.TgketThuc).OrderBy(x => x.MaNs).ToList();
                ViewBag.QTPC = QTL;
                ViewBag.Ngay = date;
                return PartialView();
            
        }
        [HttpPost("/addQTPC")]

        public IActionResult addQTPC(string Ngay)
        {
            DateTime date = DateTime.ParseExact("01-" + Ngay, "dd-MM-yyyy", CultureInfo.InvariantCulture);

            QuanLyNhanVienContext context = new QuanLyNhanVienContext();
            var kt = context.PhuCapNhanSu.Where(x => x.ThoiGian == date).ToList();

            // Nếu đã có, xóa tất cả các record đó
            if (kt.Count > 0)
            {
                context.PhuCapNhanSu.RemoveRange(kt);
                context.SaveChanges();
            }

            var QTL = context.QuaTrinhPhuCap.Include(x => x.MaHspcNavigation).Include(x => x.MaPcNavigation).Where(x => x.TgbatDau <= date && date <= x.TgketThuc).ToList();
            foreach (var qtpc in QTL)
            {
                var tienluong = context.LuongCoBan.FirstOrDefault(x => x.ThoiGian == date && x.MaNs == qtpc.MaNs).LuongNs;
                PhuCapNhanSu lcb = new PhuCapNhanSu();
                lcb.MaNs = qtpc.MaNs;
                lcb.ThoiGian = date;
                lcb.Hspc = qtpc.MaHspcNavigation.HeSoPhuCap;
                lcb.Maphucap = qtpc.MaPcNavigation.MaPc;
                lcb.TienPc = qtpc.MaHspcNavigation.HeSoPhuCap * ((double)tienluong/100);
                context.PhuCapNhanSu.Add(lcb);
                context.SaveChanges();

            }
            return PartialView();

        }
    }
}
