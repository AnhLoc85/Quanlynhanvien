using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using QuanLyNhanVien.Models;

namespace QuanLyNhanVien.Controllers
{
    public class NhanSuController : Controller
    {
        QuanLyNhanVienContext context = new QuanLyNhanVienContext();
        public IActionResult NhanSu()
        {
            return View();
        }

        public IActionResult ChiTietNhanSu(int id)
        {
            NhanSu ns = context.NhanSu.Find(id);
            return View(ns);
        }
        public IActionResult SuaNhanSu(int id)
        {
            NhanSu ns = context.NhanSu.Find(id);
            return View(ns);
        }
        public IActionResult ThemNhanSu()
        {
           
            return View();
        }
    }
}
