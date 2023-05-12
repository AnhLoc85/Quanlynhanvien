using Microsoft.AspNetCore.Mvc;
using System.Linq;
using QuanLyNhanVien.Models;


namespace QuanLyNhanVien.Controllers
{
    public class ThueController : Controller
    {
        QuanLyNhanVienContext context = new QuanLyNhanVienContext();
        public IActionResult Thue()
        {
            return View();
        }
        public IActionResult SuaThue(int id)
        {
            Thue thue = context.Thue.Find(id);
            return View(thue);
        }

        public IActionResult ThemThue()
        {
            return View();
        }
        //sửa danh mục lương
        [HttpPost]
        public IActionResult updateThue(Thue thue)
        {

            Thue thue1 = context.Thue.Find(thue.Id);

            thue1.MaThue = thue.MaThue;
            thue1.ThueSuat = thue.ThueSuat;



            context.Thue.Update(thue1);
            context.SaveChanges();
            TempData["ThongBao"] = "Sửa thành công!";
            return RedirectToAction("Thue");
        }

        //Thêm danh mục lương
        [HttpPost]
        public IActionResult insertThue(Thue thue)
        {

            bool isExist = context.Thue.Any(x => x.MaThue == thue.MaThue);
            if (isExist)
            {
                TempData["ThongBao"] = "Mã thuế suất đã tồn tại";
                return RedirectToAction("ThemThue");
            }


            context.Thue.Add(thue);
            context.SaveChanges();
            TempData["ThongBao"] = "Thêm thành công!";
            return RedirectToAction("Thue");
        }


        public IActionResult XoaThue(int id)
        {

            Thue thue = context.Thue.Find(id);


            context.Thue.Remove(thue);
            context.SaveChanges();
            TempData["ThongBao"] = "Xóa thành công!";
            return RedirectToAction("Thue");
        }
    }
}
