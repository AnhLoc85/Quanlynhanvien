#pragma checksum "F:\Project\QuanLyNhanVien\QuanLyNhanVien\Views\Phat\Phat.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4de94024b0245db405b4eb37df02f5f9582eb47e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Phat_Phat), @"mvc.1.0.view", @"/Views/Phat/Phat.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4de94024b0245db405b4eb37df02f5f9582eb47e", @"/Views/Phat/Phat.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"67e1190d3cab8feac284413eaebceed1c61e9b8b", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Phat_Phat : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "2", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "F:\Project\QuanLyNhanVien\QuanLyNhanVien\Views\Phat\Phat.cshtml"
  
    QuanLyNhanVienContext context = new QuanLyNhanVienContext();
    List<Phat> getListPhat()
    {
        return context.Phat.ToList();
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
#line 19 "F:\Project\QuanLyNhanVien\QuanLyNhanVien\Views\Phat\Phat.cshtml"
 if (TempData["ThongBao"] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <script type=\"text/javascript\" charset=\"utf-8\">\r\n                        window.onload = function () {\r\n                            alert(\"");
#nullable restore
#line 23 "F:\Project\QuanLyNhanVien\QuanLyNhanVien\Views\Phat\Phat.cshtml"
                              Write(Html.Raw(@TempData["ThongBao"]));

#line default
#line hidden
#nullable disable
            WriteLiteral("\");\r\n                    };\r\n    </script>\r\n");
#nullable restore
#line 26 "F:\Project\QuanLyNhanVien\QuanLyNhanVien\Views\Phat\Phat.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""container-xxl flex-grow-1 container-p-y"">
    <div class=""row"">
        <div class=""card"">
            <div class=""card-body"">
                <div class=""row position-absolute"" style=""margin-top: -10px"">
                    <div class=""col-sm-auto pe-2"">
                       <a href=""/Phat/ThemPhat"" class=""btn btn-primary"">
                            <span>Thêm Mới</span>
                        </a>
                    </div>
                    <div class=""col-sm-auto pe-2"">
                        <select class=""form-select""");
            BeginWriteAttribute("name", " name=\"", 1195, "\"", 1202, 0);
            EndWriteAttribute();
            WriteLiteral(" id=\"TinhTrang\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4de94024b0245db405b4eb37df02f5f9582eb47e5750", async() => {
                WriteLiteral("Hiện tại");
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
            WriteLiteral("\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4de94024b0245db405b4eb37df02f5f9582eb47e7250", async() => {
                WriteLiteral("Đã xóa");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                        </select>
                    </div>
                </div>
                <table id=""example"" class=""display table table-bordered"" style=""width: 100%"">
                    <thead>
                        <tr>
                            <th class=""text-center"">Mã Phạt</th>
                            <th class=""text-center"">Nội dung phạt</th>
                            <th class=""text-center"" width=""30%"">Tùy chọn</th>
                        </tr>
                    </thead>
                    <tbody>
");
#nullable restore
#line 53 "F:\Project\QuanLyNhanVien\QuanLyNhanVien\Views\Phat\Phat.cshtml"
                         foreach (Phat phat in getListPhat())
                        {
                            if(phat.Active == true)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n                                    <td class=\"text-center\">");
#nullable restore
#line 58 "F:\Project\QuanLyNhanVien\QuanLyNhanVien\Views\Phat\Phat.cshtml"
                                                       Write(phat.MaPhat);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td class=\"text-center\">");
#nullable restore
#line 59 "F:\Project\QuanLyNhanVien\QuanLyNhanVien\Views\Phat\Phat.cshtml"
                                                       Write(phat.NoiDung);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td class=\"text-center d-flex justify-content-evenly\">\r\n                                        <a");
            BeginWriteAttribute("href", " href=\"", 2411, "\"", 2440, 2);
            WriteAttributeValue("", 2418, "/Phat/SuaPhat/", 2418, 14, true);
#nullable restore
#line 61 "F:\Project\QuanLyNhanVien\QuanLyNhanVien\Views\Phat\Phat.cshtml"
WriteAttributeValue("", 2432, phat.Id, 2432, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                            Chỉnh sửa <i class=\"bx bx-edit-alt\"></i>\r\n                                        </a>\r\n\r\n                                        <a");
            BeginWriteAttribute("href", " href=\"", 2620, "\"", 2649, 2);
            WriteAttributeValue("", 2627, "/Phat/XoaPhat/", 2627, 14, true);
#nullable restore
#line 65 "F:\Project\QuanLyNhanVien\QuanLyNhanVien\Views\Phat\Phat.cshtml"
WriteAttributeValue("", 2641, phat.Id, 2641, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@"
                                           onclick=""return confirm('Bạn có xoá mức phạt này?')"">
                                            Xóa
                                            <i class=""bx bx-trash""></i>
                                        </a>
                                    </td>
                                </tr>
");
#nullable restore
#line 72 "F:\Project\QuanLyNhanVien\QuanLyNhanVien\Views\Phat\Phat.cshtml"
                            }
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </tbody>
                </table>
            </div>
        </div>
    </div>
</div>
<script>
    $('#TinhTrang').on('change', function() {
        var TrangThai = $(this).val();
        $.ajax({
        type: ""post"",
        url: ""/Phat/DoiTrangThai"",
        data: ""trangthai="" + TrangThai,
        success: function (response) {
             var table = $('#example').DataTable();
        // Clear existing rows from the DataTable
        table.rows().remove().draw();
      $.each(response, function (index, phat) {
    var row = `<tr>
                    <td class=""text-center"">${phat.maPhat}</td>
                    <td class=""text-center"">${phat.noiDung}</td>
                    <td class=""text-center d-flex justify-content-evenly"">
                        <a href=""/Phat/SuaPhat/${phat.id}"">
                            Chỉnh sửa <i class=""bx bx-edit-alt""></i>
                        </a>
                    ${phat.active ?
                        `<a href=""/Ph");
            WriteLiteral(@"at/XoaPhat/${phat.id}""
                            onclick=""return confirm('Bạn có xoá mức phạt này?')"">
                            Xóa
                            <i class=""bx bx-trash""></i>
                        </a>`:
                        `<a href=""/Phat/KhoiPhuc/${phat.id}""
                            onclick=""return confirm('Bạn có khôi phục mức phạt này?')"">
                            Khôi phục
                            <i class=""bx bx-redo""></i>
                        </a>`
                    }
                        
                    </td>
                </tr>`;
            // Thêm dòng mới vào DataTable và vẽ lại DataTable
            $('#example').DataTable().row.add($(row)[0]).draw(false);
        });
        },
        error: function (error) {
            console.log(error);
        }
    });
    })
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
