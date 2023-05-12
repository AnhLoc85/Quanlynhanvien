using Microsoft.AspNetCore.Mvc;
using System.Linq;
using QuanLyNhanVien.Models;


namespace QuanLyNhanVien.Controllers
{
    public class PhongBanController : Controller
    {
        QuanLyNhanVienContext context = new QuanLyNhanVienContext();
        public IActionResult PhongBan()
        {
            return View();
        }
        public IActionResult SuaPhongBan(int id)
        {
            PhongBan pb = context.PhongBan.Find(id);
            return View(pb);
        }

        public IActionResult ThemPhongBan()
        {
            return View();
        }
        //sửa danh mục lương
        [HttpPost]
        public IActionResult updatePhongBan(PhongBan pb)
        {

            PhongBan PhongBan1 = context.PhongBan.Find(pb.Id);

            PhongBan1.MaPb = pb.MaPb;
            PhongBan1.TenPhongBan = pb.TenPhongBan;



            context.PhongBan.Update(PhongBan1);
            context.SaveChanges();
            TempData["ThongBao"] = "Sửa thành công!";
            return RedirectToAction("PhongBan");
        }

        //Thêm danh mục lương
        [HttpPost]
        public IActionResult insertPhongBan(PhongBan pb)
        {

            bool isExist = context.PhongBan.Any(x => x.MaPb == pb.MaPb);
            if (isExist)
            {
                TempData["ThongBao"] = "Mã phòng ban đã tồn tại";
                return RedirectToAction("ThemPhongBan");
            }


            context.PhongBan.Add(pb);
            context.SaveChanges();
            TempData["ThongBao"] = "Thêm thành công!";
            return RedirectToAction("PhongBan");
        }


        public IActionResult XoaPhongBan(int id)
        {

            PhongBan pb = context.PhongBan.Find(id);


            context.PhongBan.Remove(pb);
            context.SaveChanges();
            TempData["ThongBao"] = "Xóa thành công!";
            return RedirectToAction("PhongBan");
        }
    }
}
