#pragma checksum "C:\Users\javie\OneDrive\Escritorio\Proyecto - Tienda Online\TiendaOnline\Areas\Cliente\Views\User\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8f54541566645d8e417f4212e184ebbb5dba26b1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Cliente_Views_User_Index), @"mvc.1.0.view", @"/Areas/Cliente/Views/User/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Cliente/Views/User/Index.cshtml", typeof(AspNetCore.Areas_Cliente_Views_User_Index))]
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
#line 1 "C:\Users\javie\OneDrive\Escritorio\Proyecto - Tienda Online\TiendaOnline\Areas\Cliente\Views\User\Index.cshtml"
using TiendaOnline.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8f54541566645d8e417f4212e184ebbb5dba26b1", @"/Areas/Cliente/Views/User/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"470a8bb87071ec9601f50d37aca56fcf7f1fd3e1", @"/Areas/Cliente/Views/_ViewImports.cshtml")]
    public class Areas_Cliente_Views_User_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ApplicationUser>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("button button-contactForm boxed-btn p-3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Active", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("button button-contactForm bg-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("button button-contactForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_PartialView", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\javie\OneDrive\Escritorio\Proyecto - Tienda Online\TiendaOnline\Areas\Cliente\Views\User\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(102, 212, true);
            WriteLiteral("<br />\n<br />\n\n<div class=\"container\">\n    <div class=\"row\">\n        <div class=\"col-6\">\n            <h2 class=\"text-info\">Lista de Usuarios</h2>\n        </div>\n        <div class=\"col-6 text-right\">\n            ");
            EndContext();
            BeginContext(314, 88, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8f54541566645d8e417f4212e184ebbb5dba26b16264", async() => {
                BeginContext(385, 13, true);
                WriteLiteral("Nuevo Usuario");
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
            BeginContext(402, 490, true);
            WriteLiteral(@"
        </div>
    </div>

    <br />

    <div>
        <table class=""table table-striped border text-center"">

            <tr class=""table-info "">
                <th>
                    Fecha de Nacimiento
                </th>
                <th>
                    Usuario
                </th>
                <th>Estado</th>
                <th>

                </th>
                <th class=""text-center"">
                    Acción
                </th>
            </tr>

");
            EndContext();
#line 40 "C:\Users\javie\OneDrive\Escritorio\Proyecto - Tienda Online\TiendaOnline\Areas\Cliente\Views\User\Index.cshtml"
             foreach (var k in Model)
            {

#line default
#line hidden
            BeginContext(944, 70, true);
            WriteLiteral("                <tr>\n                    <td>\n                        ");
            EndContext();
            BeginContext(1015, 17, false);
#line 44 "C:\Users\javie\OneDrive\Escritorio\Proyecto - Tienda Online\TiendaOnline\Areas\Cliente\Views\User\Index.cshtml"
                   Write(k.fechaNacimiento);

#line default
#line hidden
            EndContext();
            BeginContext(1032, 76, true);
            WriteLiteral("\n                    </td>\n                    <td>\n                        ");
            EndContext();
            BeginContext(1109, 10, false);
#line 47 "C:\Users\javie\OneDrive\Escritorio\Proyecto - Tienda Online\TiendaOnline\Areas\Cliente\Views\User\Index.cshtml"
                   Write(k.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(1119, 28, true);
            WriteLiteral("\n                    </td>\n\n");
            EndContext();
#line 50 "C:\Users\javie\OneDrive\Escritorio\Proyecto - Tienda Online\TiendaOnline\Areas\Cliente\Views\User\Index.cshtml"
                     if (k.LockoutEnd > DateTime.Now && k.LockoutEnd != null)
                    {

#line default
#line hidden
            BeginContext(1247, 197, true);
            WriteLiteral("                        <td>Usuario Inactivo</td>\n                        <td></td>\n                        <td>\n                            <div class=\"btn-group\">\n                                ");
            EndContext();
            BeginContext(1444, 99, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8f54541566645d8e417f4212e184ebbb5dba26b110004", async() => {
                BeginContext(1533, 6, true);
                WriteLiteral("Editar");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 56 "C:\Users\javie\OneDrive\Escritorio\Proyecto - Tienda Online\TiendaOnline\Areas\Cliente\Views\User\Index.cshtml"
                                                                                                      WriteLiteral(k.Id);

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
            BeginContext(1543, 33, true);
            WriteLiteral("\n                                ");
            EndContext();
            BeginContext(1576, 90, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8f54541566645d8e417f4212e184ebbb5dba26b112538", async() => {
                BeginContext(1654, 8, true);
                WriteLiteral("Eliminar");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 57 "C:\Users\javie\OneDrive\Escritorio\Proyecto - Tienda Online\TiendaOnline\Areas\Cliente\Views\User\Index.cshtml"
                                                                                           WriteLiteral(k.Id);

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
            BeginContext(1666, 66, true);
            WriteLiteral("\n                            </div>\n                        </td>\n");
            EndContext();
#line 60 "C:\Users\javie\OneDrive\Escritorio\Proyecto - Tienda Online\TiendaOnline\Areas\Cliente\Views\User\Index.cshtml"
                    }
                    else
                    {

#line default
#line hidden
            BeginContext(1801, 105, true);
            WriteLiteral("                        <td>Usuario Activo</td>\n                        <td>\n                            ");
            EndContext();
            BeginContext(1906, 45, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "8f54541566645d8e417f4212e184ebbb5dba26b115530", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
#line 65 "C:\Users\javie\OneDrive\Escritorio\Proyecto - Tienda Online\TiendaOnline\Areas\Cliente\Views\User\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = k.Id;

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
            BeginContext(1951, 31, true);
            WriteLiteral("\n                        </td>\n");
            EndContext();
#line 67 "C:\Users\javie\OneDrive\Escritorio\Proyecto - Tienda Online\TiendaOnline\Areas\Cliente\Views\User\Index.cshtml"
                    }

#line default
#line hidden
            BeginContext(2004, 23, true);
            WriteLiteral("\n                </tr>\n");
            EndContext();
#line 70 "C:\Users\javie\OneDrive\Escritorio\Proyecto - Tienda Online\TiendaOnline\Areas\Cliente\Views\User\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(2041, 37, true);
            WriteLiteral("\n        </table>\n    </div>\n</div>\n\n");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(2095, 202, true);
                WriteLiteral("\n    <script src=\"//cdn.jsdelivr.net/npm/alertifyjs@1.13.1/build/alertify.min.js\"></script>\n\n    <script type=\"text/javascript\">\n        $(function () {\n            //Guardar\n            var guardar = \'");
                EndContext();
                BeginContext(2298, 19, false);
#line 82 "C:\Users\javie\OneDrive\Escritorio\Proyecto - Tienda Online\TiendaOnline\Areas\Cliente\Views\User\Index.cshtml"
                      Write(TempData["guardar"]);

#line default
#line hidden
                EndContext();
                BeginContext(2317, 141, true);
                WriteLiteral("\'\n            if (guardar != \'\') {\n                alertify.success(guardar);\n            }\n\n            //Editar\n\n            var editar = \'");
                EndContext();
                BeginContext(2459, 18, false);
#line 89 "C:\Users\javie\OneDrive\Escritorio\Proyecto - Tienda Online\TiendaOnline\Areas\Cliente\Views\User\Index.cshtml"
                     Write(TempData["editar"]);

#line default
#line hidden
                EndContext();
                BeginContext(2477, 142, true);
                WriteLiteral("\'\n            if (editar != \'\') {\n                alertify.success(editar);\n            }\n\n            //Eliminar\n            var eliminar = \'");
                EndContext();
                BeginContext(2620, 20, false);
#line 95 "C:\Users\javie\OneDrive\Escritorio\Proyecto - Tienda Online\TiendaOnline\Areas\Cliente\Views\User\Index.cshtml"
                       Write(TempData["eliminar"]);

#line default
#line hidden
                EndContext();
                BeginContext(2640, 120, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ApplicationUser>> Html { get; private set; }
    }
}
#pragma warning restore 1591
