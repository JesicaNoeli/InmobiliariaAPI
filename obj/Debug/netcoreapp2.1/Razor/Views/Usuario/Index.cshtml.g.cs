#pragma checksum "C:\Users\educacion 3.0\source\repos\ProyectoInmobiliaria.net-master\Views\Usuario\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e1308ef356a07567df3d86ab041389e4645e9efe"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Usuario_Index), @"mvc.1.0.view", @"/Views/Usuario/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Usuario/Index.cshtml", typeof(AspNetCore.Views_Usuario_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e1308ef356a07567df3d86ab041389e4645e9efe", @"/Views/Usuario/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dcc030b1c9fad3d129ed290b8b880f7c0f938755", @"/Views/_ViewImports.cshtml")]
    public class Views_Usuario_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ProyectoInmobiliaria.Models.Usuario>>
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
            BeginContext(56, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "C:\Users\educacion 3.0\source\repos\ProyectoInmobiliaria.net-master\Views\Usuario\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(95, 38, true);
            WriteLiteral("\n<h2>Todos Los Usuarios</h2>\n\n<p>\n    ");
            EndContext();
            BeginContext(133, 40, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b380628fdbc24c08a7b88ce4dbcdaf6f", async() => {
                BeginContext(156, 13, true);
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
            BeginContext(173, 553, true);
            WriteLiteral(@"
</p>
<table class=""table"">
    <thead>
        <tr>
            <th>
                <label>ID Usuario</label>
            </th>
            <th>
                <label>Nombre</label>
            </th>
            <th>
                <label>Apellido</label>
            </th>
            <th>
                <label>Email</label>
            </th>
            <th>
                <label>Clave</label>
            </th>
            <th>
                <label>Rol</label>
            </th>
            <th></th>
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 37 "C:\Users\educacion 3.0\source\repos\ProyectoInmobiliaria.net-master\Views\Usuario\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(757, 46, true);
            WriteLiteral("        <tr>\n            <td>\n                ");
            EndContext();
            BeginContext(804, 39, false);
#line 40 "C:\Users\educacion 3.0\source\repos\ProyectoInmobiliaria.net-master\Views\Usuario\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.IdUs));

#line default
#line hidden
            EndContext();
            BeginContext(843, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(896, 41, false);
#line 43 "C:\Users\educacion 3.0\source\repos\ProyectoInmobiliaria.net-master\Views\Usuario\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Nombre));

#line default
#line hidden
            EndContext();
            BeginContext(937, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(990, 43, false);
#line 46 "C:\Users\educacion 3.0\source\repos\ProyectoInmobiliaria.net-master\Views\Usuario\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Apellido));

#line default
#line hidden
            EndContext();
            BeginContext(1033, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(1086, 40, false);
#line 49 "C:\Users\educacion 3.0\source\repos\ProyectoInmobiliaria.net-master\Views\Usuario\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
            EndContext();
            BeginContext(1126, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(1179, 40, false);
#line 52 "C:\Users\educacion 3.0\source\repos\ProyectoInmobiliaria.net-master\Views\Usuario\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Clave));

#line default
#line hidden
            EndContext();
            BeginContext(1219, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(1272, 38, false);
#line 55 "C:\Users\educacion 3.0\source\repos\ProyectoInmobiliaria.net-master\Views\Usuario\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Rol));

#line default
#line hidden
            EndContext();
            BeginContext(1310, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(1363, 57, false);
#line 58 "C:\Users\educacion 3.0\source\repos\ProyectoInmobiliaria.net-master\Views\Usuario\Index.cshtml"
           Write(Html.ActionLink("Editar", "Edit", new { id = item.IdUs }));

#line default
#line hidden
            EndContext();
            BeginContext(1420, 3, true);
            WriteLiteral(" |\n");
            EndContext();
#line 59 "C:\Users\educacion 3.0\source\repos\ProyectoInmobiliaria.net-master\Views\Usuario\Index.cshtml"
                 if (User.IsInRole("Administrador")) {
                

#line default
#line hidden
            BeginContext(1495, 61, false);
#line 60 "C:\Users\educacion 3.0\source\repos\ProyectoInmobiliaria.net-master\Views\Usuario\Index.cshtml"
           Write(Html.ActionLink("Eliminar", "Delete", new { id = item.IdUs }));

#line default
#line hidden
            EndContext();
#line 60 "C:\Users\educacion 3.0\source\repos\ProyectoInmobiliaria.net-master\Views\Usuario\Index.cshtml"
                                                                              
                }

#line default
#line hidden
            BeginContext(1575, 32, true);
            WriteLiteral("            </td>\n        </tr>\n");
            EndContext();
#line 64 "C:\Users\educacion 3.0\source\repos\ProyectoInmobiliaria.net-master\Views\Usuario\Index.cshtml"
}

#line default
#line hidden
            BeginContext(1609, 22, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ProyectoInmobiliaria.Models.Usuario>> Html { get; private set; }
    }
}
#pragma warning restore 1591
