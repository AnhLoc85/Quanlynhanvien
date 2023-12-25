using DocumentFormat.OpenXml.Office2010.ExcelAc;
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
            ViewBag.Ngay = date;
            return PartialView();
        }
        [HttpPost("/addQTLuong")]
        public string addQTLuong(string Ngay)
        {
            DateTime date = DateTime.ParseExact("01-" + Ngay, "dd-MM-yyyy", CultureInfo.InvariantCulture);

            List<QuaTrinhLuong> QTL = context.QuaTrinhLuong.Include(x => x.MaHslNavigation).Include(x => x.MaMlNavigation).Where(x => x.TgbatDau <= date && date <= x.TgketThuc).ToList();
            var kt = context.LuongCoBan.Where(x => x.ThoiGian == date).ToList();
            ViewBag.Ngay = date;
            LuongCoBan getQTL(int? id, DateTime? ngay)
            {
                LuongCoBan nv = context.LuongCoBan.FirstOrDefault(x => x.MaNs == id && x.ThoiGian == ngay);
                if (nv != null) return nv;
                else return new LuongCoBan();
            }
             double CalculateTotalCongNS(int? id, DateTime? ngay)
            {
            double totalCongNS = 0;
            if (id.HasValue && ngay.HasValue)
            {
                totalCongNS = context.ChamCong
                    .Where(x => x.MaNs == id && 
                                x.Ngay.HasValue && 
                                x.Ngay.Value.Month == ngay.Value.Month && 
                                x.Ngay.Value.Year == ngay.Value.Year && 
                                x.Thu != "0" && 
                                x.SoCong.HasValue) // Kiểm tra SoCong có giá trị hay không
                    .Sum(x => x.SoCong.Value); // Tính tổng giá trị SoCong
            }
            return totalCongNS;
            }
                double CalculateTotalCongNG(int? id, DateTime? ngay)
            {
            double totalCongNG = 0;
            if (id.HasValue && ngay.HasValue)
            {
                totalCongNG = context.ChamCong
                    .Where(x => x.MaNs == id && 
                                x.Ngay.HasValue && 
                                x.Ngay.Value.Month == ngay.Value.Month && 
                                x.Ngay.Value.Year == ngay.Value.Year && 
                                x.Thu == "0" && 
                                x.SoCong.HasValue) // Kiểm tra SoCong có giá trị hay không
                    .Sum(x => x.SoCong.Value); // Tính tổng giá trị SoCong
            }
            return totalCongNG;
            }
                    double CalculateTotalGioTC(int? id, DateTime? ngay)
            {
            double totalGioTC = 0;
            if (id.HasValue && ngay.HasValue)
            {
                totalGioTC = context.ChamCong
                    .Where(x => x.MaNs == id && 
                                x.Ngay.HasValue && 
                                x.Ngay.Value.Month == ngay.Value.Month && 
                                x.Ngay.Value.Year == ngay.Value.Year && 
                                x.SoGio.HasValue) // Kiểm tra SoCong có giá trị hay không
                    .Sum(x => x.SoGio.Value); // Tính tổng giá trị SoCong
            }
            return totalGioTC;
        }
            // Nếu đã có, xóa tất cả các record đó
            if (kt.Count > 0)
            {
                context.LuongCoBan.RemoveRange(kt);
                context.SaveChanges();
            }
            foreach (var item in QTL)
            {
                double tongcong = CalculateTotalCongNS(item.MaNs, ViewBag.Ngay);
                double tongluong = ((double)item.MaHslNavigation.HeSoLuong * (double)item.MaMlNavigation.TienLuong);
                double congngoaigio = CalculateTotalCongNG(item.MaNs, ViewBag.Ngay);
                double giotangca = CalculateTotalGioTC(item.MaNs, ViewBag.Ngay);
                double luongngay = (tongluong / 26);
                double luonggio = (luongngay / 8);
                double thucnhan = (luongngay * congngoaigio * (double)item.MaHslNavigation.HeSoTangCa) + (luongngay * tongcong) + (luonggio * giotangca * (double)item.MaHslNavigation.HeSoTangCa);
                LuongCoBan lcb = new LuongCoBan();
                lcb.MaNs = item.MaNs;
                lcb.ThoiGian = date;
                lcb.Hsl = item.MaHslNavigation.HeSoLuong;
                lcb.Luong = item.MaMlNavigation.TienLuong;
                lcb.LuongNs = (decimal)thucnhan;
                context.LuongCoBan.Add(lcb);
                context.SaveChanges();

            }
            return "thêm thành công";
        }
     
    }
}
