#pragma checksum "E:\Github\menusemaine_core\MenuSemaine_Core\Views\Shared\Components\ListPlats\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e707f11ddf92d1f064c38f21de0b88a117e66776"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_ListPlats_Default), @"mvc.1.0.view", @"/Views/Shared/Components/ListPlats/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/ListPlats/Default.cshtml", typeof(AspNetCore.Views_Shared_Components_ListPlats_Default))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e707f11ddf92d1f064c38f21de0b88a117e66776", @"/Views/Shared/Components/ListPlats/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9f30b1c4a3fccf6ae8281e2cac75dfad0e2ba388", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_ListPlats_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MenuSemaine_Core.Models.Plat>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(50, 27, true);
            WriteLiteral("\r\n<ul class=\"list-group\">\r\n");
            EndContext();
#line 4 "E:\Github\menusemaine_core\MenuSemaine_Core\Views\Shared\Components\ListPlats\Default.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
            BeginContext(118, 79, true);
            WriteLiteral("        <li class=\"list-group-item list-group-item-action\">\r\n            <span>");
            EndContext();
            BeginContext(198, 9, false);
#line 7 "E:\Github\menusemaine_core\MenuSemaine_Core\Views\Shared\Components\ListPlats\Default.cshtml"
             Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(207, 24, true);
            WriteLiteral("</span>\r\n        </li>\r\n");
            EndContext();
#line 9 "E:\Github\menusemaine_core\MenuSemaine_Core\Views\Shared\Components\ListPlats\Default.cshtml"
    }

#line default
#line hidden
            BeginContext(238, 5, true);
            WriteLiteral("</ul>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MenuSemaine_Core.Models.Plat>> Html { get; private set; }
    }
}
#pragma warning restore 1591
