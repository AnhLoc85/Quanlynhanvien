using Microsoft.AspNetCore.Mvc;
using System.Linq;
using QuanLyNhanVien.Models;


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


            context.ThuongPckhac.Add(thuong);
            context.SaveChanges();
            TempData["ThongBao"] = "Thêm thành công!";
            return RedirectToAction("Thuong");
        }


        public IActionResult XoaThuong(int id)
        {

            ThuongPckhac thuong = context.ThuongPckhac.Find(id);


            context.ThuongPckhac.Remove(thuong);
            context.SaveChanges();
            TempData["ThongBao"] = "Xóa thành công!";
            return RedirectToAction("Thuong");
        }
    }
}
