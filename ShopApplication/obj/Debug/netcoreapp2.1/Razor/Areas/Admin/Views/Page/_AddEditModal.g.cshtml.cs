#pragma checksum "E:\Web_Developer\Practice\BackEnd\dotnetcore\ShopApplication\ShopApplication\Areas\Admin\Views\Page\_AddEditModal.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "daeae2d59aa9dbacce0f82307535a7309c8161fd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Page__AddEditModal), @"mvc.1.0.view", @"/Areas/Admin/Views/Page/_AddEditModal.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Page/_AddEditModal.cshtml", typeof(AspNetCore.Areas_Admin_Views_Page__AddEditModal))]
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
#line 1 "E:\Web_Developer\Practice\BackEnd\dotnetcore\ShopApplication\ShopApplication\Areas\Admin\Views\_ViewImports.cshtml"
using ShopApplication;

#line default
#line hidden
#line 2 "E:\Web_Developer\Practice\BackEnd\dotnetcore\ShopApplication\ShopApplication\Areas\Admin\Views\_ViewImports.cshtml"
using ShopApplication.Models;

#line default
#line hidden
#line 3 "E:\Web_Developer\Practice\BackEnd\dotnetcore\ShopApplication\ShopApplication\Areas\Admin\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 4 "E:\Web_Developer\Practice\BackEnd\dotnetcore\ShopApplication\ShopApplication\Areas\Admin\Views\_ViewImports.cshtml"
using ShopApplication.Data.Entities;

#line default
#line hidden
#line 5 "E:\Web_Developer\Practice\BackEnd\dotnetcore\ShopApplication\ShopApplication\Areas\Admin\Views\_ViewImports.cshtml"
using ShopApplication.Application.ViewModels.System;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"daeae2d59aa9dbacce0f82307535a7309c8161fd", @"/Areas/Admin/Views/Page/_AddEditModal.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9a94525efa71c0cb4ece4dd5c94e662405894b33", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Page__AddEditModal : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-horizontal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("frmMaintainance"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 578, true);
            WriteLiteral(@"<div id=""modal-add-edit"" class=""bootbox modal fade modal-darkorange in"" tabindex=""-1"" role=""dialog"" aria-labelledby=""myModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog  modal-lg"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <button type=""button"" class=""bootbox-close-button close"" data-dismiss=""modal"" aria-hidden=""true"">×</button>
                <h4 class=""modal-title"">Add/edit page</h4>
            </div>
            <div class=""modal-body"">
                <div id=""horizontal-form"">
                    ");
            EndContext();
            BeginContext(578, 2312, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f0f1ca03f21a4bd2863ae47158152b25", async() => {
                BeginContext(641, 2242, true);
                WriteLiteral(@"
                        <div class=""form-group"">
                            <input type=""hidden"" id=""hidIdM"" value=""0"" />
                            <label for=""txtNameM"" class=""col-sm-2 control-label no-padding-right"">Name</label>
                            <div class=""col-sm-10"">
                                <input type=""text"" name=""txtNameM"" class=""form-control"" id=""txtNameM"">
                            </div>
                        </div>
                        <div class=""form-group"">
                            <label for=""txtAliasM"" class=""col-sm-2 control-label no-padding-right"">Alias</label>
                            <div class=""col-sm-10"">
                                <input type=""text"" name=""txtAliasM"" class=""form-control"" id=""txtAliasM"">
                            </div>
                        </div>

                        <div class=""form-group"">
                            <label for=""txtContentM"" class=""col-sm-2 control-label no-padding-right"">Content</label>");
                WriteLiteral(@"
                            <div class=""col-sm-10"">
                                <textarea id=""txtContentM"" rows=""6"" class=""form-control""></textarea>
                            </div>
                        </div>
                        <div class=""form-group"">
                            <div class=""col-sm-offset-2 col-sm-10"">
                                <div class=""checkbox"">
                                    <label>
                                        <input type=""checkbox"" checked=""checked"" id=""ckStatusM"">
                                        <span class=""text"">Active.</span>
                                    </label>

                                </div>
                            </div>
                        </div>
                        <div class=""form-group"">
                            <div class=""col-sm-offset-2 col-sm-10"">
                                <button type=""button"" id=""btnSaveM"" class=""btn btn-success"">Save</button>
                         ");
                WriteLiteral("       <button type=\"button\" id=\"btnCancelM\" data-dismiss=\"modal\" class=\"btn btn-danger\">Cancel</button>\r\n                            </div>\r\n                        </div>\r\n                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2890, 80, true);
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
            EndContext();
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
