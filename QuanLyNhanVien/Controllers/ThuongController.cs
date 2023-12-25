using Microsoft.AspNetCore.Mvc;
using System.Linq;
using QuanLyNhanVien.Models;
using System.Collections.Generic;


namespace QuanLyNhanVien.Controllers
{
    public class ThuongController : Controller
    {
        QuanLyNhanVienContext context = new QuanLyNhanVienContext();
        public IActionResult Thuong()
        {
            return View();
        }
        public IActionResult SuaThuong(int id)
        {
            ThuongPckhac thuong = context.ThuongPckhac.Find(id);
            return View(thuong);
        }

        public IActionResult ThemThuong()
        {
            return View();
        }
        //sửa danh mục lương
        [HttpPost]
        public IActionResult updateThuong(ThuongPckhac thuong)
        {

            ThuongPckhac thuong1 = context.ThuongPckhac.Find(thuong.Id);

            thuong1.MaThuong = thuong.MaThuong;
            thuong1.NoiDung = thuong.NoiDung;
            thuong1.Tncn = thuong.Tncn;
            thuong1.Bhxh = thuong.Bhxh;
            context.ThuongPckhac.Update(thuong1);
            context.SaveChanges();
            TempData["ThongBao"] = "Sửa thành công!";
            return RedirectToAction("Thuong");
        }

        //Thêm danh mục lương
        [HttpPost]
        public IActionResult insertThuong(ThuongPckhac thuong)
        {

            bool isExist = context.ThuongPckhac.Any(x => x.MaThuong == thuong.MaThuong);
            if (isExist)
            {
                TempData["ThongBao"] = "Mã thưởng đã tồn tại";
                return RedirectToAction("ThemThuong");
            }

            thuong.Active = true;
            context.ThuongPckhac.Add(thuong);
            context.SaveChanges();
            TempData["ThongBao"] = "Thêm thành công!";
            return RedirectToAction("Thuong");
        }


        public IActionResult XoaThuong(int id)
        {

            ThuongPckhac thuong = context.ThuongPckhac.Find(id);
            if (thuong != null)
            {
                thuong.Active = false;
                context.SaveChanges();
                TempData["ThongBao"] = "Xóa thành công!";
            }
            else
            {
                TempData["ThongBao"] = "Không tìm thấy dòng để xóa.";
            }
            return RedirectToAction("Thuong");
        }
          public IActionResult DoiTrangThai(int trangthai){
           List<ThuongPckhac> model;

            if (trangthai == 1)
            {
                model = context.ThuongPckhac.Where(x => x.Active == true).ToList();
            }
            else
            {
                model = context.ThuongPckhac.Where(x => x.Active == false).ToList();
            }

            return Json(model);
         }
          public IActionResult KhoiPhuc(int id)
        {
            ThuongPckhac thuong = context.ThuongPckhac.Find(id);
            if (thuong != null)
            {
                thuong.Active = true;
                context.SaveChanges();
                TempData["ThongBao"] = "Khôi phục thành công!";
            }
            else
            {
                TempData["ThongBao"] = "Không tìm thấy dòng để khôi phục.";
            }
            return RedirectToAction("Thuong");
        }
    }
}
