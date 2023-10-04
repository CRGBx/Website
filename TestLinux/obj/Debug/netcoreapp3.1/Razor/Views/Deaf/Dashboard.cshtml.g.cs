#pragma checksum "D:\Projects\Altered\TestLinux\TestLinux\Views\Deaf\Dashboard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e0f71a19f9c72a3b71e3130a3483efe9fc0de457"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Deaf_Dashboard), @"mvc.1.0.view", @"/Views/Deaf/Dashboard.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e0f71a19f9c72a3b71e3130a3483efe9fc0de457", @"/Views/Deaf/Dashboard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9ee1afeccf8cd41b13d27f56638a8f8538165796", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Deaf_Dashboard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "D:\Projects\Altered\TestLinux\TestLinux\Views\Deaf\Dashboard.cshtml"
  
    Layout = "~/Views/Shared/_LayoutM.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container"" style=""margin-top:30px;"">
    
    <div class=""row"">
        <div class=""col-lg-12 col-12"">
            <a href=""/Deaf/BrComplaint"" class=""btnrate"">  Enter Complaint</a>
        </div>

    </div>
    <div class=""row"">
        <div class=""col-lg-12 col-12"">
            
            <h4>Complaints Status</h4>
            <table class=""table table-bordered table-sm"">
                <thead>
                    <tr>
                        <th>Particulars</th>
                        <th>Pending Complaints</th>
                        <th>Closed Complaints</th>
                        <th>
                            Total Complaints
                        </th>
                    </tr>
                </thead>
                <tbody>
                    <tr>
                        <td>General </td>
                        <td><a href=""#"" onclick=""fetchList('Pending','G')""> ");
#nullable restore
#line 34 "D:\Projects\Altered\TestLinux\TestLinux\Views\Deaf\Dashboard.cshtml"
                                                                       Write(ViewBag.P_G);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </a></td>\r\n                        <td><a href=\"#\" onclick=\"fetchList(\'Closed\',\'G\')\"> ");
#nullable restore
#line 35 "D:\Projects\Altered\TestLinux\TestLinux\Views\Deaf\Dashboard.cshtml"
                                                                      Write(ViewBag.C_G);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </a></td>\r\n                        <td><a href=\"#\" onclick=\"fetchList(\'Total\',\'G\')\"> ");
#nullable restore
#line 36 "D:\Projects\Altered\TestLinux\TestLinux\Views\Deaf\Dashboard.cshtml"
                                                                      Write((int)ViewBag.P_G + (int)ViewBag.C_G);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </a></td>\r\n                    </tr>\r\n                    <tr>\r\n                        <td>Digital Transaction </td>\r\n                        <td> <a href=\"#\" onclick=\"fetchList(\'Pending\',\'D\')\"> ");
#nullable restore
#line 40 "D:\Projects\Altered\TestLinux\TestLinux\Views\Deaf\Dashboard.cshtml"
                                                                        Write(ViewBag.P_D);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </a></td>\r\n                        <td><a href=\"#\" onclick=\"fetchList(\'Closed\',\'D\')\"> ");
#nullable restore
#line 41 "D:\Projects\Altered\TestLinux\TestLinux\Views\Deaf\Dashboard.cshtml"
                                                                      Write(ViewBag.C_D);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a> </td>\r\n                        <td><a href=\"#\" onclick=\"fetchList(\'Total\',\'D\')\"> ");
#nullable restore
#line 42 "D:\Projects\Altered\TestLinux\TestLinux\Views\Deaf\Dashboard.cshtml"
                                                                      Write((int)ViewBag.P_D + (int)ViewBag.C_D);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </a></td>\r\n                    </tr>\r\n                    <tr>\r\n                        <td>Total </td>\r\n                        <td> <a href=\"#\" onclick=\"fetchList(\'Pending\',\'All\')\">  ");
#nullable restore
#line 46 "D:\Projects\Altered\TestLinux\TestLinux\Views\Deaf\Dashboard.cshtml"
                                                                            Write((int)ViewBag.P_G + (int)ViewBag.P_D);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </a></td>\r\n                        <td> <a href=\"#\" onclick=\"fetchList(\'Closed\',\'All\')\">  ");
#nullable restore
#line 47 "D:\Projects\Altered\TestLinux\TestLinux\Views\Deaf\Dashboard.cshtml"
                                                                           Write((int)ViewBag.C_D + (int)ViewBag.C_G);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </a></td>\r\n                        <td><a href=\"#\" onclick=\"fetchList(\'Total\',\'All\')\">  ");
#nullable restore
#line 48 "D:\Projects\Altered\TestLinux\TestLinux\Views\Deaf\Dashboard.cshtml"
                                                                         Write((int)ViewBag.P_G + (int)ViewBag.C_G + (int)ViewBag.P_D + (int)ViewBag.C_D);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" </a></td>
                    </tr>
                </tbody>
            </table>

        </div><!-- col -->

    </div>
    <div class=""row"">
        <div class=""col-lg-12 col-12"" id=""ListHolder"">

            </div>
        </div>

    </div>

");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <link rel=""stylesheet"" type=""text/css"" href=""https://cdn.datatables.net/1.12.1/css/dataTables.bootstrap4.min.css""/>
     <link rel=""stylesheet"" type=""text/css"" href=""https://cdn.datatables.net/buttons/2.2.3/css/buttons.bootstrap4.min.css""/>

    
 
<script type=""text/javascript"" src=""https://cdn.datatables.net/1.12.1/js/jquery.dataTables.min.js""></script>
<script type=""text/javascript"" src=""https://cdn.datatables.net/1.12.1/js/dataTables.bootstrap4.min.js"" ></script>
<script type=""text/javascript"" src=""https://cdn.datatables.net/buttons/2.2.3/js/dataTables.buttons.min.js""></script>
<script type=""text/javascript"" src=""https://cdn.datatables.net/buttons/2.2.3/js/buttons.bootstrap4.min.js"" ></script>
<script src=""//cdnjs.cloudflare.com/ajax/libs/jszip/3.1.3/jszip.min.js""></script>
<script src=""//cdnjs.cloudflare.com/ajax/libs/pdfmake/0.1.53/pdfmake.min.js""></script>
<script src=""//cdn.datatables.net/buttons/1.5.6/js/buttons.html5.min.js""></script>

            <script type=""text/javascript"">
");
                WriteLiteral(@"                function fetchList(a, b) {
                    fetch('/Deaf/FetchList?a=' + a + '&b=' + b).then(function (response) {
                        // The API call was successful!
                        return response.text();
                    }).then(function (html) {
                        // This is the HTML from our response as a text string
                        //console.log(html);
                        $('#ListHolder').html(html);
                        $('#dTable').DataTable( {
                            dom: 'Blfrtip',
                             ""pageLength"": 50,
    buttons: [
        'copy', 'excel', 'pdf'
    ]
} );
                });}
            </script>
        ");
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
