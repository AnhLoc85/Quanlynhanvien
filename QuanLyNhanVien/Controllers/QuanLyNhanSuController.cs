using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using QuanLyNhanVien.Models;
using Microsoft.EntityFrameworkCore;

namespace QuanLyNhanVien.Controllers
{
    public class QuanLyNhanSuController : Controller
    {
        QuanLyNhanVienContext context = new QuanLyNhanVienContext();
        public IActionResult QuaTrinhLamViec()
        {
            return View();
        }



        public IActionResult QuaTrinh(int id)
        {
            ViewBag.NS = context.NhanSu.FirstOrDefault(x => x.Id == id);
            ViewBag.QTCV = context.QtchucVu.Include(x => x.MaNsNavigation).Include(x => x.MaCvNavigation).Where(x => x.MaNs == id).ToList();
            ViewBag.QTCT = context.QtcongTac.Include(x => x.MaNsNavigation).Include(x => x.MaPbNavigation).Where(x => x.MaNs == id).ToList();
            ViewBag.QTL = context.QuaTrinhLuong.Include(x => x.MaNsNavigation).Include(x => x.MaHslNavigation).Include(x => x.MaMlNavigation).Where(x => x.MaNs == id).ToList();
            ViewBag.QTPC = context.QuaTrinhPhuCap.Include(x => x.MaNsNavigation).Include(x => x.MaHspcNavigation).Include(x => x.MaPcNavigation).Where(x => x.MaNs == id).ToList();
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
