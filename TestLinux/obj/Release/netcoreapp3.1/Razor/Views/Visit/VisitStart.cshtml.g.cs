#pragma checksum "D:\Projects\Altered\TestLinux\TestLinux\Views\Visit\VisitStart.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c1beb88583d5360328b0caae529c1433a1965a62"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Visit_VisitStart), @"mvc.1.0.view", @"/Views/Visit/VisitStart.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c1beb88583d5360328b0caae529c1433a1965a62", @"/Views/Visit/VisitStart.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9ee1afeccf8cd41b13d27f56638a8f8538165796", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Visit_VisitStart : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Yes", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "No", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "D:\Projects\Altered\TestLinux\TestLinux\Views\Visit\VisitStart.cshtml"
  
    Layout = "_Layout2.cshtml";
    var data = (List<ValueStatement>)ViewBag.Data;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n<b style=\"margin-top:15px;margin-left:15px;\">Visit Parameters</b>\r\n\r\n");
#nullable restore
#line 13 "D:\Projects\Altered\TestLinux\TestLinux\Views\Visit\VisitStart.cshtml"
 using (Html.BeginForm(null, null, FormMethod.Post, new { enctype="multipart/form-data"}))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <input type=\"hidden\" name=\"VisitId\"");
            BeginWriteAttribute("value", " value=\"", 424, "\"", 448, 1);
#nullable restore
#line 15 "D:\Projects\Altered\TestLinux\TestLinux\Views\Visit\VisitStart.cshtml"
WriteAttributeValue("", 432, ViewBag.VisitId, 432, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("/>\r\n     <input type=\"hidden\" name=\"token\"");
            BeginWriteAttribute("value", " value=\"", 491, "\"", 513, 1);
#nullable restore
#line 16 "D:\Projects\Altered\TestLinux\TestLinux\Views\Visit\VisitStart.cshtml"
WriteAttributeValue("", 499, ViewBag.Token, 499, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("/>\r\n");
#nullable restore
#line 18 "D:\Projects\Altered\TestLinux\TestLinux\Views\Visit\VisitStart.cshtml"
     foreach (var item in data)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div style=\"margin-top: 10px; margin-left: 5px; margin-right: 50px;padding-bottom:10px;\" class=\"row border border-primary\" >\r\n            <div class=\"col-sm-12 col-md-6\">\r\n                <b>");
#nullable restore
#line 22 "D:\Projects\Altered\TestLinux\TestLinux\Views\Visit\VisitStart.cshtml"
              Write(item.Statement);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b>\r\n            </div>\r\n            <div class=\"col-sm-12 col-md-6\">\r\n");
#nullable restore
#line 25 "D:\Projects\Altered\TestLinux\TestLinux\Views\Visit\VisitStart.cshtml"
                  
                    if (item.InputType == "Text")
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <input type=\"text\"");
            BeginWriteAttribute("name", " name=\"", 982, "\"", 997, 1);
#nullable restore
#line 28 "D:\Projects\Altered\TestLinux\TestLinux\Views\Visit\VisitStart.cshtml"
WriteAttributeValue("", 989, item.Id, 989, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("value", " value=\"", 998, "\"", 1006, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"form-control\" />\r\n");
#nullable restore
#line 29 "D:\Projects\Altered\TestLinux\TestLinux\Views\Visit\VisitStart.cshtml"
                    }
                    else if (item.InputType == "Numeric")
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <input type=\"number\" min=\"0\"");
            BeginWriteAttribute("name", " name=\"", 1190, "\"", 1205, 1);
#nullable restore
#line 32 "D:\Projects\Altered\TestLinux\TestLinux\Views\Visit\VisitStart.cshtml"
WriteAttributeValue("", 1197, item.Id, 1197, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("value", " value=\"", 1206, "\"", 1214, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"form-control\" />\r\n");
#nullable restore
#line 33 "D:\Projects\Altered\TestLinux\TestLinux\Views\Visit\VisitStart.cshtml"
                    }
                    else if (item.InputType == "YesNo")
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <select");
            BeginWriteAttribute("name", " name=\"", 1375, "\"", 1390, 1);
#nullable restore
#line 36 "D:\Projects\Altered\TestLinux\TestLinux\Views\Visit\VisitStart.cshtml"
WriteAttributeValue("", 1382, item.Id, 1382, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"form-control\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c1beb88583d5360328b0caae529c1433a1965a628169", async() => {
                WriteLiteral("Yes");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c1beb88583d5360328b0caae529c1433a1965a629353", async() => {
                WriteLiteral("No");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </select>\r\n");
#nullable restore
#line 40 "D:\Projects\Altered\TestLinux\TestLinux\Views\Visit\VisitStart.cshtml"
                    }
                    else if (item.InputType == "File")
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <input type=\"file\"");
            BeginWriteAttribute("name", "   name=\"", 1716, "\"", 1733, 1);
#nullable restore
#line 43 "D:\Projects\Altered\TestLinux\TestLinux\Views\Visit\VisitStart.cshtml"
WriteAttributeValue("", 1725, item.Id, 1725, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" accept=\"image/*\" capture=\"camera\"");
            BeginWriteAttribute("value", " value=\"", 1768, "\"", 1776, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"form-control\" />\r\n");
#nullable restore
#line 44 "D:\Projects\Altered\TestLinux\TestLinux\Views\Visit\VisitStart.cshtml"
                    }
                

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            </div>\r\n");
#nullable restore
#line 49 "D:\Projects\Altered\TestLinux\TestLinux\Views\Visit\VisitStart.cshtml"
     }

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-sm-12 col-md-6\" style=\"margin-top:10px;padding-left:15px;\">\r\n                <button type=\"submit\" id=\"saveBtn\" class=\"btn btn-primary\" onclick=\"ch()\">Save</button>\r\n            </div>\r\n");
#nullable restore
#line 57 "D:\Projects\Altered\TestLinux\TestLinux\Views\Visit\VisitStart.cshtml"

  
    }

#line default
#line hidden
#nullable disable
            DefineSection("scripts", async() => {
                WriteLiteral("\r\n        <script type=\"text/javascript\">\r\n            function ch(){\r\n                $(\'#saveBtn\').text(\'Saving\');\r\n            }\r\n        </script>\r\n    ");
            }
            );
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