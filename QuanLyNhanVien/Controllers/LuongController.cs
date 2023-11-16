using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using QuanLyNhanVien.Models;
using System.Threading.Tasks;

namespace QuanLyNhanVien.Controllers
{
    public class LuongController : Controller
    {
        QuanLyNhanVienContext context = new QuanLyNhanVienContext();
        public IActionResult Luong()
        {
            return View();
        }
        public IActionResult SuaLuong(int id)
        {
            Dmluong luong = context.Dmluong.Find(id);
            return View(luong);
        }

        public IActionResult ThemLuong()
        {
            return View();
        }
        //sửa danh mục lương
        [HttpPost]
        public IActionResult updateLuong(Dmluong luong)
        {

            Dmluong luong1 = context.Dmluong.Find(luong.Id);

            luong1.MaMl = luong.MaMl;
            luong1.TienLuong = luong.TienLuong;



            context.Dmluong.Update(luong1);
            context.SaveChanges();
            TempData["ThongBao"] = "Sửa thành công!";
            return RedirectToAction("Luong");
        }

        //Thêm danh mục lương
        [HttpPost]
        public IActionResult insertLuong(Dmluong luong)
        {

            bool isExist = context.Dmluong.Any(x => x.MaMl == luong.MaMl);
            if (isExist)
            {
                TempData["ThongBao"] = "Mã mức lương đã tồn tại";
                return RedirectToAction("ThemLuong");
            }

            luong.NgayAd = DateTime.Now; 
            context.Dmluong.Add(luong);
            context.SaveChanges();
            TempData["ThongBao"] = "Thêm thành công!";
            return RedirectToAction("Luong");
        }


        public IActionResult XoaLuong(int id)
        {

            Dmluong luong = context.Dmluong.Find(id);


            if (luong != null)
            {
                luong.Active = false;
                context.SaveChanges();
                TempData["ThongBao"] = "Xóa thành công!";
            }
            else
            {
                TempData["ThongBao"] = "Không tìm thấy dòng để xóa.";
            }
            return RedirectToAction("Luong");
        }
    }
}
