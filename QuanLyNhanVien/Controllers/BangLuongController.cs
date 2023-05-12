using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
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
    }
}
