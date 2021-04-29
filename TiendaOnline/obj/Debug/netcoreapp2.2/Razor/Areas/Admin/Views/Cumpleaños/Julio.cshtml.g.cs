#pragma checksum "C:\Users\javie\OneDrive\Escritorio\Proyecto - Tienda Online\TiendaOnline\Areas\Admin\Views\Cumpleaños\Julio.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3052703718747e355f361c3985ade411314325f4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Cumpleaños_Julio), @"mvc.1.0.view", @"/Areas/Admin/Views/Cumpleaños/Julio.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Cumpleaños/Julio.cshtml", typeof(AspNetCore.Areas_Admin_Views_Cumpleaños_Julio))]
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
#line 2 "C:\Users\javie\OneDrive\Escritorio\Proyecto - Tienda Online\TiendaOnline\Areas\Admin\Views\_ViewImports.cshtml"
using TiendaOnline.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3052703718747e355f361c3985ade411314325f4", @"/Areas/Admin/Views/Cumpleaños/Julio.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"470a8bb87071ec9601f50d37aca56fcf7f1fd3e1", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Cumpleaños_Julio : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<TiendaOnline.Models.ApplicationUser>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\javie\OneDrive\Escritorio\Proyecto - Tienda Online\TiendaOnline\Areas\Admin\Views\Cumpleaños\Julio.cshtml"
  
    ViewData["Title"] = "Cumpleaños Julio";

#line default
#line hidden
            BeginContext(105, 475, true);
            WriteLiteral(@"
<br />
<br />
<div class=""container"">

    <div class=""row"">
        <div class=""col-6"">
            <h2 class=""text-info"">Cumpleaños del mes de Julio</h2>

        </div>
    </div>
    <br />

    <div>
        <table class=""table table-striped border text-center"" id=""cumple"">
            <thead>
                <tr class=""table-info"">
                    <th>Correo</th>
                    <th>Fecha</th>
                </tr>
            </thead>
            <tbody>
");
            EndContext();
#line 27 "C:\Users\javie\OneDrive\Escritorio\Proyecto - Tienda Online\TiendaOnline\Areas\Admin\Views\Cumpleaños\Julio.cshtml"
                 foreach (var k in Model)
                {

#line default
#line hidden
            BeginContext(640, 53, true);
            WriteLiteral("                    <tr>\n                        <td>");
            EndContext();
            BeginContext(694, 10, false);
#line 30 "C:\Users\javie\OneDrive\Escritorio\Proyecto - Tienda Online\TiendaOnline\Areas\Admin\Views\Cumpleaños\Julio.cshtml"
                       Write(k.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(704, 34, true);
            WriteLiteral("</td>\n                        <td>");
            EndContext();
            BeginContext(739, 17, false);
#line 31 "C:\Users\javie\OneDrive\Escritorio\Proyecto - Tienda Online\TiendaOnline\Areas\Admin\Views\Cumpleaños\Julio.cshtml"
                       Write(k.fechaNacimiento);

#line default
#line hidden
            EndContext();
            BeginContext(756, 32, true);
            WriteLiteral("</td>\n                    </tr>\n");
            EndContext();
#line 33 "C:\Users\javie\OneDrive\Escritorio\Proyecto - Tienda Online\TiendaOnline\Areas\Admin\Views\Cumpleaños\Julio.cshtml"

                }

#line default
#line hidden
            BeginContext(807, 60, true);
            WriteLiteral("            </tbody>\n        </table>\n    </div>\n    </div>\n");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(888, 2379, true);
                WriteLiteral(@"
        <script type=""text/javascript"">

            //DataTable
            $(document).ready(function () {
                $('#cumple').DataTable({
                    ""language"": idioma_espanol,
                    dom: 'Bfrtip',
                    buttons: [
                        {
                            extend: 'copy',
                            text: 'COPIAR'
                        },
                        {
                            extend: 'pdf',
                            text: 'PDF'
                        },
                        {
                            extend: 'excel',
                            text: 'EXCEL'
                        },
                        {
                            extend: 'csv',
                            text: 'CSV'
                        },
                        {
                            extend: 'print',
                            text: 'IMPRIMIR'
                        }
                    ]
                });
            });

      ");
                WriteLiteral(@"      var idioma_espanol = {
                ""sProcessing"": ""Procesando..."",
                ""sLengthMenu"": ""Mostrar _MENU_ registros"",
                ""sZeroRecords"": ""No se encontraron resultados"",
                ""sEmptyTable"": ""Ningún dato disponible en esta tabla"",
                ""sInfo"": ""Mostrando registros del _START_ al _END_ de un total de _TOTAL_ registros"",
                ""sInfoEmpty"": ""Mostrando registros del 0 al 0 de un total de 0 registros"",
                ""sInfoFiltered"": ""(filtrado de un total de _MAX_ registros)"",
                ""sInfoPostFix"": """",
                ""sSearch"": ""Buscar:"",
                ""sUrl"": """",
                ""sInfoThousands"": "","",
                ""sLoadingRecords"": ""Cargando..."",
                ""oPaginate"": {
                    ""sFirst"": ""Primero"",
                    ""sLast"": ""Último"",
                    ""sNext"": ""Siguiente"",
                    ""sPrevious"": ""Anterior""
                },
                ""oAria"": {
                    ""sSortAscending"": "": Activar");
                WriteLiteral(@" para ordenar la columna de manera ascendente"",
                    ""sSortDescending"": "": Activar para ordenar la columna de manera descendente""
                },
                ""buttons"": {
                    ""copy"": ""Copiar"",
                    ""colvis"": ""Visibilidad""
                }
            }

        </script>

    ");
                EndContext();
            }
            );
            BeginContext(3269, 3, true);
            WriteLiteral("\n\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<TiendaOnline.Models.ApplicationUser>> Html { get; private set; }
    }
}
#pragma warning restore 1591
