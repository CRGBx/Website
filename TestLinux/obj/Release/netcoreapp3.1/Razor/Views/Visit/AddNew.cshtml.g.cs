#pragma checksum "D:\Projects\Altered\TestLinux\TestLinux\Views\Visit\AddNew.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f432c7744439b6c490b7674b63177d03a1908dff"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Visit_AddNew), @"mvc.1.0.view", @"/Views/Visit/AddNew.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f432c7744439b6c490b7674b63177d03a1908dff", @"/Views/Visit/AddNew.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9ee1afeccf8cd41b13d27f56638a8f8538165796", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Visit_AddNew : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CSPVisit>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 5 "D:\Projects\Altered\TestLinux\TestLinux\Views\Visit\AddNew.cshtml"
  
    Layout = "_Layout2.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n<b style=\"margin-top:15px;margin-left:15px;\">Confirm Visit Date</b>\r\n\r\n");
#nullable restore
#line 13 "D:\Projects\Altered\TestLinux\TestLinux\Views\Visit\AddNew.cshtml"
 using (Html.BeginForm())
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div style=\"margin-top: 10px; margin-left: 5px; margin-right: 50px;\" class=\"row\">\r\n        <div class=\"col-sm-12 col-md-6\">\r\n            User Id\r\n        </div>\r\n        <div class=\"col-sm-12 col-md-6\">\r\n            <input type=\"text\" name=\"UserId\"");
            BeginWriteAttribute("value", " value=\"", 539, "\"", 560, 1);
#nullable restore
#line 20 "D:\Projects\Altered\TestLinux\TestLinux\Views\Visit\AddNew.cshtml"
WriteAttributeValue("", 547, Model.UserId, 547, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"form-control\" readonly />\r\n        </div>\r\n    \r\n        <div class=\"col-sm-12 col-md-6\">\r\n            CSP Id\r\n        </div>\r\n        <div class=\"col-sm-12 col-md-6\">\r\n            <input type=\"text\" name=\"CSPId\"");
            BeginWriteAttribute("value", " value=\"", 781, "\"", 801, 1);
#nullable restore
#line 27 "D:\Projects\Altered\TestLinux\TestLinux\Views\Visit\AddNew.cshtml"
WriteAttributeValue("", 789, Model.CSPId, 789, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"form-control\" readonly />\r\n        </div>\r\n   \r\n        <div class=\"col-sm-12 col-md-6\">\r\n            Visit Date\r\n        </div>\r\n        <div class=\"col-sm-12 col-md-6\">\r\n            <input type=\"date\" name=\"VisitDate\"");
            BeginWriteAttribute("value", " value=\"", 1029, "\"", 1073, 1);
#nullable restore
#line 34 "D:\Projects\Altered\TestLinux\TestLinux\Views\Visit\AddNew.cshtml"
WriteAttributeValue("", 1037, Model.VisitDate.ToShortDateString(), 1037, 36, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"form-control\"  />\r\n            <input type=\"hidden\" name=\"token\"");
            BeginWriteAttribute("value", " value=\"", 1146, "\"", 1173, 1);
#nullable restore
#line 35 "D:\Projects\Altered\TestLinux\TestLinux\Views\Visit\AddNew.cshtml"
WriteAttributeValue("", 1154, Model.VisitRemarks, 1154, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n            <input type=\"hidden\" name=\"lat\"");
            BeginWriteAttribute("value", " value=\"", 1222, "\"", 1249, 1);
#nullable restore
#line 36 "D:\Projects\Altered\TestLinux\TestLinux\Views\Visit\AddNew.cshtml"
WriteAttributeValue("", 1230, Model.Location_lat, 1230, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n            <input type=\"hidden\" name=\"loc_long\"");
            BeginWriteAttribute("value", " value=\"", 1303, "\"", 1331, 1);
#nullable restore
#line 37 "D:\Projects\Altered\TestLinux\TestLinux\Views\Visit\AddNew.cshtml"
WriteAttributeValue("", 1311, Model.Location_long, 1311, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n        </div>\r\n    \r\n        <div class=\"col-sm-12 col-md-6\" style=\"margin-top:10px;\">\r\n            <button type=\"submit\" class=\"btn btn-primary\">Create Visit</button>\r\n        </div>\r\n\r\n    </div>\r\n");
#nullable restore
#line 45 "D:\Projects\Altered\TestLinux\TestLinux\Views\Visit\AddNew.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<div style=\"margin-left:15px;margin-top:10px;\" class=\"embed-responsive embed-responsive-1by1\">\r\n    <iframe class=\"embed-responsive-item\" style=\"width:90%\"");
            BeginWriteAttribute("src", "  src=\"", 1695, "\"", 1783, 5);
            WriteAttributeValue("", 1702, "https://maps.google.com?q=", 1702, 26, true);
#nullable restore
#line 47 "D:\Projects\Altered\TestLinux\TestLinux\Views\Visit\AddNew.cshtml"
WriteAttributeValue("", 1728, Model.Location_lat, 1728, 19, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1747, ",", 1747, 1, true);
#nullable restore
#line 47 "D:\Projects\Altered\TestLinux\TestLinux\Views\Visit\AddNew.cshtml"
WriteAttributeValue("", 1748, Model.Location_long, 1748, 20, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1768, "&output=svembed", 1768, 15, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n\r\n</iframe>\r\n\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CSPVisit> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591