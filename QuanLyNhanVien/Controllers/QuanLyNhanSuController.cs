using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using QuanLyNhanVien.Models;

namespace QuanLyNhanVien.Controllers
{
    public class QuanLyNhanSuController : Controller
    {
        QuanLyNhanVienContext context = new QuanLyNhanVienContext();
        public IActionResult QuaTrinhLamViec()
        {
            return View();
        }
        public IActionResult QuaTrinh()
        {
            return View();
        }
        public IActionResult DieuChinhLuong()
        {
            return View();
        }
        [HttpPost("/loadNhomNhanVien")]
        public IActionResult loadNhomNhanVien(int IDPB)
        {
            if(IDPB == 0)
            {
                ViewBag.NNV = context.NhanSu.ToList();
            }
            else
            {
                ViewBag.NNV = context.QtcongTac.Where(x => x.MaPb == IDPB).ToList();
            }
            ViewBag.IDPB = IDPB;
            return PartialView();
        }
    }
}
