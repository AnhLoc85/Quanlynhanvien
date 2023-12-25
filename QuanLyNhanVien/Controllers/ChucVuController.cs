﻿using Microsoft.AspNetCore.Mvc;
using QuanLyNhanVien.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuanLyNhanVien.Controllers
{
    public class ChucVuController : Controller
    {
        QuanLyNhanVienContext context = new QuanLyNhanVienContext();
        public IActionResult ChucVu()
        {
            ViewBag.ChucVu = context.ChucVu.Where(x => x.Active == true);
            return View();
        }

        public IActionResult SuaChucVu(int id)
        {
            ChucVu cv = context.ChucVu.Find(id);
            return View(cv);
        }

        public IActionResult ThemChucVu()
        {
            return View();
        }
        //sửa múc bảo hiểm
        [HttpPost]
        public IActionResult updateChucVu(ChucVu cv)
        {

            ChucVu cv1 = context.ChucVu.Find(cv.Id);

            cv1.MaCv = cv.MaCv;
            cv1.TenChucVu = cv.TenChucVu;
      

            context.ChucVu.Update(cv1);
            context.SaveChanges();
            TempData["ThongBao"] = "Sửa thành công!";
            return RedirectToAction("ChucVu");
        }

        //Thêm mức bảo hiểm
        [HttpPost]
        public IActionResult insertChucVu(ChucVu cv)
        {
            bool isExist = context.ChucVu.Any(x => x.MaCv == cv.MaCv);
            if (isExist)
            {
                TempData["ThongBao"] = "Mã chức vụ đã tồn tại";
                return RedirectToAction("ThemChucVu");
            }
            cv.Active = true;
            context.ChucVu.Add(cv);
            context.SaveChanges();
            TempData["ThongBao"] = "Thêm thành công!";
            return RedirectToAction("ChucVu");
        }
     
        public IActionResult XoaChucVu(int id)
        {

            ChucVu cv = context.ChucVu.Find(id);


            if (cv != null)
            {
                cv.Active = false;
                context.SaveChanges();
                TempData["ThongBao"] = "Xóa thành công!";
            }
            else
            {
                TempData["ThongBao"] = "Không tìm thấy dòng để xóa.";
            }
            return RedirectToAction("ChucVu");
        }
         public IActionResult DoiTrangThai(int trangthai){
           List<ChucVu> model;

            if (trangthai == 1)
            {
                model = context.ChucVu.Where(x => x.Active == true).ToList();
            }
            else
            {
                model = context.ChucVu.Where(x => x.Active == false).ToList();
            }

            return Json(model);
         }
        
         public IActionResult Khoiphuc(int id)
        {

            ChucVu cv = context.ChucVu.Find(id);


            if (cv != null)
            {
                cv.Active = true;
                context.SaveChanges();
                TempData["ThongBao"] = "Khôi phục thành công!";
            }
            else
            {
                TempData["ThongBao"] = "Không tìm thấy dòng để khôi phục";
            }
            return RedirectToAction("ChucVu");
        }
    }
}
