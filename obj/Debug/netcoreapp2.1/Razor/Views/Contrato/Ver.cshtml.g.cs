#pragma checksum "C:\Users\educacion 3.0\source\repos\ProyectoInmobiliaria.net-master\Views\Contrato\Ver.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ccc8dff8948f49034d62c1ac1e31ed279c8167de"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Contrato_Ver), @"mvc.1.0.view", @"/Views/Contrato/Ver.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Contrato/Ver.cshtml", typeof(AspNetCore.Views_Contrato_Ver))]
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
#line 1 "C:\Users\educacion 3.0\source\repos\ProyectoInmobiliaria.net-master\Views\_ViewImports.cshtml"
using ProyectoInmobiliaria.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ccc8dff8948f49034d62c1ac1e31ed279c8167de", @"/Views/Contrato/Ver.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dcc030b1c9fad3d129ed290b8b880f7c0f938755", @"/Views/_ViewImports.cshtml")]
    public class Views_Contrato_Ver : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ProyectoInmobiliaria.Models.Contrato>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(57, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "C:\Users\educacion 3.0\source\repos\ProyectoInmobiliaria.net-master\Views\Contrato\Ver.cshtml"
  
    ViewData["Title"] = "Ver";

#line default
#line hidden
            BeginContext(94, 23, true);
            WriteLiteral("\n<h2>Ver</h2>\n\n<p>\n    ");
            EndContext();
            BeginContext(117, 64, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2a3d9b4c08354cce8626cb4c23ec1939", async() => {
                BeginContext(167, 10, true);
                WriteLiteral("Create New");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 10 "C:\Users\educacion 3.0\source\repos\ProyectoInmobiliaria.net-master\Views\Contrato\Ver.cshtml"
                             WriteLiteral(ViewBag.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(181, 86, true);
            WriteLiteral("\n</p>\n<table class=\"table\">\n    <thead>\n        <tr>\n            <th>\n                ");
            EndContext();
            BeginContext(268, 43, false);
#line 16 "C:\Users\educacion 3.0\source\repos\ProyectoInmobiliaria.net-master\Views\Contrato\Ver.cshtml"
           Write(Html.DisplayNameFor(model => model.IdContr));

#line default
#line hidden
            EndContext();
            BeginContext(311, 52, true);
            WriteLiteral("\n            </th>\n            <th>\n                ");
            EndContext();
            BeginContext(364, 41, false);
#line 19 "C:\Users\educacion 3.0\source\repos\ProyectoInmobiliaria.net-master\Views\Contrato\Ver.cshtml"
           Write(Html.DisplayNameFor(model => model.IdInq));

#line default
#line hidden
            EndContext();
            BeginContext(405, 128, true);
            WriteLiteral("\n            </th>\n            <th>\n                <label>Inquilino</label>\n            </th>\n            <th>\n                ");
            EndContext();
            BeginContext(534, 41, false);
#line 25 "C:\Users\educacion 3.0\source\repos\ProyectoInmobiliaria.net-master\Views\Contrato\Ver.cshtml"
           Write(Html.DisplayNameFor(model => model.IdInm));

#line default
#line hidden
            EndContext();
            BeginContext(575, 137, true);
            WriteLiteral("\n            </th>\n            <th>\n                <label>Ubicacion Inmueble</label>\n            </th>\n            <th>\n                ");
            EndContext();
            BeginContext(713, 47, false);
#line 31 "C:\Users\educacion 3.0\source\repos\ProyectoInmobiliaria.net-master\Views\Contrato\Ver.cshtml"
           Write(Html.DisplayNameFor(model => model.FechaInicio));

#line default
#line hidden
            EndContext();
            BeginContext(760, 52, true);
            WriteLiteral("\n            </th>\n            <th>\n                ");
            EndContext();
            BeginContext(813, 47, false);
#line 34 "C:\Users\educacion 3.0\source\repos\ProyectoInmobiliaria.net-master\Views\Contrato\Ver.cshtml"
           Write(Html.DisplayNameFor(model => model.FechaCierre));

#line default
#line hidden
            EndContext();
            BeginContext(860, 52, true);
            WriteLiteral("\n            </th>\n            <th>\n                ");
            EndContext();
            BeginContext(913, 41, false);
#line 37 "C:\Users\educacion 3.0\source\repos\ProyectoInmobiliaria.net-master\Views\Contrato\Ver.cshtml"
           Write(Html.DisplayNameFor(model => model.Monto));

#line default
#line hidden
            EndContext();
            BeginContext(954, 52, true);
            WriteLiteral("\n            </th>\n            <th>\n                ");
            EndContext();
            BeginContext(1007, 43, false);
#line 40 "C:\Users\educacion 3.0\source\repos\ProyectoInmobiliaria.net-master\Views\Contrato\Ver.cshtml"
           Write(Html.DisplayNameFor(model => model.Vigente));

#line default
#line hidden
            EndContext();
            BeginContext(1050, 80, true);
            WriteLiteral("\n            </th>\n            <th></th>\n        </tr>\n    </thead>\n    <tbody>\n");
            EndContext();
#line 46 "C:\Users\educacion 3.0\source\repos\ProyectoInmobiliaria.net-master\Views\Contrato\Ver.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(1161, 46, true);
            WriteLiteral("        <tr>\n            <td>\n                ");
            EndContext();
            BeginContext(1208, 42, false);
#line 49 "C:\Users\educacion 3.0\source\repos\ProyectoInmobiliaria.net-master\Views\Contrato\Ver.cshtml"
           Write(Html.DisplayFor(modelItem => item.IdContr));

#line default
#line hidden
            EndContext();
            BeginContext(1250, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(1303, 40, false);
#line 52 "C:\Users\educacion 3.0\source\repos\ProyectoInmobiliaria.net-master\Views\Contrato\Ver.cshtml"
           Write(Html.DisplayFor(modelItem => item.IdInq));

#line default
#line hidden
            EndContext();
            BeginContext(1343, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(1396, 51, false);
#line 55 "C:\Users\educacion 3.0\source\repos\ProyectoInmobiliaria.net-master\Views\Contrato\Ver.cshtml"
           Write(Html.DisplayFor(modelItem => item.Inquilino.Nombre));

#line default
#line hidden
            EndContext();
            BeginContext(1447, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(1449, 53, false);
#line 55 "C:\Users\educacion 3.0\source\repos\ProyectoInmobiliaria.net-master\Views\Contrato\Ver.cshtml"
                                                                Write(Html.DisplayFor(modelItem => item.Inquilino.Apellido));

#line default
#line hidden
            EndContext();
            BeginContext(1502, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(1555, 40, false);
#line 58 "C:\Users\educacion 3.0\source\repos\ProyectoInmobiliaria.net-master\Views\Contrato\Ver.cshtml"
           Write(Html.DisplayFor(modelItem => item.IdInm));

#line default
#line hidden
            EndContext();
            BeginContext(1595, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(1648, 53, false);
#line 61 "C:\Users\educacion 3.0\source\repos\ProyectoInmobiliaria.net-master\Views\Contrato\Ver.cshtml"
           Write(Html.DisplayFor(modelItem => item.Inmueble.Direccion));

#line default
#line hidden
            EndContext();
            BeginContext(1701, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(1754, 46, false);
#line 64 "C:\Users\educacion 3.0\source\repos\ProyectoInmobiliaria.net-master\Views\Contrato\Ver.cshtml"
           Write(Html.DisplayFor(modelItem => item.FechaInicio));

#line default
#line hidden
            EndContext();
            BeginContext(1800, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(1853, 46, false);
#line 67 "C:\Users\educacion 3.0\source\repos\ProyectoInmobiliaria.net-master\Views\Contrato\Ver.cshtml"
           Write(Html.DisplayFor(modelItem => item.FechaCierre));

#line default
#line hidden
            EndContext();
            BeginContext(1899, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(1952, 40, false);
#line 70 "C:\Users\educacion 3.0\source\repos\ProyectoInmobiliaria.net-master\Views\Contrato\Ver.cshtml"
           Write(Html.DisplayFor(modelItem => item.Monto));

#line default
#line hidden
            EndContext();
            BeginContext(1992, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(2045, 42, false);
#line 73 "C:\Users\educacion 3.0\source\repos\ProyectoInmobiliaria.net-master\Views\Contrato\Ver.cshtml"
           Write(Html.DisplayFor(modelItem => item.Vigente));

#line default
#line hidden
            EndContext();
            BeginContext(2087, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(2140, 58, false);
#line 76 "C:\Users\educacion 3.0\source\repos\ProyectoInmobiliaria.net-master\Views\Contrato\Ver.cshtml"
           Write(Html.ActionLink("Edit", "Edit", new { id = item.IdContr }));

#line default
#line hidden
            EndContext();
            BeginContext(2198, 19, true);
            WriteLiteral(" |\n                ");
            EndContext();
            BeginContext(2218, 70, false);
#line 77 "C:\Users\educacion 3.0\source\repos\ProyectoInmobiliaria.net-master\Views\Contrato\Ver.cshtml"
           Write(Html.ActionLink("Ver Pagos", "Ver", "Pago", new { id = item.IdContr }));

#line default
#line hidden
            EndContext();
            BeginContext(2288, 2, true);
            WriteLiteral(";\n");
            EndContext();
#line 78 "C:\Users\educacion 3.0\source\repos\ProyectoInmobiliaria.net-master\Views\Contrato\Ver.cshtml"
                 if (User.IsInRole("Administrador"))
                {
                    

#line default
#line hidden
            BeginContext(2382, 62, false);
#line 80 "C:\Users\educacion 3.0\source\repos\ProyectoInmobiliaria.net-master\Views\Contrato\Ver.cshtml"
               Write(Html.ActionLink("Delete", "Delete", new { id = item.IdContr }));

#line default
#line hidden
            EndContext();
#line 80 "C:\Users\educacion 3.0\source\repos\ProyectoInmobiliaria.net-master\Views\Contrato\Ver.cshtml"
                                                                                   
                }

#line default
#line hidden
            BeginContext(2463, 32, true);
            WriteLiteral("            </td>\n        </tr>\n");
            EndContext();
#line 84 "C:\Users\educacion 3.0\source\repos\ProyectoInmobiliaria.net-master\Views\Contrato\Ver.cshtml"
}

#line default
#line hidden
            BeginContext(2497, 22, true);
            WriteLiteral("    </tbody>\n</table>\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ProyectoInmobiliaria.Models.Contrato>> Html { get; private set; }
    }
}
#pragma warning restore 1591
