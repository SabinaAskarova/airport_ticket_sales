#pragma checksum "C:\Users\acer\Documents\C#\MyProject\MyProject\Views\ToCity\Get.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8c731aab30d31d50163bf3e2899ad9b4ef23fbba"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ToCity_Get), @"mvc.1.0.view", @"/Views/ToCity/Get.cshtml")]
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
#line 1 "C:\Users\acer\Documents\C#\MyProject\MyProject\Views\_ViewImports.cshtml"
using MyProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\acer\Documents\C#\MyProject\MyProject\Views\_ViewImports.cshtml"
using MyProject.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\acer\Documents\C#\MyProject\MyProject\Views\ToCity\Get.cshtml"
using MyProject.DTOs.ToCityDTOs;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8c731aab30d31d50163bf3e2899ad9b4ef23fbba", @"/Views/ToCity/Get.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e6fe18bfd33a53b99196e5f743c625163e36f2af", @"/Views/_ViewImports.cshtml")]
    public class Views_ToCity_Get : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ToCityToListDTO>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("    <div class=\"body\">\r\n<table class=\"table table-bordered\">\r\n  <thead>\r\n    <tr>\r\n");
            WriteLiteral("      <th>TCityName</th>\r\n    </tr>\r\n  </thead>\r\n  <tbody>\r\n");
#nullable restore
#line 13 "C:\Users\acer\Documents\C#\MyProject\MyProject\Views\ToCity\Get.cshtml"
     foreach (ToCityToListDTO toCity in Model)
        {  

#line default
#line hidden
#nullable disable
            WriteLiteral("      <tr>     \r\n      <td hidden>");
#nullable restore
#line 16 "C:\Users\acer\Documents\C#\MyProject\MyProject\Views\ToCity\Get.cshtml"
            Write(toCity.TCityId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n      <td>");
#nullable restore
#line 17 "C:\Users\acer\Documents\C#\MyProject\MyProject\Views\ToCity\Get.cshtml"
     Write(toCity.TCityName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n      <td>");
#nullable restore
#line 18 "C:\Users\acer\Documents\C#\MyProject\MyProject\Views\ToCity\Get.cshtml"
     Write(Html.ActionLink("Update","UpdateForm","ToCity",new {tCityId =toCity.TCityId }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n      <td>");
#nullable restore
#line 19 "C:\Users\acer\Documents\C#\MyProject\MyProject\Views\ToCity\Get.cshtml"
     Write(Html.ActionLink("Delete","Delete","ToCity",new { tCityId=toCity.TCityId }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n      </tr>\r\n");
#nullable restore
#line 21 "C:\Users\acer\Documents\C#\MyProject\MyProject\Views\ToCity\Get.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("  </tbody>\r\n</table>\r\n\r\n<a href=\"/ToCity/AddForm\" class=\"btn btn-success\">Add</a>\r\n</div>\r\n<link rel=\"stylesheet\" href=\"./lib./lib/bootstrap/\" >\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ToCityToListDTO>> Html { get; private set; }
    }
}
#pragma warning restore 1591