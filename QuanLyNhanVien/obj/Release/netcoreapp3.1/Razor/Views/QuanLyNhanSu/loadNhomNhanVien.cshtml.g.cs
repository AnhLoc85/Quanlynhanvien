#pragma checksum "F:\Project\QuanLyNhanVien\QuanLyNhanVien\Views\QuanLyNhanSu\loadNhomNhanVien.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d9072f8c90116fe194620450bd17426cfb5c9eaa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_QuanLyNhanSu_loadNhomNhanVien), @"mvc.1.0.view", @"/Views/QuanLyNhanSu/loadNhomNhanVien.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d9072f8c90116fe194620450bd17426cfb5c9eaa", @"/Views/QuanLyNhanSu/loadNhomNhanVien.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"67e1190d3cab8feac284413eaebceed1c61e9b8b", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_QuanLyNhanSu_loadNhomNhanVien : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "F:\Project\QuanLyNhanVien\QuanLyNhanVien\Views\QuanLyNhanSu\loadNhomNhanVien.cshtml"
  
    QuanLyNhanVienContext context = new QuanLyNhanVienContext();
    List<PhongBan> getListPhongBan()
    {
        return context.PhongBan.ToList();
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
    NhanSu getNS(int? id)
    {
        NhanSu nv = context.NhanSu.Find(id);
        if (nv != null) return nv;
        else return new NhanSu();
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "F:\Project\QuanLyNhanVien\QuanLyNhanVien\Views\QuanLyNhanSu\loadNhomNhanVien.cshtml"
 if (ViewBag.IDPB == 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div id=""example1"">
        <table id=""example""
               class=""display table table-bordered table-responsive""
               style=""width: 100%"">
            <thead>
                <tr>
                    <th class=""text-center"">Mã NS</th>
                    <th class=""text-center"">Tên</th>
                    <th class=""text-center"">Ngày sinh</th>
                    <th class=""text-center"">giới tính</th>
                    <th class=""text-center"">SĐT</th>
                    <th class=""text-center"">Email</th>
                    <th class=""text-center"">Xem</th>
                </tr>
            </thead>
            <tbody id=""tbodyNS"">
");
#nullable restore
#line 44 "F:\Project\QuanLyNhanVien\QuanLyNhanVien\Views\QuanLyNhanSu\loadNhomNhanVien.cshtml"
                 foreach (NhanSu ns in ViewBag.NNV)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr class=\"text-nowrap\">\r\n                        <td class=\"text-center\">");
#nullable restore
#line 47 "F:\Project\QuanLyNhanVien\QuanLyNhanVien\Views\QuanLyNhanSu\loadNhomNhanVien.cshtml"
                                           Write(ns.MaNs);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td class=\"text-center\">");
#nullable restore
#line 48 "F:\Project\QuanLyNhanVien\QuanLyNhanVien\Views\QuanLyNhanSu\loadNhomNhanVien.cshtml"
                                           Write(ns.TenNs);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td class=\"text-center\">");
#nullable restore
#line 49 "F:\Project\QuanLyNhanVien\QuanLyNhanVien\Views\QuanLyNhanSu\loadNhomNhanVien.cshtml"
                                           Write(formatDay(@ns.NgaySinh));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td class=\"text-center\">");
#nullable restore
#line 50 "F:\Project\QuanLyNhanVien\QuanLyNhanVien\Views\QuanLyNhanSu\loadNhomNhanVien.cshtml"
                                            Write(ns.GioiTinh ?? false ? "Nam" : "Nữ");

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td class=\"text-center\">");
#nullable restore
#line 51 "F:\Project\QuanLyNhanVien\QuanLyNhanVien\Views\QuanLyNhanSu\loadNhomNhanVien.cshtml"
                                           Write(ns.Sdt);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td class=\"text-center\">");
#nullable restore
#line 52 "F:\Project\QuanLyNhanVien\QuanLyNhanVien\Views\QuanLyNhanSu\loadNhomNhanVien.cshtml"
                                           Write(ns.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td class=\"text-center\">\r\n                            <a class=\"btn btn-primary\"");
            BeginWriteAttribute("href", " href=\"", 1898, "\"", 1934, 2);
            WriteAttributeValue("", 1905, "/QuanLyNhanSu/QuaTrinh/", 1905, 23, true);
#nullable restore
#line 54 "F:\Project\QuanLyNhanVien\QuanLyNhanVien\Views\QuanLyNhanSu\loadNhomNhanVien.cshtml"
WriteAttributeValue("", 1928, ns.Id, 1928, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Chọn</a>\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 57 "F:\Project\QuanLyNhanVien\QuanLyNhanVien\Views\QuanLyNhanSu\loadNhomNhanVien.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n        </div>\r\n");
#nullable restore
#line 61 "F:\Project\QuanLyNhanVien\QuanLyNhanVien\Views\QuanLyNhanSu\loadNhomNhanVien.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <div id=""example1"">
            <table id=""example""
                   class=""display table table-bordered table-responsive""
                   style=""width: 100%"">
                <thead>
                    <tr>
                        <th class=""text-center"">Mã NS</th>
                        <th class=""text-center"">Tên</th>
                        <th class=""text-center"">Ngày sinh</th>
                        <th class=""text-center"">giới tính</th>
                        <th class=""text-center"">SĐT</th>
                        <th class=""text-center"">Email</th>
                        <th class=""text-center"">Xem</th>
                    </tr>
                </thead>
                <tbody id=""tbodyNS"">
");
#nullable restore
#line 80 "F:\Project\QuanLyNhanVien\QuanLyNhanVien\Views\QuanLyNhanSu\loadNhomNhanVien.cshtml"
                     foreach (QtcongTac ns in ViewBag.NNV)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr class=\"text-nowrap\">\r\n\r\n                            <td class=\"text-center\">");
#nullable restore
#line 84 "F:\Project\QuanLyNhanVien\QuanLyNhanVien\Views\QuanLyNhanSu\loadNhomNhanVien.cshtml"
                                               Write(getNS(ns.MaNs).MaNs);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td class=\"text-center\">");
#nullable restore
#line 85 "F:\Project\QuanLyNhanVien\QuanLyNhanVien\Views\QuanLyNhanSu\loadNhomNhanVien.cshtml"
                                               Write(getNS(ns.MaNs).TenNs);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td class=\"text-center\">");
#nullable restore
#line 86 "F:\Project\QuanLyNhanVien\QuanLyNhanVien\Views\QuanLyNhanSu\loadNhomNhanVien.cshtml"
                                               Write(formatDay(getNS(ns.MaNs).NgaySinh));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td class=\"text-center\">");
#nullable restore
#line 87 "F:\Project\QuanLyNhanVien\QuanLyNhanVien\Views\QuanLyNhanSu\loadNhomNhanVien.cshtml"
                                                Write(getNS(ns.MaNs).GioiTinh ?? false ? "Nam" : "Nữ");

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td class=\"text-center\">");
#nullable restore
#line 88 "F:\Project\QuanLyNhanVien\QuanLyNhanVien\Views\QuanLyNhanSu\loadNhomNhanVien.cshtml"
                                               Write(getNS(ns.MaNs).Sdt);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td class=\"text-center\">");
#nullable restore
#line 89 "F:\Project\QuanLyNhanVien\QuanLyNhanVien\Views\QuanLyNhanSu\loadNhomNhanVien.cshtml"
                                               Write(getNS(ns.MaNs).Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td class=\"text-center\">\r\n                                <a class=\"btn btn-primary\"");
            BeginWriteAttribute("href", " href=\"", 3623, "\"", 3671, 2);
            WriteAttributeValue("", 3630, "/QuanLyNhanSu/QuaTrinh/", 3630, 23, true);
#nullable restore
#line 91 "F:\Project\QuanLyNhanVien\QuanLyNhanVien\Views\QuanLyNhanSu\loadNhomNhanVien.cshtml"
WriteAttributeValue("", 3653, getNS(ns.MaNs).Id, 3653, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Chọn</a>\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 94 "F:\Project\QuanLyNhanVien\QuanLyNhanVien\Views\QuanLyNhanSu\loadNhomNhanVien.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\r\n            </table>\r\n        </div>\r\n");
#nullable restore
#line 98 "F:\Project\QuanLyNhanVien\QuanLyNhanVien\Views\QuanLyNhanSu\loadNhomNhanVien.cshtml"

        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<script>
    $(document).ready(function () {
        $.fn.DataTable.ext.pager.numbers_length = 3;
        $(""#example"").dataTable({
            scrollCollapse: true,
            bLengthChange: false,
            bInfo: false,
            scrollX: true,
            fixedHeader: true,
            language: {
                paginate: {
                    previous: ""<<"",
                    next: "">>"",
                },
                search: ""Tìm kiếm"",
            },
        });
    });
</script>");
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