using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using QuanLyNhanVien.Models;
using System;
using System.Globalization;
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
        public IActionResult QuaTrinhThuong(int id)
        {
            ViewBag.NS = context.NhanSu.FirstOrDefault(x => x.Id == id);
            ViewBag.TPCK = context.QuaTrinhThuongPc.Include(x => x.MaNsNavigation).Include(x => x.MaThuongNavigation).Where(x => x.MaNs == id).ToList();
            ViewBag.P = context.QuaTrinhPhat.Include(x => x.MaNsNavigation).Include(x => x.MaPhatNavigation).Where(x => x.MaNs == id).ToList();
            return View();
        }
        [HttpPost("/loadTNhanVien")]
        public IActionResult loadTNhanVien(int IDPB)
        {
            if (IDPB == 0)
            {
                ViewBag.NNV = context.NhanSu.ToList();
            }
            else
            {
                ViewBag.NNV = context.QtcongTac.Include(x => x.MaNsNavigation).Where(x => x.MaPb == IDPB).ToList();
            }
            ViewBag.IDPB = IDPB;
            return PartialView();
        }
        [HttpPost("/insertQTThuong")]
        public string insertQTThuong(int IdNS, int MaThuong, DateTime ThoiGian, decimal TienThuong)
        {
         
            QuaTrinhThuongPc qtt = new QuaTrinhThuongPc();
            qtt.MaNs = IdNS;
            qtt.MaThuong = MaThuong;
            qtt.Tgthuong = ThoiGian;
            qtt.TienThuong = TienThuong;

            context.QuaTrinhThuongPc.Add(qtt);
            context.SaveChanges();
            return "ok";
        }

        [HttpPost("/addNewRowQTT")]
        public IActionResult addNewRowQTT(DateTime thoigian, int mathuong, decimal tienthuong,string khoanthuong, int idqtt)
        {
            ViewBag.khoanthuong = khoanthuong;
            ViewBag.thoigian = thoigian;
            ViewBag.mathuong = mathuong;
            ViewBag.tienthuong = tienthuong;
            ViewBag.IDQTT = idqtt;
            return PartialView();
        }
        [HttpPost("/UpdateQTT")]
        public string UpdateQTT(string thoigian, int mathuong, decimal tienthuong, int IDQTT)
        {
           
            QuaTrinhThuongPc qtt = context.QuaTrinhThuongPc.Find(IDQTT);
            qtt.Tgthuong = DateTime.ParseExact(thoigian, "dd/MM/yyyy", CultureInfo.InvariantCulture); ;
            qtt.MaThuong = mathuong;
            qtt.TienThuong = tienthuong;

            context.QuaTrinhThuongPc.Update(qtt);
            context.SaveChanges();
            return "Cập nhập thành công";
        }

        [HttpPost("/XoaQTThuong")]
        public string XoaQTThuong(int IDQTT)
        {
            QuaTrinhThuongPc qtt = context.QuaTrinhThuongPc.FirstOrDefault(x => x.Id == IDQTT);
            context.QuaTrinhThuongPc.Remove(qtt);
            context.SaveChanges();
            return "Xóa thành công";
        }
        [HttpPost("/insertQTP")]
        public string insertQTP(int IdNS, int MaPhat, DateTime ThoiGian, decimal TienPhat)
        {

            QuaTrinhPhat qtp = new QuaTrinhPhat();
            qtp.MaNs = IdNS;
            qtp.MaPhat = MaPhat;
            qtp.Tgphat  = ThoiGian;
            qtp.TienPhat = TienPhat;

            context.QuaTrinhPhat.Add(qtp);
            context.SaveChanges();
            return "ok";
        }

        [HttpPost("/addNewRowQTP")]
        public IActionResult addNewRowQTP(DateTime thoigian, int maphat, decimal tienphat, string khoanphat, int idqtp)
        {
            ViewBag.khoanphat = khoanphat;
            ViewBag.thoigian = thoigian;
            ViewBag.maphat = maphat;
            ViewBag.tienphat = tienphat;
            ViewBag.IDQTP = idqtp;
            return PartialView();
        }
        [HttpPost("/UpdateQTP")]
        public string UpdateQTP(string thoigian, int maphat, decimal tienphat,  int IDQTP)
        {

            QuaTrinhPhat qtp = context.QuaTrinhPhat.Find(IDQTP);
            qtp.Tgphat = DateTime.ParseExact(thoigian, "dd/MM/yyyy", CultureInfo.InvariantCulture); ;
            qtp.MaPhat = maphat;
            qtp.TienPhat = tienphat;

            context.QuaTrinhPhat.Update(qtp);
            context.SaveChanges();
            return "Cập nhập thành công";
        }

        [HttpPost("/XoaQTP")]
        public string XoaQTP(int IDQTP)
        {
            QuaTrinhPhat qtp = context.QuaTrinhPhat.FirstOrDefault(x => x.Id == IDQTP);
            context.QuaTrinhPhat.Remove(qtp);
            context.SaveChanges();
            return "Xóa thành công";
        }
    }
}
