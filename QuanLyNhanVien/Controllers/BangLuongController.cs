using ClosedXML.Excel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using QuanLyNhanVien.Models;
using SelectPdf;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace QuanLyNhanVien.Controllers
{
    public class BangLuongController : Controller
    {
        public IActionResult BangLuong()
        {
            return View();
        }
        public IActionResult BangLuongPDF()
        {

            return View();
        }
        [HttpPost("/loadBangLuong")]
        public IActionResult loadBangLuong(string Ngay)
        {
            DateTime date = DateTime.ParseExact("01-" + Ngay, "dd-MM-yyyy", CultureInfo.InvariantCulture);

            QuanLyNhanVienContext context = new QuanLyNhanVienContext();
            List<NhanSu> nhanSuList = context.NhanSu
                .Include(x => x.LuongCoBan)
                .Include(x => x.PhuCapNhanSu)
                .Where(x => x.PhuCapNhanSu.Any(lcb => lcb.ThoiGian == date))
                .Where(x => x.LuongCoBan.Any(lcb => lcb.ThoiGian == date))
                .ToList();

            ViewBag.NS = nhanSuList;
            ViewBag.Ngay = date;
            return PartialView();
        }
        public double CalculateTotalLuongNS(int? id, DateTime? ngay)
        {
            QuanLyNhanVienContext context = new QuanLyNhanVienContext();

            double totalLuongNS = (double)context.PhuCapNhanSu
                .Where(x => x.MaNs == id && x.ThoiGian == ngay)
                .Sum(x => x.TienPc);

            return totalLuongNS;
        }

    
      

        [HttpPost("/BangLuongPDF")]
        public IActionResult downloadBaoCaoPhieuNhap(string ngayluong)
        {
            var fullView = new HtmlToPdf();
            fullView.Options.WebPageWidth = 1280;
            fullView.Options.PdfPageSize = PdfPageSize.A4;
            fullView.Options.MarginTop = 20;
            fullView.Options.MarginBottom = 20;
            fullView.Options.PdfPageOrientation = PdfPageOrientation.Portrait;

            var url = Url.Action("viewBangLuongPDF", "BangLuong", new { ngayluong=ngayluong});

            var currentUrl = $"{HttpContext.Request.Scheme}://{HttpContext.Request.Host}" + url;

            var pdf = fullView.ConvertUrl(currentUrl);

            var pdfBytes = pdf.Save();
            return File(pdfBytes, "application/pdf", "BangLuong.pdf");
        }
        public IActionResult viewBangLuongPDF(string ngayluong)
        {
            DateTime date = DateTime.ParseExact("01-" + ngayluong, "dd-MM-yyyy", CultureInfo.InvariantCulture);

            QuanLyNhanVienContext context = new QuanLyNhanVienContext();
            List<NhanSu> nhanSuList = context.NhanSu
                .Include(x => x.LuongCoBan)
                .Include(x => x.PhuCapNhanSu)
                .Where(x => x.PhuCapNhanSu.Any(lcb => lcb.ThoiGian == date))
                .Where(x => x.LuongCoBan.Any(lcb => lcb.ThoiGian == date))
                .ToList();

            ViewBag.NS = nhanSuList;
            ViewBag.Ngay = date;
            return View("BangLuongPDF");
        }
        public ActionResult ExportToExcel(string ngayluong)
        {

            DateTime date = DateTime.ParseExact("01-" + ngayluong, "dd-MM-yyyy", CultureInfo.InvariantCulture);

            QuanLyNhanVienContext context = new QuanLyNhanVienContext();
            List<NhanSu> nhanSuList = context.NhanSu
                .Include(x => x.LuongCoBan)
                .Include(x => x.PhuCapNhanSu)
                .Include(x => x.QuaTrinhThuongPc)
                .Include(x => x.QuaTrinhPhat)
                .AsEnumerable()
                .Where(x => x.PhuCapNhanSu.Any(lcb => lcb.ThoiGian == date))
                .Where(x => x.LuongCoBan.Any(lcb => lcb.ThoiGian == date))
                .ToList();

            ViewBag.NS = nhanSuList;
            ViewBag.Ngay = date;
            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("Bảng lương");
                var currentRow = 1;
                worksheet.Range(currentRow, 1, currentRow, 11).Merge();

                
                var titleCell = worksheet.Cell(currentRow, 1);
                titleCell.Value = "BẢNG TÍNH - THANH TOÁN TIỀN LƯƠNG";
                titleCell.Style.Font.Bold = true;
                titleCell.Style.Font.FontName = "Times New Roman";
                titleCell.Style.Font.FontSize = 20;
                titleCell.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                currentRow += 2;
                worksheet.Range(currentRow, 1, currentRow, 11).Merge();
                var ngay = worksheet.Cell(currentRow, 1);
                ngay.Value = "Tháng:" + date.Month + "   Năm: " + date.Year;
                ngay.Style.Font.FontSize = 12;
                ngay.Style.Font.FontName = "Times New Roman";
                ngay.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Right;
                currentRow += 2;
                var stt = 1;
                worksheet.Cell(currentRow, 1).Value = "STT";
                worksheet.Cell(currentRow, 2).Value = "Mã NS";
                worksheet.Cell(currentRow, 3).Value = "Tên NS";
                worksheet.Cell(currentRow, 4).Value = "Lương cơ bản";
                worksheet.Cell(currentRow, 5).Value = "Phụ cấp theo % lương";
                worksheet.Cell(currentRow, 6).Value = "Thưởng, phụ cấp khác";
                worksheet.Cell(currentRow, 7).Value = "Phạt, trừ lương";
                worksheet.Cell(currentRow, 8).Value = "BHYT";
                worksheet.Cell(currentRow, 9).Value = "Tổng lương";
                worksheet.Cell(currentRow, 10).Value = "BHXH";
                worksheet.Cell(currentRow, 11).Value = "Thực nhận";
                foreach (var nv in nhanSuList)
                {
                    currentRow++;
                    decimal tongluong = ((decimal)(nv.LuongCoBan.Where(x => x.ThoiGian == date).Select(x => x.LuongNs).FirstOrDefault()
                        + (decimal)nv.PhuCapNhanSu.Where(x => x.ThoiGian == date).Sum(x => x.TienPc)
                        + nv.QuaTrinhThuongPc.Where(x => x.Tgthuong == date).Sum(x => x.TienThuong)
                        - nv.QuaTrinhPhat.Where(x => x.Tgphat == date).Sum(x => x.TienPhat)));
                    worksheet.Cell(currentRow, 1).Value = stt;
                    worksheet.Cell(currentRow, 2).Value = nv.MaNs;
                    worksheet.Cell(currentRow, 3).Value = nv.TenNs;
                    worksheet.Cell(currentRow, 4).Value = nv.LuongCoBan.Where(x => x.ThoiGian == date).Select(x => x.LuongNs).FirstOrDefault();
                    worksheet.Cell(currentRow, 5).Value = nv.PhuCapNhanSu.Where(x=> x.ThoiGian == date).Sum(x => x.TienPc);
                    worksheet.Cell(currentRow, 6).Value = nv.QuaTrinhThuongPc.Where(x => x.Tgthuong == date).Sum(x => x.TienThuong);
                    worksheet.Cell(currentRow, 7).Value = nv.QuaTrinhPhat.Where(x => x.Tgphat == date).Sum(x => x.TienPhat);
                    worksheet.Cell(currentRow, 8).Value = nv.LuongCoBan.Where(x => x.ThoiGian == date).Select(x => x.LuongNs).FirstOrDefault();
                    worksheet.Cell(currentRow, 9).Value = tongluong;
                    worksheet.Cell(currentRow, 10).Value = nv.LuongCoBan.Select(x => x.LuongNs).FirstOrDefault();
                    worksheet.Cell(currentRow, 11).Value = nv.LuongCoBan.Select(x => x.LuongNs).FirstOrDefault();

                    stt++;
                }
                worksheet.Range(worksheet.Cell(4, 4), worksheet.Cell(currentRow, 4)).Style.NumberFormat.Format = "0,00";
                worksheet.Range(worksheet.Cell(4, 5), worksheet.Cell(currentRow, 5)).Style.NumberFormat.Format = "0,00";
                worksheet.Range(worksheet.Cell(4, 6), worksheet.Cell(currentRow, 6)).Style.NumberFormat.Format = "0,00";
                worksheet.Range(worksheet.Cell(4, 7), worksheet.Cell(currentRow, 7)).Style.NumberFormat.Format = "0,00";
                worksheet.Range(worksheet.Cell(4, 8), worksheet.Cell(currentRow, 8)).Style.NumberFormat.Format = "0,00";
                worksheet.Range(worksheet.Cell(4, 9), worksheet.Cell(currentRow, 9)).Style.NumberFormat.Format = "0,00";
                worksheet.Range(worksheet.Cell(4, 10), worksheet.Cell(currentRow, 10)).Style.NumberFormat.Format = "0,00";
                worksheet.Range(worksheet.Cell(4, 11), worksheet.Cell(currentRow, 11)).Style.NumberFormat.Format = "0,00";
                
                using (var stream = new MemoryStream())
                {
                    worksheet.Columns().AdjustToContents();
                    workbook.SaveAs(stream);
                    var content = stream.ToArray();
                    return File(content, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "Bangluong.xlsx");
                }
            }
        }

        }
    }