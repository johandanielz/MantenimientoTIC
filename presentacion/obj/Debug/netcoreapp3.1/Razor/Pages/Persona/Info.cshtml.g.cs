#pragma checksum "C:\Users\acer\OneDrive\Escritorio\Proyecto_3er_Ciclo\MantenimientoTIC\presentacion\Pages\Persona\Info.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a7d992755e7e7ed4cb823ecdeeb2fb68b4e04a62"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(presentacion.Pages.Persona.Pages_Persona_Info), @"mvc.1.0.razor-page", @"/Pages/Persona/Info.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a7d992755e7e7ed4cb823ecdeeb2fb68b4e04a62", @"/Pages/Persona/Info.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e52c7aa6b92c6a21f6f51b18846af8d2d3133abd", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Persona_Info : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a7d992755e7e7ed4cb823ecdeeb2fb68b4e04a623809", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a7d992755e7e7ed4cb823ecdeeb2fb68b4e04a624071", async() => {
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
            WriteLiteral("\r\n<ol class=\"breadcrumb\">\r\n    <li class=\"breadcrumb-item active\">Secci??n Datos de Personas</li>\r\n</ol>\r\n<div>\r\n  <h5>Datos de <strong>");
#nullable restore
#line 12 "C:\Users\acer\OneDrive\Escritorio\Proyecto_3er_Ciclo\MantenimientoTIC\presentacion\Pages\Persona\Info.cshtml"
                  Write(Model.ListPersona.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></h5>\r\n    <br>\r\n    <div class=\"row\" id=\"info\">\r\n        <div class=\"col-md-2\">\r\n            <label><strong>Tipo de Documento</strong></label>\r\n        </div>\r\n        <div class=\"col-md-10\">\r\n            ");
#nullable restore
#line 19 "C:\Users\acer\OneDrive\Escritorio\Proyecto_3er_Ciclo\MantenimientoTIC\presentacion\Pages\Persona\Info.cshtml"
       Write(Html.DisplayFor(m => m.ListPersona.TipoDocumento));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div class=\"col-md-2\">\r\n            <label><strong>Nombres</strong></label>\r\n        </div>\r\n        <div class=\"col-md-10\">\r\n            ");
#nullable restore
#line 25 "C:\Users\acer\OneDrive\Escritorio\Proyecto_3er_Ciclo\MantenimientoTIC\presentacion\Pages\Persona\Info.cshtml"
       Write(Html.DisplayFor(m => m.ListPersona.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div class=\"col-md-2\">\r\n            <label><strong>Apellidos</strong></label>\r\n        </div>\r\n        <div class=\"col-md-10\">\r\n            ");
#nullable restore
#line 31 "C:\Users\acer\OneDrive\Escritorio\Proyecto_3er_Ciclo\MantenimientoTIC\presentacion\Pages\Persona\Info.cshtml"
       Write(Html.DisplayFor(m => m.ListPersona.Apellido));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div class=\"col-md-2\">\r\n            <label><strong>Celular</strong></label>\r\n        </div>\r\n        <div class=\"col-md-10\">\r\n            ");
#nullable restore
#line 37 "C:\Users\acer\OneDrive\Escritorio\Proyecto_3er_Ciclo\MantenimientoTIC\presentacion\Pages\Persona\Info.cshtml"
       Write(Html.DisplayFor(m => m.ListPersona.Celular));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div class=\"col-md-2\">\r\n            <label><strong>Correo</strong></label>\r\n        </div>\r\n        <div class=\"col-md-10\">\r\n            ");
#nullable restore
#line 43 "C:\Users\acer\OneDrive\Escritorio\Proyecto_3er_Ciclo\MantenimientoTIC\presentacion\Pages\Persona\Info.cshtml"
       Write(Html.DisplayFor(m => m.ListPersona.Correo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div class=\"col-md-2\">\r\n            <label><strong>Direccion</strong></label>\r\n        </div>\r\n        <div class=\"col-md-10\">\r\n            ");
#nullable restore
#line 49 "C:\Users\acer\OneDrive\Escritorio\Proyecto_3er_Ciclo\MantenimientoTIC\presentacion\Pages\Persona\Info.cshtml"
       Write(Html.DisplayFor(m => m.ListPersona.Direccion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div class=\"col-md-2\">\r\n            <label><strong>Tipo de Persona</strong></label>\r\n        </div>\r\n        <div class=\"col-md-10\">\r\n            ");
#nullable restore
#line 55 "C:\Users\acer\OneDrive\Escritorio\Proyecto_3er_Ciclo\MantenimientoTIC\presentacion\Pages\Persona\Info.cshtml"
       Write(Html.DisplayFor(m => m.ListPersona.Clasificacion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n    ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<presentacion.Pages.EditModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<presentacion.Pages.EditModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<presentacion.Pages.EditModel>)PageContext?.ViewData;
        public presentacion.Pages.EditModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
