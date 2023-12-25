using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using QuanLyNhanVien.Models;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Net.Http;
using System.Runtime.InteropServices;
using DocumentFormat.OpenXml.EMMA;
using System.Globalization;

namespace QuanLyNhanVien.Controllers
{
    public class ChamCongController : Controller
    {
        QuanLyNhanVienContext context = new QuanLyNhanVienContext();
        public IActionResult ChamCong()
        {
          ViewBag.ChamCongSang = context.ChamCong.Include(x => x.MaNsNavigation).Where(cc => cc.GioVaoSang != null && cc.Ngay == DateTime.Today).ToList();
          ViewBag.ChamCongChieu = context.ChamCong.Include(x => x.MaNsNavigation).Where(cc => cc.GioVaoChieu != null && cc.Ngay == DateTime.Today).ToList();
          ViewBag.ChamCongToi = context.ChamCong.Include(x => x.MaNsNavigation).Where(cc => cc.GioVaoToi != null && cc.Ngay == DateTime.Today).ToList();
           
            return View();
        }
        public dynamic QuetQRChamCong(string maDD)
        {   
            var message = "";
            var idNs = context.NhanSu.FirstOrDefault(x => x.MaNs == maDD)?.Id;
            var lichLamViec = context.LichLamViec.FirstOrDefault();
            var chamcong = context.ChamCong.Include(x=> x.MaNsNavigation).Where(x => x.Ngay == DateTime.Today).ToList();
            var chamcongChoMaNs = chamcong.FirstOrDefault(x => x.MaNs == idNs);
            var tg = DateTime.Now.TimeOfDay;
            var thu = DateTime.Now.DayOfWeek.ToString();
            if (thu == "Sunday")
                {
                    thu = "0"; // hoặc bất kỳ giá trị nào bạn muốn gán cho Chủ nhật
                }
            ChamCong model = new ChamCong();
            if(idNs != null){
                  CapNhapNgayCong( (int)idNs, DateTime.Now);

                if (lichLamViec != null)
                {
                    // Xử lý cho giờ vào sáng
                    if (tg > lichLamViec.Vaosang?.Subtract(TimeSpan.FromHours(1)) &&
                        tg < lichLamViec.Vaosang?.Add(TimeSpan.FromHours(1)))
                    {
                        if (chamcongChoMaNs != null)
                        {
                            if(chamcongChoMaNs.GioVaoSang == null){
                                chamcongChoMaNs.GioVaoSang = tg;
                                context.ChamCong.Update(chamcongChoMaNs);
                                context.SaveChanges();
                                model = chamcongChoMaNs;
                            }
                            else{
                                 return new
                                    {
                                        statusCode = 500,
                                        message = "Đã chấm công trong khoảng thời gian này!",
                                    };
                            }
                        }
                        else
                        {
                        model = new ChamCong
                            {
                                Ngay = DateTime.Today,
                                GioVaoSang = tg,
                                MaNs = idNs,
                                Thu = thu,
                                // Gán các giá trị khác nếu cần thiết
                            };

                            context.ChamCong.Add(model);
                            context.SaveChanges();
                        }
                    }
                    // Xử lý cho giờ ra sáng
                    if (tg > lichLamViec.Rasang?.Subtract(TimeSpan.FromHours(1)) &&
                        tg < lichLamViec.Rasang?.Add(TimeSpan.FromHours(1)))
                    {
                        if (chamcongChoMaNs != null)
                        {
                            if(chamcongChoMaNs.GioRaSang == null){
                                chamcongChoMaNs.GioRaSang = tg;
                                context.ChamCong.Update(chamcongChoMaNs);
                                context.SaveChanges();
                                model = chamcongChoMaNs;
                            }
                            else{
                                return new
                                    {
                                        statusCode = 500,
                                        message = "Đã chấm công trong khoảng thời gian này!",
                                    };
                            }
                            
                        }else{
                                 return new
                                    {
                                        statusCode = 500,
                                        message = "Bạn đã không chấm công vào buổi sáng!",
                                    };
                            }
                    }

                    // Xử lý cho giờ vào chiều
                    if (tg > lichLamViec.Vaochieu?.Subtract(TimeSpan.FromHours(1)) &&
                        tg < lichLamViec.Vaochieu?.Add(TimeSpan.FromHours(1)))
                    {
                        if (chamcongChoMaNs != null)
                        {
                            if(chamcongChoMaNs.GioVaoChieu == null){
                                chamcongChoMaNs.GioVaoChieu = tg;
                                context.ChamCong.Update(chamcongChoMaNs);
                                context.SaveChanges();
                                model = chamcongChoMaNs;
                            }
                            else{
                                 return new
                                    {
                                        statusCode = 500,
                                        message = "Đã chấm công trong khoảng thời gian này!",
                                    };
                            }
                        }
                        else
                        {
                        model = new ChamCong
                            {
                                Ngay = DateTime.Today,
                                GioVaoChieu = tg,
                                MaNs = idNs,
                                Thu = thu,
                                // Gán các giá trị khác nếu cần thiết
                            };

                            context.ChamCong.Add(model);
                            context.SaveChanges();
                        }
                    }

                    // Xử lý cho giờ ra chiều
                    if (tg > lichLamViec.Rachieu?.Subtract(TimeSpan.FromHours(1)) &&
                        tg < lichLamViec.Rachieu?.Add(TimeSpan.FromHours(1)))
                    {
                        if (chamcongChoMaNs != null)
                        {
                           
                            if(chamcongChoMaNs.GioRaChieu == null){
                                chamcongChoMaNs.GioRaChieu = tg;
                                context.ChamCong.Update(chamcongChoMaNs);
                                context.SaveChanges();
                                model = chamcongChoMaNs;
                            }
                            else{
                                return new
                                    {
                                        statusCode = 500,
                                        message = "Đã chấm công trong khoảng thời gian này!",
                                    };
                            }
                        }else{
                                return new
                                {
                                    statusCode = 500,
                                    message = "Bạn đã không chấm công vào buổi chiều!",
                                };
                        }
                    }

                    // Xử lý cho giờ vào tối
                    if (tg > lichLamViec.Vaotoi?.Subtract(TimeSpan.FromHours(1)) &&
                        tg < lichLamViec.Vaotoi?.Add(TimeSpan.FromHours(1)))
                    {
                        if (chamcongChoMaNs != null)
                        {
                            if(chamcongChoMaNs.GioVaoToi == null){
                                chamcongChoMaNs.GioVaoToi = tg;
                                context.ChamCong.Update(chamcongChoMaNs);
                                context.SaveChanges();
                                model = chamcongChoMaNs;
                            }
                            else{
                                 return new
                                    {
                                        statusCode = 500,
                                        message = "Đã chấm công trong khoảng thời gian này!",
                                    };
                            }
                        }
                        else
                        {
                        model = new ChamCong
                            {
                                Ngay = DateTime.Today,
                                GioVaoToi = tg,
                                MaNs = idNs,
                                Thu = thu,
                                // Gán các giá trị khác nếu cần thiết
                            };

                            context.ChamCong.Add(model);
                            context.SaveChanges();
                        }
                    }

                    // Xử lý cho giờ ra tối
                    if (tg > lichLamViec.Ratoi?.Subtract(TimeSpan.FromHours(1)) &&
                        tg < lichLamViec.Ratoi?.Add(TimeSpan.FromHours(1)))
                    {
                        if (chamcongChoMaNs != null)
                        {
                            if(chamcongChoMaNs.GioRaToi == null){
                                chamcongChoMaNs.GioRaToi = tg;
                                context.ChamCong.Update(chamcongChoMaNs);
                                context.SaveChanges();
                                model = chamcongChoMaNs;
                            }
                            else{
                                return new
                                    {
                                        statusCode = 500,
                                        message = "Đã chấm công trong khoảng thời gian này!",
                                    };
                            }
                            
                        }else{
                            return new
                            {
                                statusCode = 500,
                                message = "Bạn đã không chấm công vào buổi tối!",
                            };
                        }
                    }
                }
                if(model.Id != 0){
                    return new
                    {
                        statusCode = 200,
                        message = "Điểm danh thành công",
                        model1 = model
                    };
                }else{
                    return new
                    {
                        statusCode = 500,
                        message = "Không trong thời gian điểm danh hoặc đã điểm danh",
                        model1 = model
                    };
                }
              
            }
           return Ok();
        }
        public void CapNhapNgayCong(int IdNS, DateTime Ngay){
          ChamCong chamCongs = context.ChamCong.FirstOrDefault(x => x.MaNs == IdNS && x.Ngay == Ngay);
          if(chamCongs != null){
          LichLamViec lichLamViec = context.LichLamViec.FirstOrDefault();
          double thoigiantre = 15;
          double ngayCongMoi = 0 ;
          double ngayCong = 1;
          
          if(chamCongs.GioVaoSang == null || chamCongs.GioVaoChieu == null || chamCongs.GioRaSang == null || chamCongs.GioRaChieu == null)
          {

            chamCongs.SoCong = 0;
          }
          else
          {
          // vào sáng
          if(chamCongs.GioVaoSang < ThoiGianTre(lichLamViec.Vaosang, thoigiantre, true)){
                ngayCongMoi = 1 ;
          }
          else{
                ngayCongMoi = 0.5;
          }
          ngayCong = XuLyNgayCong(ngayCong, ngayCongMoi);
          // ra sáng
        if(chamCongs.GioRaSang > ThoiGianTre(lichLamViec.Rasang, thoigiantre, false)){
                ngayCongMoi = 1 ;
          }
          else{
                ngayCongMoi = 0.5;
          }
         ngayCong = XuLyNgayCong(ngayCong, ngayCongMoi);
          // vào chiều
          if(chamCongs.GioVaoChieu < ThoiGianTre(lichLamViec.Vaochieu, thoigiantre,true)){
                ngayCongMoi = 1 ;
          }

          else{
                ngayCongMoi = 0.5;
          }
         ngayCong = XuLyNgayCong(ngayCong, ngayCongMoi);
          // ra chiều
        if(chamCongs.GioRaChieu > ThoiGianTre(lichLamViec.Rachieu, thoigiantre,false)){
                 ngayCongMoi = 1 ;
          }

          else{
                ngayCongMoi = 0.5;
          }
         ngayCong = XuLyNgayCong(ngayCong, ngayCongMoi);
         chamCongs.SoCong = ngayCong;
          }



          // tối
          if(chamCongs.GioVaoToi== null || chamCongs.GioRaToi == null){
                chamCongs.SoGio = 0 ;
          }else{
          double soGioMoi = 0 ;
          double soGio = 2;
            // vào tối
          if(chamCongs.GioVaoToi < ThoiGianTre(lichLamViec.Vaotoi, thoigiantre, true)){
                soGioMoi = 2 ;
          }
          else{
                soGioMoi = 1;
          }
          soGio = XuLyNgayCong(soGio, soGioMoi);
          // ra tối
         if(chamCongs.GioRaToi > ThoiGianTre(lichLamViec.Ratoi, thoigiantre, false)){
                soGioMoi = 2 ;
          }
          else{
                soGioMoi = 1;
          }
         soGio = XuLyNgayCong(soGio, soGioMoi);
         chamCongs.SoGio = soGio;
          }
         context.ChamCong.Update(chamCongs);
         context.SaveChanges();
          }

        }
        public TimeSpan ThoiGianTre(TimeSpan? thoiGian, double thoigiantre, bool vao){
          TimeSpan tgTre = TimeSpan.FromMinutes(thoigiantre);
          TimeSpan timeSpan = (TimeSpan)thoiGian;
          if(vao == true){
          TimeSpan thoiGianSauKhiThem = timeSpan.Add(tgTre);
                return thoiGianSauKhiThem;
          }else{
          TimeSpan thoiGianSauKhiThem = timeSpan.Subtract(tgTre);
                return thoiGianSauKhiThem;
          }

        }
        public double XuLyNgayCong(double NgayCongCu, double NgayCongMoi){
            double ketqua = NgayCongCu ;

            if(NgayCongMoi < NgayCongCu){
                return ketqua = NgayCongMoi;
            }
            if(NgayCongCu <1 && NgayCongMoi < 1 ){
                return ketqua = 0;
            }
            return ketqua;
        }
         public IActionResult TimKiemChamCong(string Ngay, string MaNS)
        {
            DateTime date = DateTime.ParseExact(Ngay, "dd-MM-yyyy", CultureInfo.InvariantCulture);
            var model = context.ChamCong.Include(x => x.MaNsNavigation)
            .Where(x => x.Ngay == date &&  
                    ( MaNS == null|| x.MaNsNavigation.MaNs == MaNS)).ToList();
            return Ok(model);
        }
    }
}
