using Microsoft.AspNetCore.Mvc;
using System.Linq;
using QuanLyNhanVien.Models;
using System.Collections.Generic;


namespace QuanLyNhanVien.Controllers
{
    public class PhatController : Controller
    {
        QuanLyNhanVienContext context = new QuanLyNhanVienContext();
        public IActionResult Phat()
        {
            return View();
        }
        public IActionResult SuaPhat(int id)
        {
            Phat phat = context.Phat.Find(id);
            return View(phat);
        }

        public IActionResult ThemPhat()
        {
            return View();
        }
        //sửa danh mục lương
        [HttpPost]
        public IActionResult updatePhat(Phat phat)
        {

            Phat phat1 = context.Phat.Find(phat.Id);

            phat1.MaPhat = phat.MaPhat;
            phat1.NoiDung = phat.NoiDung;

            context.Phat.Update(phat1);
            context.SaveChanges();
            TempData["ThongBao"] = "Sửa thành công!";
            return RedirectToAction("Phat");
        }

        //Thêm danh mục lương
        [HttpPost]
        public IActionResult insertPhat(Phat phat)
        {

            bool isExist = context.Phat.Any(x => x.MaPhat == phat.MaPhat);
            if (isExist)
            {
                TempData["ThongBao"] = "Mã phạt đã tồn tại";
                return RedirectToAction("ThemPhat");
            }

            phat.Active = true;
            context.Phat.Add(phat);
            context.SaveChanges();
            TempData["ThongBao"] = "Thêm thành công!";
            return RedirectToAction("Phat");
        }


        public IActionResult XoaPhat(int id)
        {

            Phat phat = context.Phat.Find(id);
            if (phat != null)
            {
                phat.Active = false;
                context.SaveChanges();
                TempData["ThongBao"] = "Xóa thành công!";
            }
            else
            {
                TempData["ThongBao"] = "Không tìm thấy dòng để xóa.";
            }
            return RedirectToAction("Phat");
        }
         public IActionResult DoiTrangThai(int trangthai){
           List<Phat> model;

            if (trangthai == 1)
            {
                model = context.Phat.Where(x => x.Active == true).ToList();
            }
            else
            {
                model = context.Phat.Where(x => x.Active == false).ToList();
            }

            return Json(model);
         }
        public IActionResult KhoiPhuc(int id)
        {

            Phat phat = context.Phat.Find(id);
            if (phat != null)
            {
                phat.Active = true;
                context.SaveChanges();
                TempData["ThongBao"] = "Khôi phục thành công!";
            }
            else
            {
                TempData["ThongBao"] = "Không tìm thấy dòng để khôi phục.";
            }
            return RedirectToAction("Phat");
        }
    }
}
