#pragma checksum "D:\Projects\Altered\TestLinux\TestLinux\Views\Home\PageL.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "46246dbbbd76a6f72fd3b1c056c0db9d5226f099"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_PageL), @"mvc.1.0.view", @"/Views/Home/PageL.cshtml")]
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
#line 1 "D:\Projects\Altered\TestLinux\TestLinux\Views\_ViewImports.cshtml"
using TestLinux;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Projects\Altered\TestLinux\TestLinux\Views\_ViewImports.cshtml"
using TestLinux.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\Projects\Altered\TestLinux\TestLinux\Views\Home\PageL.cshtml"
using System.IO;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"46246dbbbd76a6f72fd3b1c056c0db9d5226f099", @"/Views/Home/PageL.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9ee1afeccf8cd41b13d27f56638a8f8538165796", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_PageL : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 6 "D:\Projects\Altered\TestLinux\TestLinux\Views\Home\PageL.cshtml"
  
    Layout = "~/Views/Shared/_LayoutL.cshtml";
    string contents = "Invalid Link , Contact Administrator";
    using (var reader = new StreamReader(ViewBag.Id))
    {
        contents = reader.ReadToEnd();
    }


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 17 "D:\Projects\Altered\TestLinux\TestLinux\Views\Home\PageL.cshtml"
Write(Html.Raw(contents));

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591