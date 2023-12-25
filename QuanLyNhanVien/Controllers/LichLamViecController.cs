using Microsoft.AspNetCore.Mvc;
using QuanLyNhanVien.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuanLyNhanVien.Controllers
{
    public class LichLamViecController : Controller
    {
        QuanLyNhanVienContext context = new QuanLyNhanVienContext();
        public IActionResult LichLamViec()
        {
            ViewBag.LichLamViec = context.LichLamViec.FirstOrDefault();
            return View();
        }
        public IActionResult SuaLichLamViec(LichLamViec model)
        {
            var lichmoi = context.LichLamViec.FirstOrDefault();
            lichmoi.Vaosang = model.Vaosang;
            lichmoi.Rasang = model.Rasang;
            lichmoi.Vaochieu = model.Vaochieu;
            lichmoi.Rachieu = model.Rachieu;
            lichmoi.Vaotoi = model.Vaotoi;
            lichmoi.Ratoi = model.Ratoi;
             context.LichLamViec.Update(lichmoi);
            context.SaveChanges();
            model = lichmoi;
             return Json(new {
                StatusCode = 200,
                message = "Thành công",
                model1 = model,
            });
        
        }

    }
}
