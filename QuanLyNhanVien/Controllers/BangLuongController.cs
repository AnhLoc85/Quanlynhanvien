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
    public class BangLuongController : Controller
    {
        public IActionResult BangLuong()
        {
            return View();
        }
        [HttpPost("/loadBangLuong")]

        public IActionResult loadBangLuong(string Ngay)
        {
            DateTime date = DateTime.ParseExact("01-" + Ngay, "dd-MM-yyyy", CultureInfo.InvariantCulture);

            QuanLyNhanVienContext context = new QuanLyNhanVienContext();
            List<NhanSu> nhanSuList = context.NhanSu
                .Include(x => x.LuongCoBan)
                .Include(x => x.PhuCapNhanSu)
                .Where(x => x.PhuCapNhanSu.Any(lcb => lcb.ThoiGian == date))
                .Where(x => x.LuongCoBan.Any(lcb => lcb.ThoiGian == date))
                .ToList();

            ViewBag.NS = nhanSuList;
            ViewBag.Ngay = date;
            return PartialView();
        }
        public double CalculateTotalLuongNS(int? id, DateTime? ngay)
        {
            QuanLyNhanVienContext context = new QuanLyNhanVienContext();

            double totalLuongNS = (double)context.PhuCapNhanSu
                .Where(x => x.MaNs == id && x.ThoiGian == ngay)
                .Sum(x => x.TienPc);

            return totalLuongNS;
        }


    }
}