#pragma checksum "C:\Users\acer\OneDrive\Escritorio\Proyecto_3er_Ciclo\MantenimientoTIC\presentacion\Pages\Persona\Persona.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "27c2798d585d0a17a5fb2de58240635be58b3b48"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(presentacion.Pages.Persona.Pages_Persona_Persona), @"mvc.1.0.razor-page", @"/Pages/Persona/Persona.cshtml")]
namespace presentacion.Pages.Persona
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\acer\OneDrive\Escritorio\Proyecto_3er_Ciclo\MantenimientoTIC\presentacion\Pages\_ViewImports.cshtml"
using presentacion;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"27c2798d585d0a17a5fb2de58240635be58b3b48", @"/Pages/Persona/Persona.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e52c7aa6b92c6a21f6f51b18846af8d2d3133abd", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Persona_Persona : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<h1>Listado de Saludos en Varios Idiomas</h1>
<table class=""table"">
  <thead>
    <tr>
      <th scope=""col"">#</th>
      <th scope=""col"">Cedula</th>
      <th scope=""col"">Nombre</th>
      <th scope=""col"">Apellidos</th>
      <th scope=""col"">Celular</th>
      <th scope=""col"">Correo</th>
      <th scope=""col"">Direccion</th>
      <th scope=""col"">Clasificacion</th>
    </tr>
  </thead>
  <tbody>
");
#nullable restore
#line 20 "C:\Users\acer\OneDrive\Escritorio\Proyecto_3er_Ciclo\MantenimientoTIC\presentacion\Pages\Persona\Persona.cshtml"
     foreach (var personas in Model.persona)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 23 "C:\Users\acer\OneDrive\Escritorio\Proyecto_3er_Ciclo\MantenimientoTIC\presentacion\Pages\Persona\Persona.cshtml"
           Write(personas.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 24 "C:\Users\acer\OneDrive\Escritorio\Proyecto_3er_Ciclo\MantenimientoTIC\presentacion\Pages\Persona\Persona.cshtml"
           Write(personas.Cedula);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 25 "C:\Users\acer\OneDrive\Escritorio\Proyecto_3er_Ciclo\MantenimientoTIC\presentacion\Pages\Persona\Persona.cshtml"
           Write(personas.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 26 "C:\Users\acer\OneDrive\Escritorio\Proyecto_3er_Ciclo\MantenimientoTIC\presentacion\Pages\Persona\Persona.cshtml"
           Write(personas.Apellido);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 27 "C:\Users\acer\OneDrive\Escritorio\Proyecto_3er_Ciclo\MantenimientoTIC\presentacion\Pages\Persona\Persona.cshtml"
           Write(personas.Celular);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 28 "C:\Users\acer\OneDrive\Escritorio\Proyecto_3er_Ciclo\MantenimientoTIC\presentacion\Pages\Persona\Persona.cshtml"
           Write(personas.Correo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 29 "C:\Users\acer\OneDrive\Escritorio\Proyecto_3er_Ciclo\MantenimientoTIC\presentacion\Pages\Persona\Persona.cshtml"
           Write(personas.Direccion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 30 "C:\Users\acer\OneDrive\Escritorio\Proyecto_3er_Ciclo\MantenimientoTIC\presentacion\Pages\Persona\Persona.cshtml"
           Write(personas.Clasificacion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n");
#nullable restore
#line 32 "C:\Users\acer\OneDrive\Escritorio\Proyecto_3er_Ciclo\MantenimientoTIC\presentacion\Pages\Persona\Persona.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(" </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<presentacion.Pages.PersonaModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<presentacion.Pages.PersonaModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<presentacion.Pages.PersonaModel>)PageContext?.ViewData;
        public presentacion.Pages.PersonaModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
