#pragma checksum "D:\projectVS\QuanLyNhanSu\Quanlynhanvien\QuanLyNhanVien\Views\ChotLuong\loadNhomNhanVien.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "668b8adf37c50dbe57cac0825c1533335fe0ea22"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ChotLuong_loadNhomNhanVien), @"mvc.1.0.view", @"/Views/ChotLuong/loadNhomNhanVien.cshtml")]
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
#line 1 "D:\projectVS\QuanLyNhanSu\Quanlynhanvien\QuanLyNhanVien\Views\_ViewImports.cshtml"
using QuanLyNhanVien;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\projectVS\QuanLyNhanSu\Quanlynhanvien\QuanLyNhanVien\Views\_ViewImports.cshtml"
using QuanLyNhanVien.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"668b8adf37c50dbe57cac0825c1533335fe0ea22", @"/Views/ChotLuong/loadNhomNhanVien.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"67e1190d3cab8feac284413eaebceed1c61e9b8b", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_ChotLuong_loadNhomNhanVien : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\projectVS\QuanLyNhanSu\Quanlynhanvien\QuanLyNhanVien\Views\ChotLuong\loadNhomNhanVien.cshtml"
  
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
#line 26 "D:\projectVS\QuanLyNhanSu\Quanlynhanvien\QuanLyNhanVien\Views\ChotLuong\loadNhomNhanVien.cshtml"
 if (ViewBag.IDPB == 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <tbody id=\"tbodyNS\">\r\n");
#nullable restore
#line 29 "D:\projectVS\QuanLyNhanSu\Quanlynhanvien\QuanLyNhanVien\Views\ChotLuong\loadNhomNhanVien.cshtml"
         foreach (NhanSu ns in ViewBag.NNV)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr class=\"text-nowrap\">\r\n            <td class=\"text-center\">");
#nullable restore
#line 32 "D:\projectVS\QuanLyNhanSu\Quanlynhanvien\QuanLyNhanVien\Views\ChotLuong\loadNhomNhanVien.cshtml"
                               Write(ns.MaNs);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td class=\"text-center\">");
#nullable restore
#line 33 "D:\projectVS\QuanLyNhanSu\Quanlynhanvien\QuanLyNhanVien\Views\ChotLuong\loadNhomNhanVien.cshtml"
                               Write(ns.TenNs);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td class=\"text-center\">");
#nullable restore
#line 34 "D:\projectVS\QuanLyNhanSu\Quanlynhanvien\QuanLyNhanVien\Views\ChotLuong\loadNhomNhanVien.cshtml"
                               Write(formatDay(@ns.NgaySinh));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td class=\"text-center\">");
#nullable restore
#line 35 "D:\projectVS\QuanLyNhanSu\Quanlynhanvien\QuanLyNhanVien\Views\ChotLuong\loadNhomNhanVien.cshtml"
                                Write(ns.GioiTinh ?? false ? "Nam" : "Nữ");

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td class=\"text-center\">");
#nullable restore
#line 36 "D:\projectVS\QuanLyNhanSu\Quanlynhanvien\QuanLyNhanVien\Views\ChotLuong\loadNhomNhanVien.cshtml"
                               Write(ns.Sdt);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td class=\"text-center\">");
#nullable restore
#line 37 "D:\projectVS\QuanLyNhanSu\Quanlynhanvien\QuanLyNhanVien\Views\ChotLuong\loadNhomNhanVien.cshtml"
                               Write(ns.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td class=\"text-center\">\r\n                <a class=\"btn btn-primary\"");
            BeginWriteAttribute("href", " href=\"", 1123, "\"", 1159, 2);
            WriteAttributeValue("", 1130, "/QuanLyNhanSu/QuaTrinh/", 1130, 23, true);
#nullable restore
#line 39 "D:\projectVS\QuanLyNhanSu\Quanlynhanvien\QuanLyNhanVien\Views\ChotLuong\loadNhomNhanVien.cshtml"
WriteAttributeValue("", 1153, ns.Id, 1153, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Chọn</a>\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 42 "D:\projectVS\QuanLyNhanSu\Quanlynhanvien\QuanLyNhanVien\Views\ChotLuong\loadNhomNhanVien.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n    </tbody>\r\n");
#nullable restore
#line 47 "D:\projectVS\QuanLyNhanSu\Quanlynhanvien\QuanLyNhanVien\Views\ChotLuong\loadNhomNhanVien.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<tbody id=\"tbodyNS\">\r\n");
#nullable restore
#line 51 "D:\projectVS\QuanLyNhanSu\Quanlynhanvien\QuanLyNhanVien\Views\ChotLuong\loadNhomNhanVien.cshtml"
     foreach (QtcongTac ns in ViewBag.NNV)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <tr class=\"text-nowrap\">\r\n\r\n        <td class=\"text-center\">");
#nullable restore
#line 55 "D:\projectVS\QuanLyNhanSu\Quanlynhanvien\QuanLyNhanVien\Views\ChotLuong\loadNhomNhanVien.cshtml"
                           Write(getNS(ns.MaNs).MaNs);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td class=\"text-center\">");
#nullable restore
#line 56 "D:\projectVS\QuanLyNhanSu\Quanlynhanvien\QuanLyNhanVien\Views\ChotLuong\loadNhomNhanVien.cshtml"
                           Write(getNS(ns.MaNs).TenNs);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td class=\"text-center\">");
#nullable restore
#line 57 "D:\projectVS\QuanLyNhanSu\Quanlynhanvien\QuanLyNhanVien\Views\ChotLuong\loadNhomNhanVien.cshtml"
                           Write(formatDay(getNS(ns.MaNs).NgaySinh));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td class=\"text-center\">");
#nullable restore
#line 58 "D:\projectVS\QuanLyNhanSu\Quanlynhanvien\QuanLyNhanVien\Views\ChotLuong\loadNhomNhanVien.cshtml"
                            Write(getNS(ns.MaNs).GioiTinh ?? false ? "Nam" : "Nữ");

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td class=\"text-center\">");
#nullable restore
#line 59 "D:\projectVS\QuanLyNhanSu\Quanlynhanvien\QuanLyNhanVien\Views\ChotLuong\loadNhomNhanVien.cshtml"
                           Write(getNS(ns.MaNs).Sdt);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td class=\"text-center\">");
#nullable restore
#line 60 "D:\projectVS\QuanLyNhanSu\Quanlynhanvien\QuanLyNhanVien\Views\ChotLuong\loadNhomNhanVien.cshtml"
                           Write(getNS(ns.MaNs).Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td class=\"text-center\">\r\n            <a class=\"btn btn-primary\"");
            BeginWriteAttribute("href", " href=\"", 1825, "\"", 1873, 2);
            WriteAttributeValue("", 1832, "/QuanLyNhanSu/QuaTrinh/", 1832, 23, true);
#nullable restore
#line 62 "D:\projectVS\QuanLyNhanSu\Quanlynhanvien\QuanLyNhanVien\Views\ChotLuong\loadNhomNhanVien.cshtml"
WriteAttributeValue("", 1855, getNS(ns.MaNs).Id, 1855, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Chọn</a>\r\n        </td>\r\n    </tr>\r\n");
#nullable restore
#line 65 "D:\projectVS\QuanLyNhanSu\Quanlynhanvien\QuanLyNhanVien\Views\ChotLuong\loadNhomNhanVien.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n</tbody>\r\n");
#nullable restore
#line 70 "D:\projectVS\QuanLyNhanSu\Quanlynhanvien\QuanLyNhanVien\Views\ChotLuong\loadNhomNhanVien.cshtml"
}

#line default
#line hidden
#nullable disable
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
