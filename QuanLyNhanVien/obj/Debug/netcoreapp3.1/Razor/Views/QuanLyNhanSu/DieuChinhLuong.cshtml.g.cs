#pragma checksum "F:\Project\QuanLyNhanVien\QuanLyNhanVien\Views\QuanLyNhanSu\DieuChinhLuong.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "298e4af00d3962f1577656fb2b8ce9a1412e3fc0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_QuanLyNhanSu_DieuChinhLuong), @"mvc.1.0.view", @"/Views/QuanLyNhanSu/DieuChinhLuong.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"298e4af00d3962f1577656fb2b8ce9a1412e3fc0", @"/Views/QuanLyNhanSu/DieuChinhLuong.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"67e1190d3cab8feac284413eaebceed1c61e9b8b", @"/Views/_ViewImports.cshtml")]
    public class Views_QuanLyNhanSu_DieuChinhLuong : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
#line 1 "F:\Project\QuanLyNhanVien\QuanLyNhanVien\Views\QuanLyNhanSu\DieuChinhLuong.cshtml"
  
    QuanLyNhanVienContext context = new QuanLyNhanVienContext();
    List<Dmluong> getListLuong()
    {
        return context.Dmluong.ToList();
    }
    string format1(decimal? a)
    {
        return a?.ToString("N0", System.Globalization.CultureInfo.InvariantCulture);
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""container-xxl flex-grow-1 container-p-y"">
    <div class=""row"">
        <div class=""card"">
            <div class=""card-body"">
              <div
                        class=""border border-dark border-2 p-2 rounded mb-3 bg-light""
                      >
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "298e4af00d3962f1577656fb2b8ce9a1412e3fc04157", async() => {
                WriteLiteral(@"
                          <div class=""row mb-2"">
                            <label class=""col-sm-1 col-lg-1 col-form-label""
                              >Từ </label
                            >
                            <div class=""col-sm-2 col-lg-2"">
                                <input class=""form-control""");
                BeginWriteAttribute("name", "\r\n                                        name=\"", 923, "\"", 971, 0);
                EndWriteAttribute();
                WriteLiteral(@"
                                        id=""TuNgayDCL""/>
                            </div>
                            <label class=""col-sm-1 col-lg-1 col-form-label""
                              >đến</label
                            >
                            <div class=""col-sm-2 col-lg-2"">
                                <input class=""form-control""");
                BeginWriteAttribute("name", "\r\n                                        name=\"", 1339, "\"", 1387, 0);
                EndWriteAttribute();
                WriteLiteral(@"
                                        id=""DenNgayDCL""/>
                            </div>
                            <label class=""col-sm-2 col-lg-2 col-form-label""
                              >Mức lương cơ sở</label
                            >
                            <div class=""col-sm-2 col-lg-2"">
                              <select
                                class=""form-select""");
                BeginWriteAttribute("name", "\r\n                                name=\"", 1799, "\"", 1839, 0);
                EndWriteAttribute();
                WriteLiteral("\r\n                                id=\"MAML\"\r\n                              >\r\n                              ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "298e4af00d3962f1577656fb2b8ce9a1412e3fc06230", async() => {
                    WriteLiteral(" -- Mức lương --");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("disabled", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
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
                WriteLiteral("\r\n");
#nullable restore
#line 47 "F:\Project\QuanLyNhanVien\QuanLyNhanVien\Views\QuanLyNhanSu\DieuChinhLuong.cshtml"
                                     foreach (var item in getListLuong())
                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "298e4af00d3962f1577656fb2b8ce9a1412e3fc08252", async() => {
#nullable restore
#line 49 "F:\Project\QuanLyNhanVien\QuanLyNhanVien\Views\QuanLyNhanSu\DieuChinhLuong.cshtml"
                                                            Write(format1(item.TienLuong));

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 49 "F:\Project\QuanLyNhanVien\QuanLyNhanVien\Views\QuanLyNhanSu\DieuChinhLuong.cshtml"
                                           WriteLiteral(item.Id);

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
#line 50 "F:\Project\QuanLyNhanVien\QuanLyNhanVien\Views\QuanLyNhanSu\DieuChinhLuong.cshtml"
                                    }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                          </select>
                             
                            </div>
                            <div
                              class=""col-sm-2 col-lg-2 d-flex justify-content-end""
                            >
                              <button class=""btn btn-primary"" onclick=""addQTDCL()"">Điều chỉnh</button>
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

            </div>
        </div>
    </div>
</div>
<script>
    function addQTDCL() {
        var TuNgay = $('#TuNgayDCL').val();
        var DenNgay = $('#DenNgayDCL').val();
        var MAML = $('#MAML').val();
        $.ajax({
            type: ""post"",
            url: ""/addQTDCL"",
            data: ""&TuNgay="" + TuNgay + ""&DenNgay="" + DenNgay + ""&MAML="" + MAML,
            success: function (result) {
                alert(""ok"");
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
