#pragma checksum "C:\Users\acer\OneDrive\Escritorio\Proyecto_3er_Ciclo\MantenimientoTIC\presentacion\Pages\Vehiculo\InfoVehiculo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "adb0139cbc1ad53768ae389eb92d9e88c793c56a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(presentacion.Pages.Vehiculo.Pages_Vehiculo_InfoVehiculo), @"mvc.1.0.razor-page", @"/Pages/Vehiculo/InfoVehiculo.cshtml")]
namespace presentacion.Pages.Vehiculo
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"adb0139cbc1ad53768ae389eb92d9e88c793c56a", @"/Pages/Vehiculo/InfoVehiculo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e52c7aa6b92c6a21f6f51b18846af8d2d3133abd", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Vehiculo_InfoVehiculo : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/Persona.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "adb0139cbc1ad53768ae389eb92d9e88c793c56a3856", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "adb0139cbc1ad53768ae389eb92d9e88c793c56a4118", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<ol class=\"breadcrumb\">\r\n    <li class=\"breadcrumb-item active\">Secci??n Datos de Vehiculo</li>\r\n</ol>\r\n<div>\r\n  <h5>Datos del Vehiculo <strong>");
#nullable restore
#line 12 "C:\Users\acer\OneDrive\Escritorio\Proyecto_3er_Ciclo\MantenimientoTIC\presentacion\Pages\Vehiculo\InfoVehiculo.cshtml"
                            Write(Model.InfoVehiculo.Placa);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></h5>\r\n    <br>\r\n    <div class=\"row\" id=\"info\">\r\n        <div class=\"col-md-2\">\r\n            <label><strong>Placa</strong></label>\r\n        </div>\r\n        <div class=\"col-md-10\">\r\n            ");
#nullable restore
#line 19 "C:\Users\acer\OneDrive\Escritorio\Proyecto_3er_Ciclo\MantenimientoTIC\presentacion\Pages\Vehiculo\InfoVehiculo.cshtml"
       Write(Html.DisplayFor(m => m.InfoVehiculo.Placa));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div class=\"col-md-2\">\r\n            <label><strong>Modelo</strong></label>\r\n        </div>\r\n        <div class=\"col-md-10\">\r\n            ");
#nullable restore
#line 25 "C:\Users\acer\OneDrive\Escritorio\Proyecto_3er_Ciclo\MantenimientoTIC\presentacion\Pages\Vehiculo\InfoVehiculo.cshtml"
       Write(Html.DisplayFor(m => m.InfoVehiculo.Modelo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div class=\"col-md-2\">\r\n            <label><strong>Servicio</strong></label>\r\n        </div>\r\n        <div class=\"col-md-10\">\r\n            ");
#nullable restore
#line 31 "C:\Users\acer\OneDrive\Escritorio\Proyecto_3er_Ciclo\MantenimientoTIC\presentacion\Pages\Vehiculo\InfoVehiculo.cshtml"
       Write(Html.DisplayFor(m => m.InfoVehiculo.Servicio));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div class=\"col-md-2\">\r\n            <label><strong>Color</strong></label>\r\n        </div>\r\n        <div class=\"col-md-10\">\r\n            ");
#nullable restore
#line 37 "C:\Users\acer\OneDrive\Escritorio\Proyecto_3er_Ciclo\MantenimientoTIC\presentacion\Pages\Vehiculo\InfoVehiculo.cshtml"
       Write(Html.DisplayFor(m => m.InfoVehiculo.color.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div class=\"col-md-2\">\r\n            <label><strong>Estilo</strong></label>\r\n        </div>\r\n        <div class=\"col-md-10\">\r\n            ");
#nullable restore
#line 43 "C:\Users\acer\OneDrive\Escritorio\Proyecto_3er_Ciclo\MantenimientoTIC\presentacion\Pages\Vehiculo\InfoVehiculo.cshtml"
       Write(Html.DisplayFor(m => m.InfoVehiculo.estilo.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div class=\"col-md-2\">\r\n            <label><strong>Marca</strong></label>\r\n        </div>\r\n        <div class=\"col-md-10\">\r\n            ");
#nullable restore
#line 49 "C:\Users\acer\OneDrive\Escritorio\Proyecto_3er_Ciclo\MantenimientoTIC\presentacion\Pages\Vehiculo\InfoVehiculo.cshtml"
       Write(Html.DisplayFor(m => m.InfoVehiculo.marca.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div class=\"col-md-2\">\r\n            <label><strong>Tipo Vehiculo</strong></label>\r\n        </div>\r\n        <div class=\"col-md-10\">\r\n            ");
#nullable restore
#line 55 "C:\Users\acer\OneDrive\Escritorio\Proyecto_3er_Ciclo\MantenimientoTIC\presentacion\Pages\Vehiculo\InfoVehiculo.cshtml"
       Write(Html.DisplayFor(m => m.InfoVehiculo.tipoVehiculo.Tipo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n       <div class=\"col-md-2\">\r\n            <label><strong>Propietario</strong></label>\r\n        </div>\r\n        <div class=\"col-md-10\">\r\n            ");
#nullable restore
#line 61 "C:\Users\acer\OneDrive\Escritorio\Proyecto_3er_Ciclo\MantenimientoTIC\presentacion\Pages\Vehiculo\InfoVehiculo.cshtml"
       Write(Html.DisplayFor(m => m.InfoVehiculo.persona.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<presentacion.Pages.InfoVehiculoModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<presentacion.Pages.InfoVehiculoModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<presentacion.Pages.InfoVehiculoModel>)PageContext?.ViewData;
        public presentacion.Pages.InfoVehiculoModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
