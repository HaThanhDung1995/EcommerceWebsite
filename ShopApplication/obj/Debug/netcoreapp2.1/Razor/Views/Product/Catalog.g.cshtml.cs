#pragma checksum "E:\Web_Developer\Practice\BackEnd\dotnetcore\ShopApplication\ShopApplication\Views\Product\Catalog.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4a2a5e7de8734674ef9923e28ae744a8deb28fb1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Catalog), @"mvc.1.0.view", @"/Views/Product/Catalog.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Product/Catalog.cshtml", typeof(AspNetCore.Views_Product_Catalog))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4a2a5e7de8734674ef9923e28ae744a8deb28fb1", @"/Views/Product/Catalog.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c6917980a95311f35f324cd854419d4a3c81b13d", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Catalog : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ShopApplication.Models.ProductViewModels.CatalogViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "sortBy", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onchange", new global::Microsoft.AspNetCore.Html.HtmlString("this.form.submit()"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "pageSize", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "E:\Web_Developer\Practice\BackEnd\dotnetcore\ShopApplication\ShopApplication\Views\Product\Catalog.cshtml"
  
    ViewData["Title"] = Model.Data.CurrentPage == 1 ? Model.Category.Name : Model.Category.Name + " - Page " + Model.Data.CurrentPage;
    ViewData["MetaKeyword"] = Model.Data.CurrentPage == 1 ? Model.Category.SeoKeywords : Model.Category.SeoKeywords + " - Page " + Model.Data.CurrentPage;
    ViewData["MetaDescription"] = Model.Data.CurrentPage == 1 ? Model.Category.SeoDescription : Model.Category.SeoDescription + " - Page " + Model.Data.CurrentPage;

#line default
#line hidden
            BeginContext(531, 314, true);
            WriteLiteral(@"<!-- Breadcrumbs -->
<div class=""breadcrumbs"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-xs-12"">
                <ul>
                    <li class=""home""> <a title=""Go to Home Page"" href=""index.html"">Home</a><span>&raquo;</span></li>
                    <li><strong>");
            EndContext();
            BeginContext(846, 19, false);
#line 14 "E:\Web_Developer\Practice\BackEnd\dotnetcore\ShopApplication\ShopApplication\Views\Product\Catalog.cshtml"
                           Write(Model.Category.Name);

#line default
#line hidden
            EndContext();
            BeginContext(865, 533, true);
            WriteLiteral(@"</strong></li>
                </ul>
            </div>
        </div>
    </div>
</div>
<!-- Breadcrumbs End -->
<!-- Main Container -->
<div class=""main-container col1-layout"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-main col-sm-12 col-xs-12"">
                <div class=""shop-inner"">
                    <div class=""page-title"">
                        <h2>iPhone 6</h2>
                    </div>
                    <div class=""toolbar column"">
                        ");
            EndContext();
            BeginContext(1398, 901, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8479618c9e4d4820a911d2ced6f34858", async() => {
                BeginContext(1480, 205, true);
                WriteLiteral("\r\n                            <div class=\"sorter\">\r\n                                <div class=\"short-by\">\r\n                                    <label>Sort By:</label>\r\n                                    ");
                EndContext();
                BeginContext(1685, 153, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f7e9ee3b67be4045a1fb174d5fbf6f3c", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Name = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 35 "E:\Web_Developer\Practice\BackEnd\dotnetcore\ShopApplication\ShopApplication\Views\Product\Catalog.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.SortType);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
#line 36 "E:\Web_Developer\Practice\BackEnd\dotnetcore\ShopApplication\ShopApplication\Views\Product\Catalog.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = Model.SortTypes;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1838, 197, true);
                WriteLiteral("\r\n                                </div>\r\n                                <div class=\"short-by page\">\r\n                                    <label>Show:</label>\r\n                                    ");
                EndContext();
                BeginContext(2035, 155, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a03e32d04d6e46dc9705c7190ecb561c", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Name = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
#line 40 "E:\Web_Developer\Practice\BackEnd\dotnetcore\ShopApplication\ShopApplication\Views\Product\Catalog.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.PageSize);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
#line 41 "E:\Web_Developer\Practice\BackEnd\dotnetcore\ShopApplication\ShopApplication\Views\Product\Catalog.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = Model.PageSizes;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2190, 102, true);
                WriteLiteral("\r\n                                </div>\r\n                            </div>\r\n                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 5, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1412, "/", 1412, 1, true);
#line 31 "E:\Web_Developer\Practice\BackEnd\dotnetcore\ShopApplication\ShopApplication\Views\Product\Catalog.cshtml"
AddHtmlAttributeValue("", 1413, Model.Category.SeoAlias, 1413, 24, false);

#line default
#line hidden
            AddHtmlAttributeValue("", 1437, "-c.", 1437, 3, true);
#line 31 "E:\Web_Developer\Practice\BackEnd\dotnetcore\ShopApplication\ShopApplication\Views\Product\Catalog.cshtml"
AddHtmlAttributeValue("", 1440, Model.Category.Id, 1440, 20, false);

#line default
#line hidden
            AddHtmlAttributeValue("", 1460, ".html", 1460, 5, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2299, 135, true);
            WriteLiteral("\r\n                    </div>\r\n                    <div class=\"product-grid-area\">\r\n                        <ul class=\"products-grid\">\r\n");
            EndContext();
#line 48 "E:\Web_Developer\Practice\BackEnd\dotnetcore\ShopApplication\ShopApplication\Views\Product\Catalog.cshtml"
                             foreach (var item in Model.Data.Results)
                            {
                                var url = "/" + item.SeoAlias + "-p." + item.Id + ".html";

#line default
#line hidden
            BeginContext(2628, 648, true);
            WriteLiteral(@"                                <li class=""item col-lg-3 col-md-4 col-sm-6 col-xs-6 "">
                                    <div class=""product-item"">
                                        <div class=""item-inner"">
                                            <div class=""product-thumbnail"">
                                                <div class=""icon-sale-label sale-left"">Sale</div>
                                                <div class=""icon-new-label new-right"">New</div>
                                                <div class=""pr-img-area"">
                                                    <a title=""Ipsums Dolors Untra""");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 3276, "\"", 3287, 1);
#line 58 "E:\Web_Developer\Practice\BackEnd\dotnetcore\ShopApplication\ShopApplication\Views\Product\Catalog.cshtml"
WriteAttributeValue("", 3283, url, 3283, 4, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3288, 90, true);
            WriteLiteral(">\r\n                                                        <figure> <img class=\"first-img\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 3378, "\"", 3395, 1);
#line 59 "E:\Web_Developer\Practice\BackEnd\dotnetcore\ShopApplication\ShopApplication\Views\Product\Catalog.cshtml"
WriteAttributeValue("", 3384, item.Image, 3384, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 3396, "\"", 3412, 1);
#line 59 "E:\Web_Developer\Practice\BackEnd\dotnetcore\ShopApplication\ShopApplication\Views\Product\Catalog.cshtml"
WriteAttributeValue("", 3402, item.Name, 3402, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3413, 24, true);
            WriteLiteral("> <img class=\"hover-img\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 3437, "\"", 3454, 1);
#line 59 "E:\Web_Developer\Practice\BackEnd\dotnetcore\ShopApplication\ShopApplication\Views\Product\Catalog.cshtml"
WriteAttributeValue("", 3443, item.Image, 3443, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 3455, "\"", 3471, 1);
#line 59 "E:\Web_Developer\Practice\BackEnd\dotnetcore\ShopApplication\ShopApplication\Views\Product\Catalog.cshtml"
WriteAttributeValue("", 3461, item.Name, 3461, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3472, 1152, true);
            WriteLiteral(@"></figure>
                                                    </a>
                                                </div>
                                                <div class=""pr-info-area"">
                                                    <div class=""pr-button"">
                                                        <div class=""mt-button add_to_wishlist""> <a href=""wishlist.html""> <i class=""fa fa-heart""></i> </a> </div>
                                                        <div class=""mt-button add_to_compare""> <a href=""compare.html""> <i class=""fa fa-signal""></i> </a> </div>
                                                        <div class=""mt-button quick-view""> <a href=""quick_view.html""> <i class=""fa fa-search""></i> </a> </div>
                                                    </div>
                                                </div>
                                            </div>
                                            <div class=""item-info"">
                         ");
            WriteLiteral("                       <div class=\"info-inner\">\r\n                                                    <div class=\"item-title\"> <a");
            EndContext();
            BeginWriteAttribute("title", " title=\"", 4624, "\"", 4642, 1);
#line 72 "E:\Web_Developer\Practice\BackEnd\dotnetcore\ShopApplication\ShopApplication\Views\Product\Catalog.cshtml"
WriteAttributeValue("", 4632, item.Name, 4632, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("href", " href=\"", 4643, "\"", 4654, 1);
#line 72 "E:\Web_Developer\Practice\BackEnd\dotnetcore\ShopApplication\ShopApplication\Views\Product\Catalog.cshtml"
WriteAttributeValue("", 4650, url, 4650, 4, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4655, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(4657, 9, false);
#line 72 "E:\Web_Developer\Practice\BackEnd\dotnetcore\ShopApplication\ShopApplication\Views\Product\Catalog.cshtml"
                                                                                                          Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(4666, 532, true);
            WriteLiteral(@"</a> </div>
                                                    <div class=""item-content"">
                                                        <div class=""rating""> <i class=""fa fa-star""></i> <i class=""fa fa-star""></i> <i class=""fa fa-star""></i> <i class=""fa fa-star-o""></i> <i class=""fa fa-star-o""></i> </div>
                                                        <div class=""item-price"">
                                                            <div class=""price-box""> <span class=""regular-price""> <span class=""price"">");
            EndContext();
            BeginContext(5199, 25, false);
#line 76 "E:\Web_Developer\Practice\BackEnd\dotnetcore\ShopApplication\ShopApplication\Views\Product\Catalog.cshtml"
                                                                                                                                Write(item.Price.ToString("N0"));

#line default
#line hidden
            EndContext();
            BeginContext(5224, 281, true);
            WriteLiteral(@"</span> </span> </div>
                                                        </div>
                                                        <div class=""pro-action"">
                                                            <button type=""button"" class=""add-to-cart"" data-id=""");
            EndContext();
            BeginContext(5506, 7, false);
#line 79 "E:\Web_Developer\Practice\BackEnd\dotnetcore\ShopApplication\ShopApplication\Views\Product\Catalog.cshtml"
                                                                                                          Write(item.Id);

#line default
#line hidden
            EndContext();
            BeginContext(5513, 402, true);
            WriteLiteral(@"""><span> Add to Cart</span> </button>
                                                        </div>
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </li>
");
            EndContext();
#line 87 "E:\Web_Developer\Practice\BackEnd\dotnetcore\ShopApplication\ShopApplication\Views\Product\Catalog.cshtml"

                            }

#line default
#line hidden
            BeginContext(5948, 81, true);
            WriteLiteral("\r\n                        </ul>\r\n                    </div>\r\n                    ");
            EndContext();
            BeginContext(6031, 47, false);
#line 92 "E:\Web_Developer\Practice\BackEnd\dotnetcore\ShopApplication\ShopApplication\Views\Product\Catalog.cshtml"
                Write(await Component.InvokeAsync("Pager",Model.Data));

#line default
#line hidden
            EndContext();
            BeginContext(6079, 110, true);
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n<!-- Main Container End --> ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ShopApplication.Models.ProductViewModels.CatalogViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
