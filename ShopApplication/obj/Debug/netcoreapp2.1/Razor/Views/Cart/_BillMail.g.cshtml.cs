#pragma checksum "E:\Web_Developer\Practice\BackEnd\dotnetcore\ShopApplication\ShopApplication\Views\Cart\_BillMail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b448fce09211de86e34ee8e0f165d7c7219d9192"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cart__BillMail), @"mvc.1.0.view", @"/Views/Cart/_BillMail.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Cart/_BillMail.cshtml", typeof(AspNetCore.Views_Cart__BillMail))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b448fce09211de86e34ee8e0f165d7c7219d9192", @"/Views/Cart/_BillMail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c6917980a95311f35f324cd854419d4a3c81b13d", @"/Views/_ViewImports.cshtml")]
    public class Views_Cart__BillMail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BillViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(142, 95, true);
            WriteLiteral("\r\n<h1>Panda Shop new bill</h1>\r\n<table>\r\n    <tr>\r\n        <td>Customer Name</td>\r\n        <td>");
            EndContext();
            BeginContext(238, 18, false);
#line 9 "E:\Web_Developer\Practice\BackEnd\dotnetcore\ShopApplication\ShopApplication\Views\Cart\_BillMail.cshtml"
       Write(Model.CustomerName);

#line default
#line hidden
            EndContext();
            BeginContext(256, 66, true);
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <td>Address</td>\r\n        <td>");
            EndContext();
            BeginContext(323, 21, false);
#line 13 "E:\Web_Developer\Practice\BackEnd\dotnetcore\ShopApplication\ShopApplication\Views\Cart\_BillMail.cshtml"
       Write(Model.CustomerAddress);

#line default
#line hidden
            EndContext();
            BeginContext(344, 64, true);
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <td>Phone</td>\r\n        <td>");
            EndContext();
            BeginContext(409, 20, false);
#line 17 "E:\Web_Developer\Practice\BackEnd\dotnetcore\ShopApplication\ShopApplication\Views\Cart\_BillMail.cshtml"
       Write(Model.CustomerMobile);

#line default
#line hidden
            EndContext();
            BeginContext(429, 63, true);
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <td>Date</td>\r\n        <td>");
            EndContext();
            BeginContext(493, 46, false);
#line 21 "E:\Web_Developer\Practice\BackEnd\dotnetcore\ShopApplication\ShopApplication\Views\Cart\_BillMail.cshtml"
       Write(Model.DateCreated.ToString("dd/MM/yyyy hh:mm"));

#line default
#line hidden
            EndContext();
            BeginContext(539, 359, true);
            WriteLiteral(@"</td>
    </tr>
    <tr>
        <td>Details</td>
        <td>
            <table>
                <thead>
                <tr>
                    <th>Product</th>
                    <th>Quantity</th>
                    <th>Price</th>
                    <th>Total</th>
                </tr>
                </thead>
                <tbody>
");
            EndContext();
#line 36 "E:\Web_Developer\Practice\BackEnd\dotnetcore\ShopApplication\ShopApplication\Views\Cart\_BillMail.cshtml"
                 foreach (var item in Model.BillDetails)
                {

#line default
#line hidden
            BeginContext(975, 54, true);
            WriteLiteral("                    <tr>\r\n                        <td>");
            EndContext();
            BeginContext(1030, 17, false);
#line 39 "E:\Web_Developer\Practice\BackEnd\dotnetcore\ShopApplication\ShopApplication\Views\Cart\_BillMail.cshtml"
                       Write(item.Product.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1047, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(1083, 13, false);
#line 40 "E:\Web_Developer\Practice\BackEnd\dotnetcore\ShopApplication\ShopApplication\Views\Cart\_BillMail.cshtml"
                       Write(item.Quantity);

#line default
#line hidden
            EndContext();
            BeginContext(1096, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(1132, 10, false);
#line 41 "E:\Web_Developer\Practice\BackEnd\dotnetcore\ShopApplication\ShopApplication\Views\Cart\_BillMail.cshtml"
                       Write(item.Price);

#line default
#line hidden
            EndContext();
            BeginContext(1142, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(1179, 43, false);
#line 42 "E:\Web_Developer\Practice\BackEnd\dotnetcore\ShopApplication\ShopApplication\Views\Cart\_BillMail.cshtml"
                        Write((item.Quantity * item.Price).ToString("N0"));

#line default
#line hidden
            EndContext();
            BeginContext(1223, 34, true);
            WriteLiteral("</td>\r\n                    </tr>\r\n");
            EndContext();
#line 44 "E:\Web_Developer\Practice\BackEnd\dotnetcore\ShopApplication\ShopApplication\Views\Cart\_BillMail.cshtml"
                }

#line default
#line hidden
            BeginContext(1276, 142, true);
            WriteLiteral("                </tbody>\r\n                <tfoot>\r\n                <tr>\r\n                    <td colspan=\"5\">\r\n                        Total: ");
            EndContext();
            BeginContext(1419, 63, false);
#line 49 "E:\Web_Developer\Practice\BackEnd\dotnetcore\ShopApplication\ShopApplication\Views\Cart\_BillMail.cshtml"
                          Write(Model.BillDetails.Sum(x => x.Quantity * x.Price).ToString("N0"));

#line default
#line hidden
            EndContext();
            BeginContext(1482, 136, true);
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n                </tfoot>\r\n            </table>\r\n        </td>\r\n    </tr>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BillViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
