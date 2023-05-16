#pragma checksum "F:\Project\QuanLyNhanVien\QuanLyNhanVien\Views\NhanSu\NhanSu.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "da802ddf0817c35326fca67c4a9a1f721e3df5c8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_NhanSu_NhanSu), @"mvc.1.0.view", @"/Views/NhanSu/NhanSu.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"da802ddf0817c35326fca67c4a9a1f721e3df5c8", @"/Views/NhanSu/NhanSu.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"67e1190d3cab8feac284413eaebceed1c61e9b8b", @"/Views/_ViewImports.cshtml")]
    public class Views_NhanSu_NhanSu : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "F:\Project\QuanLyNhanVien\QuanLyNhanVien\Views\NhanSu\NhanSu.cshtml"
  
    QuanLyNhanVienContext context = new QuanLyNhanVienContext();
    List<NhanSu> getListNhanSu()
    {
        return context.NhanSu.ToList();
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
#line 20 "F:\Project\QuanLyNhanVien\QuanLyNhanVien\Views\NhanSu\NhanSu.cshtml"
 if (TempData["ThongBao"] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <script type=\"text/javascript\" charset=\"utf-8\">\r\n                        window.onload = function () {\r\n                            alert(\"");
#nullable restore
#line 24 "F:\Project\QuanLyNhanVien\QuanLyNhanVien\Views\NhanSu\NhanSu.cshtml"
                              Write(Html.Raw(@TempData["ThongBao"]));

#line default
#line hidden
#nullable disable
            WriteLiteral("\");\r\n                    };\r\n    </script>\r\n");
#nullable restore
#line 27 "F:\Project\QuanLyNhanVien\QuanLyNhanVien\Views\NhanSu\NhanSu.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""container-xxl flex-grow-1 container-p-y"">
    <div class=""row"">
        <div class=""card"">
            <div class=""card-body"">
                <div class=""position-absolute"" style=""margin-top: -10px"">
                    <div class=""col-lg-2 col-sm-2"" style=""width: auto"">
                        <a href=""/NhanSu/ThemNhanSu"" class=""btn btn-primary"">
                            <span>Thêm Mới</span>
                        </a>
                    </div>
                </div>
                <table id=""example""
                       class=""display table table-bordered table-responsive""
                       style=""width: 100%"">
                    <thead>
                        <tr>
                            <th class=""text-center"">Mã NS</th>
                            <th class=""text-center"">Ảnh</th>
                            <th class=""text-center"">Tên</th>
                            <th class=""text-center"">Ngày sinh</th>
                            <th class=""text-ce");
            WriteLiteral(@"nter"">Địa chỉ</th>
                            <th class=""text-center"">giới tính</th>
                            <th class=""text-center"">SĐT</th>
                            <th class=""text-center"">Email</th>
                            <th class=""text-center"">Quê quán</th>
                            <th class=""text-center"">Tùy chọn</th>
                        </tr>
                    </thead>
                    <tbody>
");
#nullable restore
#line 57 "F:\Project\QuanLyNhanVien\QuanLyNhanVien\Views\NhanSu\NhanSu.cshtml"
                         foreach (NhanSu ns in getListNhanSu())
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr class=\"text-nowrap\">\r\n                                <td class=\"text-center\">");
#nullable restore
#line 60 "F:\Project\QuanLyNhanVien\QuanLyNhanVien\Views\NhanSu\NhanSu.cshtml"
                                                   Write(ns.MaNs);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td class=\"text-center p-1\">\r\n                                    <img height=\"45px\"\r\n                                         width=\"45px\"");
            BeginWriteAttribute("src", "\r\n                                         src=\"", 2496, "\"", 2555, 1);
#nullable restore
#line 64 "F:\Project\QuanLyNhanVien\QuanLyNhanVien\Views\NhanSu\NhanSu.cshtml"
WriteAttributeValue("", 2544, ns.HinhAnh, 2544, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("\r\n                                         alt=\"ảnh nhân sự\" />\r\n                                </td>\r\n                                <td class=\"text-center\">");
#nullable restore
#line 67 "F:\Project\QuanLyNhanVien\QuanLyNhanVien\Views\NhanSu\NhanSu.cshtml"
                                                   Write(ns.TenNs);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td class=\"text-center\">");
#nullable restore
#line 68 "F:\Project\QuanLyNhanVien\QuanLyNhanVien\Views\NhanSu\NhanSu.cshtml"
                                                   Write(formatDay(@ns.NgaySinh));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td class=\"text-center\">");
#nullable restore
#line 69 "F:\Project\QuanLyNhanVien\QuanLyNhanVien\Views\NhanSu\NhanSu.cshtml"
                                                   Write(ns.DiaChi);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td class=\"text-center\">");
#nullable restore
#line 70 "F:\Project\QuanLyNhanVien\QuanLyNhanVien\Views\NhanSu\NhanSu.cshtml"
                                                    Write(ns.GioiTinh ?? false ? "Nam" : "Nữ");

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td class=\"text-center\">");
#nullable restore
#line 71 "F:\Project\QuanLyNhanVien\QuanLyNhanVien\Views\NhanSu\NhanSu.cshtml"
                                                   Write(ns.Sdt);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td class=\"text-center\">");
#nullable restore
#line 72 "F:\Project\QuanLyNhanVien\QuanLyNhanVien\Views\NhanSu\NhanSu.cshtml"
                                                   Write(ns.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td class=\"text-center\">");
#nullable restore
#line 73 "F:\Project\QuanLyNhanVien\QuanLyNhanVien\Views\NhanSu\NhanSu.cshtml"
                                                   Write(ns.QueQuan);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
                                <td class=""text-center"">
                                    <div class=""dropdown"">
                                        <button type=""button"" class=""btn p-0 dropdown-toggle hide-arrow"" data-bs-toggle=""dropdown"" aria-expanded=""false"">
                                            <i class=""bx bx-dots-vertical-rounded""></i>
                                        </button>
                                        <div class=""dropdown-menu""");
            BeginWriteAttribute("style", " style=\"", 3688, "\"", 3696, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                            <a class=\"dropdown-item\"");
            BeginWriteAttribute("href", " href=\"", 3768, "\"", 3799, 2);
            WriteAttributeValue("", 3775, "/NhanSu/SuaNhanSu/", 3775, 18, true);
#nullable restore
#line 80 "F:\Project\QuanLyNhanVien\QuanLyNhanVien\Views\NhanSu\NhanSu.cshtml"
WriteAttributeValue("", 3793, ns.Id, 3793, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"bx bx-edit-alt me-1\"></i>Chỉnh sửa</a>\r\n                                            <a class=\"dropdown-item\"");
            BeginWriteAttribute("href", " href=\"", 3919, "\"", 3950, 2);
            WriteAttributeValue("", 3926, "/NhanSu/XoaNhanSu/", 3926, 18, true);
#nullable restore
#line 81 "F:\Project\QuanLyNhanVien\QuanLyNhanVien\Views\NhanSu\NhanSu.cshtml"
WriteAttributeValue("", 3944, ns.Id, 3944, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" onclick=\"return confirm(\'Bạn có xoá nhân sự này?\')\"><i class=\"bx bx-trash me-1\"></i>Xóa</a>\r\n                                            <a class=\"dropdown-item\"");
            BeginWriteAttribute("href", " href=\"", 4113, "\"", 4148, 2);
            WriteAttributeValue("", 4120, "/NhanSu/ChiTietNhanSu/", 4120, 22, true);
#nullable restore
#line 82 "F:\Project\QuanLyNhanVien\QuanLyNhanVien\Views\NhanSu\NhanSu.cshtml"
WriteAttributeValue("", 4142, ns.Id, 4142, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@"  ><i class=""bx bx-low-vision me-1""></i>Xem</a>
                                            
                                        </div>
                                    </div>
                                </td>
                            </tr>
");
#nullable restore
#line 88 "F:\Project\QuanLyNhanVien\QuanLyNhanVien\Views\NhanSu\NhanSu.cshtml"
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
