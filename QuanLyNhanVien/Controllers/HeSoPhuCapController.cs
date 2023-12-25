using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using QuanLyNhanVien.Models;
using System.Threading.Tasks;
using DocumentFormat.OpenXml.Drawing;

namespace QuanLyNhanVien.Controllers
{
    public class HeSoPhuCapController : Controller
    {
        QuanLyNhanVienContext context = new QuanLyNhanVienContext();
        public IActionResult HeSoPhuCap()
        {
            return View();
        }
        public IActionResult SuaHeSoPhuCap(int id)
        {
            DmheSoPhuCap hspc = context.DmheSoPhuCap.Find(id);
            return View(hspc);
        }

        public IActionResult ThemHeSoPhuCap()
        {
            return View();
        }
        //sửa hệ số phụ cấp
        [HttpPost]
        public IActionResult updateHeSoPhuCap(DmheSoPhuCap hspc)
        {

            DmheSoPhuCap hspc1 = context.DmheSoPhuCap.Find(hspc.Id);

            hspc1.MaHspc = hspc.MaHspc;
            hspc1.HeSoPhuCap = hspc.HeSoPhuCap;

            context.DmheSoPhuCap.Update(hspc1);
            context.SaveChanges();
            TempData["ThongBao"] = "Sửa thành công!";
            return RedirectToAction("HeSoPhuCap");
        }

        //Thêm hệ số phụ cấp 
        [HttpPost]
        public IActionResult insertHeSoPhuCap(DmheSoPhuCap hspc)
        {

            bool isExist = context.DmheSoPhuCap.Any(x => x.MaHspc == hspc.MaHspc);
            if (isExist)
            {
                TempData["ThongBao"] = "Mã hệ số phụ cấp đã tồn tại";
                return RedirectToAction("ThemHeSoPhuCap");
            }
  
            hspc.Active = true;
            context.DmheSoPhuCap.Add(hspc);
            context.SaveChanges();
            TempData["ThongBao"] = "Thêm thành công!";
            return RedirectToAction("HeSoPhuCap");
        }


        public IActionResult XoaHeSoPhuCap(int id)
        {

            DmheSoPhuCap hspc = context.DmheSoPhuCap.Find(id);
            if (hspc != null)
            {
                hspc.Active = false;
                context.SaveChanges();
                TempData["ThongBao"] = "Xóa thành công!";
            }
            else
            {
                TempData["ThongBao"] = "Không tìm thấy dòng để xóa.";
            }
            return RedirectToAction("HeSoPhuCap");
        }
         public IActionResult DoiTrangThai(int trangthai){
           List<DmheSoPhuCap> model;

            if (trangthai == 1)
            {
                model = context.DmheSoPhuCap.Where(x => x.Active == true).ToList();
            }
            else
            {
                model = context.DmheSoPhuCap.Where(x => x.Active == false).ToList();
            }

            return Json(model);
         }
        public IActionResult KhoiPhuc(int id)
        {

            DmheSoPhuCap hspc = context.DmheSoPhuCap.Find(id);
            if (hspc != null)
            {
                hspc.Active = true;
                context.SaveChanges();
                TempData["ThongBao"] = "Khôi phục thành công!";
            }
            else
            {
                TempData["ThongBao"] = "Không tìm thấy dòng để khôi phục.";
            }
            return RedirectToAction("HeSoPhuCap");
        }
    }
}
