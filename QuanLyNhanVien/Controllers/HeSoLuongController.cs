﻿using Microsoft.AspNetCore.Mvc;
using QuanLyNhanVien.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuanLyNhanVien.Controllers
{
    public class HeSoLuongController : Controller
    {
        QuanLyNhanVienContext context = new QuanLyNhanVienContext();
        public IActionResult HeSoLuong()
        {
            return View();
        }
        public IActionResult SuaHeSoLuong(int id)
        {
            Dmhsluong hsl = context.Dmhsluong.Find(id);
            return View(hsl);
        }

        public IActionResult ThemHeSoLuong()
        {
            return View();
        }
        //sửa hệ số lương
        [HttpPost]
        public IActionResult updateHeSoLuong(Dmhsluong hsl)
        {

            Dmhsluong hsl1 = context.Dmhsluong.Find(hsl.Id);

            hsl1.MaHsl = hsl.MaHsl;
            hsl1.HeSoLuong = hsl.HeSoLuong;

            context.Dmhsluong.Update(hsl1);
            context.SaveChanges();
            TempData["ThongBao"] = "Sửa thành công!";
            return RedirectToAction("HeSoLuong");
        }

       
        [HttpPost]
        public IActionResult insertHeSoLuong(Dmhsluong hsl)
        {
    
            bool isExist = context.Dmhsluong.Any(x => x.MaHsl == hsl.MaHsl);
            if (isExist)
            {
                TempData["ThongBao"] = "Mã hệ số lương đã tồn tại";
                return RedirectToAction("ThemHeSoLuong");
            }

            hsl.Active = true;
            context.Dmhsluong.Add(hsl);
            context.SaveChanges();
            TempData["ThongBao"] = "Thêm thành công!";
            return RedirectToAction("HeSoLuong");
        }


        public IActionResult XoaHeSoLuong(int id)
        {

            Dmhsluong hsl = context.Dmhsluong.Find(id);
            if (hsl != null)
            {
                hsl.Active = false;
                context.SaveChanges();
                TempData["ThongBao"] = "Xóa thành công!";
            }
            else
            {
                TempData["ThongBao"] = "Không tìm thấy dòng để xóa.";
            }
            return RedirectToAction("HeSoLuong");
        }
         public IActionResult DoiTrangThai(int trangthai){
           List<Dmhsluong> heSoLuongList;

            if (trangthai == 1)
            {
                heSoLuongList = context.Dmhsluong.Where(x => x.Active == true).ToList();
            }
            else
            {
                heSoLuongList = context.Dmhsluong.Where(x => x.Active == false).ToList();
            }

            return Json(heSoLuongList);
         }
         public IActionResult KhoiPhuc(int id)
        {

            Dmhsluong hsl = context.Dmhsluong.Find(id);
            if (hsl != null)
            {
                hsl.Active = true;
                context.SaveChanges();
                TempData["ThongBao"] = "Khôi phục thành công!";
            }
            else
            {
                TempData["ThongBao"] = "Không tìm thấy dòng để khôi phục.";
            }
            return RedirectToAction("HeSoLuong");
        }
    }
}
