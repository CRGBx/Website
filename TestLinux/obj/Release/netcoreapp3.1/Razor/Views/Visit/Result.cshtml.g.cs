#pragma checksum "D:\Projects\Altered\TestLinux\TestLinux\Views\Visit\Result.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3061e9f9de73a9ccc82258c3a56b25493afc04cf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Visit_Result), @"mvc.1.0.view", @"/Views/Visit/Result.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3061e9f9de73a9ccc82258c3a56b25493afc04cf", @"/Views/Visit/Result.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9ee1afeccf8cd41b13d27f56638a8f8538165796", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Visit_Result : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "D:\Projects\Altered\TestLinux\TestLinux\Views\Visit\Result.cshtml"
  
    Layout = "_layout2.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 8 "D:\Projects\Altered\TestLinux\TestLinux\Views\Visit\Result.cshtml"
 if (ViewBag.Result == "OK")
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div style=""margin-top:15px;margin-left:15px;"" class=""d-flex justify-content-center""><i class=""bi bi-check-circle-fill"" style=""font-size: 8rem; color: cornflowerblue;""></i>
    <a href=""http://home/"" class=""btn btn-primary-sm"">
        Go To Home
    </a>    
    </div>
");
#nullable restore
#line 15 "D:\Projects\Altered\TestLinux\TestLinux\Views\Visit\Result.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <b>");
#nullable restore
#line 18 "D:\Projects\Altered\TestLinux\TestLinux\Views\Visit\Result.cshtml"
  Write(ViewBag.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</b>
    <div style=""margin-top:15px;margin-left:15px;"" class=""d-flex justify-content-center""><i class=""bi bi-x-circle-fill"" style=""font-size: 8rem; color: red;""></i>
    <a href=""http://home/"" class=""btn btn-primary-sm"">
        Go To Home
    </a>    
    </div>
");
#nullable restore
#line 24 "D:\Projects\Altered\TestLinux\TestLinux\Views\Visit\Result.cshtml"
}

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
