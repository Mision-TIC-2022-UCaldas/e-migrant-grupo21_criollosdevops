#pragma checksum "C:\Users\Pablo Mayorga\Documents\mision tic\ciclo 4\programacion\Hackaton\E-Migrant\E-Migrant.App\E_Migrant.App.FrontEnd\Pages\Migrante\ListarMigrante.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7ce2713211b8c75419ebcfd117a3acb6c5945fc1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(E_Migrant.App.FrontEnd.Pages.Migrante.Pages_Migrante_ListarMigrante), @"mvc.1.0.razor-page", @"/Pages/Migrante/ListarMigrante.cshtml")]
namespace E_Migrant.App.FrontEnd.Pages.Migrante
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
#line 1 "C:\Users\Pablo Mayorga\Documents\mision tic\ciclo 4\programacion\Hackaton\E-Migrant\E-Migrant.App\E_Migrant.App.FrontEnd\Pages\_ViewImports.cshtml"
using E_Migrant.App.FrontEnd;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7ce2713211b8c75419ebcfd117a3acb6c5945fc1", @"/Pages/Migrante/ListarMigrante.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"29f80d627369a9adfc720bbccab5385fe0c8f011", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Migrante_ListarMigrante : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary table-btn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./CrearCliente", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("color:#FFC300"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./ListarMigrante", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./EditarMigrante", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class = \"center\">\r\n<h3>Listar Migrante</h3>\r\n<p>En está página podrá visualizar su registro de migrante</p>\r\n<div class=\"form-group row\" style=\"text-align: left:10%\" id=\"detail\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7ce2713211b8c75419ebcfd117a3acb6c5945fc14973", async() => {
                WriteLiteral("Agregar Migrante");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"</div>

<table class=""table table-dark"">
  <thead class=""thead-dark"">
    <tr>
        <th scope=""col"">Tipo_Documento</th>
      <th scope=""col"">Numero_Documento</th>
      <th scope=""col"">Nombre</th>
      <th scope=""col"">Apellidos</th>
      <th scope=""col"">Fecha de Nacimiento</th>
      <th scope=""col"">Email</th>
      <th scope=""col"">Telefono</th>
      <th scope=""col"">Direccion</th>
      <th scope=""col"">Pais</th>
      <th scope=""col"">Ciudad</th>
      <th scope=""col"">Situacion_Laboral</th>
      
    </tr>
  </thead>
");
#nullable restore
#line 27 "C:\Users\Pablo Mayorga\Documents\mision tic\ciclo 4\programacion\Hackaton\E-Migrant\E-Migrant.App\E_Migrant.App.FrontEnd\Pages\Migrante\ListarMigrante.cshtml"
 foreach(var migrante in Model.migrantes){

#line default
#line hidden
#nullable disable
            WriteLiteral("    <tr>\r\n        <td>");
#nullable restore
#line 29 "C:\Users\Pablo Mayorga\Documents\mision tic\ciclo 4\programacion\Hackaton\E-Migrant\E-Migrant.App\E_Migrant.App.FrontEnd\Pages\Migrante\ListarMigrante.cshtml"
       Write(migrante.Tipo_Documento);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td><b>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7ce2713211b8c75419ebcfd117a3acb6c5945fc17463", async() => {
#nullable restore
#line 30 "C:\Users\Pablo Mayorga\Documents\mision tic\ciclo 4\programacion\Hackaton\E-Migrant\E-Migrant.App\E_Migrant.App.FrontEnd\Pages\Migrante\ListarMigrante.cshtml"
                                                                                           Write(migrante.Numero_Documento);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 30 "C:\Users\Pablo Mayorga\Documents\mision tic\ciclo 4\programacion\Hackaton\E-Migrant\E-Migrant.App\E_Migrant.App.FrontEnd\Pages\Migrante\ListarMigrante.cshtml"
                                                                      WriteLiteral(migrante.Id);

#line default
#line hidden
#nullable disable
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
            WriteLiteral("</b></td>\r\n        <td>");
#nullable restore
#line 31 "C:\Users\Pablo Mayorga\Documents\mision tic\ciclo 4\programacion\Hackaton\E-Migrant\E-Migrant.App\E_Migrant.App.FrontEnd\Pages\Migrante\ListarMigrante.cshtml"
       Write(migrante.Apellidos);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 32 "C:\Users\Pablo Mayorga\Documents\mision tic\ciclo 4\programacion\Hackaton\E-Migrant\E-Migrant.App\E_Migrant.App.FrontEnd\Pages\Migrante\ListarMigrante.cshtml"
       Write(migrante.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 33 "C:\Users\Pablo Mayorga\Documents\mision tic\ciclo 4\programacion\Hackaton\E-Migrant\E-Migrant.App\E_Migrant.App.FrontEnd\Pages\Migrante\ListarMigrante.cshtml"
       Write(migrante.Fecha_nacimiento);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 34 "C:\Users\Pablo Mayorga\Documents\mision tic\ciclo 4\programacion\Hackaton\E-Migrant\E-Migrant.App\E_Migrant.App.FrontEnd\Pages\Migrante\ListarMigrante.cshtml"
       Write(migrante.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 35 "C:\Users\Pablo Mayorga\Documents\mision tic\ciclo 4\programacion\Hackaton\E-Migrant\E-Migrant.App\E_Migrant.App.FrontEnd\Pages\Migrante\ListarMigrante.cshtml"
       Write(migrante.Telefono);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 36 "C:\Users\Pablo Mayorga\Documents\mision tic\ciclo 4\programacion\Hackaton\E-Migrant\E-Migrant.App\E_Migrant.App.FrontEnd\Pages\Migrante\ListarMigrante.cshtml"
       Write(migrante.Direccion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 37 "C:\Users\Pablo Mayorga\Documents\mision tic\ciclo 4\programacion\Hackaton\E-Migrant\E-Migrant.App\E_Migrant.App.FrontEnd\Pages\Migrante\ListarMigrante.cshtml"
       Write(migrante.Pais);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 38 "C:\Users\Pablo Mayorga\Documents\mision tic\ciclo 4\programacion\Hackaton\E-Migrant\E-Migrant.App\E_Migrant.App.FrontEnd\Pages\Migrante\ListarMigrante.cshtml"
       Write(migrante.Ciudad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 39 "C:\Users\Pablo Mayorga\Documents\mision tic\ciclo 4\programacion\Hackaton\E-Migrant\E-Migrant.App\E_Migrant.App.FrontEnd\Pages\Migrante\ListarMigrante.cshtml"
       Write(migrante.Situacion_Laboral);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n       \r\n        <td>\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7ce2713211b8c75419ebcfd117a3acb6c5945fc113111", async() => {
                WriteLiteral("Editar");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 42 "C:\Users\Pablo Mayorga\Documents\mision tic\ciclo 4\programacion\Hackaton\E-Migrant\E-Migrant.App\E_Migrant.App.FrontEnd\Pages\Migrante\ListarMigrante.cshtml"
                                                                               WriteLiteral(migrante.Id);

#line default
#line hidden
#nullable disable
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
            WriteLiteral("\r\n            \r\n        </td>  \r\n    </tr>\r\n");
#nullable restore
#line 46 "C:\Users\Pablo Mayorga\Documents\mision tic\ciclo 4\programacion\Hackaton\E-Migrant\E-Migrant.App\E_Migrant.App.FrontEnd\Pages\Migrante\ListarMigrante.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<E_Migrant.App.FrontEnd.ListarMigranteModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<E_Migrant.App.FrontEnd.ListarMigranteModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<E_Migrant.App.FrontEnd.ListarMigranteModel>)PageContext?.ViewData;
        public E_Migrant.App.FrontEnd.ListarMigranteModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
