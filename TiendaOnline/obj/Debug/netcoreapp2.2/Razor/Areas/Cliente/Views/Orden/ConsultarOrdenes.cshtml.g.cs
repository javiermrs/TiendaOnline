#pragma checksum "C:\Users\javie\OneDrive\Escritorio\Proyecto - Tienda Online\TiendaOnline\Areas\Cliente\Views\Orden\ConsultarOrdenes.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "23d229e8e87e592f57bb60075daf8e24df6a6ff9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Cliente_Views_Orden_ConsultarOrdenes), @"mvc.1.0.view", @"/Areas/Cliente/Views/Orden/ConsultarOrdenes.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Cliente/Views/Orden/ConsultarOrdenes.cshtml", typeof(AspNetCore.Areas_Cliente_Views_Orden_ConsultarOrdenes))]
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
#line 1 "C:\Users\javie\OneDrive\Escritorio\Proyecto - Tienda Online\TiendaOnline\Areas\Cliente\Views\_ViewImports.cshtml"
using TiendaOnline;

#line default
#line hidden
#line 2 "C:\Users\javie\OneDrive\Escritorio\Proyecto - Tienda Online\TiendaOnline\Areas\Cliente\Views\_ViewImports.cshtml"
using TiendaOnline.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23d229e8e87e592f57bb60075daf8e24df6a6ff9", @"/Areas/Cliente/Views/Orden/ConsultarOrdenes.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"470a8bb87071ec9601f50d37aca56fcf7f1fd3e1", @"/Areas/Cliente/Views/_ViewImports.cshtml")]
    public class Areas_Cliente_Views_Orden_ConsultarOrdenes : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<TiendaOnline.Models.Orden>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn_3 p-2 pl-4 pr-4"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\javie\OneDrive\Escritorio\Proyecto - Tienda Online\TiendaOnline\Areas\Cliente\Views\Orden\ConsultarOrdenes.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(84, 493, true);
            WriteLiteral(@"
<br />
<br />
<div class=""container"">

    <div class=""row"">
        <div class=""col-6"">
            <h2 class=""text-dark text-center"">Mis Ordenes</h2>
        </div>
    </div>
    <br />
    <div>
        <table class=""table table-striped border text-center "">

            <tr class=""table-info text-center"">
                <th scope=""col"">Numero de Orden</th>
                <th>Nombre del Cliente</th>
                <th>Fecha</th>
                <th>Estado</th>


            </tr>
");
            EndContext();
#line 27 "C:\Users\javie\OneDrive\Escritorio\Proyecto - Tienda Online\TiendaOnline\Areas\Cliente\Views\Orden\ConsultarOrdenes.cshtml"
             foreach (var k in Model)
            {

#line default
#line hidden
            BeginContext(629, 68, true);
            WriteLiteral("                <tr class=\"\">\n                    <td class=\"visit\">");
            EndContext();
            BeginContext(698, 13, false);
#line 30 "C:\Users\javie\OneDrive\Escritorio\Proyecto - Tienda Online\TiendaOnline\Areas\Cliente\Views\Orden\ConsultarOrdenes.cshtml"
                                 Write(k.numeroOrden);

#line default
#line hidden
            EndContext();
            BeginContext(711, 30, true);
            WriteLiteral("</td>\n                    <td>");
            EndContext();
            BeginContext(742, 8, false);
#line 31 "C:\Users\javie\OneDrive\Escritorio\Proyecto - Tienda Online\TiendaOnline\Areas\Cliente\Views\Orden\ConsultarOrdenes.cshtml"
                   Write(k.Nombre);

#line default
#line hidden
            EndContext();
            BeginContext(750, 30, true);
            WriteLiteral("</td>\n                    <td>");
            EndContext();
            BeginContext(781, 7, false);
#line 32 "C:\Users\javie\OneDrive\Escritorio\Proyecto - Tienda Online\TiendaOnline\Areas\Cliente\Views\Orden\ConsultarOrdenes.cshtml"
                   Write(k.Fecha);

#line default
#line hidden
            EndContext();
            BeginContext(788, 30, true);
            WriteLiteral("</td>\n                    <td>");
            EndContext();
            BeginContext(819, 8, false);
#line 33 "C:\Users\javie\OneDrive\Escritorio\Proyecto - Tienda Online\TiendaOnline\Areas\Cliente\Views\Orden\ConsultarOrdenes.cshtml"
                   Write(k.Estado);

#line default
#line hidden
            EndContext();
            BeginContext(827, 30, true);
            WriteLiteral("</td>\n\n\n                </tr>\n");
            EndContext();
#line 37 "C:\Users\javie\OneDrive\Escritorio\Proyecto - Tienda Online\TiendaOnline\Areas\Cliente\Views\Orden\ConsultarOrdenes.cshtml"
            }

#line default
#line hidden
            BeginContext(871, 34, true);
            WriteLiteral("        </table>\n\n    </div>\n\n    ");
            EndContext();
            BeginContext(905, 82, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "23d229e8e87e592f57bb60075daf8e24df6a6ff97495", async() => {
                BeginContext(977, 6, true);
                WriteLiteral("Volver");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(987, 8, true);
            WriteLiteral("\n\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<TiendaOnline.Models.Orden>> Html { get; private set; }
    }
}
#pragma warning restore 1591
