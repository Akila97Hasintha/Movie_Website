#pragma checksum "D:\Movie web\movie_web\movie_web\Views\Actors\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "db4806041ba13a68c1be3a926ee5f66111bcdb84"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Actors_Index), @"mvc.1.0.view", @"/Views/Actors/Index.cshtml")]
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
#line 1 "D:\Movie web\movie_web\movie_web\Views\_ViewImports.cshtml"
using movie_web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Movie web\movie_web\movie_web\Views\_ViewImports.cshtml"
using movie_web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"db4806041ba13a68c1be3a926ee5f66111bcdb84", @"/Views/Actors/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d25fecc91284788cb4b61e865cc24a4a27152c22", @"/Views/_ViewImports.cshtml")]
    public class Views_Actors_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<movie_web.Models.Actor>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 4 "D:\Movie web\movie_web\movie_web\Views\Actors\Index.cshtml"
   
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-md-8 offset-md-2\">\r\n        <table class=\"table\">\r\n            <thead>\r\n                <tr>\r\n                    <th>");
#nullable restore
#line 13 "D:\Movie web\movie_web\movie_web\Views\Actors\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.ProfilePictueUrl));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                    <th>");
#nullable restore
#line 14 "D:\Movie web\movie_web\movie_web\Views\Actors\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.FullName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                    <th>");
#nullable restore
#line 15 "D:\Movie web\movie_web\movie_web\Views\Actors\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Bio));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                    <th>Actions</th>\r\n                </tr>\r\n            </thead>\r\n            <tbody>\r\n");
#nullable restore
#line 20 "D:\Movie web\movie_web\movie_web\Views\Actors\Index.cshtml"
                 foreach(var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td class=\"align-middle\">\r\n                        <img class=\"rounded-circle\"");
            BeginWriteAttribute("src", " src=\"", 740, "\"", 768, 1);
#nullable restore
#line 24 "D:\Movie web\movie_web\movie_web\Views\Actors\Index.cshtml"
WriteAttributeValue("", 746, item.ProfilePictueUrl, 746, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 769, "\"", 789, 1);
#nullable restore
#line 24 "D:\Movie web\movie_web\movie_web\Views\Actors\Index.cshtml"
WriteAttributeValue("", 775, item.FullName, 775, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"max-width: 150px\" />\r\n                    </td>\r\n                    <td class=\"align-middle\">\r\n                        ");
#nullable restore
#line 27 "D:\Movie web\movie_web\movie_web\Views\Actors\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.FullName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td class=\"align-middle\">\r\n                        ");
#nullable restore
#line 30 "D:\Movie web\movie_web\movie_web\Views\Actors\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Bio));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </td>
                    <td class=""align-middle"">
                        <a class=""btn btn-outline-primary"">
                            <i class=""bi bi-pencil-square"">Edit</i>
                        </a>|
                        <a class=""btn btn-outline-info"">
                            <i class=""bi bi-pencil-square"">Detais</i>
                        </a>|
                        <a class=""btn btn-danger"">
                            <i class=""bi bi-trash"">Delete</i>
                        </a>|
                    </td>
                </tr>
");
#nullable restore
#line 44 "D:\Movie web\movie_web\movie_web\Views\Actors\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<movie_web.Models.Actor>> Html { get; private set; }
    }
}
#pragma warning restore 1591
