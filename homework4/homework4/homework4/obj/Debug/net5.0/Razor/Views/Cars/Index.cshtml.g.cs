#pragma checksum "D:\Kredek_repos\homework4\homework4\homework4\Views\Cars\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ae1b22491aa4aa7675d3fe66e2261ad0627ff2fa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cars_Index), @"mvc.1.0.view", @"/Views/Cars/Index.cshtml")]
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
#line 1 "D:\Kredek_repos\homework4\homework4\homework4\Views\_ViewImports.cshtml"
using homework4;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Kredek_repos\homework4\homework4\homework4\Views\_ViewImports.cshtml"
using homework4.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ae1b22491aa4aa7675d3fe66e2261ad0627ff2fa", @"/Views/Cars/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"24a4f6647b390419dbca3926ad535fe25143ee3a", @"/Views/_ViewImports.cshtml")]
    public class Views_Cars_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Car>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 7 "D:\Kredek_repos\homework4\homework4\homework4\Views\Cars\Index.cshtml"
   
    ViewData["Title"] = "Lista filmów";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<p>\r\n    ");
#nullable restore
#line 12 "D:\Kredek_repos\homework4\homework4\homework4\Views\Cars\Index.cshtml"
Write(Html.ActionLink("Utwórz nowy", "Create", "Cars"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</p>\r\n\r\n<table>\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "D:\Kredek_repos\homework4\homework4\homework4\Views\Cars\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Brand));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "D:\Kredek_repos\homework4\homework4\homework4\Views\Cars\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Model));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 25 "D:\Kredek_repos\homework4\homework4\homework4\Views\Cars\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Mileage));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 28 "D:\Kredek_repos\homework4\homework4\homework4\Views\Cars\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.IsAvailable));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n        </tr>\r\n    </thead>\r\n\r\n    <tbody>\r\n");
#nullable restore
#line 34 "D:\Kredek_repos\homework4\homework4\homework4\Views\Cars\Index.cshtml"
         foreach(var car in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 38 "D:\Kredek_repos\homework4\homework4\homework4\Views\Cars\Index.cshtml"
           Write(Html.DisplayFor(modelItem => car.Brand));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 41 "D:\Kredek_repos\homework4\homework4\homework4\Views\Cars\Index.cshtml"
           Write(Html.DisplayFor(modelItem => car.Model));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 44 "D:\Kredek_repos\homework4\homework4\homework4\Views\Cars\Index.cshtml"
           Write(Html.DisplayFor(modelItem => car.Mileage));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 47 "D:\Kredek_repos\homework4\homework4\homework4\Views\Cars\Index.cshtml"
           Write(Html.DisplayFor(modelItem => car.IsAvailable));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 50 "D:\Kredek_repos\homework4\homework4\homework4\Views\Cars\Index.cshtml"
           Write(Html.ActionLink("Edytuj", "Edit", "Cars", routeValues: new { id = car.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 51 "D:\Kredek_repos\homework4\homework4\homework4\Views\Cars\Index.cshtml"
           Write(Html.ActionLink("Usuń", "Delete", "Cars", routeValues: new { id = car.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n            </td>\r\n        </tr>    \r\n");
#nullable restore
#line 55 "D:\Kredek_repos\homework4\homework4\homework4\Views\Cars\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Car>> Html { get; private set; }
    }
}
#pragma warning restore 1591
