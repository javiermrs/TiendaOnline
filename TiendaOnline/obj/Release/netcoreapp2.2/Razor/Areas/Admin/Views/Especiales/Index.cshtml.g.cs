#pragma checksum "C:\Users\javie\OneDrive\Escritorio\Proyecto - Tienda Online\TiendaOnline\Areas\Admin\Views\Especiales\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5fe0a694602ea12ac0a1b0f2393eddac46e5a39a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Especiales_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Especiales/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Especiales/Index.cshtml", typeof(AspNetCore.Areas_Admin_Views_Especiales_Index))]
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
#line 1 "C:\Users\javie\OneDrive\Escritorio\Proyecto - Tienda Online\TiendaOnline\Areas\Admin\Views\_ViewImports.cshtml"
using TiendaOnline;

#line default
#line hidden
#line 1 "C:\Users\javie\OneDrive\Escritorio\Proyecto - Tienda Online\TiendaOnline\Areas\Admin\Views\Especiales\Index.cshtml"
using TiendaOnline.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5fe0a694602ea12ac0a1b0f2393eddac46e5a39a", @"/Areas/Admin/Views/Especiales/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"470a8bb87071ec9601f50d37aca56fcf7f1fd3e1", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Especiales_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Especiales>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_ButtonEspecialPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\javie\OneDrive\Escritorio\Proyecto - Tienda Online\TiendaOnline\Areas\Admin\Views\Especiales\Index.cshtml"
  
    ViewData["Title"] = "Especiales";

#line default
#line hidden
            BeginContext(102, 158, true);
            WriteLiteral("<br />\n<br />\n\n\n<div class=\"row\">\n    <div class=\"col-6\">\n        <h2 class=\"text-info\">Especiales</h2>\n    </div>\n    <div class=\"col-6 text-right\">\n        ");
            EndContext();
            BeginContext(260, 62, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5fe0a694602ea12ac0a1b0f2393eddac46e5a39a4880", async() => {
                BeginContext(304, 14, true);
                WriteLiteral("Nuevo Especial");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(322, 147, true);
            WriteLiteral("\n    </div>\n</div>\n\n<br />\n\n<div>\n    <table class=\"table table-striped border\">\n\n        <tr class=\"table-info\">\n            <th>\n                ");
            EndContext();
            BeginContext(470, 34, false);
#line 26 "C:\Users\javie\OneDrive\Escritorio\Proyecto - Tienda Online\TiendaOnline\Areas\Admin\Views\Especiales\Index.cshtml"
           Write(Html.DisplayNameFor(c => c.Nombre));

#line default
#line hidden
            EndContext();
            BeginContext(504, 148, true);
            WriteLiteral("\n            </th>\n            <th>\n\n            </th>\n            <th class=\"text-center\">\n                Acción\n            </th>\n        </tr>\n\n");
            EndContext();
#line 36 "C:\Users\javie\OneDrive\Escritorio\Proyecto - Tienda Online\TiendaOnline\Areas\Admin\Views\Especiales\Index.cshtml"
         foreach (var k in Model)
        {

#line default
#line hidden
            BeginContext(696, 58, true);
            WriteLiteral("            <tr>\n                <td>\n                    ");
            EndContext();
            BeginContext(755, 8, false);
#line 40 "C:\Users\javie\OneDrive\Escritorio\Proyecto - Tienda Online\TiendaOnline\Areas\Admin\Views\Especiales\Index.cshtml"
               Write(k.Nombre);

#line default
#line hidden
            EndContext();
            BeginContext(763, 64, true);
            WriteLiteral("\n                </td>\n                <td>\n                    ");
            EndContext();
            BeginContext(827, 55, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "5fe0a694602ea12ac0a1b0f2393eddac46e5a39a7834", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
#line 43 "C:\Users\javie\OneDrive\Escritorio\Proyecto - Tienda Online\TiendaOnline\Areas\Admin\Views\Especiales\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = k.ID;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(882, 41, true);
            WriteLiteral("\n                </td>\n            </tr>\n");
            EndContext();
#line 46 "C:\Users\javie\OneDrive\Escritorio\Proyecto - Tienda Online\TiendaOnline\Areas\Admin\Views\Especiales\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(933, 23, true);
            WriteLiteral("\n    </table>\n</div>\n\n\n");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(973, 202, true);
                WriteLiteral("\n    <script src=\"//cdn.jsdelivr.net/npm/alertifyjs@1.13.1/build/alertify.min.js\"></script>\n\n    <script type=\"text/javascript\">\n        $(function () {\n            //Guardar\n            var guardar = \'");
                EndContext();
                BeginContext(1176, 19, false);
#line 58 "C:\Users\javie\OneDrive\Escritorio\Proyecto - Tienda Online\TiendaOnline\Areas\Admin\Views\Especiales\Index.cshtml"
                      Write(TempData["guardar"]);

#line default
#line hidden
                EndContext();
                BeginContext(1195, 141, true);
                WriteLiteral("\'\n            if (guardar != \'\') {\n                alertify.success(guardar);\n            }\n\n            //Editar\n\n            var editar = \'");
                EndContext();
                BeginContext(1337, 18, false);
#line 65 "C:\Users\javie\OneDrive\Escritorio\Proyecto - Tienda Online\TiendaOnline\Areas\Admin\Views\Especiales\Index.cshtml"
                     Write(TempData["editar"]);

#line default
#line hidden
                EndContext();
                BeginContext(1355, 142, true);
                WriteLiteral("\'\n            if (editar != \'\') {\n                alertify.success(editar);\n            }\n\n            //Eliminar\n            var eliminar = \'");
                EndContext();
                BeginContext(1498, 20, false);
#line 71 "C:\Users\javie\OneDrive\Escritorio\Proyecto - Tienda Online\TiendaOnline\Areas\Admin\Views\Especiales\Index.cshtml"
                       Write(TempData["eliminar"]);

#line default
#line hidden
                EndContext();
                BeginContext(1518, 120, true);
                WriteLiteral("\'\n            if (eliminar != \'\') {\n                alertify.error(eliminar);\n            }\n\n\n        })\n    </script>\n\n");
                EndContext();
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Especiales>> Html { get; private set; }
    }
}
#pragma warning restore 1591
