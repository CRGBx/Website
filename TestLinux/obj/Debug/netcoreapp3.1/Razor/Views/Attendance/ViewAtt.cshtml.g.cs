#pragma checksum "D:\Projects\Altered\TestLinux\TestLinux\Views\Attendance\ViewAtt.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "45c7bf4d660075b8ef0731a97f7b498f01b3c10a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Attendance_ViewAtt), @"mvc.1.0.view", @"/Views/Attendance/ViewAtt.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"45c7bf4d660075b8ef0731a97f7b498f01b3c10a", @"/Views/Attendance/ViewAtt.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9ee1afeccf8cd41b13d27f56638a8f8538165796", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Attendance_ViewAtt : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<AttendanceProfie>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 5 "D:\Projects\Altered\TestLinux\TestLinux\Views\Attendance\ViewAtt.cshtml"
  
    Layout = "_Layout2.cshtml";
    int sno = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<table class=\"table table-responsive-sm table-bordered\">\r\n    <thead>\r\n        <tr>\r\n            <th>S.No.</th>\r\n            <th>Date</th>\r\n            <th>Attendance</th>\r\n            <th>Remark</th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 20 "D:\Projects\Altered\TestLinux\TestLinux\Views\Attendance\ViewAtt.cshtml"
     foreach (var item in Model)
	{
        sno++;

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t<tr>\r\n            <td>");
#nullable restore
#line 24 "D:\Projects\Altered\TestLinux\TestLinux\Views\Attendance\ViewAtt.cshtml"
           Write(sno);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 25 "D:\Projects\Altered\TestLinux\TestLinux\Views\Attendance\ViewAtt.cshtml"
           Write(item.ForDate.ToString("dd-MM-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>   \r\n\r\n            <td>");
#nullable restore
#line 27 "D:\Projects\Altered\TestLinux\TestLinux\Views\Attendance\ViewAtt.cshtml"
           Write(item.Attendance);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 28 "D:\Projects\Altered\TestLinux\TestLinux\Views\Attendance\ViewAtt.cshtml"
           Write(item.Remarks);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n");
#nullable restore
#line 30 "D:\Projects\Altered\TestLinux\TestLinux\Views\Attendance\ViewAtt.cshtml"
	}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<AttendanceProfie>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
