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
    public class NhanSuController : Controller
    {
        QuanLyNhanVienContext context = new QuanLyNhanVienContext();
        private readonly IWebHostEnvironment webHostEnvironment;

        public NhanSuController(IWebHostEnvironment hostEnvironment)
        {
            webHostEnvironment = hostEnvironment;
        }

        public IActionResult NhanSu()
        {
            return View();
        }

        public IActionResult ChiTietNhanSu(int id)
        {
            ViewBag.QTCV = context.QtchucVu.FirstOrDefault(x => x.MaNs == id);
            NhanSu ns = context.NhanSu.Find(id);
            return View(ns);
        }
        public IActionResult SuaNhanSu(int id)
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
        public IActionResult ThemNhanSu()
        {
            return View();
        }
        public IActionResult insertNhanSu(NhanSu ns, string selectedCityText, string selectedDistrictText, string selectedWardText, string address, IFormFile avt)
        {
            bool isExist = context.NhanSu.Any(x => x.MaNs == ns.MaNs);
            if (isExist)
            {
                TempData["ThongBao"] = "Mã nhân sự đã tồn tại";
                return RedirectToAction("ThemNhanSu");
            }

            var address1 = address + ", " + selectedWardText + ", " + selectedDistrictText + ", " + selectedCityText;
            ns.DiaChi = address1;
            ns.HinhAnh = UploadedFile(ns, avt);
            context.NhanSu.Add(ns);
            context.SaveChanges();

            TempData["ThongBao"] = "Thêm thành công!";
            return RedirectToAction("NhanSu");
        }
        public IActionResult updateNhanSu(NhanSu ns, string selectedCityText, string selectedDistrictText, string selectedWardText, string address, string selectedQueText, IFormFile newImage, string gioitinh)
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
            return RedirectToAction("NhanSu");
        }

        public IActionResult XoaNhanSu(int id)
        {
                NhanSu ns = context.NhanSu.Find(id);
                List<QtchucVu> qtcvList = context.QtchucVu.Where(x => x.MaNs == id).ToList();
            List<QtcongTac> qtctList = context.QtcongTac.Where(x => x.MaNs == id).ToList();
            List<QuaTrinhLuong> qtlList = context.QuaTrinhLuong.Where(x => x.MaNs == id).ToList();
            List<QuaTrinhThuongPc> qttList = context.QuaTrinhThuongPc.Where(x => x.MaNs == id).ToList();
            List<QuaTrinhPhat> qtpList = context.QuaTrinhPhat.Where(x => x.MaNs == id).ToList();
            List<QuaTrinhPhuCap> qtpcList = context.QuaTrinhPhuCap.Where(x => x.MaNs == id).ToList();
            List<QuaTrinhDongThue> qtdtList = context.QuaTrinhDongThue.Where(x => x.MaNs == id).ToList();
            List<QuaTrinhDongBh> qtbhList = context.QuaTrinhDongBh.Where(x => x.MaNs == id).ToList();

            context.QtchucVu.RemoveRange(qtcvList);
            context.QtcongTac.RemoveRange(qtctList);
            context.QuaTrinhLuong.RemoveRange(qtlList);
            context.QuaTrinhThuongPc.RemoveRange(qttList);
            context.QuaTrinhPhat.RemoveRange(qtpList);
            context.QuaTrinhPhuCap.RemoveRange(qtpcList);
            context.QuaTrinhDongThue.RemoveRange(qtdtList);
            context.QuaTrinhDongBh.RemoveRange(qtbhList);
            context.NhanSu.Remove(ns);
                context.SaveChanges();
                TempData["ThongBao"] = "Xóa thành công!";
                return RedirectToAction("NhanSu");
        }
        private string UploadedFile(NhanSu model, IFormFile avt)
        {
            string uniqueFileName = null;

            if (avt != null)
            {
                string uploadsFolder = Path.Combine(webHostEnvironment.WebRootPath, "assets/img/avatars");
                uniqueFileName = model.MaNs + ".png";
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    avt.CopyTo(fileStream);
                }

                uniqueFileName = "/assets/img/avatars/" + uniqueFileName; // Thêm đường dẫn vào tên file
            }

            return uniqueFileName;
        }
    }
}
