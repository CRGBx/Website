#pragma checksum "D:\Projects\Altered\TestLinux\TestLinux\Views\Deaf\ViewComplaint.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f42d4e2d8c09b961b7a31cd31c0e7f66663f53d1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Deaf_ViewComplaint), @"mvc.1.0.view", @"/Views/Deaf/ViewComplaint.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f42d4e2d8c09b961b7a31cd31c0e7f66663f53d1", @"/Views/Deaf/ViewComplaint.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9ee1afeccf8cd41b13d27f56638a8f8538165796", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Deaf_ViewComplaint : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Grievance>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("selected", new global::Microsoft.AspNetCore.Html.HtmlString("selected"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Processed", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Closed", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 5 "D:\Projects\Altered\TestLinux\TestLinux\Views\Deaf\ViewComplaint.cshtml"
  
    Layout = "~/Views/Shared/_LayoutM.cshtml";
    var brcode = ViewBag.brcode;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container\" style=\"margin-top:10px;\">\r\n    <div class=\"row\">\r\n        <div class=\"col-lg-6 col-12\">\r\n            <h4>View Complaint</h4>\r\n\r\n        </div><!-- col -->\r\n\r\n    </div>\r\n\r\n");
#nullable restore
#line 19 "D:\Projects\Altered\TestLinux\TestLinux\Views\Deaf\ViewComplaint.cshtml"
     using (Html.BeginForm())
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "D:\Projects\Altered\TestLinux\TestLinux\Views\Deaf\ViewComplaint.cshtml"
   Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"form-horizontal col-lg-6\">\r\n\r\n    <hr />\r\n    ");
#nullable restore
#line 26 "D:\Projects\Altered\TestLinux\TestLinux\Views\Deaf\ViewComplaint.cshtml"
Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <div class=\"form-group form-row\">\r\n\r\n        <label class=\"control-label col-md-6\">Complaint Id</label>\r\n        <div class=\"col-md-10\">\r\n            <input readonly type=\"text\" name=\"Id\"");
            BeginWriteAttribute("value", " value=\"", 817, "\"", 834, 1);
#nullable restore
#line 31 "D:\Projects\Altered\TestLinux\TestLinux\Views\Deaf\ViewComplaint.cshtml"
WriteAttributeValue("", 825, Model.Id, 825, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""form-control form-control-sm"" />
        </div>
    </div>
    <div class=""form-group form-row"">

        <label class=""control-label col-md-6"">Applicant Name</label>
        <div class=""col-md-10"">
            <input readonly type=""text"" name=""ApplicantName""");
            BeginWriteAttribute("value", " value=\"", 1109, "\"", 1137, 1);
#nullable restore
#line 38 "D:\Projects\Altered\TestLinux\TestLinux\Views\Deaf\ViewComplaint.cshtml"
WriteAttributeValue("", 1117, Model.ApplicantName, 1117, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""form-control form-control-sm"" />
        </div>
    </div>
    <div class=""form-group form-row"">
        <label class=""control-label col-md-6"">Mobile Number</label>
        <div class=""col-md-10"">
            <input readonly type=""text"" name=""MobileNo""");
            BeginWriteAttribute("value", " value=\"", 1404, "\"", 1427, 1);
#nullable restore
#line 44 "D:\Projects\Altered\TestLinux\TestLinux\Views\Deaf\ViewComplaint.cshtml"
WriteAttributeValue("", 1412, Model.MobileNo, 1412, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"form-control form-control-sm\" />\r\n        </div>\r\n    </div>\r\n    <div class=\"form-group form-row\">\r\n        <label class=\"control-label col-md-6\">Current Status</label>\r\n        <div class=\"col-md-10\">\r\n            <input readonly type=\"text\"");
            BeginWriteAttribute("value", " value=\"", 1679, "\"", 1700, 1);
#nullable restore
#line 50 "D:\Projects\Altered\TestLinux\TestLinux\Views\Deaf\ViewComplaint.cshtml"
WriteAttributeValue("", 1687, Model.Status, 1687, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""form-control form-control-sm"" />
        </div>
    </div>
    <div class=""form-group form-row"">
        <label class=""control-label col-md-6"">Complaint Type</label>
        <div class=""col-md-10"">
            <input readonly type=""text"" name=""Segment""");
            BeginWriteAttribute("value", " value=\"", 1967, "\"", 1989, 1);
#nullable restore
#line 56 "D:\Projects\Altered\TestLinux\TestLinux\Views\Deaf\ViewComplaint.cshtml"
WriteAttributeValue("", 1975, Model.Segment, 1975, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""form-control form-control-sm"" />
        </div>
    </div>
    <div class=""form-group form-row"">
        <label class=""control-label col-md-6"">Account Number</label>
        <div class=""col-md-10"">
            <input readonly type=""text"" name=""AccountNumber""");
            BeginWriteAttribute("value", " value=\"", 2262, "\"", 2290, 1);
#nullable restore
#line 62 "D:\Projects\Altered\TestLinux\TestLinux\Views\Deaf\ViewComplaint.cshtml"
WriteAttributeValue("", 2270, Model.AccountNumber, 2270, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""form-control form-control-sm"" />
        </div>
    </div>
    <div class=""form-group form-row"">
        <label class=""control-label col-md-6"">Transaction Type</label>
        <div class=""col-md-10"">
            <input readonly type=""text"" name=""DigitalTxn""");
            BeginWriteAttribute("value", " value=\"", 2562, "\"", 2587, 1);
#nullable restore
#line 68 "D:\Projects\Altered\TestLinux\TestLinux\Views\Deaf\ViewComplaint.cshtml"
WriteAttributeValue("", 2570, Model.DigitalTxn, 2570, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""form-control form-control-sm"" />
        </div>
    </div>
    <div class=""form-group form-row"">
        <label class=""control-label col-md-6"">Transaction Date</label>
        <div class=""col-md-10"">
            <input readonly type=""text"" name=""TransactionDate""");
            BeginWriteAttribute("value", " value=\"", 2864, "\"", 2894, 1);
#nullable restore
#line 74 "D:\Projects\Altered\TestLinux\TestLinux\Views\Deaf\ViewComplaint.cshtml"
WriteAttributeValue("", 2872, Model.TransactionDate, 2872, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""form-control form-control-sm"" />
        </div>
    </div>
    <div class=""form-group form-row"">
        <label class=""control-label col-md-6"">Transaction Amount</label>
        <div class=""col-md-10"">
            <input readonly type=""text"" name=""AmountInvolved""");
            BeginWriteAttribute("value", " value=\"", 3172, "\"", 3201, 1);
#nullable restore
#line 80 "D:\Projects\Altered\TestLinux\TestLinux\Views\Deaf\ViewComplaint.cshtml"
WriteAttributeValue("", 3180, Model.AmountInvolved, 3180, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""form-control form-control-sm"" />
        </div>
    </div>
    <div class=""form-group form-row"">
        <label class=""control-label col-md-6"">Complaint</label>
        <div class=""col-md-10"">
            <textarea readonly type=""text"" name=""Complaint""");
            BeginWriteAttribute("value", " value=\"", 3468, "\"", 3492, 1);
#nullable restore
#line 86 "D:\Projects\Altered\TestLinux\TestLinux\Views\Deaf\ViewComplaint.cshtml"
WriteAttributeValue("", 3476, Model.Complaint, 3476, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"form-control form-control-sm\" rows=\"3\">");
#nullable restore
#line 86 "D:\Projects\Altered\TestLinux\TestLinux\Views\Deaf\ViewComplaint.cshtml"
                                                                                                                              Write(Model.Complaint);

#line default
#line hidden
#nullable disable
            WriteLiteral("</textarea>\r\n        </div>\r\n    </div>\r\n\r\n\r\n");
#nullable restore
#line 91 "D:\Projects\Altered\TestLinux\TestLinux\Views\Deaf\ViewComplaint.cshtml"
     if (brcode.StartsWith("099") == false && brcode != "09900")
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"form-group form-row\">\r\n            <label class=\"control-label col-md-6\">Branch Reply</label>\r\n            <div class=\"col-md-10\">\r\n                <textarea type=\"text\" name=\"InternalReply\" required");
            BeginWriteAttribute("value", " value=\"", 3893, "\"", 3921, 1);
#nullable restore
#line 96 "D:\Projects\Altered\TestLinux\TestLinux\Views\Deaf\ViewComplaint.cshtml"
WriteAttributeValue("", 3901, Model.InternalReply, 3901, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"form-control form-control-sm\" rows=\"3\">");
#nullable restore
#line 96 "D:\Projects\Altered\TestLinux\TestLinux\Views\Deaf\ViewComplaint.cshtml"
                                                                                                                                          Write(Model.InternalReply);

#line default
#line hidden
#nullable disable
            WriteLiteral("</textarea>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 99 "D:\Projects\Altered\TestLinux\TestLinux\Views\Deaf\ViewComplaint.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"form-group form-row\">\r\n            <label class=\"control-label col-md-6\">Branch Reply</label>\r\n            <div class=\"col-md-10\">\r\n                <textarea readonly type=\"text\" name=\"InternalReply\"");
            BeginWriteAttribute("value", " value=\"", 4281, "\"", 4309, 1);
#nullable restore
#line 105 "D:\Projects\Altered\TestLinux\TestLinux\Views\Deaf\ViewComplaint.cshtml"
WriteAttributeValue("", 4289, Model.InternalReply, 4289, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"form-control form-control-sm\" rows=\"3\">");
#nullable restore
#line 105 "D:\Projects\Altered\TestLinux\TestLinux\Views\Deaf\ViewComplaint.cshtml"
                                                                                                                                          Write(Model.InternalReply);

#line default
#line hidden
#nullable disable
            WriteLiteral("</textarea>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 108 "D:\Projects\Altered\TestLinux\TestLinux\Views\Deaf\ViewComplaint.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n");
#nullable restore
#line 112 "D:\Projects\Altered\TestLinux\TestLinux\Views\Deaf\ViewComplaint.cshtml"
     if (brcode.StartsWith("099") && brcode != "09900")
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"form-group form-row\">\r\n            <label class=\"control-label col-md-6\">RO Reply</label>\r\n            <div class=\"col-md-10\">\r\n                <textarea type=\"text\" name=\"ROReply\" required");
            BeginWriteAttribute("value", " value=\"", 4712, "\"", 4734, 1);
#nullable restore
#line 117 "D:\Projects\Altered\TestLinux\TestLinux\Views\Deaf\ViewComplaint.cshtml"
WriteAttributeValue("", 4720, Model.ROReply, 4720, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"form-control form-control-sm\" rows=\"3\">");
#nullable restore
#line 117 "D:\Projects\Altered\TestLinux\TestLinux\Views\Deaf\ViewComplaint.cshtml"
                                                                                                                              Write(Model.ROReply);

#line default
#line hidden
#nullable disable
            WriteLiteral("</textarea>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 120 "D:\Projects\Altered\TestLinux\TestLinux\Views\Deaf\ViewComplaint.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"form-group form-row\">\r\n            <label class=\"control-label col-md-6\">RO Reply</label>\r\n            <div class=\"col-md-10\">\r\n                <textarea readonly type=\"text\" name=\"ROReply\"");
            BeginWriteAttribute("value", " value=\"", 5078, "\"", 5100, 1);
#nullable restore
#line 126 "D:\Projects\Altered\TestLinux\TestLinux\Views\Deaf\ViewComplaint.cshtml"
WriteAttributeValue("", 5086, Model.ROReply, 5086, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"form-control form-control-sm\" rows=\"3\">");
#nullable restore
#line 126 "D:\Projects\Altered\TestLinux\TestLinux\Views\Deaf\ViewComplaint.cshtml"
                                                                                                                              Write(Model.ROReply);

#line default
#line hidden
#nullable disable
            WriteLiteral("</textarea>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 129 "D:\Projects\Altered\TestLinux\TestLinux\Views\Deaf\ViewComplaint.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n");
#nullable restore
#line 133 "D:\Projects\Altered\TestLinux\TestLinux\Views\Deaf\ViewComplaint.cshtml"
     if (brcode == "09900")
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"form-group form-row\">\r\n            <label class=\"control-label col-md-6\">HO Reply</label>\r\n            <div class=\"col-md-10\">\r\n                <textarea type=\"text\" name=\"HOReply\"");
            BeginWriteAttribute("value", " value=\"", 5460, "\"", 5482, 1);
#nullable restore
#line 138 "D:\Projects\Altered\TestLinux\TestLinux\Views\Deaf\ViewComplaint.cshtml"
WriteAttributeValue("", 5468, Model.HOReply, 5468, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" required class=\"form-control form-control-sm\" rows=\"3\">");
#nullable restore
#line 138 "D:\Projects\Altered\TestLinux\TestLinux\Views\Deaf\ViewComplaint.cshtml"
                                                                                                                              Write(Model.HOReply);

#line default
#line hidden
#nullable disable
            WriteLiteral("</textarea>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 141 "D:\Projects\Altered\TestLinux\TestLinux\Views\Deaf\ViewComplaint.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"form-group form-row\">\r\n            <label class=\"control-label col-md-6\">HO Reply</label>\r\n            <div class=\"col-md-10\">\r\n                <textarea readonly type=\"text\" name=\"HOReply\"");
            BeginWriteAttribute("value", "  value=\"", 5835, "\"", 5858, 1);
#nullable restore
#line 147 "D:\Projects\Altered\TestLinux\TestLinux\Views\Deaf\ViewComplaint.cshtml"
WriteAttributeValue("", 5844, Model.HOReply, 5844, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"form-control form-control-sm\" rows=\"3\">");
#nullable restore
#line 147 "D:\Projects\Altered\TestLinux\TestLinux\Views\Deaf\ViewComplaint.cshtml"
                                                                                                                               Write(Model.HOReply);

#line default
#line hidden
#nullable disable
            WriteLiteral("</textarea>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 150 "D:\Projects\Altered\TestLinux\TestLinux\Views\Deaf\ViewComplaint.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <div class=\"form-group form-row\">\r\n        <label class=\"control-label col-md-6\">Change Status</label>\r\n        <div class=\"col-md-10\">\r\n            <select class=\"form-control\" name=\"Status\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f42d4e2d8c09b961b7a31cd31c0e7f66663f53d120473", async() => {
                WriteLiteral("\r\n                    ");
#nullable restore
#line 157 "D:\Projects\Altered\TestLinux\TestLinux\Views\Deaf\ViewComplaint.cshtml"
               Write(Model.Status);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 156 "D:\Projects\Altered\TestLinux\TestLinux\Views\Deaf\ViewComplaint.cshtml"
                                       WriteLiteral(Model.Status);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f42d4e2d8c09b961b7a31cd31c0e7f66663f53d122459", async() => {
                WriteLiteral("\r\n                    Processed\r\n                ");
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
            WriteLiteral("\r\n");
#nullable restore
#line 162 "D:\Projects\Altered\TestLinux\TestLinux\Views\Deaf\ViewComplaint.cshtml"
                 if (brcode == "09900" || brcode.StartsWith("099"))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f42d4e2d8c09b961b7a31cd31c0e7f66663f53d123959", async() => {
                WriteLiteral("\r\n                        Closed\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 167 "D:\Projects\Altered\TestLinux\TestLinux\Views\Deaf\ViewComplaint.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            </select>
        </div>
    </div>

    <div class=""form-group form-row"" style=""margin-top:10px;"">
        <div class=""col-md-6""></div>
        <div class=""col-md-offset-2 col-md-10"">
            <input type=""submit"" value=""Save"" class=""btn btn-primary mx-auto"" />
        </div>
    </div>
</div>
");
#nullable restore
#line 180 "D:\Projects\Altered\TestLinux\TestLinux\Views\Deaf\ViewComplaint.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Grievance> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
