#pragma checksum "C:\Users\Yura\RiderProjects\Web1\Web1\Views\Client\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cc8bcf60231071abc51e92499e05cfe439bcdc20"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Client_Index), @"mvc.1.0.view", @"/Views/Client/Index.cshtml")]
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
#line 1 "C:\Users\Yura\RiderProjects\Web1\Web1\Views\_ViewImports.cshtml"
using Web1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Yura\RiderProjects\Web1\Web1\Views\_ViewImports.cshtml"
using Web1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cc8bcf60231071abc51e92499e05cfe439bcdc20", @"/Views/Client/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4f4350575864478f163bc4cef769cb0463ac39cb", @"/Views/_ViewImports.cshtml")]
    public class Views_Client_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Client>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<style>
table, td {
 padding: 15px;
  text-align: left;
  border: 1px solid black;
}
tr {
  background-color: #4CAF50;
  color: white;
}
</style>
<h3>clients</h3>
<table>
<tr>
    <td>
        <p>id</p>
    </td>
   
     <td>
         <p>first_name</p>
     </td>
     
     <td>
         <p>last_name</p>
     </td>
    
     <td>
         <p>email</p>
     </td>
     
     <td>
         <p>role</p>
     </td>
     
     <td>
         <p>active</p>
     </td>
      
     <td><p>password</p></td>
     
</tr>
");
#nullable restore
#line 43 "C:\Users\Yura\RiderProjects\Web1\Web1\Views\Client\Index.cshtml"
 foreach (var item in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <tr>\r\n        <td>\r\n            ");
#nullable restore
#line 47 "C:\Users\Yura\RiderProjects\Web1\Web1\Views\Client\Index.cshtml"
       Write(Html.DisplayFor(modelItem => item.id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </td>\r\n        <td>\r\n            ");
#nullable restore
#line 50 "C:\Users\Yura\RiderProjects\Web1\Web1\Views\Client\Index.cshtml"
       Write(Html.DisplayFor(modelItem => item.firstname));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </td>\r\n        <td>\r\n            ");
#nullable restore
#line 53 "C:\Users\Yura\RiderProjects\Web1\Web1\Views\Client\Index.cshtml"
       Write(Html.DisplayFor(modelItem => item.lastname));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </td>\r\n        <td>\r\n            ");
#nullable restore
#line 56 "C:\Users\Yura\RiderProjects\Web1\Web1\Views\Client\Index.cshtml"
       Write(Html.DisplayFor(modelItem => item.email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </td>\r\n        <td>\r\n            ");
#nullable restore
#line 59 "C:\Users\Yura\RiderProjects\Web1\Web1\Views\Client\Index.cshtml"
       Write(Html.DisplayFor(modelItem => item.role));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </td>\r\n        <td>\r\n            ");
#nullable restore
#line 62 "C:\Users\Yura\RiderProjects\Web1\Web1\Views\Client\Index.cshtml"
       Write(Html.DisplayFor(modelItem => item.password));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </td>\r\n    </tr>\r\n");
#nullable restore
#line 65 "C:\Users\Yura\RiderProjects\Web1\Web1\Views\Client\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </table >");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Client>> Html { get; private set; }
    }
}
#pragma warning restore 1591