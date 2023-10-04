#pragma checksum "D:\Projects\Altered\TestLinux\TestLinux\Views\Deaf\FetchList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f5824273132ba9dfabf004c69fde0c3633c370f4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Deaf_FetchList), @"mvc.1.0.view", @"/Views/Deaf/FetchList.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f5824273132ba9dfabf004c69fde0c3633c370f4", @"/Views/Deaf/FetchList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9ee1afeccf8cd41b13d27f56638a8f8538165796", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Deaf_FetchList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Grievance>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 6 "D:\Projects\Altered\TestLinux\TestLinux\Views\Deaf\FetchList.cshtml"
  
    Layout = null;
    int sn = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<table class=""table table-striped table-bordered"" id=""dTable"">
    <thead>
        <tr>
            <th>
                S.No.
            </th>
            <th>
                Registered Date
            </th>
            <th>
                Source
            </th>
            <th>
                Branch
            </th>
            <th>
                District
            </th>
            <th>
                ComplaintId
            </th>
            <th>
                Customer Name
            </th>
            <th>
                Mobile NUmber
            </th>
            <th>
                Status
            </th>
            <th>
                RO Reply
            </th>
            <th>
                Closure Date
            </th>
            <th>
                View
            </th>
        </tr>

    </thead>
    <tbody>
");
#nullable restore
#line 54 "D:\Projects\Altered\TestLinux\TestLinux\Views\Deaf\FetchList.cshtml"
         foreach (var item in Model.OrderByDescending(a => a.RegisterDate).ToList())
        {
            sn++;

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 58 "D:\Projects\Altered\TestLinux\TestLinux\Views\Deaf\FetchList.cshtml"
               Write(sn);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 59 "D:\Projects\Altered\TestLinux\TestLinux\Views\Deaf\FetchList.cshtml"
               Write(item.RegisterDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 60 "D:\Projects\Altered\TestLinux\TestLinux\Views\Deaf\FetchList.cshtml"
               Write(item.ComplaintType);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 61 "D:\Projects\Altered\TestLinux\TestLinux\Views\Deaf\FetchList.cshtml"
               Write(item.Branch);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 62 "D:\Projects\Altered\TestLinux\TestLinux\Views\Deaf\FetchList.cshtml"
               Write(item.District);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 63 "D:\Projects\Altered\TestLinux\TestLinux\Views\Deaf\FetchList.cshtml"
               Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 64 "D:\Projects\Altered\TestLinux\TestLinux\Views\Deaf\FetchList.cshtml"
               Write(item.ApplicantName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 65 "D:\Projects\Altered\TestLinux\TestLinux\Views\Deaf\FetchList.cshtml"
               Write(item.MobileNo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 66 "D:\Projects\Altered\TestLinux\TestLinux\Views\Deaf\FetchList.cshtml"
               Write(item.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>\r\n");
#nullable restore
#line 68 "D:\Projects\Altered\TestLinux\TestLinux\Views\Deaf\FetchList.cshtml"
                     if (item.ROReplyDate != null)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <span>Yes</span>\r\n");
#nullable restore
#line 71 "D:\Projects\Altered\TestLinux\TestLinux\Views\Deaf\FetchList.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <span>No</span>\r\n");
#nullable restore
#line 75 "D:\Projects\Altered\TestLinux\TestLinux\Views\Deaf\FetchList.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n");
#nullable restore
#line 79 "D:\Projects\Altered\TestLinux\TestLinux\Views\Deaf\FetchList.cshtml"
                 if (item.ClosureDate.HasValue)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <span>");
#nullable restore
#line 81 "D:\Projects\Altered\TestLinux\TestLinux\Views\Deaf\FetchList.cshtml"
                     Write(item.ClosureDate.Value.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 82 "D:\Projects\Altered\TestLinux\TestLinux\Views\Deaf\FetchList.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 2149, "\"", 2214, 2);
            WriteAttributeValue("", 2156, "/Deaf/ViewComplaint/", 2156, 20, true);
#nullable restore
#line 84 "D:\Projects\Altered\TestLinux\TestLinux\Views\Deaf\FetchList.cshtml"
WriteAttributeValue("", 2176, _protector.Decode(item.Id.ToString()), 2176, 38, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">View</a></td>\r\n        </tr>\r\n");
#nullable restore
#line 86 "D:\Projects\Altered\TestLinux\TestLinux\Views\Deaf\FetchList.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public CustomIDataProtection _protector { get; private set; } = default!;
        #nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Grievance>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
