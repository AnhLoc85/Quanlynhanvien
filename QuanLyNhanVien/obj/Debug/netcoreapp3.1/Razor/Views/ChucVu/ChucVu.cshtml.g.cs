#pragma checksum "F:\Project\QuanLyNhanVien\QuanLyNhanVien\Views\ChucVu\ChucVu.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fd43b30714b28aa242fcacbd7c200be358e6eb04"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ChucVu_ChucVu), @"mvc.1.0.view", @"/Views/ChucVu/ChucVu.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fd43b30714b28aa242fcacbd7c200be358e6eb04", @"/Views/ChucVu/ChucVu.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"67e1190d3cab8feac284413eaebceed1c61e9b8b", @"/Views/_ViewImports.cshtml")]
    public class Views_ChucVu_ChucVu : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "F:\Project\QuanLyNhanVien\QuanLyNhanVien\Views\ChucVu\ChucVu.cshtml"
  
    QuanLyNhanVienContext context = new QuanLyNhanVienContext();
    List<ChucVu> getListChucVu()
    {
        return context.ChucVu.ToList();
    }
    string formatDay(DateTime? date)
    {
        if (date != null)
        {
            return date.Value.ToString("dd/MM/yyyy");
        }
        else
        {
            return null;
        }
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "F:\Project\QuanLyNhanVien\QuanLyNhanVien\Views\ChucVu\ChucVu.cshtml"
 if (TempData["ThongBao"] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <script type=\"text/javascript\" charset=\"utf-8\">\r\n                        window.onload = function () {\r\n                            alert(\"");
#nullable restore
#line 24 "F:\Project\QuanLyNhanVien\QuanLyNhanVien\Views\ChucVu\ChucVu.cshtml"
                              Write(Html.Raw(@TempData["ThongBao"]));

#line default
#line hidden
#nullable disable
            WriteLiteral("\");\r\n                    };\r\n    </script>\r\n");
#nullable restore
#line 27 "F:\Project\QuanLyNhanVien\QuanLyNhanVien\Views\ChucVu\ChucVu.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container-xxl flex-grow-1 container-p-y"">
    <div class=""row"">
        <div class=""card"">
            <div class=""card-body"">
                <div class=""position-absolute"" style=""margin-top: -10px"">
                    <div class=""col-lg-2 col-sm-2"" style=""width: auto"">
                        <a href=""/ChucVu/ThemChucVu"" class=""btn btn-primary"">
                            <span>Thêm Mới</span>
                        </a>
                    </div>
                </div>
                <table id=""example""
                       class=""display table table-bordered""
                       style=""width: 100%"">
                    <thead>
                        <tr>
                            <th class=""text-center"">Mã CV</th>
                            <th class=""text-center"">Chức vụ</th>
                            <th class=""text-center"" width=""30%"">Tùy chọn</th>
                        </tr>
                    </thead>
                    <tbody>
");
#nullable restore
#line 51 "F:\Project\QuanLyNhanVien\QuanLyNhanVien\Views\ChucVu\ChucVu.cshtml"
                         foreach (ChucVu cv in getListChucVu())
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td class=\"text-center\">");
#nullable restore
#line 54 "F:\Project\QuanLyNhanVien\QuanLyNhanVien\Views\ChucVu\ChucVu.cshtml"
                                                   Write(cv.MaCv);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td class=\"text-center\">");
#nullable restore
#line 55 "F:\Project\QuanLyNhanVien\QuanLyNhanVien\Views\ChucVu\ChucVu.cshtml"
                                                   Write(cv.TenChucVu);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td class=\"text-center d-flex justify-content-evenly\">\r\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 2048, "\"", 2079, 2);
            WriteAttributeValue("", 2055, "/ChucVu/SuaChucVu/", 2055, 18, true);
#nullable restore
#line 57 "F:\Project\QuanLyNhanVien\QuanLyNhanVien\Views\ChucVu\ChucVu.cshtml"
WriteAttributeValue("", 2073, cv.Id, 2073, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                        Chỉnh sửa <i class=\"bx bx-edit-alt\"></i>\r\n                                    </a>\r\n\r\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 2247, "\"", 2278, 2);
            WriteAttributeValue("", 2254, "/ChucVu/XoaChucVu/", 2254, 18, true);
#nullable restore
#line 61 "F:\Project\QuanLyNhanVien\QuanLyNhanVien\Views\ChucVu\ChucVu.cshtml"
WriteAttributeValue("", 2272, cv.Id, 2272, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@"
                                       onclick=""return confirm('Bạn có xoá dịch vụ vận chuyển này?')"">
                                        Xóa
                                        <i class=""bx bx-trash""></i>
                                    </a>
                                </td>
                            </tr>
");
#nullable restore
#line 68 "F:\Project\QuanLyNhanVien\QuanLyNhanVien\Views\ChucVu\ChucVu.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tbody>\r\n                </table>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
