#pragma checksum "C:\Users\Mad Coder\Documents\Visual Studio 2017\Projects\BookStore\BookStore\Views\Book\Gallery.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4be74305c2f417f7c794081b470fc7e5126baa92"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Book_Gallery), @"mvc.1.0.view", @"/Views/Book/Gallery.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Book/Gallery.cshtml", typeof(AspNetCore.Views_Book_Gallery))]
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
#line 1 "C:\Users\Mad Coder\Documents\Visual Studio 2017\Projects\BookStore\BookStore\Views\_ViewImports.cshtml"
using BookStore;

#line default
#line hidden
#line 2 "C:\Users\Mad Coder\Documents\Visual Studio 2017\Projects\BookStore\BookStore\Views\_ViewImports.cshtml"
using BookStore.Models;

#line default
#line hidden
#line 3 "C:\Users\Mad Coder\Documents\Visual Studio 2017\Projects\BookStore\BookStore\Views\_ViewImports.cshtml"
using BookStore.Models.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4be74305c2f417f7c794081b470fc7e5126baa92", @"/Views/Book/Gallery.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ebfb66dd7688adb2b874a32236680b170c920090", @"/Views/_ViewImports.cshtml")]
    public class Views_Book_Gallery : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GalleryViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/shop-homepage.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Book/"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("list-group-item"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "ShopingCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddToShopingCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-box-cart"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(25, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Mad Coder\Documents\Visual Studio 2017\Projects\BookStore\BookStore\Views\Book\Gallery.cshtml"
  
ViewData["Title"] = "Gallery";

#line default
#line hidden
            BeginContext(66, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(68, 56, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c2fde63f0a554d99b425f6926f35c42c", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(124, 24, true);
            WriteLiteral("\r\n\r\n<h2>Gallery</h2>\r\n\r\n");
            EndContext();
            BeginContext(202, 76, true);
            WriteLiteral("\r\n<div class=\"row\">\r\n\r\n    <div class=\"col-md-3\" >\r\n        <p class=\"lead\">");
            EndContext();
            BeginContext(279, 21, false);
#line 18 "C:\Users\Mad Coder\Documents\Visual Studio 2017\Projects\BookStore\BookStore\Views\Book\Gallery.cshtml"
                   Write(Model.currentCategory);

#line default
#line hidden
            EndContext();
            BeginContext(300, 52, true);
            WriteLiteral("</p>\r\n        <div class=\"list-group\">\r\n            ");
            EndContext();
            BeginContext(352, 55, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "25db540f29d0464583c4dcdb8fadb828", async() => {
                BeginContext(394, 9, true);
                WriteLiteral("All Books");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(407, 14, true);
            WriteLiteral("\r\n            ");
            EndContext();
            BeginContext(422, 60, false);
#line 21 "C:\Users\Mad Coder\Documents\Visual Studio 2017\Projects\BookStore\BookStore\Views\Book\Gallery.cshtml"
       Write(await Html.PartialAsync("_CategorySideBar",Model.Categories));

#line default
#line hidden
            EndContext();
            BeginContext(482, 62, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"col-md-9\">\r\n\r\n");
            EndContext();
            BeginContext(2191, 29, true);
            WriteLiteral("\r\n        <div class=\"row\">\r\n");
            EndContext();
#line 59 "C:\Users\Mad Coder\Documents\Visual Studio 2017\Projects\BookStore\BookStore\Views\Book\Gallery.cshtml"
             foreach (var item in Model.Books)
            {

#line default
#line hidden
            BeginContext(2283, 182, true);
            WriteLiteral("                <div class=\"col-sm-4 col-lg-4 col-md-4\">\r\n                    <div class=\"thumbnail\">\r\n                        <div class=\"img-box\">\r\n                            <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 2465, "\"", 2496, 1);
#line 64 "C:\Users\Mad Coder\Documents\Visual Studio 2017\Projects\BookStore\BookStore\Views\Book\Gallery.cshtml"
WriteAttributeValue("", 2471, Url.Content(item.ImgUrl), 2471, 25, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2497, 38, true);
            WriteLiteral(" alt=\"\">\r\n                            ");
            EndContext();
            BeginContext(2535, 126, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c6de5ea0eb5842e895a57a2fc3899f9e", async() => {
                BeginContext(2646, 11, true);
                WriteLiteral("Add to Cart");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-bookId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 65 "C:\Users\Mad Coder\Documents\Visual Studio 2017\Projects\BookStore\BookStore\Views\Book\Gallery.cshtml"
                                                                                                WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["bookId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-bookId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["bookId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2661, 133, true);
            WriteLiteral("\r\n                        </div>\r\n                        <div class=\"caption\">\r\n                            <h4 class=\"pull-right\">$");
            EndContext();
            BeginContext(2795, 10, false);
#line 68 "C:\Users\Mad Coder\Documents\Visual Studio 2017\Projects\BookStore\BookStore\Views\Book\Gallery.cshtml"
                                               Write(item.Price);

#line default
#line hidden
            EndContext();
            BeginContext(2805, 85, true);
            WriteLiteral("</h4>\r\n                            <h4>\r\n                                <a href=\"#\">");
            EndContext();
            BeginContext(2891, 9, false);
#line 70 "C:\Users\Mad Coder\Documents\Visual Studio 2017\Projects\BookStore\BookStore\Views\Book\Gallery.cshtml"
                                       Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(2900, 160, true);
            WriteLiteral("</a>\r\n                            </h4>\r\n                            <h5>\r\n                                <a target=\"_blank\" href=\"http://www.fb.com/shbsovon\">");
            EndContext();
            BeginContext(3061, 11, false);
#line 73 "C:\Users\Mad Coder\Documents\Visual Studio 2017\Projects\BookStore\BookStore\Views\Book\Gallery.cshtml"
                                                                                Write(item.Author);

#line default
#line hidden
            EndContext();
            BeginContext(3072, 72, true);
            WriteLiteral("</a>\r\n                            </h5>\r\n                            <p>");
            EndContext();
            BeginContext(3145, 12, false);
#line 75 "C:\Users\Mad Coder\Documents\Visual Studio 2017\Projects\BookStore\BookStore\Views\Book\Gallery.cshtml"
                          Write(item.Details);

#line default
#line hidden
            EndContext();
            BeginContext(3157, 702, true);
            WriteLiteral(@"</p>
                        </div>
                        <div class=""ratings"">
                            <p class=""pull-right"">15 reviews</p>
                            <p>
                                <span class=""glyphicon glyphicon-star""></span>
                                <span class=""glyphicon glyphicon-star""></span>
                                <span class=""glyphicon glyphicon-star""></span>
                                <span class=""glyphicon glyphicon-star""></span>
                                <span class=""glyphicon glyphicon-star""></span>
                            </p>
                        </div>
                    </div>
                </div>
");
            EndContext();
#line 89 "C:\Users\Mad Coder\Documents\Visual Studio 2017\Projects\BookStore\BookStore\Views\Book\Gallery.cshtml"
            }

#line default
#line hidden
            BeginContext(3900, 44, true);
            WriteLiteral("\r\n\r\n        </div>\r\n\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GalleryViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
