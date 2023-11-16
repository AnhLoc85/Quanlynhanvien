using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Globalization;
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
        [HttpPost("/loadNhomNhanVien1")]
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
        [HttpPost("/insertQTChucVu")]
        public string insertQTChucVu(int IdNS, int ChucVu, string TuNgayCV, string DenNgayCV)
        {
            DateTime FromDay = DateTime.ParseExact("01-" + TuNgayCV, "dd-MM-yyyy", CultureInfo.InvariantCulture);
            DateTime ToDay = DateTime.ParseExact("01-" + DenNgayCV, "dd-MM-yyyy", CultureInfo.InvariantCulture);
            QtchucVu qtcv = new QtchucVu();
            qtcv.MaNs = IdNS;
            qtcv.MaCv = ChucVu;
            qtcv.TgbatDau = FromDay;
            qtcv.TgketThuc = ToDay;
            context.QtchucVu.Add(qtcv);
            context.SaveChanges();
            return "ok";
        }

        [HttpPost("/addNewRowQTCV")]
        public IActionResult addNewRowQTCV(DateTime tungay, DateTime denngay, string chucvu, int macv, int IDQT)
        {
            ViewBag.tungay = tungay;
            ViewBag.denngay = denngay;
            ViewBag.chucvu = chucvu;
            ViewBag.macv = macv;
            ViewBag.IDQT = IDQT;
            return PartialView();
        }
        [HttpPost("/UpdateQTCV")]
        public string UpdateQTCV(string tungay, string denngay, int chucvu, int IDQT)
        {
            DateTime FromDay = DateTime.ParseExact("01-" + tungay, "dd-MM-yyyy", CultureInfo.InvariantCulture);
            DateTime ToDay = DateTime.ParseExact("01-" + denngay, "dd-MM-yyyy", CultureInfo.InvariantCulture);
            QuanLyNhanVienContext context = new QuanLyNhanVienContext();
            QtchucVu qtcv = context.QtchucVu.Find(IDQT);
            qtcv.TgbatDau = FromDay;
            qtcv.TgketThuc = ToDay;
            qtcv.MaCv = chucvu;
            context.QtchucVu.Update(qtcv);
            context.SaveChanges();
            return "Cập nhập thành công";
        }

        [HttpPost("/XoaQTChucVu")]
        public string XoaQTChucVu(int IDQT)
        {
            QtchucVu qt = context.QtchucVu.FirstOrDefault(x => x.Id == IDQT);
            context.QtchucVu.Remove(qt);
            context.SaveChanges();
            return "Xóa thành công";
        }
        [HttpPost("/insertQTCongTac")]
        public string insertQTCongTac(int IdNS, int PhongBan, string TuNgayCV, string DenNgayCV)
        {
            DateTime FromDay = DateTime.ParseExact("01-" + TuNgayCV, "dd-MM-yyyy", CultureInfo.InvariantCulture);
            DateTime ToDay = DateTime.ParseExact("01-" + DenNgayCV, "dd-MM-yyyy", CultureInfo.InvariantCulture);
            QtcongTac qtct = new QtcongTac();
            qtct.MaNs = IdNS;
            qtct.MaPb = PhongBan;
            qtct.TgbatDau = FromDay;
            qtct.TgketThuc = ToDay;
            context.QtcongTac.Add(qtct);
            context.SaveChanges();
            return "ok";
        }
        [HttpPost("/addNewRowQTCT")]
        public IActionResult addNewRowQTCT(DateTime tungay, DateTime denngay, string phongban, int mapb, int IDQTCT)
        {
            ViewBag.tungay = tungay;
            ViewBag.denngay = denngay;
            ViewBag.phongban = phongban;
            ViewBag.mapb = mapb;
            ViewBag.IDQTCT = IDQTCT;
            return PartialView();
        }
        [HttpPost("/UpdateQTCT")]
        public string UpdateQTCT(string tungay, string denngay, int phongban, int IDQTCT)
        {
            DateTime FromDay = DateTime.ParseExact("01-" + tungay, "dd-MM-yyyy", CultureInfo.InvariantCulture);
            DateTime ToDay = DateTime.ParseExact("01-" + denngay, "dd-MM-yyyy", CultureInfo.InvariantCulture);
            QuanLyNhanVienContext context = new QuanLyNhanVienContext();
            QtcongTac qtct = context.QtcongTac.Find(IDQTCT);
            qtct.TgbatDau = FromDay;
            qtct.TgketThuc = ToDay;
            qtct.MaPb = phongban;
            context.QtcongTac.Update(qtct);
            context.SaveChanges();
            return "Cập nhập thành công";
        }

        [HttpPost("/XoaQTCongTac")]
        public string XoaQTCongTac(int IDQTCT)
        {
            QtcongTac qtct = context.QtcongTac.FirstOrDefault(x => x.Id == IDQTCT);
            context.QtcongTac.Remove(qtct);
            context.SaveChanges();
            return "Xóa thành công";
        }

        [HttpPost("/insertQTLuong")]
        public string insertQTLuong(int IdNS, int MaHSL, int MaMl, string TuNgayQTL, string DenNgayQTL)
        {
            DateTime FromDay = DateTime.ParseExact("01-" + TuNgayQTL, "dd-MM-yyyy", CultureInfo.InvariantCulture);
            DateTime ToDay = DateTime.ParseExact("01-" + DenNgayQTL, "dd-MM-yyyy", CultureInfo.InvariantCulture);
            QuaTrinhLuong qtl = new QuaTrinhLuong();
            qtl.MaNs = IdNS;
            qtl.MaHsl = MaHSL;
            qtl.MaMl = MaMl;
            qtl.TgbatDau = FromDay;
            qtl.TgketThuc = ToDay;
            context.QuaTrinhLuong.Add(qtl);
            context.SaveChanges();
            return "Thêm quá  trình lương thành công";
        }

        [HttpPost("/addNewRowQTL")]
        public IActionResult addNewRowQTL(DateTime tungay, DateTime denngay, float hesoluong, int mahsl, float tienluong, int maml, int IDQTL)
        {
            ViewBag.tungay = tungay;
            ViewBag.denngay = denngay;
            ViewBag.Hesoluong = hesoluong;
            ViewBag.mahsl = mahsl;
            ViewBag.Tienluong = tienluong;
            ViewBag.maml = maml;
            ViewBag.IDQTL = IDQTL;
            return PartialView();
        }
        [HttpPost("/UpdateQTL")]
        public string UpdateQTL(string tungay, string denngay, int mahsl, int maml, int IDQTL)
        {
            DateTime FromDay = DateTime.ParseExact("01-" + tungay, "dd-MM-yyyy", CultureInfo.InvariantCulture);
            DateTime ToDay = DateTime.ParseExact("01-" + denngay, "dd-MM-yyyy", CultureInfo.InvariantCulture);
            QuanLyNhanVienContext context = new QuanLyNhanVienContext();
            QuaTrinhLuong qtl = context.QuaTrinhLuong.Find(IDQTL);
            qtl.TgbatDau = FromDay;
            qtl.TgketThuc = ToDay;
            qtl.MaHsl = mahsl;
            qtl.MaMl = maml;
            context.QuaTrinhLuong.Update(qtl);
            context.SaveChanges();
            return "Cập nhập thành công";
        }

        [HttpPost("/XoaQTLuong")]
        public string XoaQTLuong(int IDQTL)
        {
            QuaTrinhLuong qtl = context.QuaTrinhLuong.FirstOrDefault(x => x.Id == IDQTL);
            context.QuaTrinhLuong.Remove(qtl);
            context.SaveChanges();
            return "Xóa thành công";
        }

        [HttpPost("/insertQTPhuCap")]
        public string insertQTPhuCap(int IdNS, int MaHSPC, int MaMPC, string TuNgayQTPC, string DenNgayQTPC)
        {
            DateTime FromDay = DateTime.ParseExact("01-" + TuNgayQTPC, "dd-MM-yyyy", CultureInfo.InvariantCulture);
            DateTime ToDay = DateTime.ParseExact("01-" + DenNgayQTPC, "dd-MM-yyyy", CultureInfo.InvariantCulture);
            QuaTrinhPhuCap qtpc = new QuaTrinhPhuCap();
            qtpc.MaNs = IdNS;
            qtpc.MaHspc = MaHSPC;
            qtpc.MaPc = MaMPC;
            qtpc.TgbatDau = FromDay;
            qtpc.TgketThuc = ToDay;
            context.QuaTrinhPhuCap.Add(qtpc);
            context.SaveChanges();
            return "Thêm quá  trình lương thành công";
        }

        [HttpPost("/addNewRowQTPC")]
        public IActionResult addNewRowQTPC(DateTime tungay, DateTime denngay, float hesophucap, int mahspc, string khoanphucap, int mampc, int IDQTPC)
        {
            ViewBag.tungay = tungay;
            ViewBag.denngay = denngay;
            ViewBag.Hesophucap = hesophucap;
            ViewBag.mahspc = mahspc;
            ViewBag.KhoanPC = khoanphucap;
            ViewBag.mampc = mampc;
            ViewBag.IDQTPC = IDQTPC;
            return PartialView();
        }
        [HttpPost("/UpdateQTPC")]
        public string UpdateQTPC(string tungay, string denngay, int mahspc, int mampc, int IDQTPC)
        {
            DateTime FromDay = DateTime.ParseExact("01-" + tungay, "dd-MM-yyyy", CultureInfo.InvariantCulture);
            DateTime ToDay = DateTime.ParseExact("01-" + denngay, "dd-MM-yyyy", CultureInfo.InvariantCulture);
            QuanLyNhanVienContext context = new QuanLyNhanVienContext();
            QuaTrinhPhuCap qtpc = context.QuaTrinhPhuCap.Find(IDQTPC);
            qtpc.TgbatDau = FromDay;
            qtpc.TgketThuc = ToDay;
            qtpc.MaHspc = mahspc;
            qtpc.MaPc = mampc;
            context.QuaTrinhPhuCap.Update(qtpc);
            context.SaveChanges();
            return "Cập nhập thành công";
        }

        [HttpPost("/XoaQTPhuCap")]
        public string XoaQTPhuCap(int IDQTPC)
        { 
            QuaTrinhPhuCap qtpc = context.QuaTrinhPhuCap.FirstOrDefault(x => x.Id == IDQTPC);
            context.QuaTrinhPhuCap.Remove(qtpc);
            context.SaveChanges();
            return "Xóa thành công";
        }
        [HttpPost("/addQTDCL")]
        public string addQTDCL(string TuNgay, string DenNgay, int MAML)
        {
            QuanLyNhanVienContext context = new QuanLyNhanVienContext();

            DateTime tungay = DateTime.ParseExact("01-" + TuNgay, "dd-MM-yyyy", CultureInfo.InvariantCulture);
            DateTime denngay = DateTime.ParseExact("01-" + DenNgay, "dd-MM-yyyy", CultureInfo.InvariantCulture);
            List<NhanSu> ns = context.NhanSu.ToList();
            foreach (var n in ns)
            {
                QuaTrinhLuong qtl = new QuaTrinhLuong();
                var kt = context.QuaTrinhLuong.Where(x => x.MaNs == n.Id).OrderByDescending(x => x.TgketThuc).FirstOrDefault();

                DateTime newTgketThuc = tungay.AddMonths(-1);

                QuaTrinhLuong qtl1 = context.QuaTrinhLuong.Find(kt.Id);
                qtl1.TgketThuc = newTgketThuc;
                context.QuaTrinhLuong.Update(qtl1);
                context.SaveChanges();
                qtl.MaNs = n.Id;
                qtl.MaHsl = kt.MaHsl;
                qtl.MaMl = MAML;
                qtl.TgbatDau = tungay;
                qtl.TgketThuc = denngay;
                context.QuaTrinhLuong.Add(qtl);
                context.SaveChanges();

            }
            return "thêm thành công";
        }
    }
}
