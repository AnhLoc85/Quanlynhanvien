#pragma checksum "F:\Project\QuanLyNhanVien\QuanLyNhanVien\Views\BangLuong\BangLuong.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7c123effa2dc39d3825b9a5d76ea13a967d04a03"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_BangLuong_BangLuong), @"mvc.1.0.view", @"/Views/BangLuong/BangLuong.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7c123effa2dc39d3825b9a5d76ea13a967d04a03", @"/Views/BangLuong/BangLuong.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"67e1190d3cab8feac284413eaebceed1c61e9b8b", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_BangLuong_BangLuong : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "0", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "F:\Project\QuanLyNhanVien\QuanLyNhanVien\Views\BangLuong\BangLuong.cshtml"
  
    QuanLyNhanVienContext context = new QuanLyNhanVienContext();
    List<PhongBan> getListPhongBan()
    {
        return context.PhongBan.Where(x => x.Active == true).ToList();
    }
    List<NhanSu> getListNhanSu()
    {
        return context.NhanSu.Where(x => x.Active == true).ToList();
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7c123effa2dc39d3825b9a5d76ea13a967d04a034941", async() => {
                WriteLiteral(@"
                        <div class=""row mb-2"">
                            <label class=""col-sm-1 col-lg-1 col-form-label"">Tháng</label>
                            <div class=""col-sm-2 col-lg-2"">
                                <input class=""form-control"" name=""ngayluong"" id=""NgayBangLuong"" onblur=""loadQTLuong()"" required/>
                            </div>
                            <div class=""col-sm-9 col-lg-9 d-flex justify-content-end"">
                                <button formaction=""/BangLuongPDF"" type=""submit""  class=""btn btn-danger"">
                                    <i class='bx bxs-file-pdf'></i> Xuất PDF
                                </button>
                            </div>
");
                WriteLiteral("                        </div>\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7c123effa2dc39d3825b9a5d76ea13a967d04a037580", async() => {
                WriteLiteral("Tất cả");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
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
#line 56 "F:\Project\QuanLyNhanVien\QuanLyNhanVien\Views\BangLuong\BangLuong.cshtml"
                             foreach (PhongBan pb in getListPhongBan()) {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7c123effa2dc39d3825b9a5d76ea13a967d04a039343", async() => {
#nullable restore
#line 57 "F:\Project\QuanLyNhanVien\QuanLyNhanVien\Views\BangLuong\BangLuong.cshtml"
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
#line 57 "F:\Project\QuanLyNhanVien\QuanLyNhanVien\Views\BangLuong\BangLuong.cshtml"
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
#line 58 "F:\Project\QuanLyNhanVien\QuanLyNhanVien\Views\BangLuong\BangLuong.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        </select>
                    </div>
                </div>
                <div id=""tbodyBangLuong"">
                    <table id=""example""
                           class=""table table-bordered table-responsive""
                           width=""100%"">
                        <thead>
                           <tr>
                            <th class=""text-center"">STT</th>
                            <th class=""text-center"">Mã NS</th>
                            <th class=""text-center"">Tên NS</th>
                            <th class=""text-center"">Lương cơ bản</th>
                            <th class=""text-center"">Phụ cấp theo % lương</th>
                            <th class=""text-center"">Thưởng, phụ cấp khác</th>
                            <th class=""text-center"">Tổng lương</th>
                            <th class=""text-center"">Thuế</th>
                            <th class=""text-center"">Bảo hiểm</th>
                            <th class=""text-center"">");
            WriteLiteral(@"khoản phạt, trừ lương</th>
                            <th class=""text-center"">Thực nhận</th>
                        </tr>
                        </thead>
                        <tbody>
                            <tr>
                                <td class=""text-center""></td>
                                <td class=""text-center""></td>
                                <td class=""text-left""></td>
                                <td class=""text-right""></td>
                                <td class=""text-right""></td>
                                <td class=""text-right""></td>
                                <td class=""text-right""></td>
                                <td class=""text-right""></td>
                                <td class=""text-right""></td>
                                <td class=""text-right""></td>
                                <td class=""text-right""></td>
                            </tr>
                        </tbody>
                    </table>
              ");
            WriteLiteral(@"  </div>
            </div>
        </div>
    </div>
</div>

<script>
    function loadQTLuong() {
        var Ngay = $('#NgayBangLuong').val();
        $.ajax({
            type: ""post"",
            url: ""/loadBangLuong"",
            data: ""&Ngay="" + Ngay,
            success: function (result) {

                $('#tbodyBangLuong').replaceWith(result);
                showToast('Thành công', 200)
            },
            error: function () {
                alert(""Fail"");
            }
        });
    }
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
