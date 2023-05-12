using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuanLyNhanVien.Controllers
{
    public class ChotPhuCapController : Controller
    {
        public IActionResult ChotPhuCap()
        {
            return View();
        }
    }
}
