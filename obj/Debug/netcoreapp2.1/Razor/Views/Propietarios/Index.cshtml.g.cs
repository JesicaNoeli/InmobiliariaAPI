#pragma checksum "C:\Users\educacion 3.0\source\repos\ProyectoInmobiliaria.net-master\Views\Propietarios\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "28d346607b4483059f095ef70ad38761d24999ad"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Propietarios_Index), @"mvc.1.0.view", @"/Views/Propietarios/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Propietarios/Index.cshtml", typeof(AspNetCore.Views_Propietarios_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"28d346607b4483059f095ef70ad38761d24999ad", @"/Views/Propietarios/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dcc030b1c9fad3d129ed290b8b880f7c0f938755", @"/Views/_ViewImports.cshtml")]
    public class Views_Propietarios_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ProyectoInmobiliaria.Models.Propietario>>
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
            BeginContext(60, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "C:\Users\educacion 3.0\source\repos\ProyectoInmobiliaria.net-master\Views\Propietarios\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(99, 42, true);
            WriteLiteral("\n<h2>Todos los Propietarios</h2>\n\n<p>\n    ");
            EndContext();
            BeginContext(141, 40, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "74c04657017d43d89be8ee870d71d975", async() => {
                BeginContext(164, 13, true);
                WriteLiteral("Agregar Nuevo");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(181, 166, true);
            WriteLiteral("\n</p>\n<table class=\"table\">\n    <thead>\n        <tr>\n            <th>\n               <label>ID Propietario</label>\n            </th>\n            <th>\n                ");
            EndContext();
            BeginContext(348, 42, false);
#line 19 "C:\Users\educacion 3.0\source\repos\ProyectoInmobiliaria.net-master\Views\Propietarios\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Nombre));

#line default
#line hidden
            EndContext();
            BeginContext(390, 52, true);
            WriteLiteral("\n            </th>\n            <th>\n                ");
            EndContext();
            BeginContext(443, 44, false);
#line 22 "C:\Users\educacion 3.0\source\repos\ProyectoInmobiliaria.net-master\Views\Propietarios\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Apellido));

#line default
#line hidden
            EndContext();
            BeginContext(487, 52, true);
            WriteLiteral("\n            </th>\n            <th>\n                ");
            EndContext();
            BeginContext(540, 39, false);
#line 25 "C:\Users\educacion 3.0\source\repos\ProyectoInmobiliaria.net-master\Views\Propietarios\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Dni));

#line default
#line hidden
            EndContext();
            BeginContext(579, 52, true);
            WriteLiteral("\n            </th>\n            <th>\n                ");
            EndContext();
            BeginContext(632, 41, false);
#line 28 "C:\Users\educacion 3.0\source\repos\ProyectoInmobiliaria.net-master\Views\Propietarios\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(673, 52, true);
            WriteLiteral("\n            </th>\n            <th>\n                ");
            EndContext();
            BeginContext(726, 44, false);
#line 31 "C:\Users\educacion 3.0\source\repos\ProyectoInmobiliaria.net-master\Views\Propietarios\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Telefono));

#line default
#line hidden
            EndContext();
            BeginContext(770, 93, true);
            WriteLiteral("\n            </th>\n            \n            <th></th>\n        </tr>\n    </thead>\n    <tbody>\n");
            EndContext();
#line 38 "C:\Users\educacion 3.0\source\repos\ProyectoInmobiliaria.net-master\Views\Propietarios\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(894, 46, true);
            WriteLiteral("        <tr>\n            <td>\n                ");
            EndContext();
            BeginContext(941, 41, false);
#line 41 "C:\Users\educacion 3.0\source\repos\ProyectoInmobiliaria.net-master\Views\Propietarios\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.IdProp));

#line default
#line hidden
            EndContext();
            BeginContext(982, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(1035, 41, false);
#line 44 "C:\Users\educacion 3.0\source\repos\ProyectoInmobiliaria.net-master\Views\Propietarios\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Nombre));

#line default
#line hidden
            EndContext();
            BeginContext(1076, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(1129, 43, false);
#line 47 "C:\Users\educacion 3.0\source\repos\ProyectoInmobiliaria.net-master\Views\Propietarios\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Apellido));

#line default
#line hidden
            EndContext();
            BeginContext(1172, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(1225, 38, false);
#line 50 "C:\Users\educacion 3.0\source\repos\ProyectoInmobiliaria.net-master\Views\Propietarios\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Dni));

#line default
#line hidden
            EndContext();
            BeginContext(1263, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(1316, 40, false);
#line 53 "C:\Users\educacion 3.0\source\repos\ProyectoInmobiliaria.net-master\Views\Propietarios\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
            EndContext();
            BeginContext(1356, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(1409, 43, false);
#line 56 "C:\Users\educacion 3.0\source\repos\ProyectoInmobiliaria.net-master\Views\Propietarios\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Telefono));

#line default
#line hidden
            EndContext();
            BeginContext(1452, 65, true);
            WriteLiteral("\n            </td>\n            \n            <td>\n                ");
            EndContext();
            BeginContext(1518, 59, false);
#line 60 "C:\Users\educacion 3.0\source\repos\ProyectoInmobiliaria.net-master\Views\Propietarios\Index.cshtml"
           Write(Html.ActionLink("Editar", "Edit", new { id = item.IdProp }));

#line default
#line hidden
            EndContext();
            BeginContext(1577, 3, true);
            WriteLiteral(" |\n");
            EndContext();
#line 61 "C:\Users\educacion 3.0\source\repos\ProyectoInmobiliaria.net-master\Views\Propietarios\Index.cshtml"
                 if (User.IsInRole("Administrador")) {
                    

#line default
#line hidden
            BeginContext(1656, 63, false);
#line 62 "C:\Users\educacion 3.0\source\repos\ProyectoInmobiliaria.net-master\Views\Propietarios\Index.cshtml"
               Write(Html.ActionLink("Eliminar", "Delete", new { id = item.IdProp }));

#line default
#line hidden
            EndContext();
#line 62 "C:\Users\educacion 3.0\source\repos\ProyectoInmobiliaria.net-master\Views\Propietarios\Index.cshtml"
                                                                                    
                                                                                     }

#line default
#line hidden
            BeginContext(1807, 20, true);
            WriteLiteral("                    ");
            EndContext();
            BeginContext(1828, 87, false);
#line 64 "C:\Users\educacion 3.0\source\repos\ProyectoInmobiliaria.net-master\Views\Propietarios\Index.cshtml"
               Write(Html.ActionLink("Ver Propiedades", "InmPorProp", "Inmuebles", new { id = item.IdProp }));

#line default
#line hidden
            EndContext();
            BeginContext(1915, 46, true);
            WriteLiteral("\n                </td>\n    \n            </tr>\n");
            EndContext();
#line 68 "C:\Users\educacion 3.0\source\repos\ProyectoInmobiliaria.net-master\Views\Propietarios\Index.cshtml"

}

#line default
#line hidden
            BeginContext(1964, 22, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ProyectoInmobiliaria.Models.Propietario>> Html { get; private set; }
    }
}
#pragma warning restore 1591
