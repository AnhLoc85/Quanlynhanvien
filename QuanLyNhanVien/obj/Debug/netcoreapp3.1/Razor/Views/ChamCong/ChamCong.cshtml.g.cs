#pragma checksum "F:\Project\QuanLyNhanVien\QuanLyNhanVien\Views\ChamCong\ChamCong.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "193474f7cfd98a4ae4f7bad87f9479fb93a34e78"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ChamCong_ChamCong), @"mvc.1.0.view", @"/Views/ChamCong/ChamCong.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"193474f7cfd98a4ae4f7bad87f9479fb93a34e78", @"/Views/ChamCong/ChamCong.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"67e1190d3cab8feac284413eaebceed1c61e9b8b", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_ChamCong_ChamCong : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/Chamcong.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""container-xxl flex-grow-1 container-p-y"">
    <div class=""row"">
       <div class=""card"">
            <div class=""card-header"">
                <div class=""row"">
                         <div class=""row""><div class=""col-4"">
                  <div class="" row"">
                        <label for=""html5-text-input"" class=""col-md-3 col-form-label"">Quét qr</label>
                        <div class=""col-md-9"">
                          <input class=""form-control"" type=""text""");
            BeginWriteAttribute("value", " value=\"", 496, "\"", 504, 0);
            EndWriteAttribute();
            WriteLiteral(@" id=""MaDinhDanh"" placeholder=""Quét qr điểm danh"">
                        </div>
                      </div>
                </div>
                   <div class=""col-3"">
                  <div class="" row"">
                        <label for=""html5-text-input"" class=""col-md-4 col-form-label"">Mã nhân sự</label>
                        <div class=""col-md-8"">
                          <input class=""form-control"" type=""text""");
            BeginWriteAttribute("value", " value=\"", 939, "\"", 947, 0);
            EndWriteAttribute();
            WriteLiteral(@" id=""MaNS"" placeholder=""Mã nhân sự"">
                        </div>
                      </div>
                </div><div class=""col-3"">
                  <div class="" row"">
                        <label for=""html5-text-input"" class=""col-md-auto col-form-label"">Ngày</label>
                        <div class=""col-md-8"">
                          <input class=""form-control"" type=""text""");
            BeginWriteAttribute("value", " value=\"", 1345, "\"", 1353, 0);
            EndWriteAttribute();
            WriteLiteral(@" id=""Ngay"" placeholder=""Ngày"">
                        </div>
                      </div>
                </div><div class=""col-auto"">
                  
                  <button type=""button"" class=""btn btn-outline-primary"">
                              <span class=""tf-icons bx bx-search""></span>TÌm kiếm</button>
                            
                            
                </div></div>           

                </div>
            </div>
        <div class=""card-body"">
                <div class=""nav-align-top mb-4"">
                    <ul class=""nav nav-tabs nav-fill"" role=""tablist"">
                      <li class=""nav-item"">
                        <button type=""button"" class=""nav-link active"" role=""tab"" data-bs-toggle=""tab"" data-bs-target=""#navs-justified-home"" aria-controls=""navs-justified-home"" aria-selected=""true"">
                          <i class=""tf-icons bx bx-home""></i>Sáng
                        </button>
                      </li>
                      ");
            WriteLiteral(@"<li class=""nav-item"">
                        <button type=""button"" class=""nav-link"" role=""tab"" data-bs-toggle=""tab"" data-bs-target=""#navs-justified-profile"" aria-controls=""navs-justified-profile"" aria-selected=""false"">
                          <i class=""tf-icons bx bx-user""></i>Trưa</button>
                      </li>
                      <li class=""nav-item"">
                        <button type=""button"" class=""nav-link"" role=""tab"" data-bs-toggle=""tab"" data-bs-target=""#navs-justified-messages"" aria-controls=""navs-justified-messages"" aria-selected=""false"">
                          <i class=""tf-icons bx bx-message-square""></i>Tối</button>
                      </li>
                    </ul>
                    <div class=""tab-content"">
                      <div class=""tab-pane fade active show"" id=""navs-justified-home"" role=""tabpanel"">
                        <div class=""row"">
                            <div >
                               <table id=""example"" class=""display table table-bo");
            WriteLiteral(@"rdered"" style=""width: 100%"">
                                    <thead>
                                        <th class=""text-center"">Mã nhân sự</th>
                                        <th class=""text-center"">Tên nhân sự</th>
                                        <th class=""text-center"">Thời gian vào</th>
                                        <th class=""text-center"">Thời gian ra</th>
                                    </thead>
                                    <tbody id=""DDSang"">

                                    </tbody>
                                </table>
                            </div>
                        </div>
                        
                      </div>
                      <div class=""tab-pane fade"" id=""navs-justified-profile"" role=""tabpanel"">
                        <div class=""row"">
                            <div >
                               <table id=""example"" class=""display table table-bordered"" style=""width: 100%"">
                  ");
            WriteLiteral(@"                  <thead>
                                        <th class=""text-center"">Mã nhân sự</th>
                                        <th class=""text-center"">Tên nhân sự</th>
                                        <th class=""text-center"">Thời gian vào</th>
                                        <th class=""text-center"">Thời gian ra</th>
                                    </thead>
                                    <tbody id=""DDSang"">

                                    </tbody>
                                </table>
                            </div>
                        </div>
                        
                      </div>
                      <div class=""tab-pane fade"" id=""navs-justified-messages"" role=""tabpanel"">
                        <div class=""row"">
                            <div >
                               <table id=""example"" class=""display table table-bordered"" style=""width: 100%"">
                                    <thead>
                    ");
            WriteLiteral(@"                    <th class=""text-center"">Mã nhân sự</th>
                                        <th class=""text-center"">Tên nhân sự</th>
                                        <th class=""text-center"">Thời gian vào</th>
                                        <th class=""text-center"">Thời gian ra</th>
                                    </thead>
                                    <tbody id=""DDSang"">

                                    </tbody>
                                </table>
                            </div>
                        </div>
                      </div>
                    </div>
                  </div>
            </div>
        </div>
    </div>
</div>
 ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "193474f7cfd98a4ae4f7bad87f9479fb93a34e7810386", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
