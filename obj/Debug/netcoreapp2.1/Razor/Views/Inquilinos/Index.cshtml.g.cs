#pragma checksum "C:\Users\educacion 3.0\source\repos\ProyectoInmobiliaria.net-master\Views\Inquilinos\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "47796ea799c21cf27370bd81b715ec219998676f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Inquilinos_Index), @"mvc.1.0.view", @"/Views/Inquilinos/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Inquilinos/Index.cshtml", typeof(AspNetCore.Views_Inquilinos_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"47796ea799c21cf27370bd81b715ec219998676f", @"/Views/Inquilinos/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dcc030b1c9fad3d129ed290b8b880f7c0f938755", @"/Views/_ViewImports.cshtml")]
    public class Views_Inquilinos_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ProyectoInmobiliaria.Models.Inquilino>>
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
            BeginContext(58, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "C:\Users\educacion 3.0\source\repos\ProyectoInmobiliaria.net-master\Views\Inquilinos\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(97, 30, true);
            WriteLiteral("\n<h2>Inquilinos</h2>\n\n<p>\n    ");
            EndContext();
            BeginContext(127, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a4881a48cf7a42c08975bd21502750cc", async() => {
                BeginContext(150, 10, true);
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
            BeginContext(164, 86, true);
            WriteLiteral("\n</p>\n<table class=\"table\">\n    <thead>\n        <tr>\n            <th>\n                ");
            EndContext();
            BeginContext(251, 41, false);
#line 16 "C:\Users\educacion 3.0\source\repos\ProyectoInmobiliaria.net-master\Views\Inquilinos\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.IdInq));

#line default
#line hidden
            EndContext();
            BeginContext(292, 52, true);
            WriteLiteral("\n            </th>\n            <th>\n                ");
            EndContext();
            BeginContext(345, 42, false);
#line 19 "C:\Users\educacion 3.0\source\repos\ProyectoInmobiliaria.net-master\Views\Inquilinos\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Nombre));

#line default
#line hidden
            EndContext();
            BeginContext(387, 52, true);
            WriteLiteral("\n            </th>\n            <th>\n                ");
            EndContext();
            BeginContext(440, 44, false);
#line 22 "C:\Users\educacion 3.0\source\repos\ProyectoInmobiliaria.net-master\Views\Inquilinos\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Apellido));

#line default
#line hidden
            EndContext();
            BeginContext(484, 52, true);
            WriteLiteral("\n            </th>\n            <th>\n                ");
            EndContext();
            BeginContext(537, 39, false);
#line 25 "C:\Users\educacion 3.0\source\repos\ProyectoInmobiliaria.net-master\Views\Inquilinos\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Dni));

#line default
#line hidden
            EndContext();
            BeginContext(576, 52, true);
            WriteLiteral("\n            </th>\n            <th>\n                ");
            EndContext();
            BeginContext(629, 44, false);
#line 28 "C:\Users\educacion 3.0\source\repos\ProyectoInmobiliaria.net-master\Views\Inquilinos\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Telefono));

#line default
#line hidden
            EndContext();
            BeginContext(673, 52, true);
            WriteLiteral("\n            </th>\n            <th>\n                ");
            EndContext();
            BeginContext(726, 52, false);
#line 31 "C:\Users\educacion 3.0\source\repos\ProyectoInmobiliaria.net-master\Views\Inquilinos\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.DireccionTrabajo));

#line default
#line hidden
            EndContext();
            BeginContext(778, 80, true);
            WriteLiteral("\n            </th>\n            <th></th>\n        </tr>\n    </thead>\n    <tbody>\n");
            EndContext();
#line 37 "C:\Users\educacion 3.0\source\repos\ProyectoInmobiliaria.net-master\Views\Inquilinos\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(889, 46, true);
            WriteLiteral("        <tr>\n            <td>\n                ");
            EndContext();
            BeginContext(936, 40, false);
#line 40 "C:\Users\educacion 3.0\source\repos\ProyectoInmobiliaria.net-master\Views\Inquilinos\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.IdInq));

#line default
#line hidden
            EndContext();
            BeginContext(976, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(1029, 41, false);
#line 43 "C:\Users\educacion 3.0\source\repos\ProyectoInmobiliaria.net-master\Views\Inquilinos\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Nombre));

#line default
#line hidden
            EndContext();
            BeginContext(1070, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(1123, 43, false);
#line 46 "C:\Users\educacion 3.0\source\repos\ProyectoInmobiliaria.net-master\Views\Inquilinos\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Apellido));

#line default
#line hidden
            EndContext();
            BeginContext(1166, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(1219, 38, false);
#line 49 "C:\Users\educacion 3.0\source\repos\ProyectoInmobiliaria.net-master\Views\Inquilinos\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Dni));

#line default
#line hidden
            EndContext();
            BeginContext(1257, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(1310, 43, false);
#line 52 "C:\Users\educacion 3.0\source\repos\ProyectoInmobiliaria.net-master\Views\Inquilinos\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Telefono));

#line default
#line hidden
            EndContext();
            BeginContext(1353, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(1406, 51, false);
#line 55 "C:\Users\educacion 3.0\source\repos\ProyectoInmobiliaria.net-master\Views\Inquilinos\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.DireccionTrabajo));

#line default
#line hidden
            EndContext();
            BeginContext(1457, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(1510, 56, false);
#line 58 "C:\Users\educacion 3.0\source\repos\ProyectoInmobiliaria.net-master\Views\Inquilinos\Index.cshtml"
           Write(Html.ActionLink("Edit", "Edit", new { id = item.IdInq }));

#line default
#line hidden
            EndContext();
            BeginContext(1566, 19, true);
            WriteLiteral(" |\n                ");
            EndContext();
            BeginContext(1586, 62, false);
#line 59 "C:\Users\educacion 3.0\source\repos\ProyectoInmobiliaria.net-master\Views\Inquilinos\Index.cshtml"
           Write(Html.ActionLink("Details", "Details", new { id = item.IdInq }));

#line default
#line hidden
            EndContext();
            BeginContext(1648, 19, true);
            WriteLiteral(" |\n                ");
            EndContext();
            BeginContext(1668, 60, false);
#line 60 "C:\Users\educacion 3.0\source\repos\ProyectoInmobiliaria.net-master\Views\Inquilinos\Index.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new { id = item.IdInq }));

#line default
#line hidden
            EndContext();
            BeginContext(1728, 7, true);
            WriteLiteral("\n</tr>\n");
            EndContext();
#line 62 "C:\Users\educacion 3.0\source\repos\ProyectoInmobiliaria.net-master\Views\Inquilinos\Index.cshtml"
}

#line default
#line hidden
            BeginContext(1737, 22, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ProyectoInmobiliaria.Models.Inquilino>> Html { get; private set; }
    }
}
#pragma warning restore 1591
