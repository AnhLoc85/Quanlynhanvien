using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using QuanLyNhanVien.Models;
using Microsoft.AspNetCore.Http;
using System.IO;
using Microsoft.AspNetCore.Hosting;
namespace QuanLyNhanVien.Controllers
{
    
    public class HoSoController : Controller
    {
        QuanLyNhanVienContext context = new QuanLyNhanVienContext();
        private readonly IWebHostEnvironment webHostEnvironment;
        public IActionResult HoSo(int id)
        {
            NhanSu ns = context.NhanSu.Find(id);
            // Tách thông tin tỉnh, huyện và xã từ trường DiaChi
            if (ns.DiaChi != null)
            {
                string[] diaChiParts = ns.DiaChi.Split(", ");
                string tinhThanh = diaChiParts[diaChiParts.Length - 1];
                string quanHuyen = diaChiParts[diaChiParts.Length - 2];
                string phuongXa = diaChiParts[diaChiParts.Length - 3];
                string diaChi = diaChiParts[diaChiParts.Length - 4];

                // Đặt thông tin tỉnh, huyện và xã vào ViewBag để truyền vào view
                ViewBag.TinhThanh = tinhThanh;
                ViewBag.QuanHuyen = quanHuyen;
                ViewBag.PhuongXa = phuongXa;
                ViewBag.DiaChi = diaChi;
            }
            return View(ns);
        }
        public IActionResult updateHoSo(NhanSu ns, string selectedCityText, string selectedDistrictText, string selectedWardText, string address, string selectedQueText, IFormFile newImage, string gioitinh)
        {
            NhanSu ns1 = context.NhanSu.Find(ns.Id);


            var address1 = address + ", " + selectedWardText + ", " + selectedDistrictText + ", " + selectedCityText;

            if (newImage != null && newImage.Length > 0)
            {
                string uploadsFolder = Path.Combine(webHostEnvironment.WebRootPath, "assets/img/avatars");
                string uniqueFileName = ns.MaNs + Path.GetExtension(newImage.FileName);
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);

                // Lưu file ảnh vào thư mục /assets/img/avatars/
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    newImage.CopyTo(fileStream);
                }
                ns1.HinhAnh = "/assets/img/avatars/" + uniqueFileName;
            }

            ns1.TenNs = ns.TenNs;

            ns1.DiaChi = address1;
            ns1.Email = ns.Email;
            ns1.Sdt = ns.Sdt;
            ns1.GioiTinh = bool.Parse(gioitinh);
            ns1.QueQuan = selectedQueText;
            ns1.NgaySinh = ns.NgaySinh;

            context.NhanSu.Update(ns1);
            context.SaveChanges();
            TempData["ThongBao"] = "Sửa thành công!";
            return RedirectToAction("Home","TrangChu");
        }
    }
}
