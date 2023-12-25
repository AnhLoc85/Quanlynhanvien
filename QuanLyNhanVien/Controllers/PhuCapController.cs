using Microsoft.AspNetCore.Mvc;
using System.Linq;
using QuanLyNhanVien.Models;
using System.Collections.Generic;


namespace QuanLyNhanVien.Controllers
{
    public class PhuCapController : Controller
    {
        QuanLyNhanVienContext context = new QuanLyNhanVienContext();
        public IActionResult PhuCap()
        {
            return View();
        }
        public IActionResult SuaPhuCap(int id)
        {
            DmmucPhuCap pc = context.DmmucPhuCap.Find(id);
            return View(pc);
        }

        public IActionResult ThemPhuCap()
        {
            return View();
        }
        //sửa danh mục lương
        [HttpPost]
        public IActionResult updatePhuCap(DmmucPhuCap pc)
        {

            DmmucPhuCap pc1 = context.DmmucPhuCap.Find(pc.Id);

            pc1.MaPc = pc.MaPc;
            pc1.KhoanPhuCap = pc.KhoanPhuCap;
            pc1.Tncn = pc.Tncn;
            pc1.Bhxh = pc.Bhxh;
            context.DmmucPhuCap.Update(pc1);
            context.SaveChanges();
            TempData["ThongBao"] = "Sửa thành công!";
            return RedirectToAction("PhuCap");
        }

        //Thêm danh mục lương
        [HttpPost]
        public IActionResult insertPhuCap(DmmucPhuCap pc)
        {

            bool isExist = context.DmmucPhuCap.Any(x => x.MaPc == pc.MaPc);
            if (isExist)
            {
                TempData["ThongBao"] = "Mã phụ cấp đã tồn tại";
                return RedirectToAction("ThemPhuCap");
            }

            pc.Active = true;
            context.DmmucPhuCap.Add(pc);
            context.SaveChanges();
            TempData["ThongBao"] = "Thêm thành công!";
            return RedirectToAction("PhuCap");
        }


        public IActionResult XoaPhuCap(int id)
        {
            DmmucPhuCap pc = context.DmmucPhuCap.Find(id);

            if (pc != null)
            {
                pc.Active = false;
                context.SaveChanges();
                TempData["ThongBao"] = "Xóa thành công!";
            }
            else
            {
                TempData["ThongBao"] = "Không tìm thấy dòng để xóa.";
            }

            return RedirectToAction("PhuCap");
        }
         public IActionResult DoiTrangThai(int trangthai){
           List<DmmucPhuCap> model;

            if (trangthai == 1)
            {
                model = context.DmmucPhuCap.Where(x => x.Active == true).ToList();
            }
            else
            {
                model = context.DmmucPhuCap.Where(x => x.Active == false).ToList();
            }

            return Json(model);
         }
        public IActionResult KhoiPhuc(int id)
        {
            DmmucPhuCap pc = context.DmmucPhuCap.Find(id);

            if (pc != null)
            {
                pc.Active = true;
                context.SaveChanges();
                TempData["ThongBao"] = "Khôi phục thành công!";
            }
            else
            {
                TempData["ThongBao"] = "Không tìm thấy dòng để khôi phục.";
            }

            return RedirectToAction("PhuCap");
        }

    }
}
