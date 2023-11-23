using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using QuanLyNhanVien.Models;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace QuanLyNhanVien.Controllers
{
    public class ChamCongController : Controller
    {
        QuanLyNhanVienContext context = new QuanLyNhanVienContext();
        public IActionResult ChamCong()
        {
          ViewBag.ChamCongSang = context.ChamCong.Include(x => x.MaNsNavigation).Where(cc => cc.GioVaoSang != null).ToList();
          ViewBag.ChamCongChieu = context.ChamCong.Include(x => x.MaNsNavigation).Where(cc => cc.GioVaoChieu != null).ToList();
          ViewBag.ChamCongToi = context.ChamCong.Include(x => x.MaNsNavigation).Where(cc => cc.GioVaoToi != null).ToList();
           
            return View();
        }
        public IActionResult QuetQRChamCong(string maDD)
        {
            var idNs = context.NhanSu.FirstOrDefault(x => x.MaNs == maDD)?.Id;
            var LichLV = context.LichLamViec;
            var phanTuCanSoSanh = LichLV.FirstOrDefault();
            var chamcong = context.ChamCong.Include(x=> x.MaNsNavigation).Where(x => x.Ngay == DateTime.Today).ToList();
            var chamcongChoMaNs = chamcong.FirstOrDefault(x => x.MaNs == idNs);
            var tg = DateTime.Now.TimeOfDay;
            ChamCong model = new ChamCong();
            if(idNs > 0){
                if (phanTuCanSoSanh != null)
                {
                    // Xử lý cho giờ vào sáng
                    if (tg > phanTuCanSoSanh.Vaosang?.Subtract(TimeSpan.FromHours(1)) &&
                        tg < phanTuCanSoSanh.Vaosang?.Add(TimeSpan.FromHours(1)))
                    {
                        if (chamcongChoMaNs != null)
                        {
                            if(chamcongChoMaNs.GioVaoSang == null){
                                chamcongChoMaNs.Ngay = DateTime.Today;
                                chamcongChoMaNs.GioVaoSang = tg;
                                chamcongChoMaNs.MaNs = idNs;
                                context.ChamCong.Update(chamcongChoMaNs);
                                context.SaveChanges();
                                model = chamcongChoMaNs;
                            }
                            else{
                                return Ok();
                            }
                        }
                        else
                        {
                        model = new ChamCong
                            {
                                Ngay = DateTime.Today,
                                GioVaoSang = tg,
                                MaNs = idNs,
                                // Gán các giá trị khác nếu cần thiết
                            };

                            context.ChamCong.Add(model);
                            context.SaveChanges();
                        }
                    }
                    // Xử lý cho giờ ra sáng
                    if (tg > phanTuCanSoSanh.Rasang?.Subtract(TimeSpan.FromHours(1)) &&
                        tg < phanTuCanSoSanh.Rasang?.Add(TimeSpan.FromHours(1)))
                    {
                    if (chamcongChoMaNs != null && chamcongChoMaNs.GioRaSang == null)
                        {
                            model = new ChamCong
                            {
                                Ngay = DateTime.Today,
                                GioRaSang = tg,
                                MaNs = idNs,
                                // Gán các giá trị khác nếu cần thiết
                            };
                            context.ChamCong.Add(model);
                            context.SaveChanges();
                        }
                        else
                        {
                            model = new ChamCong
                            {
                                Ngay = DateTime.Today,
                                GioRaSang = tg,
                                MaNs = idNs,
                                // Gán các giá trị khác nếu cần thiết
                            };

                            context.ChamCong.Add(model);
                            context.SaveChanges();
                        }
                    }

                    // Xử lý cho giờ vào chiều
                    if (tg > phanTuCanSoSanh.Vaochieu?.Subtract(TimeSpan.FromHours(1)) &&
                        tg < phanTuCanSoSanh.Vaochieu?.Add(TimeSpan.FromHours(1)))
                    {
                        // Xử lý tương tự như trên cho giờ vào chiều
                    }

                    // Xử lý cho giờ ra chiều
                    if (tg > phanTuCanSoSanh.Rachieu?.Subtract(TimeSpan.FromHours(1)) &&
                        tg < phanTuCanSoSanh.Rachieu?.Add(TimeSpan.FromHours(1)))
                    {
                        // Xử lý tương tự như trên cho giờ ra chiều
                    }

                    // Xử lý cho giờ vào tối
                    if (tg > phanTuCanSoSanh.Vaotoi?.Subtract(TimeSpan.FromHours(1)) &&
                        tg < phanTuCanSoSanh.Vaotoi?.Add(TimeSpan.FromHours(1)))
                    {
                        // Xử lý tương tự như trên cho giờ vào tối
                    }

                    // Xử lý cho giờ ra tối
                    if (tg > phanTuCanSoSanh.Ratoi?.Subtract(TimeSpan.FromHours(1)) &&
                        tg < phanTuCanSoSanh.Ratoi?.Add(TimeSpan.FromHours(1)))
                    {
                        // Xử lý tương tự như trên cho giờ ra tối
                    }
                }
            }
           // model.GioRaSang = null;
           return Ok(model); // Trả về trang lỗi hoặc xử lý khác nếu không thỏa mãn điều kiện
        }

    }
}
