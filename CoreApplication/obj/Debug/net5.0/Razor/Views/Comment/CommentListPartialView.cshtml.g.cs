#pragma checksum "C:\Users\umuta\source\repos\CoreApplication\CoreApplication\Views\Comment\CommentListPartialView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "31bdf359c70cb12c47e76432a93cd1939450e333"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Comment_CommentListPartialView), @"mvc.1.0.view", @"/Views/Comment/CommentListPartialView.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"31bdf359c70cb12c47e76432a93cd1939450e333", @"/Views/Comment/CommentListPartialView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e310b9187167501f1b65764b597aab6fdccabea1", @"/Views/_ViewImports.cshtml")]
    public class Views_Comment_CommentListPartialView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<EntityLayer.Concrete.Comment>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"comment-top\">\r\n    <h4>Comments</h4>\r\n");
#nullable restore
#line 4 "C:\Users\umuta\source\repos\CoreApplication\CoreApplication\Views\Comment\CommentListPartialView.cshtml"
     foreach(var item in Model){

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"media\">\r\n        <img src=\"images/t1.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 191, "\"", 197, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"img-fluid\" />\r\n        <div class=\"media-body\">\r\n            <h5 class=\"mt-0\">");
#nullable restore
#line 8 "C:\Users\umuta\source\repos\CoreApplication\CoreApplication\Views\Comment\CommentListPartialView.cshtml"
                        Write(item.CommentUsername);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n            <p>\r\n                ");
#nullable restore
#line 10 "C:\Users\umuta\source\repos\CoreApplication\CoreApplication\Views\Comment\CommentListPartialView.cshtml"
           Write(item.CommentContent);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </p>\r\n\r\n            <div class=\"media mt-3\">\r\n                <a class=\"d-flex pr-3\" href=\"#\">\r\n                    <img src=\"images/t2.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 519, "\"", 525, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""img-fluid"" />
                </a>
                <div class=""media-body"">
                    <h5 class=""mt-0"">Richard Spark</h5>
                    <p>
                        Lorem Ipsum convallis diam consequat magna vulputate malesuada. id dignissim sapien velit id felis ac cursus eros.
                        Cras a ornare elit.
                    </p>
                </div>
            </div>
        </div>
    </div>
");
#nullable restore
#line 27 "C:\Users\umuta\source\repos\CoreApplication\CoreApplication\Views\Comment\CommentListPartialView.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<EntityLayer.Concrete.Comment>> Html { get; private set; }
    }
}
#pragma warning restore 1591
