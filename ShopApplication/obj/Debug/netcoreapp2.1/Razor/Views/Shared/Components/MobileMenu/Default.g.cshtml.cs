#pragma checksum "E:\Web_Developer\Practice\BackEnd\dotnetcore\ShopApplication\ShopApplication\Views\Shared\Components\MobileMenu\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6c37edd393beaf354e499e2eacc3a32cdb1908ea"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_MobileMenu_Default), @"mvc.1.0.view", @"/Views/Shared/Components/MobileMenu/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/MobileMenu/Default.cshtml", typeof(AspNetCore.Views_Shared_Components_MobileMenu_Default))]
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
#line 1 "E:\Web_Developer\Practice\BackEnd\dotnetcore\ShopApplication\ShopApplication\Views\Shared\Components\MobileMenu\Default.cshtml"
using ShopApplication.Application.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6c37edd393beaf354e499e2eacc3a32cdb1908ea", @"/Views/Shared/Components/MobileMenu/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c6917980a95311f35f324cd854419d4a3c81b13d", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_MobileMenu_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ShopApplication.Application.ViewModels.ProductCategoryViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(125, 194, true);
            WriteLiteral("<div id=\"mobile-menu\">\r\n    <ul>\r\n        <li>\r\n            <a href=\"/\" class=\"home1\">Home</a>\r\n        </li>\r\n        <li>\r\n            <a href=\"/products.html\">Products</a>\r\n            <ul>\r\n");
            EndContext();
#line 11 "E:\Web_Developer\Practice\BackEnd\dotnetcore\ShopApplication\ShopApplication\Views\Shared\Components\MobileMenu\Default.cshtml"
                 foreach (var item in Model.Where(x => x.ParentId == null))
                {

#line default
#line hidden
            BeginContext(415, 52, true);
            WriteLiteral("                    <li>\r\n                        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 467, "\"", 507, 5);
            WriteAttributeValue("", 474, "/", 474, 1, true);
#line 14 "E:\Web_Developer\Practice\BackEnd\dotnetcore\ShopApplication\ShopApplication\Views\Shared\Components\MobileMenu\Default.cshtml"
WriteAttributeValue("", 475, item.SeoAlias, 475, 14, false);

#line default
#line hidden
            WriteAttributeValue("", 489, "-c.", 489, 3, true);
#line 14 "E:\Web_Developer\Practice\BackEnd\dotnetcore\ShopApplication\ShopApplication\Views\Shared\Components\MobileMenu\Default.cshtml"
WriteAttributeValue("", 492, item.Id, 492, 10, false);

#line default
#line hidden
            WriteAttributeValue("", 502, ".html", 502, 5, true);
            EndWriteAttribute();
            BeginContext(508, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(510, 9, false);
#line 14 "E:\Web_Developer\Practice\BackEnd\dotnetcore\ShopApplication\ShopApplication\Views\Shared\Components\MobileMenu\Default.cshtml"
                                                               Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(519, 7, true);
            WriteLiteral(" </a>\r\n");
            EndContext();
#line 15 "E:\Web_Developer\Practice\BackEnd\dotnetcore\ShopApplication\ShopApplication\Views\Shared\Components\MobileMenu\Default.cshtml"
                         if (Model.Any(x => x.ParentId == item.Id))
                        {

#line default
#line hidden
            BeginContext(622, 34, true);
            WriteLiteral("                            <ul>\r\n");
            EndContext();
#line 18 "E:\Web_Developer\Practice\BackEnd\dotnetcore\ShopApplication\ShopApplication\Views\Shared\Components\MobileMenu\Default.cshtml"
                                 foreach (var subItem in Model.Where(x => x.ParentId == item.Id))
                                {

#line default
#line hidden
            BeginContext(790, 42, true);
            WriteLiteral("                                    <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 832, "\"", 878, 5);
            WriteAttributeValue("", 839, "/", 839, 1, true);
#line 20 "E:\Web_Developer\Practice\BackEnd\dotnetcore\ShopApplication\ShopApplication\Views\Shared\Components\MobileMenu\Default.cshtml"
WriteAttributeValue("", 840, subItem.SeoAlias, 840, 17, false);

#line default
#line hidden
            WriteAttributeValue("", 857, "-c.", 857, 3, true);
#line 20 "E:\Web_Developer\Practice\BackEnd\dotnetcore\ShopApplication\ShopApplication\Views\Shared\Components\MobileMenu\Default.cshtml"
WriteAttributeValue("", 860, subItem.Id, 860, 13, false);

#line default
#line hidden
            WriteAttributeValue("", 873, ".html", 873, 5, true);
            EndWriteAttribute();
            BeginContext(879, 7, true);
            WriteLiteral("><span>");
            EndContext();
            BeginContext(887, 12, false);
#line 20 "E:\Web_Developer\Practice\BackEnd\dotnetcore\ShopApplication\ShopApplication\Views\Shared\Components\MobileMenu\Default.cshtml"
                                                                                           Write(subItem.Name);

#line default
#line hidden
            EndContext();
            BeginContext(899, 18, true);
            WriteLiteral("</span></a></li>\r\n");
            EndContext();
#line 21 "E:\Web_Developer\Practice\BackEnd\dotnetcore\ShopApplication\ShopApplication\Views\Shared\Components\MobileMenu\Default.cshtml"
                                }

#line default
#line hidden
            BeginContext(952, 35, true);
            WriteLiteral("                            </ul>\r\n");
            EndContext();
#line 23 "E:\Web_Developer\Practice\BackEnd\dotnetcore\ShopApplication\ShopApplication\Views\Shared\Components\MobileMenu\Default.cshtml"
                        }

#line default
#line hidden
            BeginContext(1014, 29, true);
            WriteLiteral("\r\n                    </li>\r\n");
            EndContext();
#line 26 "E:\Web_Developer\Practice\BackEnd\dotnetcore\ShopApplication\ShopApplication\Views\Shared\Components\MobileMenu\Default.cshtml"
                }

#line default
#line hidden
            BeginContext(1062, 53, true);
            WriteLiteral("            </ul>\r\n        </li>\r\n\r\n    </ul>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ShopApplication.Application.ViewModels.ProductCategoryViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
