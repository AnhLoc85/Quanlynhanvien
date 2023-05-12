using Microsoft.AspNetCore.Mvc;
using QuanLyNhanVien.Models;
using System.Linq;


namespace QuanLyNhanVien.Controllers
{
    public class CapNhatThuongController : Controller
    {
        QuanLyNhanVienContext context = new QuanLyNhanVienContext();
        public IActionResult CapNhatThuong()
        {
            return View();
        }
        public IActionResult QuaTrinhThuong()
        {
            return View();
        }
        [HttpPost("/loadNhomNhanVien")]
        public IActionResult loadNhomNhanVien(int IDPB)
        {
            if (IDPB == 0)
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
