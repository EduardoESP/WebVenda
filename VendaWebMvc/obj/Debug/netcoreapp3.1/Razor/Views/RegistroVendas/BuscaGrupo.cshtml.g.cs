#pragma checksum "C:\Users\eduardosantana.OCYAN\Desktop\WebVenda\VendaWebMvc\Views\RegistroVendas\BuscaGrupo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7dae92be3989b32ee20fe910f1998525c7a049ad"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_RegistroVendas_BuscaGrupo), @"mvc.1.0.view", @"/Views/RegistroVendas/BuscaGrupo.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7dae92be3989b32ee20fe910f1998525c7a049ad", @"/Views/RegistroVendas/BuscaGrupo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a3e69205e1989b62de9ffa0ad58b0d28b705b8f5", @"/Views/_ViewImports.cshtml")]
    public class Views_RegistroVendas_BuscaGrupo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<IGrouping<Departamento, RegistroVendas>>>
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
#line 3 "C:\Users\eduardosantana.OCYAN\Desktop\WebVenda\VendaWebMvc\Views\RegistroVendas\BuscaGrupo.cshtml"
  
    ViewData["Title"] = "Busca Agrupadando Setor";
    DateTime minDate = DateTime.Parse(ViewData["minDate"] as string);
    DateTime maxDate = DateTime.Parse(ViewData["maxDate"] as string);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>");
#nullable restore
#line 9 "C:\Users\eduardosantana.OCYAN\Desktop\WebVenda\VendaWebMvc\Views\RegistroVendas\BuscaGrupo.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n\r\n<nav class=\"navbar navbar-inverse\">\r\n    <div class=\"container-fluid\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7dae92be3989b32ee20fe910f1998525c7a049ad4808", async() => {
                WriteLiteral("\r\n            <div class=\"form-group\">\r\n                <div class=\"form-group\">\r\n                    <label for=\"minDate\">Data Inicial</label>\r\n                    <input type=\"date\" class=\"form-control\" name=\"minDate\"");
                BeginWriteAttribute("value", " value=", 648, "", 675, 1);
#nullable restore
#line 17 "C:\Users\eduardosantana.OCYAN\Desktop\WebVenda\VendaWebMvc\Views\RegistroVendas\BuscaGrupo.cshtml"
WriteAttributeValue("", 655, ViewData["minDate"], 655, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    <label for=\"maxDate\">Data Final</label>\r\n                    <input type=\"date\" class=\"form-control\" name=\"maxDate\"");
                BeginWriteAttribute("value", " value=", 881, "", 908, 1);
#nullable restore
#line 21 "C:\Users\eduardosantana.OCYAN\Desktop\WebVenda\VendaWebMvc\Views\RegistroVendas\BuscaGrupo.cshtml"
WriteAttributeValue("", 888, ViewData["maxDate"], 888, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                </div>\r\n            </div>\r\n            <button type=\"submit\" class=\"btn btn-primary\">Filtrar</button>\r\n        ");
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
            WriteLiteral("\r\n    </div>\r\n</nav>\r\n\r\n");
#nullable restore
#line 29 "C:\Users\eduardosantana.OCYAN\Desktop\WebVenda\VendaWebMvc\Views\RegistroVendas\BuscaGrupo.cshtml"
 foreach(var AgruparDepartamento in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"panel panel-primary\">\r\n    <div class=\"panel-heading\">\r\n        <h3 class=\"panel-title\">Departamento ");
#nullable restore
#line 33 "C:\Users\eduardosantana.OCYAN\Desktop\WebVenda\VendaWebMvc\Views\RegistroVendas\BuscaGrupo.cshtml"
                                        Write(AgruparDepartamento.Key.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral(", Total Vendas = ");
#nullable restore
#line 33 "C:\Users\eduardosantana.OCYAN\Desktop\WebVenda\VendaWebMvc\Views\RegistroVendas\BuscaGrupo.cshtml"
                                                                                      Write(AgruparDepartamento.Key.TotalVendas(minDate, maxDate).ToString("F2"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h3>
    </div>
    <div class=""panel-body"">
        <table class=""table table-striped table-hover"">
            <thead>
                <tr class=""success"">
                    <th>
                      Data
                    </th>

                    <th>
                       Valor
                    </th>

                    <th>
                       Vendedor
                    </th>

                    <th>
                      Status
                    </th>
                  
                </tr>
            </thead>

            <tbody>
");
#nullable restore
#line 59 "C:\Users\eduardosantana.OCYAN\Desktop\WebVenda\VendaWebMvc\Views\RegistroVendas\BuscaGrupo.cshtml"
                 foreach (var item in AgruparDepartamento)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>\r\n                            ");
#nullable restore
#line 63 "C:\Users\eduardosantana.OCYAN\Desktop\WebVenda\VendaWebMvc\Views\RegistroVendas\BuscaGrupo.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Data));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 66 "C:\Users\eduardosantana.OCYAN\Desktop\WebVenda\VendaWebMvc\Views\RegistroVendas\BuscaGrupo.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Valor));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 69 "C:\Users\eduardosantana.OCYAN\Desktop\WebVenda\VendaWebMvc\Views\RegistroVendas\BuscaGrupo.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Vendedor.Nome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        \r\n                       \r\n                    </tr>\r\n");
#nullable restore
#line 74 "C:\Users\eduardosantana.OCYAN\Desktop\WebVenda\VendaWebMvc\Views\RegistroVendas\BuscaGrupo.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n</div>\r\n");
#nullable restore
#line 79 "C:\Users\eduardosantana.OCYAN\Desktop\WebVenda\VendaWebMvc\Views\RegistroVendas\BuscaGrupo.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<IGrouping<Departamento, RegistroVendas>>> Html { get; private set; }
    }
}
#pragma warning restore 1591
