#pragma checksum "E:\Web_Developer\Practice\BackEnd\dotnetcore\ShopApplication\ShopApplication\Views\Contact\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4676c4e85554ce7eba941a770192bdaa8f9914a2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Contact_Index), @"mvc.1.0.view", @"/Views/Contact/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Contact/Index.cshtml", typeof(AspNetCore.Views_Contact_Index))]
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
#line 1 "E:\Web_Developer\Practice\BackEnd\dotnetcore\ShopApplication\ShopApplication\Views\_ViewImports.cshtml"
using ShopApplication;

#line default
#line hidden
#line 2 "E:\Web_Developer\Practice\BackEnd\dotnetcore\ShopApplication\ShopApplication\Views\_ViewImports.cshtml"
using ShopApplication.Models;

#line default
#line hidden
#line 3 "E:\Web_Developer\Practice\BackEnd\dotnetcore\ShopApplication\ShopApplication\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 4 "E:\Web_Developer\Practice\BackEnd\dotnetcore\ShopApplication\ShopApplication\Views\_ViewImports.cshtml"
using ShopApplication.Data.Entities;

#line default
#line hidden
#line 5 "E:\Web_Developer\Practice\BackEnd\dotnetcore\ShopApplication\ShopApplication\Views\_ViewImports.cshtml"
using ShopApplication.Models.AccountViewModels;

#line default
#line hidden
#line 6 "E:\Web_Developer\Practice\BackEnd\dotnetcore\ShopApplication\ShopApplication\Views\_ViewImports.cshtml"
using ShopApplication.Models.ManageViewModels;

#line default
#line hidden
#line 7 "E:\Web_Developer\Practice\BackEnd\dotnetcore\ShopApplication\ShopApplication\Views\_ViewImports.cshtml"
using ShopApplication.Application.ViewModels.Product;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4676c4e85554ce7eba941a770192bdaa8f9914a2", @"/Views/Contact/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c6917980a95311f35f324cd854419d4a3c81b13d", @"/Views/_ViewImports.cshtml")]
    public class Views_Contact_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ContactPageViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/client-ap/controller/contact/index.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "text", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control input-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rows", new global::Microsoft.AspNetCore.Html.HtmlString("10"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/contact.html"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.TextAreaTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "E:\Web_Developer\Practice\BackEnd\dotnetcore\ShopApplication\ShopApplication\Views\Contact\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            DefineSection("Scripts", async() => {
                BeginContext(87, 125, true);
                WriteLiteral("\r\n    <script src=\"https://maps.googleapis.com/maps/api/js?key=AIzaSyB4NZj0gr2Tej-xeK73cU_79igN6MGtAU4\">\r\n    </script>\r\n    ");
                EndContext();
                BeginContext(212, 89, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "527e579a14e2487890efaae1a46680db", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 8 "E:\Web_Developer\Practice\BackEnd\dotnetcore\ShopApplication\ShopApplication\Views\Contact\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion = true;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(301, 116, true);
                WriteLiteral("\r\n    <script>\r\n        var contactObj = new ContactController();\r\n        contactObj.initialize();\r\n    </script>\r\n");
                EndContext();
            }
            );
            BeginContext(420, 32, true);
            WriteLiteral("<input type=\"hidden\" id=\"hidLng\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 452, "\"", 478, 1);
#line 14 "E:\Web_Developer\Practice\BackEnd\dotnetcore\ShopApplication\ShopApplication\Views\Contact\Index.cshtml"
WriteAttributeValue("", 460, Model.Contact.Lng, 460, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(479, 37, true);
            WriteLiteral(" />\r\n<input type=\"hidden\" id=\"hidLat\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 516, "\"", 542, 1);
#line 15 "E:\Web_Developer\Practice\BackEnd\dotnetcore\ShopApplication\ShopApplication\Views\Contact\Index.cshtml"
WriteAttributeValue("", 524, Model.Contact.Lat, 524, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(543, 41, true);
            WriteLiteral(" />\r\n<input type=\"hidden\" id=\"hidAddress\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 584, "\"", 614, 1);
#line 16 "E:\Web_Developer\Practice\BackEnd\dotnetcore\ShopApplication\ShopApplication\Views\Contact\Index.cshtml"
WriteAttributeValue("", 592, Model.Contact.Address, 592, 22, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(615, 38, true);
            WriteLiteral(" />\r\n<input type=\"hidden\" id=\"hidName\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 653, "\"", 680, 1);
#line 17 "E:\Web_Developer\Practice\BackEnd\dotnetcore\ShopApplication\ShopApplication\Views\Contact\Index.cshtml"
WriteAttributeValue("", 661, Model.Contact.Name, 661, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(681, 1968, true);
            WriteLiteral(@" />
<!-- Breadcrumbs -->
<div class=""breadcrumbs"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-xs-12"">
                <ul>
                    <li class=""home""> <a title=""Go to Home Page"" href=""index.html"">Home</a><span>&raquo;</span></li>
                    <li><strong>Contact Us</strong></li>
                </ul>
            </div>
        </div>
    </div>
</div>
<!-- Breadcrumbs End -->
<!-- Main Container -->
<section class=""main-container col1-layout"">
    <div class=""main container"">
        <div class=""row"">
            <section class=""col-main col-sm-12"">
                <div id=""contact"" class=""page-content page-contact"">
                    <div class=""page-title"">
                        <h2>Contact Us</h2>
                    </div>
                    <div id=""message-box-conact"">We're available for new projects</div>
                    <div class=""row"">
                        <div class=""col-xs-12 col-sm-6"" id=""contact_form_ma");
            WriteLiteral(@"p"">
                            <h3 class=""page-subheading"">Let's get in touch</h3>
                            <p>Lorem ipsum dolor sit amet onsectetuer adipiscing elit. Mauris fermentum dictum magna. Sed laoreet aliquam leo. Ut tellus dolor dapibus eget. Mauris tincidunt aliquam lectus sed vestibulum. Vestibulum bibendum suscipit mattis.</p>
                            <br />
                            <ul>
                                <li><i class=""fa fa-circle""></i> Praesent nec tincidunt turpis.</li>
                                <li><i class=""fa fa-circle""></i> Aliquam et nisi risus.&nbsp;Cras ut varius ante.</li>
                                <li><i class=""fa fa-circle""></i> Ut congue gravida dolor, vitae viverra dolor.</li>
                            </ul>
                            <br />
                            <ul class=""store_info"">
                                <li><i class=""fa fa-home""></i>");
            EndContext();
            BeginContext(2650, 21, false);
#line 54 "E:\Web_Developer\Practice\BackEnd\dotnetcore\ShopApplication\ShopApplication\Views\Contact\Index.cshtml"
                                                         Write(Model.Contact.Address);

#line default
#line hidden
            EndContext();
            BeginContext(2671, 76, true);
            WriteLiteral("</li>\r\n                                <li><i class=\"fa fa-phone\"></i><span>");
            EndContext();
            BeginContext(2748, 19, false);
#line 55 "E:\Web_Developer\Practice\BackEnd\dotnetcore\ShopApplication\ShopApplication\Views\Contact\Index.cshtml"
                                                                Write(Model.Contact.Phone);

#line default
#line hidden
            EndContext();
            BeginContext(2767, 95, true);
            WriteLiteral("</span></li>\r\n                                <li><i class=\"fa fa-envelope\"></i>Email: <span><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2862, "\"", 2896, 2);
            WriteAttributeValue("", 2869, "mailto:", 2869, 7, true);
#line 56 "E:\Web_Developer\Practice\BackEnd\dotnetcore\ShopApplication\ShopApplication\Views\Contact\Index.cshtml"
WriteAttributeValue("", 2876, Model.Contact.Email, 2876, 20, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2897, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(2899, 19, false);
#line 56 "E:\Web_Developer\Practice\BackEnd\dotnetcore\ShopApplication\ShopApplication\Views\Contact\Index.cshtml"
                                                                                                                Write(Model.Contact.Email);

#line default
#line hidden
            EndContext();
            BeginContext(2918, 133, true);
            WriteLiteral("</a></span></li>\r\n                            </ul>\r\n                        </div>\r\n                        <div class=\"col-sm-6\">\r\n");
            EndContext();
#line 60 "E:\Web_Developer\Practice\BackEnd\dotnetcore\ShopApplication\ShopApplication\Views\Contact\Index.cshtml"
                             if (ViewData["Success"] != null)
                            {

                                if ((bool)ViewData["Success"] == true)
                                {

#line default
#line hidden
            BeginContext(3254, 224, true);
            WriteLiteral("                                    <div class=\"alert alert-success\">\r\n                                        Thank you for your feedback. We are going to reply your order soon.\r\n                                    </div>\r\n");
            EndContext();
#line 68 "E:\Web_Developer\Practice\BackEnd\dotnetcore\ShopApplication\ShopApplication\Views\Contact\Index.cshtml"

                                }
                                else
                                {

#line default
#line hidden
            BeginContext(3588, 229, true);
            WriteLiteral("                                    <div class=\"alert alert-danger\">\r\n                                        Have an error in send feedback progress. Please contact to administrator.\r\n                                    </div>\r\n");
            EndContext();
#line 75 "E:\Web_Developer\Practice\BackEnd\dotnetcore\ShopApplication\ShopApplication\Views\Contact\Index.cshtml"

                                }


                            }
                            else
                            {

#line default
#line hidden
            BeginContext(3954, 119, true);
            WriteLiteral("                                <div id=\"map\" style=\"width:100%;height:500px;\"></div>\r\n                                ");
            EndContext();
            BeginContext(4073, 1737, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1d430a6146f54b5dbc5fa3056f259819", async() => {
                BeginContext(4116, 124, true);
                WriteLiteral("\r\n                                    <h3 class=\"page-subheading\">Make an enquiry</h3>\r\n                                    ");
                EndContext();
                BeginContext(4240, 60, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "140550ee236c4b7b8f51fcdbe7b01497", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
#line 85 "E:\Web_Developer\Practice\BackEnd\dotnetcore\ShopApplication\ShopApplication\Views\Contact\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary = global::Microsoft.AspNetCore.Mvc.Rendering.ValidationSummary.All;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-summary", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4300, 38, true);
                WriteLiteral("\r\n                                    ");
                EndContext();
                BeginContext(4339, 23, false);
#line 86 "E:\Web_Developer\Practice\BackEnd\dotnetcore\ShopApplication\ShopApplication\Views\Contact\Index.cshtml"
                               Write(Html.AntiForgeryToken());

#line default
#line hidden
                EndContext();
                BeginContext(4362, 248, true);
                WriteLiteral("\r\n                                    <div class=\"contact-form-box\">\r\n                                        <div class=\"form-selector\">\r\n                                            <label>Name</label>\r\n                                            ");
                EndContext();
                BeginContext(4610, 75, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e519b815b51640ea8bdf8738a3f70859", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
#line 90 "E:\Web_Developer\Practice\BackEnd\dotnetcore\ShopApplication\ShopApplication\Views\Contact\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Feedback.Name);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4685, 229, true);
                WriteLiteral("\r\n                                        </div>\r\n                                        <div class=\"form-selector\">\r\n                                            <label>Email</label>\r\n                                            ");
                EndContext();
                BeginContext(4914, 76, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "684f6dd9dbf24996a6bdfa26ddca3e72", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
#line 94 "E:\Web_Developer\Practice\BackEnd\dotnetcore\ShopApplication\ShopApplication\Views\Contact\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Feedback.Email);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4990, 231, true);
                WriteLiteral("\r\n                                        </div>\r\n                                        <div class=\"form-selector\">\r\n                                            <label>Message</label>\r\n                                            ");
                EndContext();
                BeginContext(5221, 88, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("textarea", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3e9d24b1817d4a42b7e92efcd96af5e1", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.TextAreaTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
#line 98 "E:\Web_Developer\Practice\BackEnd\dotnetcore\ShopApplication\ShopApplication\Views\Contact\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Feedback.Message);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(5309, 494, true);
                WriteLiteral(@"
                                        </div>
                                        <div class=""form-selector"">
                                            <button type=""submit"" class=""button""><i class=""icon-paper-plane icons""></i>&nbsp; <span>Send Message</span></button>
                                            &nbsp; <a href=""#"" class=""button"">Clear</a>
                                        </div>
                                    </div>
                                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5810, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 106 "E:\Web_Developer\Practice\BackEnd\dotnetcore\ShopApplication\ShopApplication\Views\Contact\Index.cshtml"

                            }

#line default
#line hidden
            BeginContext(5845, 177, true);
            WriteLiteral("                        </div>\r\n                    </div>\r\n                </div>\r\n            </section>\r\n        </div>\r\n    </div>\r\n</section>\r\n<!-- Main Container End -->\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ContactPageViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
