#pragma checksum "F:\Project\QuanLyNhanVien\QuanLyNhanVien\Views\CapNhatThuong\CapNhatThuong.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "98fe607408a3b68b098655d687ee5e508b071e74"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CapNhatThuong_CapNhatThuong), @"mvc.1.0.view", @"/Views/CapNhatThuong/CapNhatThuong.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"98fe607408a3b68b098655d687ee5e508b071e74", @"/Views/CapNhatThuong/CapNhatThuong.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"67e1190d3cab8feac284413eaebceed1c61e9b8b", @"/Views/_ViewImports.cshtml")]
    public class Views_CapNhatThuong_CapNhatThuong : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "0", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "F:\Project\QuanLyNhanVien\QuanLyNhanVien\Views\CapNhatThuong\CapNhatThuong.cshtml"
  
    QuanLyNhanVienContext context = new QuanLyNhanVienContext();
    List<PhongBan> getListPhongBan()
    {
        return context.PhongBan.ToList();
    }
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
            WriteLiteral(@"
<div class=""container-xxl flex-grow-1 container-p-y"">
    <div class=""row"">
        <div class=""card"">
            <div class=""card-body"">
                <div class=""position-absolute"" style=""margin-top: -10px"">
                    <div class=""col-lg-2 col-sm-2"">
                        <select class=""form-select w-auto"" id=""nhomNS"" onchange=""loadNhomNhanSu()"">
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "98fe607408a3b68b098655d687ee5e508b071e744461", async() => {
                WriteLiteral("Tất cả");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 34 "F:\Project\QuanLyNhanVien\QuanLyNhanVien\Views\CapNhatThuong\CapNhatThuong.cshtml"
                             foreach (PhongBan pb in getListPhongBan())
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "98fe607408a3b68b098655d687ee5e508b071e746261", async() => {
#nullable restore
#line 36 "F:\Project\QuanLyNhanVien\QuanLyNhanVien\Views\CapNhatThuong\CapNhatThuong.cshtml"
                                              Write(pb.TenPhongBan);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 36 "F:\Project\QuanLyNhanVien\QuanLyNhanVien\Views\CapNhatThuong\CapNhatThuong.cshtml"
                               WriteLiteral(pb.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 37 "F:\Project\QuanLyNhanVien\QuanLyNhanVien\Views\CapNhatThuong\CapNhatThuong.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        </select>
                    </div>
                </div>
                <div id=""tbodyNS"">
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
                        <tbody>
");
#nullable restore
#line 57 "F:\Project\QuanLyNhanVien\QuanLyNhanVien\Views\CapNhatThuong\CapNhatThuong.cshtml"
                             foreach (NhanSu ns in getListNhanSu())
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr class=\"text-nowrap\">\r\n                                    <td class=\"text-center\">");
#nullable restore
#line 60 "F:\Project\QuanLyNhanVien\QuanLyNhanVien\Views\CapNhatThuong\CapNhatThuong.cshtml"
                                                       Write(ns.MaNs);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td class=\"text-start\">");
#nullable restore
#line 61 "F:\Project\QuanLyNhanVien\QuanLyNhanVien\Views\CapNhatThuong\CapNhatThuong.cshtml"
                                                      Write(ns.TenNs);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td class=\"text-center\">");
#nullable restore
#line 62 "F:\Project\QuanLyNhanVien\QuanLyNhanVien\Views\CapNhatThuong\CapNhatThuong.cshtml"
                                                       Write(formatDay(@ns.NgaySinh));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td class=\"text-center\">");
#nullable restore
#line 63 "F:\Project\QuanLyNhanVien\QuanLyNhanVien\Views\CapNhatThuong\CapNhatThuong.cshtml"
                                                        Write(ns.GioiTinh ?? false ? "Nam" : "Nữ");

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td class=\"text-center\">");
#nullable restore
#line 64 "F:\Project\QuanLyNhanVien\QuanLyNhanVien\Views\CapNhatThuong\CapNhatThuong.cshtml"
                                                       Write(ns.Sdt);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td class=\"text-start\">");
#nullable restore
#line 65 "F:\Project\QuanLyNhanVien\QuanLyNhanVien\Views\CapNhatThuong\CapNhatThuong.cshtml"
                                                      Write(ns.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td class=\"text-center\">\r\n                                        <a class=\"btn btn-primary\"");
            BeginWriteAttribute("href", " href=\"", 2860, "\"", 2903, 2);
            WriteAttributeValue("", 2867, "/CapNhatThuong/QuaTrinhThuong/", 2867, 30, true);
#nullable restore
#line 67 "F:\Project\QuanLyNhanVien\QuanLyNhanVien\Views\CapNhatThuong\CapNhatThuong.cshtml"
WriteAttributeValue("", 2897, ns.Id, 2897, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Chọn</a>\r\n                                    </td>\r\n                                </tr>\r\n");
#nullable restore
#line 70 "F:\Project\QuanLyNhanVien\QuanLyNhanVien\Views\CapNhatThuong\CapNhatThuong.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        </tbody>
                    </table>
                </div>
                </div>
            </div>
    </div>
</div>

<script>
    function loadNhomNhanSu() {
        var idnns = $('#nhomNS').val();
        $.ajax({
            type: ""post"",
            url: ""/loadTNhanVien"",
            data: ""&IDPB="" + idnns,
            success: function (result) {
                $('#tbodyNS').replaceWith(result);
            },
            error: function () {
                alert(""Fail"");
            }
        });
    }
</script>");
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
