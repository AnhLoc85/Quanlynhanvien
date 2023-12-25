using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using QuanLyNhanVien.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;


namespace QuanLyNhanVien.Controllers
{
    public class TrangChuController : Controller
    {
        [Authorize]
        public IActionResult Home()
        {
            return View();
        }
        QuanLyNhanVienContext context = new QuanLyNhanVienContext();
        public ActionResult LogOut()
        {
            HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Index", "Home");
        }
        [HttpPost]
        public dynamic ThongTinNhanVien(){
            int idnv = int.Parse(User.FindFirstValue(ClaimTypes.Name));
            List<ChamCong> chamCongs = context.ChamCong.Where(x => x.MaNs == idnv &&
                                    x.Ngay.Value.Month == DateTime.Now.Month).ToList();
            // ngày công
            double ngayCong = (double)chamCongs.Where(x => x.Thu != "0").Sum(x => x.SoCong);
            // ngày tăng ca
            double tangCa = (double)chamCongs.Where(x => x.Thu =="0").Sum(x => x.SoCong);
            // giờ tăng ca 
            double gioTangCa = (double)chamCongs.Sum(x => x.SoGio);
            // số ngày đi trễ 
            double soNgayDiTre = (double)chamCongs.Where(x => x.SoCong == 0.5).Count();
            // thưởng
            var thuong = context.QuaTrinhThuongPc.Include(x=> x.MaThuongNavigation).Where(x => x.MaNs == idnv && 
                        x.Tgthuong.Value.Month == DateTime.Now.Month).ToList();
            // phạt 
            var phat = context.QuaTrinhPhat.Include(x => x.MaPhatNavigation).Where(x => x.MaNs == idnv &&
                        x.Tgphat.Value.Month == DateTime.Now.Month);
            // phụ câps
            var phuCap = context.QuaTrinhPhuCap.Include(x => x.MaPcNavigation).Include(x=> x.MaHspcNavigation).Where(x => x.MaNs == idnv &&
                        (x.TgbatDau.Value.Month <= DateTime.Now.Month &&
                         x.TgketThuc.Value.Month >= DateTime.Now.Month)).ToList();
            var thoiGian = new {
                    thang = DateTime.Now.Month,
                    nam = DateTime.Now.Year
                };
            var nhanSu = context.NhanSu.Where(x => x.Id == idnv).FirstOrDefault();
            var luong = context.QuaTrinhLuong.Include(x => x.MaNsNavigation).Include(x=>x.MaHslNavigation)
                                                    .Include(x=> x.MaMlNavigation).Where(x => x.MaNs == idnv).FirstOrDefault();
            var luongNS = luong.MaHslNavigation.HeSoLuong * (double)luong.MaMlNavigation.TienLuong;
            var luongUocTinh = (luongNS/26) * ngayCong + (luongNS/26) * tangCa * luong.MaHslNavigation.HeSoTangCa
                                 + (luongNS/26)/8 * gioTangCa * luong.MaHslNavigation.HeSoTangCa;

            return new{
                ngayCong = ngayCong,
                tangCa = tangCa,
                gioTangCa = gioTangCa,
                soNgayDiTre = soNgayDiTre,
                thuong = thuong,
                phat = phat,
                phuCap = phuCap,
                thoiGian = thoiGian,
                nhanSu = nhanSu,
                luongUocTinh = luongUocTinh,
            };
        }
    }
}
