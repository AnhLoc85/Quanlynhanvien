#pragma checksum "F:\Project\QuanLyNhanVien\QuanLyNhanVien\Views\ChotLuong\ChotLuong.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3a873afd1872d8aa70c4727a6ca35f09aa0bbbfe"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ChotLuong_ChotLuong), @"mvc.1.0.view", @"/Views/ChotLuong/ChotLuong.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3a873afd1872d8aa70c4727a6ca35f09aa0bbbfe", @"/Views/ChotLuong/ChotLuong.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"67e1190d3cab8feac284413eaebceed1c61e9b8b", @"/Views/_ViewImports.cshtml")]
    public class Views_ChotLuong_ChotLuong : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "F:\Project\QuanLyNhanVien\QuanLyNhanVien\Views\ChotLuong\ChotLuong.cshtml"
  
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
            WriteLiteral("\r\n<div class=\"container-xxl flex-grow-1 container-p-y\">\r\n    <div class=\"row\">\r\n        <div class=\"card\">\r\n            <div class=\"card-body\">\r\n                <div class=\"border border-dark border-2 p-2 rounded mb-3 bg-light\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3a873afd1872d8aa70c4727a6ca35f09aa0bbbfe4542", async() => {
                WriteLiteral(@"
                        <div class=""row mb-2"">
                            <label class=""col-sm-1 col-lg-1 col-form-label"">Tháng</label>
                            <div class=""col-sm-2 col-lg-2"">
                                <select class=""form-select""");
                BeginWriteAttribute("name", " name=\"", 992, "\"", 999, 0);
                EndWriteAttribute();
                BeginWriteAttribute("id", " id=\"", 1000, "\"", 1005, 0);
                EndWriteAttribute();
                WriteLiteral(@"></select>
                            </div>
                            <label class=""col-sm-1 col-lg-1 col-form-label"">năm</label>
                            <div class=""col-sm-2 col-lg-2"">
                                <select class=""form-select""");
                BeginWriteAttribute("name", " name=\"", 1263, "\"", 1270, 0);
                EndWriteAttribute();
                BeginWriteAttribute("id", " id=\"", 1271, "\"", 1276, 0);
                EndWriteAttribute();
                WriteLiteral(@"></select>
                            </div>

                            <div class=""col-sm-6 col-lg-6 d-flex justify-content-end"">
                                <button class=""btn btn-primary"">Chốt lương</button>
                            </div>
                        </div>
                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                </div>
                <div class=""position-absolute"" style=""margin-top: -10px"">
                    <div class=""col-lg-2 col-sm-2"">
                        <select class=""form-select w-auto""
                                id=""nhomNS""
                                onchange=""loadNhomNhanSu()"">
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3a873afd1872d8aa70c4727a6ca35f09aa0bbbfe7505", async() => {
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
#line 53 "F:\Project\QuanLyNhanVien\QuanLyNhanVien\Views\ChotLuong\ChotLuong.cshtml"
                             foreach (PhongBan pb in getListPhongBan()) {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3a873afd1872d8aa70c4727a6ca35f09aa0bbbfe9268", async() => {
#nullable restore
#line 54 "F:\Project\QuanLyNhanVien\QuanLyNhanVien\Views\ChotLuong\ChotLuong.cshtml"
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
#line 54 "F:\Project\QuanLyNhanVien\QuanLyNhanVien\Views\ChotLuong\ChotLuong.cshtml"
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
#line 55 "F:\Project\QuanLyNhanVien\QuanLyNhanVien\Views\ChotLuong\ChotLuong.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        </select>
                    </div>
                </div>
                <table id=""example""
                       class=""table table-bordered table-responsive""
                       width=""100%"">
                    <thead>
                        <tr>
                            <th class=""text-center"">Mã NS</th>
                            <th class=""text-center"">Tên NS</th>
                            <th class=""text-center"">Ngày sinh</th>
                            <th class=""text-center"">Giới tính</th>
                            <th class=""text-center"">Hệ số lương</th>
                            <th class=""text-center"">mức lương cơ bản</th>
                            <th class=""text-center"">Tiền lương</th>
                        </tr>
                    </thead>
                    <tbody>
                        <tr>
                            <td class=""text-center""></td>
                            <td class=""text-left""></td>
                  ");
            WriteLiteral(@"          <td class=""text-center""></td>
                            <td class=""text-center""></td>
                            <td class=""text-center""></td>
                            <td class=""text-right""></td>
                            <td class=""text-right""></td>
                        </tr>
                    </tbody>
                </table>
            </div>
        </div>
    </div>
</div>

");
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
