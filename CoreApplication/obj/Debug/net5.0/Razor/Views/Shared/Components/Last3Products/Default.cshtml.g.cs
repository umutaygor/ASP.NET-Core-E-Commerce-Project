#pragma checksum "C:\Users\umuta\source\repos\CoreApplication\CoreApplication\Views\Shared\Components\Last3Products\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "86eb02535f5bee35884458cc7a967f5933dfa35b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Last3Products_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Last3Products/Default.cshtml")]
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
#line 1 "C:\Users\umuta\source\repos\CoreApplication\CoreApplication\Views\_ViewImports.cshtml"
using CoreApplication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\umuta\source\repos\CoreApplication\CoreApplication\Views\_ViewImports.cshtml"
using CoreApplication.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\umuta\source\repos\CoreApplication\CoreApplication\Views\Shared\Components\Last3Products\Default.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"86eb02535f5bee35884458cc7a967f5933dfa35b", @"/Views/Shared/Components/Last3Products/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e310b9187167501f1b65764b597aab6fdccabea1", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Last3Products_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Product>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Theme/web/images/4.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-img-top img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("<div class=\"tech-btm\">\r\n    <h3>Latest Posts</h3>\r\n");
#nullable restore
#line 5 "C:\Users\umuta\source\repos\CoreApplication\CoreApplication\Views\Shared\Components\Last3Products\Default.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"blog-grids row mb-3\">\r\n        <div class=\"col-md-5 blog-grid-left\">\r\n            <a");
            BeginWriteAttribute("href", " href=\"", 243, "\"", 289, 2);
            WriteAttributeValue("", 250, "/Product/ProductReadAll/", 250, 24, true);
#nullable restore
#line 9 "C:\Users\umuta\source\repos\CoreApplication\CoreApplication\Views\Shared\Components\Last3Products\Default.cshtml"
WriteAttributeValue("", 274, item.ProductID, 274, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "86eb02535f5bee35884458cc7a967f5933dfa35b5477", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
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
            WriteLiteral("\r\n            </a>\r\n        </div>\r\n        <div class=\"col-md-7 blog-grid-right\">\r\n\r\n            <h5>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 505, "\"", 551, 2);
            WriteAttributeValue("", 512, "/Product/ProductReadAll/", 512, 24, true);
#nullable restore
#line 16 "C:\Users\umuta\source\repos\CoreApplication\CoreApplication\Views\Shared\Components\Last3Products\Default.cshtml"
WriteAttributeValue("", 536, item.ProductID, 536, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 16 "C:\Users\umuta\source\repos\CoreApplication\CoreApplication\Views\Shared\Components\Last3Products\Default.cshtml"
                                                             Write(item.ProductContent.Substring(0, item.ProductContent.Substring(0, 50).LastIndexOf(" ")));

#line default
#line hidden
#nullable disable
            WriteLiteral("...</a>\r\n            </h5>\r\n            <div class=\"sub-meta\">\r\n                <span>\r\n                    <i class=\"far fa-clock\"></i>");
#nullable restore
#line 20 "C:\Users\umuta\source\repos\CoreApplication\CoreApplication\Views\Shared\Components\Last3Products\Default.cshtml"
                                            Write(((DateTime)item.ProductCreateDate).ToString("dd-MMM-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </span>\r\n            </div>\r\n        </div>\r\n\r\n    </div>\r\n");
#nullable restore
#line 26 "C:\Users\umuta\source\repos\CoreApplication\CoreApplication\Views\Shared\Components\Last3Products\Default.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
