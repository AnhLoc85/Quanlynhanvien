using Microsoft.AspNetCore.Mvc;
using System.Linq;
using QuanLyNhanVien.Models;


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

    }
}
