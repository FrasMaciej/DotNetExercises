#pragma checksum "D:\Kredek_repos\homework2\HomeWork2\HomeWork2\Views\Home\FilmDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "250ddcbc588d40e18a2ca6e4b58b46e8d0300262"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_FilmDetails), @"mvc.1.0.view", @"/Views/Home/FilmDetails.cshtml")]
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
#line 1 "D:\Kredek_repos\homework2\HomeWork2\HomeWork2\Views\_ViewImports.cshtml"
using HomeWork2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Kredek_repos\homework2\HomeWork2\HomeWork2\Views\_ViewImports.cshtml"
using HomeWork2.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"250ddcbc588d40e18a2ca6e4b58b46e8d0300262", @"/Views/Home/FilmDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b6c033a6d5a8a2f56ca7644e3fab900a0456ebb0", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_FilmDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("rounded"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("height:25rem"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AllFilms", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\Kredek_repos\homework2\HomeWork2\HomeWork2\Views\Home\FilmDetails.cshtml"
  
    ViewData["Title"] = "Szczegóły";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Szczegóły filmu</h1>\r\n\r\n<h4>");
#nullable restore
#line 7 "D:\Kredek_repos\homework2\HomeWork2\HomeWork2\Views\Home\FilmDetails.cshtml"
Write(Model.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n<h4>Numer: ");
#nullable restore
#line 8 "D:\Kredek_repos\homework2\HomeWork2\HomeWork2\Views\Home\FilmDetails.cshtml"
      Write(Model.id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "250ddcbc588d40e18a2ca6e4b58b46e8d03002624906", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 150, "~/images/", 150, 9, true);
#nullable restore
#line 9 "D:\Kredek_repos\homework2\HomeWork2\HomeWork2\Views\Home\FilmDetails.cshtml"
AddHtmlAttributeValue("", 159, Model.image, 159, 12, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute(",", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("width:18rem", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<h5>Opis filmu</h5>\r\n<p>");
#nullable restore
#line 11 "D:\Kredek_repos\homework2\HomeWork2\HomeWork2\Views\Home\FilmDetails.cshtml"
Write(Model.description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<h5 class=\"my-2\">Bilet Normalny: ");
#nullable restore
#line 12 "D:\Kredek_repos\homework2\HomeWork2\HomeWork2\Views\Home\FilmDetails.cshtml"
                            Write(Model.normalTicketPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral(" zł</h5>\r\n<h5 class=\"my-3\">Bilet Ulgowy: ");
#nullable restore
#line 13 "D:\Kredek_repos\homework2\HomeWork2\HomeWork2\Views\Home\FilmDetails.cshtml"
                          Write(Model.reducedTicketPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral(" zł</h5>\r\n\r\n<input type=\"button\" class=\"btn btn-primary\" value=\"Złóż Zamówienie\"");
            BeginWriteAttribute("onclick", " onclick=\"", 463, "\"", 544, 3);
            WriteAttributeValue("", 473, "location.href=\'", 473, 15, true);
#nullable restore
#line 15 "D:\Kredek_repos\homework2\HomeWork2\HomeWork2\Views\Home\FilmDetails.cshtml"
WriteAttributeValue("", 488, Url.Action("CreateOrder", "Home", new {id = Model.id}), 488, 55, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 543, "\'", 543, 1, true);
            EndWriteAttribute();
            WriteLiteral(" />\r\n\r\n<hr />\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "250ddcbc588d40e18a2ca6e4b58b46e8d03002628643", async() => {
                WriteLiteral("Powrót");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
