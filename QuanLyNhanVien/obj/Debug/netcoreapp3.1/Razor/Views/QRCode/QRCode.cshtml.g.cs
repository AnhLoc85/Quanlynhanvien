#pragma checksum "F:\Project\QuanLyNhanVien\QuanLyNhanVien\Views\QRCode\QRCode.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aa97cbe13734f1d82852447a89a911222437a00b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_QRCode_QRCode), @"mvc.1.0.view", @"/Views/QRCode/QRCode.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "F:\Project\QuanLyNhanVien\QuanLyNhanVien\Views\_ViewImports.cshtml"
using QuanLyNhanVien;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\Project\QuanLyNhanVien\QuanLyNhanVien\Views\_ViewImports.cshtml"
using QuanLyNhanVien.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\Project\QuanLyNhanVien\QuanLyNhanVien\Views\QRCode\QRCode.cshtml"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aa97cbe13734f1d82852447a89a911222437a00b", @"/Views/QRCode/QRCode.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"67e1190d3cab8feac284413eaebceed1c61e9b8b", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_QRCode_QRCode : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "F:\Project\QuanLyNhanVien\QuanLyNhanVien\Views\QRCode\QRCode.cshtml"
  
     int idnv = int.Parse(User.FindFirstValue(ClaimTypes.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container-xxl flex-grow-1 container-p-y\">\r\n    <h2>QR Code Generated</h2>\r\n    <div id=\"qrCodeContainer\" >\r\n        <img id=\"qrCodeImage\" alt=\"QR Code\" />\r\n    </div>\r\n \r\n</div>\r\n\r\n <script>\r\nvar idnv = ");
#nullable restore
#line 16 "F:\Project\QuanLyNhanVien\QuanLyNhanVien\Views\QRCode\QRCode.cshtml"
      Write(Html.Raw(Json.Serialize(idnv)));

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n\r\ndocument.addEventListener(\"DOMContentLoaded\", function () {\r\n    generateQRCode();\r\n");
            WriteLiteral(@"});
    function generateQRCode() {
    var currentDate = new Date(); // Lấy ngày giờ hiện tại
    // Lấy các giá trị riêng lẻ của ngày, tháng, năm, giờ, phút
    var day = String(currentDate.getDate()).padStart(2, '0'); // Lấy ngày (có thêm số 0 nếu cần thiết)
    var month = String(currentDate.getMonth() + 1).padStart(2, '0'); // Lấy tháng (có thêm số 0 nếu cần thiết)
    var year = currentDate.getFullYear(); // Lấy năm
    var hours = String(currentDate.getHours()).padStart(2, '0'); // Lấy giờ (có thêm số 0 nếu cần thiết)
    var minutes = String(currentDate.getMinutes()).padStart(2, '0'); // Lấy phút (có thêm số 0 nếu cần thiết)
    var qrText = idnv;// + ""_"" + day + month + year + hours + minutes;
        $.ajax({
            type: ""POST"",
            url: ""/QRCode/GenerateQRCode"",
            data: { qrText: qrText },
            success: function (base64Image) {
                // Hiển thị QR code
                $(""#qrCodeContainer"").html('<img src=""data:image/png;base64,' + base64Imag");
            WriteLiteral("e + \'\" alt=\"QR Code\">\');\r\n            }\r\n        });\r\n    }\r\n    </script>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
