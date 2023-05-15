using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using QuanLyNhanVien.Models;

namespace QuanLyNhanVien.Controllers
{
    public class NhanSuController : Controller
    {
        QuanLyNhanVienContext context = new QuanLyNhanVienContext();
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
            return View(ns);
        }
        public IActionResult ThemNhanSu()
        {
            return View();
        }
        public IActionResult insertNhanSu(NhanSu ns)
        {
            {
                bool isExist = context.NhanSu.Any(x => x.MaNs == ns.MaNs);
                if (isExist)
                {
                    TempData["ThongBao"] = "Mã nhân sự đã tồn tại";
                    return RedirectToAction("ThemNhanSu");
                }

                context.NhanSu.Add(ns);
                context.SaveChanges();
                TempData["ThongBao"] = "Thêm thành công!";
                return RedirectToAction("NhanSu");
            }
        }
        public IActionResult updateNhanSu(NhanSu ns)
        {
            NhanSu ns1 = context.NhanSu.Find(ns.Id);

            ns1.MaNs = ns.MaNs;
            ns1.TenNs = ns.TenNs;
            ns1.HinhAnh = ns.HinhAnh;
            ns1.DiaChi = ns.DiaChi;
            ns1.Email = ns.Email;
            ns1.Sdt = ns.Sdt;
            ns1.GioiTinh = ns.GioiTinh;
            ns1.QueQuan = ns.QueQuan;
            ns1.NgaySinh = ns.NgaySinh;

            context.NhanSu.Update(ns1);
            context.SaveChanges();
            TempData["ThongBao"] = "Sửa thành công!";
            return RedirectToAction("NhanSu");
        }

        public IActionResult deleteNhanSu(int id)
        {
                NhanSu ns = context.NhanSu.Find(id);


                context.NhanSu.Remove(ns);
                context.SaveChanges();
                TempData["ThongBao"] = "Xóa thành công!";
                return RedirectToAction("NhanSu");
        }
    }
}
