#pragma checksum "C:\Users\educacion 3.0\source\repos\ProyectoInmobiliaria.net-master\Views\Inmuebles\InmPorProp.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5c1b5eff74b6fe3996d76e668415a5a13423d452"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Inmuebles_InmPorProp), @"mvc.1.0.view", @"/Views/Inmuebles/InmPorProp.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Inmuebles/InmPorProp.cshtml", typeof(AspNetCore.Views_Inmuebles_InmPorProp))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5c1b5eff74b6fe3996d76e668415a5a13423d452", @"/Views/Inmuebles/InmPorProp.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dcc030b1c9fad3d129ed290b8b880f7c0f938755", @"/Views/_ViewImports.cshtml")]
    public class Views_Inmuebles_InmPorProp : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ProyectoInmobiliaria.Models.Inmueble>>
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
#line 3 "C:\Users\educacion 3.0\source\repos\ProyectoInmobiliaria.net-master\Views\Inmuebles\InmPorProp.cshtml"
  
    ViewData["Title"] = "InmPorProp";

#line default
#line hidden
            BeginContext(101, 45, true);
            WriteLiteral("\n<h2>Inmuebles del propietario</h2>\n\n<p>\n    ");
            EndContext();
            BeginContext(146, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "66483d6672af4884b2b859dbfb477ac8", async() => {
                BeginContext(169, 10, true);
                WriteLiteral("Create New");
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
            BeginContext(183, 86, true);
            WriteLiteral("\n</p>\n<table class=\"table\">\n    <thead>\n        <tr>\n            <th>\n                ");
            EndContext();
            BeginContext(270, 41, false);
#line 16 "C:\Users\educacion 3.0\source\repos\ProyectoInmobiliaria.net-master\Views\Inmuebles\InmPorProp.cshtml"
           Write(Html.DisplayNameFor(model => model.IdInm));

#line default
#line hidden
            EndContext();
            BeginContext(311, 52, true);
            WriteLiteral("\n            </th>\n            <th>\n                ");
            EndContext();
            BeginContext(364, 42, false);
#line 19 "C:\Users\educacion 3.0\source\repos\ProyectoInmobiliaria.net-master\Views\Inmuebles\InmPorProp.cshtml"
           Write(Html.DisplayNameFor(model => model.IdProp));

#line default
#line hidden
            EndContext();
            BeginContext(406, 130, true);
            WriteLiteral("\n            </th>\n            <th>\n                <label>Propietario</label>\n            </th>\n            <th>\n                ");
            EndContext();
            BeginContext(537, 45, false);
#line 25 "C:\Users\educacion 3.0\source\repos\ProyectoInmobiliaria.net-master\Views\Inmuebles\InmPorProp.cshtml"
           Write(Html.DisplayNameFor(model => model.Direccion));

#line default
#line hidden
            EndContext();
            BeginContext(582, 52, true);
            WriteLiteral("\n            </th>\n            <th>\n                ");
            EndContext();
            BeginContext(635, 40, false);
#line 28 "C:\Users\educacion 3.0\source\repos\ProyectoInmobiliaria.net-master\Views\Inmuebles\InmPorProp.cshtml"
           Write(Html.DisplayNameFor(model => model.Tipo));

#line default
#line hidden
            EndContext();
            BeginContext(675, 52, true);
            WriteLiteral("\n            </th>\n            <th>\n                ");
            EndContext();
            BeginContext(728, 39, false);
#line 31 "C:\Users\educacion 3.0\source\repos\ProyectoInmobiliaria.net-master\Views\Inmuebles\InmPorProp.cshtml"
           Write(Html.DisplayNameFor(model => model.Uso));

#line default
#line hidden
            EndContext();
            BeginContext(767, 52, true);
            WriteLiteral("\n            </th>\n            <th>\n                ");
            EndContext();
            BeginContext(820, 49, false);
#line 34 "C:\Users\educacion 3.0\source\repos\ProyectoInmobiliaria.net-master\Views\Inmuebles\InmPorProp.cshtml"
           Write(Html.DisplayNameFor(model => model.CantAmbientes));

#line default
#line hidden
            EndContext();
            BeginContext(869, 52, true);
            WriteLiteral("\n            </th>\n            <th>\n                ");
            EndContext();
            BeginContext(922, 41, false);
#line 37 "C:\Users\educacion 3.0\source\repos\ProyectoInmobiliaria.net-master\Views\Inmuebles\InmPorProp.cshtml"
           Write(Html.DisplayNameFor(model => model.Costo));

#line default
#line hidden
            EndContext();
            BeginContext(963, 52, true);
            WriteLiteral("\n            </th>\n            <th>\n                ");
            EndContext();
            BeginContext(1016, 46, false);
#line 40 "C:\Users\educacion 3.0\source\repos\ProyectoInmobiliaria.net-master\Views\Inmuebles\InmPorProp.cshtml"
           Write(Html.DisplayNameFor(model => model.Disponible));

#line default
#line hidden
            EndContext();
            BeginContext(1062, 80, true);
            WriteLiteral("\n            </th>\n            <th></th>\n        </tr>\n    </thead>\n    <tbody>\n");
            EndContext();
#line 46 "C:\Users\educacion 3.0\source\repos\ProyectoInmobiliaria.net-master\Views\Inmuebles\InmPorProp.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(1173, 46, true);
            WriteLiteral("        <tr>\n            <td>\n                ");
            EndContext();
            BeginContext(1220, 40, false);
#line 49 "C:\Users\educacion 3.0\source\repos\ProyectoInmobiliaria.net-master\Views\Inmuebles\InmPorProp.cshtml"
           Write(Html.DisplayFor(modelItem => item.IdInm));

#line default
#line hidden
            EndContext();
            BeginContext(1260, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(1313, 41, false);
#line 52 "C:\Users\educacion 3.0\source\repos\ProyectoInmobiliaria.net-master\Views\Inmuebles\InmPorProp.cshtml"
           Write(Html.DisplayFor(modelItem => item.IdProp));

#line default
#line hidden
            EndContext();
            BeginContext(1354, 52, true);
            WriteLiteral("\n            </td>\n            <th>\n                ");
            EndContext();
            BeginContext(1407, 53, false);
#line 55 "C:\Users\educacion 3.0\source\repos\ProyectoInmobiliaria.net-master\Views\Inmuebles\InmPorProp.cshtml"
           Write(Html.DisplayFor(modelItem => item.Propietario.Nombre));

#line default
#line hidden
            EndContext();
            BeginContext(1460, 2, true);
            WriteLiteral("  ");
            EndContext();
            BeginContext(1463, 55, false);
#line 55 "C:\Users\educacion 3.0\source\repos\ProyectoInmobiliaria.net-master\Views\Inmuebles\InmPorProp.cshtml"
                                                                   Write(Html.DisplayFor(modelItem => item.Propietario.Apellido));

#line default
#line hidden
            EndContext();
            BeginContext(1518, 52, true);
            WriteLiteral("\n            </th>\n            <td>\n                ");
            EndContext();
            BeginContext(1571, 44, false);
#line 58 "C:\Users\educacion 3.0\source\repos\ProyectoInmobiliaria.net-master\Views\Inmuebles\InmPorProp.cshtml"
           Write(Html.DisplayFor(modelItem => item.Direccion));

#line default
#line hidden
            EndContext();
            BeginContext(1615, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(1668, 39, false);
#line 61 "C:\Users\educacion 3.0\source\repos\ProyectoInmobiliaria.net-master\Views\Inmuebles\InmPorProp.cshtml"
           Write(Html.DisplayFor(modelItem => item.Tipo));

#line default
#line hidden
            EndContext();
            BeginContext(1707, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(1760, 38, false);
#line 64 "C:\Users\educacion 3.0\source\repos\ProyectoInmobiliaria.net-master\Views\Inmuebles\InmPorProp.cshtml"
           Write(Html.DisplayFor(modelItem => item.Uso));

#line default
#line hidden
            EndContext();
            BeginContext(1798, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(1851, 48, false);
#line 67 "C:\Users\educacion 3.0\source\repos\ProyectoInmobiliaria.net-master\Views\Inmuebles\InmPorProp.cshtml"
           Write(Html.DisplayFor(modelItem => item.CantAmbientes));

#line default
#line hidden
            EndContext();
            BeginContext(1899, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(1952, 40, false);
#line 70 "C:\Users\educacion 3.0\source\repos\ProyectoInmobiliaria.net-master\Views\Inmuebles\InmPorProp.cshtml"
           Write(Html.DisplayFor(modelItem => item.Costo));

#line default
#line hidden
            EndContext();
            BeginContext(1992, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(2045, 45, false);
#line 73 "C:\Users\educacion 3.0\source\repos\ProyectoInmobiliaria.net-master\Views\Inmuebles\InmPorProp.cshtml"
           Write(Html.DisplayFor(modelItem => item.Disponible));

#line default
#line hidden
            EndContext();
            BeginContext(2090, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(2143, 56, false);
#line 76 "C:\Users\educacion 3.0\source\repos\ProyectoInmobiliaria.net-master\Views\Inmuebles\InmPorProp.cshtml"
           Write(Html.ActionLink("Edit", "Edit", new { id = item.IdInm }));

#line default
#line hidden
            EndContext();
            BeginContext(2199, 3, true);
            WriteLiteral(" |\n");
            EndContext();
#line 77 "C:\Users\educacion 3.0\source\repos\ProyectoInmobiliaria.net-master\Views\Inmuebles\InmPorProp.cshtml"
                 if (User.IsInRole("Administrador"))
                {
                    

#line default
#line hidden
            BeginContext(2294, 60, false);
#line 79 "C:\Users\educacion 3.0\source\repos\ProyectoInmobiliaria.net-master\Views\Inmuebles\InmPorProp.cshtml"
               Write(Html.ActionLink("Delete", "Delete", new { id = item.IdInm }));

#line default
#line hidden
            EndContext();
#line 79 "C:\Users\educacion 3.0\source\repos\ProyectoInmobiliaria.net-master\Views\Inmuebles\InmPorProp.cshtml"
                                                                                 
                }

#line default
#line hidden
            BeginContext(2373, 32, true);
            WriteLiteral("            </td>\n        </tr>\n");
            EndContext();
#line 83 "C:\Users\educacion 3.0\source\repos\ProyectoInmobiliaria.net-master\Views\Inmuebles\InmPorProp.cshtml"
}

#line default
#line hidden
            BeginContext(2407, 22, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ProyectoInmobiliaria.Models.Inmueble>> Html { get; private set; }
    }
}
#pragma warning restore 1591