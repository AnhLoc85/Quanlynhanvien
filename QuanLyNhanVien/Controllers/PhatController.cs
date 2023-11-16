using Microsoft.AspNetCore.Mvc;
using System.Linq;
using QuanLyNhanVien.Models;


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
    }
}
