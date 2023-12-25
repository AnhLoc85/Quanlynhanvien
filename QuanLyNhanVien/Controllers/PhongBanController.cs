using Microsoft.AspNetCore.Mvc;
using System.Linq;
using QuanLyNhanVien.Models;
using System.Collections.Generic;


namespace QuanLyNhanVien.Controllers
{
    public class PhongBanController : Controller
    {
        QuanLyNhanVienContext context = new QuanLyNhanVienContext();
        public IActionResult PhongBan()
        {
            ViewBag.PhongBan = context.PhongBan.Where(x => x.Active == true);
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

            pb.Active = true;
            context.PhongBan.Add(pb);
            context.SaveChanges();
            TempData["ThongBao"] = "Thêm thành công!";
            return RedirectToAction("PhongBan");
        }


        public IActionResult XoaPhongBan(int id)
        {

            PhongBan pb = context.PhongBan.Find(id);

            if(pb != null)
            {
                pb.Active = false;
                context.SaveChanges();
                TempData["ThongBao"] = "Xóa thành công!";
            }
            else
            {
                TempData["ThongBao"] = "Không tìm thấy dòng để xóa.";
            }
            return RedirectToAction("PhongBan");
        }
         public IActionResult DoiTrangThai(int trangthai){
           List<PhongBan> phongBanList;

            if (trangthai == 1)
            {
                phongBanList = context.PhongBan.Where(x => x.Active == true).ToList();
            }
            else
            {
                phongBanList = context.PhongBan.Where(x => x.Active == false).ToList();
            }

            return Json(phongBanList);
         }
         public IActionResult KhoiPhuc(int id)
        {

            PhongBan pb = context.PhongBan.Find(id);

            if(pb != null)
            {
                pb.Active = true;
                context.SaveChanges();
                TempData["ThongBao"] = "Khôi phục thành công!";
            }
            else
            {
                TempData["ThongBao"] = "Không tìm thấy dòng để khôi phục.";
            }
            return RedirectToAction("PhongBan");
        }
    }
}
