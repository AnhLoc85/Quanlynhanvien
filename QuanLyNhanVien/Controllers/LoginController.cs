using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;
using System;
using QuanLyNhanVien.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using System.Collections.Generic;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;

namespace QuanLyNhanVien.Controllers
{
    [AllowAnonymous]

    public class LoginController : Controller
    {
        QuanLyNhanVienContext context = new QuanLyNhanVienContext();
        private readonly ILogger<LoginController> _logger;

        public LoginController(ILogger<LoginController> logger)
        {
            _logger = logger;
        }
        [HttpGet]
        [Route("/login")]
        public IActionResult Index(string returnUrl)
        {
            if (HttpContext.User.Identity.Name == null)
                return View("Login");
            else
            {
                if (string.IsNullOrWhiteSpace(returnUrl) || !returnUrl.StartsWith("/"))
                {
                    returnUrl = "/";
                }
                return Redirect(returnUrl);
            }
        }
        [HttpPost]
        [Route("/login")]
        public async Task<IActionResult> LoginUser(TaiKhoan taiKhoan, string returnUrl)
        {
            TaiKhoan a = context.TaiKhoan
                .FirstOrDefault(x => x.TaiKhoan1 == taiKhoan.TaiKhoan1);


            if (a == null)
            {
                return Redirect("/login");
            }
            if (a.MatKhau.Equals(taiKhoan.MatKhau))
            {
                await SignInUser(a);

                if (string.IsNullOrWhiteSpace(returnUrl) || !returnUrl.StartsWith("/"))
                {
                    returnUrl = "/";
                }
                return Redirect(returnUrl);
            }
            else
            {
                TempData["LoginFailed"] = true;
                return RedirectToAction("Index");
            }
        }
        [HttpGet]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Index");
        }
        private async Task SignInUser(TaiKhoan accounts)
        {
            TaiKhoan user = context.TaiKhoan.Where(x => x.MaTk == accounts.MaTk).FirstOrDefault();

            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, user.MaNs.ToString()),
                new Claim(ClaimTypes.Role, accounts.MaQuyen.ToString()),
            };

            var claimsIdentity = new ClaimsIdentity(
                claims, CookieAuthenticationDefaults.AuthenticationScheme);

            await HttpContext.SignInAsync(
                CookieAuthenticationDefaults.AuthenticationScheme,
                new ClaimsPrincipal(claimsIdentity));
        }

        public IActionResult test()
        {
            return View();
        }

    }
}
