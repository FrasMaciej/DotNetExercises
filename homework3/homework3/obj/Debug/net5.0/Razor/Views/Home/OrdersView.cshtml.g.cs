#pragma checksum "D:\Kredek_repos\homework3\homework3\Views\Home\OrdersView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "57929b17f3b4df17fd4908da03f0659ba97c8f60"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_OrdersView), @"mvc.1.0.view", @"/Views/Home/OrdersView.cshtml")]
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
#line 1 "D:\Kredek_repos\homework3\homework3\Views\_ViewImports.cshtml"
using homework3;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Kredek_repos\homework3\homework3\Views\_ViewImports.cshtml"
using homework3.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"57929b17f3b4df17fd4908da03f0659ba97c8f60", @"/Views/Home/OrdersView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8fe54fbeb2677cffdd1afc42d7286b5102f775e7", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_OrdersView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<homework3.Models.Order>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Kredek_repos\homework3\homework3\Views\Home\OrdersView.cshtml"
  
    ViewData["Title"] = "Historia Zamówień";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Zamówienia</h1>

<table class=""table"">
    <thead>
        <tr>
            <th>
                Id Pizzy
            </th>
            <th>
                Miasto
            </th>
            <th>
                Adres
            </th>
            <th>
                Email
            </th>
            <th>
                Numer Telefonu
            </th>
            <th>
                Data zamówienia
            </th>
            <th></th>
        </tr>
    </thead>

    <tbody>
");
#nullable restore
#line 35 "D:\Kredek_repos\homework3\homework3\Views\Home\OrdersView.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 39 "D:\Kredek_repos\homework3\homework3\Views\Home\OrdersView.cshtml"
           Write(Html.DisplayFor(modelItem => item.PizzaId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 42 "D:\Kredek_repos\homework3\homework3\Views\Home\OrdersView.cshtml"
           Write(Html.DisplayFor(modelItem => item.City));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 45 "D:\Kredek_repos\homework3\homework3\Views\Home\OrdersView.cshtml"
           Write(Html.DisplayFor(modelItem => item.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 48 "D:\Kredek_repos\homework3\homework3\Views\Home\OrdersView.cshtml"
           Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 51 "D:\Kredek_repos\homework3\homework3\Views\Home\OrdersView.cshtml"
           Write(Html.DisplayFor(modelItem => item.PhoneNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 54 "D:\Kredek_repos\homework3\homework3\Views\Home\OrdersView.cshtml"
           Write(Html.DisplayFor(modelItem => item.OrderDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 57 "D:\Kredek_repos\homework3\homework3\Views\Home\OrdersView.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<homework3.Models.Order>> Html { get; private set; }
    }
}
#pragma warning restore 1591
