#pragma checksum "C:\Users\eduardosantana.OCYAN\Desktop\WebVenda\VendaWebMvc\Views\RegistroVendas\BuscaSimples.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e2e984661950c6257f75d093614f7c3f75bbea98"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_RegistroVendas_BuscaSimples), @"mvc.1.0.view", @"/Views/RegistroVendas/BuscaSimples.cshtml")]
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
#line 1 "C:\Users\eduardosantana.OCYAN\Desktop\WebVenda\VendaWebMvc\Views\_ViewImports.cshtml"
using VendaWebMvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\eduardosantana.OCYAN\Desktop\WebVenda\VendaWebMvc\Views\_ViewImports.cshtml"
using VendaWebMvc.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e2e984661950c6257f75d093614f7c3f75bbea98", @"/Views/RegistroVendas/BuscaSimples.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a3e69205e1989b62de9ffa0ad58b0d28b705b8f5", @"/Views/_ViewImports.cshtml")]
    public class Views_RegistroVendas_BuscaSimples : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<VendaWebMvc.Models.RegistroVendas>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("navbar-form navbar-left"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("search"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\eduardosantana.OCYAN\Desktop\WebVenda\VendaWebMvc\Views\RegistroVendas\BuscaSimples.cshtml"
  
    ViewData["Title"] = "Busca Simples";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>");
#nullable restore
#line 7 "C:\Users\eduardosantana.OCYAN\Desktop\WebVenda\VendaWebMvc\Views\RegistroVendas\BuscaSimples.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n\r\n<nav class=\"navbar navbar-inverse\">\r\n    <div class=\"container-fluid\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e2e984661950c6257f75d093614f7c3f75bbea984664", async() => {
                WriteLiteral("\r\n            <div class=\"form-group\">\r\n                <div class=\"form-group\">\r\n                    <label for=\"minDate\">Data Inicial</label>\r\n                    <input type=\"date\" class=\"form-control\" name=\"minDate\"");
                BeginWriteAttribute("value", " value=", 491, "", 518, 1);
#nullable restore
#line 15 "C:\Users\eduardosantana.OCYAN\Desktop\WebVenda\VendaWebMvc\Views\RegistroVendas\BuscaSimples.cshtml"
WriteAttributeValue("", 498, ViewData["minDate"], 498, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    <label for=\"maxDate\">Data Final</label>\r\n                    <input type=\"date\" class=\"form-control\" name=\"maxDate\"");
                BeginWriteAttribute("value", " value=", 724, "", 751, 1);
#nullable restore
#line 19 "C:\Users\eduardosantana.OCYAN\Desktop\WebVenda\VendaWebMvc\Views\RegistroVendas\BuscaSimples.cshtml"
WriteAttributeValue("", 731, ViewData["maxDate"], 731, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("/>\r\n                </div>\r\n            </div>\r\n            <button type=\"submit\" class=\"btn btn-primary\">Filtrar</button>\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</nav>\r\n\r\n<div class=\"panel panel-primary\">\r\n    <div class=\"panel-heading\">\r\n        <h3 class=\"panel-title\">Total Vendas = ");
#nullable restore
#line 29 "C:\Users\eduardosantana.OCYAN\Desktop\WebVenda\VendaWebMvc\Views\RegistroVendas\BuscaSimples.cshtml"
                                          Write(Model.Sum(obj => obj.Valor).ToString("F2"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n    </div>\r\n    <div class=\"panel-body\">\r\n        <table class=\"table table-striped table-hover\">\r\n            <thead>\r\n                <tr class=\"success\">\r\n                    <th>\r\n                        ");
#nullable restore
#line 36 "C:\Users\eduardosantana.OCYAN\Desktop\WebVenda\VendaWebMvc\Views\RegistroVendas\BuscaSimples.cshtml"
                   Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n\r\n                    <th>\r\n                        ");
#nullable restore
#line 40 "C:\Users\eduardosantana.OCYAN\Desktop\WebVenda\VendaWebMvc\Views\RegistroVendas\BuscaSimples.cshtml"
                   Write(Html.DisplayNameFor(model => model.Data));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n\r\n                    <th>\r\n                        ");
#nullable restore
#line 44 "C:\Users\eduardosantana.OCYAN\Desktop\WebVenda\VendaWebMvc\Views\RegistroVendas\BuscaSimples.cshtml"
                   Write(Html.DisplayNameFor(model => model.Vendedor));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n\r\n                    <th>\r\n                        ");
#nullable restore
#line 48 "C:\Users\eduardosantana.OCYAN\Desktop\WebVenda\VendaWebMvc\Views\RegistroVendas\BuscaSimples.cshtml"
                   Write(Html.DisplayNameFor(model => model.Vendedor.Departamento));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n\r\n                    <th>\r\n                        ");
#nullable restore
#line 52 "C:\Users\eduardosantana.OCYAN\Desktop\WebVenda\VendaWebMvc\Views\RegistroVendas\BuscaSimples.cshtml"
                   Write(Html.DisplayNameFor(model => model.Valor));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                </tr>\r\n            </thead>\r\n\r\n            <tbody>\r\n");
#nullable restore
#line 58 "C:\Users\eduardosantana.OCYAN\Desktop\WebVenda\VendaWebMvc\Views\RegistroVendas\BuscaSimples.cshtml"
                 foreach(var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
#nullable restore
#line 62 "C:\Users\eduardosantana.OCYAN\Desktop\WebVenda\VendaWebMvc\Views\RegistroVendas\BuscaSimples.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 65 "C:\Users\eduardosantana.OCYAN\Desktop\WebVenda\VendaWebMvc\Views\RegistroVendas\BuscaSimples.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Data));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 68 "C:\Users\eduardosantana.OCYAN\Desktop\WebVenda\VendaWebMvc\Views\RegistroVendas\BuscaSimples.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Vendedor.Nome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 71 "C:\Users\eduardosantana.OCYAN\Desktop\WebVenda\VendaWebMvc\Views\RegistroVendas\BuscaSimples.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Vendedor.Departamento));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 74 "C:\Users\eduardosantana.OCYAN\Desktop\WebVenda\VendaWebMvc\Views\RegistroVendas\BuscaSimples.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Valor));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 77 "C:\Users\eduardosantana.OCYAN\Desktop\WebVenda\VendaWebMvc\Views\RegistroVendas\BuscaSimples.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<VendaWebMvc.Models.RegistroVendas>> Html { get; private set; }
    }
}
#pragma warning restore 1591
