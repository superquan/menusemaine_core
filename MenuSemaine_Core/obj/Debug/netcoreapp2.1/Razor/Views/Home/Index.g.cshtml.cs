#pragma checksum "E:\Github\menusemaine_core\MenuSemaine_Core\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "657133d64cb3865572f5df0999524811f0c4788f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "E:\Github\menusemaine_core\MenuSemaine_Core\Views\_ViewImports.cshtml"
using MenuSemaine_Core;

#line default
#line hidden
#line 2 "E:\Github\menusemaine_core\MenuSemaine_Core\Views\_ViewImports.cshtml"
using MenuSemaine_Core.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"657133d64cb3865572f5df0999524811f0c4788f", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9f30b1c4a3fccf6ae8281e2cac75dfad0e2ba388", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MenuSemaine_Core.Models.Plat>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(50, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "E:\Github\menusemaine_core\MenuSemaine_Core\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(97, 29, true);
            WriteLiteral("\r\n<h1>Hello world 2019</h1>\r\n");
            EndContext();
#line 8 "E:\Github\menusemaine_core\MenuSemaine_Core\Views\Home\Index.cshtml"
 if (Model.Count() > 0)
{

#line default
#line hidden
            BeginContext(154, 238, true);
            WriteLiteral("    <table class=\"table table-striped rounded bg-light\">\r\n        <thead>\r\n            <tr>\r\n                <th>ID</th>\r\n                <th>Name</th>\r\n                <th>Type</th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
            EndContext();
#line 19 "E:\Github\menusemaine_core\MenuSemaine_Core\Views\Home\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
            BeginContext(449, 46, true);
            WriteLiteral("                <tr>\r\n                    <td>");
            EndContext();
            BeginContext(496, 7, false);
#line 22 "E:\Github\menusemaine_core\MenuSemaine_Core\Views\Home\Index.cshtml"
                   Write(item.ID);

#line default
#line hidden
            EndContext();
            BeginContext(503, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(535, 9, false);
#line 23 "E:\Github\menusemaine_core\MenuSemaine_Core\Views\Home\Index.cshtml"
                   Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(544, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(576, 9, false);
#line 24 "E:\Github\menusemaine_core\MenuSemaine_Core\Views\Home\Index.cshtml"
                   Write(item.Type);

#line default
#line hidden
            EndContext();
            BeginContext(585, 30, true);
            WriteLiteral("</td>\r\n                </tr>\r\n");
            EndContext();
#line 26 "E:\Github\menusemaine_core\MenuSemaine_Core\Views\Home\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(630, 32, true);
            WriteLiteral("        </tbody>\r\n    </table>\r\n");
            EndContext();
#line 29 "E:\Github\menusemaine_core\MenuSemaine_Core\Views\Home\Index.cshtml"
}
else
{

#line default
#line hidden
            BeginContext(674, 46, true);
            WriteLiteral("    <p>\r\n        <h1>Not data</h1>\r\n    </p>\r\n");
            EndContext();
#line 35 "E:\Github\menusemaine_core\MenuSemaine_Core\Views\Home\Index.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MenuSemaine_Core.Models.Plat>> Html { get; private set; }
    }
}
#pragma warning restore 1591
