using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using QuanLyNhanVien.Models;

namespace QuanLyNhanVien.Controllers
{
    public class BHXHController : Controller
    {
        QuanLyNhanVienContext context = new QuanLyNhanVienContext();
        public IActionResult BHXH()
        {
            return View();
        }

        [Route("/BHXH/ViewSuaBHXH/{id}")]
        public IActionResult SuaBHXH(int id)
        {
            BaoHiem bh = context.BaoHiem.Find(id);
            return View(bh);
        }

        //sửa múc bảo hiểm
        [HttpPost]
        public IActionResult updateBHXH(BaoHiem bh)
        {

            BaoHiem bh1 = context.BaoHiem.Find(bh.Id);

            bh1.MaBh = bh.MaBh;
            bh1.MucBaoHiem = bh.MucBaoHiem;
            bh1.Tgad = bh.Tgad;

            context.BaoHiem.Update(bh1);
            context.SaveChanges();
            TempData["ThongBao"] = "Sửa thành công!";
            return RedirectToAction("BHXH");
        }

        //Thêm mức bảo hiểm
        [HttpPost]
        public IActionResult insertBHXH(BaoHiem bh)
        {
            bool isExist = context.BaoHiem.Any(x => x.MaBh == bh.MaBh);
            if (isExist)
            {
                TempData["ThongBao"] = "Mã bảo hiểm đã tồn tại";
                return RedirectToAction("ThemBHXH");
            }

            context.BaoHiem.Add(bh);
            context.SaveChanges();
            TempData["ThongBao"] = "Thêm thành công!";
            return RedirectToAction("BHXH");
        }
        public IActionResult ViewThemBHXH()
        {
            return View("ThemBHXH");
        }

        [Route("/BHXH/XoaBHXH/{id}")]
        public IActionResult XoaBHXH(int id)
        {
            BaoHiem bh = context.BaoHiem.Find(id);
            context.BaoHiem.Remove(bh);
            context.SaveChanges();
            TempData["ThongBao"] = "Xóa thành công!";
            return RedirectToAction("BHXH");
        }
    }
}
