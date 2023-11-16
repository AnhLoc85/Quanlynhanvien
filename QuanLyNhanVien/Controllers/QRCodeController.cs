
using Microsoft.AspNetCore.Mvc;
using System.Drawing;
using QRCoder;
using System;
using System.Collections.Generic;
using System.IO;
namespace QuanLyNhanVien.Controllers
{
    public class QRCodeController : Controller
    {
        public IActionResult QRCode()
    {
        return View();
    }
      [HttpPost]
public IActionResult GenerateQRCode(string qrText)
{
    QRCodeGenerator qrGenerator = new QRCodeGenerator();
    QRCodeData qrCodeData = qrGenerator.CreateQrCode(qrText, QRCodeGenerator.ECCLevel.Q);
    QRCode qrCode = new QRCode(qrCodeData);
    Bitmap qrCodeImage = qrCode.GetGraphic(20);

    // Convert image to base64
    string base64Image = Convert.ToBase64String(BitmapToBytes(qrCodeImage));

    // Return base64 string to JavaScript
    return Content(base64Image);
}

private static byte[] BitmapToBytes(Bitmap img)
{
    using (MemoryStream stream = new MemoryStream())
    {
        img.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
        return stream.ToArray();
    }
}

    }
}