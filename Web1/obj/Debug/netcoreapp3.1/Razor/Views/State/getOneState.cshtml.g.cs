#pragma checksum "C:\Users\Yura\RiderProjects\Web1\Web1\Views\State\getOneState.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a37158cfc6e848df8ce0bfcc7a620126bf3f4396"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_State_getOneState), @"mvc.1.0.view", @"/Views/State/getOneState.cshtml")]
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
#nullable restore
#line 1 "C:\Users\Yura\RiderProjects\Web1\Web1\Views\State\getOneState.cshtml"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a37158cfc6e848df8ce0bfcc7a620126bf3f4396", @"/Views/State/getOneState.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4f4350575864478f163bc4cef769cb0463ac39cb", @"/Views/_ViewImports.cshtml")]
    public class Views_State_getOneState : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<State>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
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
<table>
 <tr>
        <td>id</td>
        <td>name</td>
        <td>area</td>
        <td>population</td>
         <td>language</td>
     <td></td>
     <td></td>
 </tr>

<tr>
    <td>");
#nullable restore
#line 26 "C:\Users\Yura\RiderProjects\Web1\Web1\Views\State\getOneState.cshtml"
   Write(Model.id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 27 "C:\Users\Yura\RiderProjects\Web1\Web1\Views\State\getOneState.cshtml"
   Write(Model.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 28 "C:\Users\Yura\RiderProjects\Web1\Web1\Views\State\getOneState.cshtml"
   Write(Model.area);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 29 "C:\Users\Yura\RiderProjects\Web1\Web1\Views\State\getOneState.cshtml"
   Write(Model.population);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 30 "C:\Users\Yura\RiderProjects\Web1\Web1\Views\State\getOneState.cshtml"
   Write(Model.language);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 31 "C:\Users\Yura\RiderProjects\Web1\Web1\Views\State\getOneState.cshtml"
       if (User.FindFirst(x => x.Type == ClaimsIdentity.DefaultRoleClaimType).Value == "admin")
      {

#line default
#line hidden
#nullable disable
            WriteLiteral("          <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a37158cfc6e848df8ce0bfcc7a620126bf3f43964996", async() => {
                WriteLiteral("edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 657, "~/state/edit/", 657, 13, true);
#nullable restore
#line 33 "C:\Users\Yura\RiderProjects\Web1\Web1\Views\State\getOneState.cshtml"
AddHtmlAttributeValue("", 670, Model.id, 670, 9, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\r\n          <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a37158cfc6e848df8ce0bfcc7a620126bf3f43966525", async() => {
                WriteLiteral("delete");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 719, "~/state/delete/", 719, 15, true);
#nullable restore
#line 34 "C:\Users\Yura\RiderProjects\Web1\Web1\Views\State\getOneState.cshtml"
AddHtmlAttributeValue("", 734, Model.id, 734, 9, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\r\n");
#nullable restore
#line 35 "C:\Users\Yura\RiderProjects\Web1\Web1\Views\State\getOneState.cshtml"
      }

#line default
#line hidden
#nullable disable
            WriteLiteral("</tr>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<State> Html { get; private set; }
    }
}
#pragma warning restore 1591
