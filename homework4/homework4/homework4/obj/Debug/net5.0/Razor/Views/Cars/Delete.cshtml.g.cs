#pragma checksum "D:\Kredek_repos\homework4\homework4\homework4\Views\Cars\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6d6e527653f2adcfd723a5cf06efce11a872b68d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cars_Delete), @"mvc.1.0.view", @"/Views/Cars/Delete.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6d6e527653f2adcfd723a5cf06efce11a872b68d", @"/Views/Cars/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"24a4f6647b390419dbca3926ad535fe25143ee3a", @"/Views/_ViewImports.cshtml")]
    public class Views_Cars_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Car>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Kredek_repos\homework4\homework4\homework4\Views\Cars\Delete.cshtml"
 using (Html.BeginForm("Delete", "Cars", FormMethod.Post))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h3>Czy na pewno chcesz usunąć poniższy rekord</h3>\r\n    <hr />\r\n");
            WriteLiteral("    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 9 "D:\Kredek_repos\homework4\homework4\homework4\Views\Cars\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Brand));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dt class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 12 "D:\Kredek_repos\homework4\homework4\homework4\Views\Cars\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Brand));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 16 "D:\Kredek_repos\homework4\homework4\homework4\Views\Cars\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Model));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dt class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 19 "D:\Kredek_repos\homework4\homework4\homework4\Views\Cars\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Model));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 23 "D:\Kredek_repos\homework4\homework4\homework4\Views\Cars\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Mileage));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n\r\n    </dl>\r\n");
            WriteLiteral("    <input type=\"submit\" value=\"Usuń\" class=\"btn btn-danger\" />\r\n");
#nullable restore
#line 29 "D:\Kredek_repos\homework4\homework4\homework4\Views\Cars\Delete.cshtml"

}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Car> Html { get; private set; }
    }
}
#pragma warning restore 1591