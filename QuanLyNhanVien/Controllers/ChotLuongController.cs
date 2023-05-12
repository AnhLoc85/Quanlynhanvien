using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuanLyNhanVien.Controllers
{
    public class ChotLuongController : Controller
    {
        public IActionResult ChotLuong()
        {
            return View();
        }
    }
}
