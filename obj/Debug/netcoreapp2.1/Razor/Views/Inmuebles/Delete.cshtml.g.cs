#pragma checksum "C:\Users\educacion 3.0\source\repos\ProyectoInmobiliaria.net-master\Views\Inmuebles\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c0eca27ca9ceaa589c8ebb49fcb1f8acd450984e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Inmuebles_Delete), @"mvc.1.0.view", @"/Views/Inmuebles/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Inmuebles/Delete.cshtml", typeof(AspNetCore.Views_Inmuebles_Delete))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c0eca27ca9ceaa589c8ebb49fcb1f8acd450984e", @"/Views/Inmuebles/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dcc030b1c9fad3d129ed290b8b880f7c0f938755", @"/Views/_ViewImports.cshtml")]
    public class Views_Inmuebles_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProyectoInmobiliaria.Models.Inmueble>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(44, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "C:\Users\educacion 3.0\source\repos\ProyectoInmobiliaria.net-master\Views\Inmuebles\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
            BeginContext(84, 168, true);
            WriteLiteral("\n<h2>Eliminar</h2>\n\n<h3>Esta seguro que quiere borrar est inmueble?</h3>\n<div>\n    <h4>Inmueble</h4>\n    <hr />\n    <dl class=\"dl-horizontal\">\n        <dt>\n            ");
            EndContext();
            BeginContext(253, 41, false);
#line 15 "C:\Users\educacion 3.0\source\repos\ProyectoInmobiliaria.net-master\Views\Inmuebles\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.IdInm));

#line default
#line hidden
            EndContext();
            BeginContext(294, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(335, 37, false);
#line 18 "C:\Users\educacion 3.0\source\repos\ProyectoInmobiliaria.net-master\Views\Inmuebles\Delete.cshtml"
       Write(Html.DisplayFor(model => model.IdInm));

#line default
#line hidden
            EndContext();
            BeginContext(372, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(413, 42, false);
#line 21 "C:\Users\educacion 3.0\source\repos\ProyectoInmobiliaria.net-master\Views\Inmuebles\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.IdProp));

#line default
#line hidden
            EndContext();
            BeginContext(455, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(496, 38, false);
#line 24 "C:\Users\educacion 3.0\source\repos\ProyectoInmobiliaria.net-master\Views\Inmuebles\Delete.cshtml"
       Write(Html.DisplayFor(model => model.IdProp));

#line default
#line hidden
            EndContext();
            BeginContext(534, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(575, 45, false);
#line 27 "C:\Users\educacion 3.0\source\repos\ProyectoInmobiliaria.net-master\Views\Inmuebles\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Direccion));

#line default
#line hidden
            EndContext();
            BeginContext(620, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(661, 41, false);
#line 30 "C:\Users\educacion 3.0\source\repos\ProyectoInmobiliaria.net-master\Views\Inmuebles\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Direccion));

#line default
#line hidden
            EndContext();
            BeginContext(702, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(743, 40, false);
#line 33 "C:\Users\educacion 3.0\source\repos\ProyectoInmobiliaria.net-master\Views\Inmuebles\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Tipo));

#line default
#line hidden
            EndContext();
            BeginContext(783, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(824, 36, false);
#line 36 "C:\Users\educacion 3.0\source\repos\ProyectoInmobiliaria.net-master\Views\Inmuebles\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Tipo));

#line default
#line hidden
            EndContext();
            BeginContext(860, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(901, 39, false);
#line 39 "C:\Users\educacion 3.0\source\repos\ProyectoInmobiliaria.net-master\Views\Inmuebles\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Uso));

#line default
#line hidden
            EndContext();
            BeginContext(940, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(981, 35, false);
#line 42 "C:\Users\educacion 3.0\source\repos\ProyectoInmobiliaria.net-master\Views\Inmuebles\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Uso));

#line default
#line hidden
            EndContext();
            BeginContext(1016, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(1057, 49, false);
#line 45 "C:\Users\educacion 3.0\source\repos\ProyectoInmobiliaria.net-master\Views\Inmuebles\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.CantAmbientes));

#line default
#line hidden
            EndContext();
            BeginContext(1106, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(1147, 45, false);
#line 48 "C:\Users\educacion 3.0\source\repos\ProyectoInmobiliaria.net-master\Views\Inmuebles\Delete.cshtml"
       Write(Html.DisplayFor(model => model.CantAmbientes));

#line default
#line hidden
            EndContext();
            BeginContext(1192, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(1233, 41, false);
#line 51 "C:\Users\educacion 3.0\source\repos\ProyectoInmobiliaria.net-master\Views\Inmuebles\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Costo));

#line default
#line hidden
            EndContext();
            BeginContext(1274, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(1315, 37, false);
#line 54 "C:\Users\educacion 3.0\source\repos\ProyectoInmobiliaria.net-master\Views\Inmuebles\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Costo));

#line default
#line hidden
            EndContext();
            BeginContext(1352, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(1393, 46, false);
#line 57 "C:\Users\educacion 3.0\source\repos\ProyectoInmobiliaria.net-master\Views\Inmuebles\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Disponible));

#line default
#line hidden
            EndContext();
            BeginContext(1439, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(1480, 42, false);
#line 60 "C:\Users\educacion 3.0\source\repos\ProyectoInmobiliaria.net-master\Views\Inmuebles\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Disponible));

#line default
#line hidden
            EndContext();
            BeginContext(1522, 34, true);
            WriteLiteral("\n        </dd>\n    </dl>\n    \n    ");
            EndContext();
            BeginContext(1556, 158, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3c1ae4bd692e4e1ba6f8b3bc84434678", async() => {
                BeginContext(1582, 82, true);
                WriteLiteral("\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-default\" /> |\n        ");
                EndContext();
                BeginContext(1664, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "99512e01651a4f5ab3131d7cc3d93ab1", async() => {
                    BeginContext(1686, 12, true);
                    WriteLiteral("Back to List");
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
                BeginContext(1702, 5, true);
                WriteLiteral("\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1714, 8, true);
            WriteLiteral("\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProyectoInmobiliaria.Models.Inmueble> Html { get; private set; }
    }
}
#pragma warning restore 1591
