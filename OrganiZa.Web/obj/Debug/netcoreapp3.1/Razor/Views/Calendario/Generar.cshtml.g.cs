#pragma checksum "C:\Users\joela\Documents\UTM\Repositorios\4AOrganiZa21\OrganiZa.Web\Views\Calendario\Generar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0b4d568ae653074899bd69497181cea1230146f8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Calendario_Generar), @"mvc.1.0.view", @"/Views/Calendario/Generar.cshtml")]
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
#nullable restore
#line 1 "C:\Users\joela\Documents\UTM\Repositorios\4AOrganiZa21\OrganiZa.Web\Views\_ViewImports.cshtml"
using OrganiZa.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\joela\Documents\UTM\Repositorios\4AOrganiZa21\OrganiZa.Web\Views\_ViewImports.cshtml"
using OrganiZa.Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0b4d568ae653074899bd69497181cea1230146f8", @"/Views/Calendario/Generar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8b5fa6f82ce3f61704c19d7d8960f1f8b2898c5a", @"/Views/_ViewImports.cshtml")]
    public class Views_Calendario_Generar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CalendarioModels>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/site.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap/dist/js/bootstrap.bundle.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Calendario", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Comprobacion", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success m-1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("signup"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("mt-3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<link rel=\"stylesheet\" href=\"/lib/bootstrap/dist/css/bootstrap.min.css\" />\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "0b4d568ae653074899bd69497181cea1230146f87090", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0b4d568ae653074899bd69497181cea1230146f88204", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0b4d568ae653074899bd69497181cea1230146f89243", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<div class=\"container\">\r\n\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0b4d568ae653074899bd69497181cea1230146f810319", async() => {
                WriteLiteral(@"

        <div class=""header"">
            <br>



        </div>
        <div class=""col-md-12"">
            <br>
            <br>
            <br>
        </div>
        <div>
            <hr />
            <dl class=""row"">
                <dt class=""col-sm-2"">
                    Nombre de la escuela
                </dt>
                <dd class=""col-sm-10"">
                    ");
#nullable restore
#line 33 "C:\Users\joela\Documents\UTM\Repositorios\4AOrganiZa21\OrganiZa.Web\Views\Calendario\Generar.cshtml"
               Write(Html.DisplayFor(model => model.Escuelas.NombreE));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </dd>\r\n\r\n            </dl>\r\n            <dl class=\"row\">\r\n                <dt class=\"col-sm-2\">\r\n                    Modo de pago\r\n                </dt>\r\n                <dd class=\"col-sm-10\">\r\n                    ");
#nullable restore
#line 42 "C:\Users\joela\Documents\UTM\Repositorios\4AOrganiZa21\OrganiZa.Web\Views\Calendario\Generar.cshtml"
               Write(Html.DisplayFor(model => model.Escuelas.ModoP));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </dd>\r\n\r\n            </dl>\r\n        </div>\r\n");
#nullable restore
#line 47 "C:\Users\joela\Documents\UTM\Repositorios\4AOrganiZa21\OrganiZa.Web\Views\Calendario\Generar.cshtml"
         if (Model.Escuelas.ModoP == "Cuatrimestral")
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <div class=\"col-md-12\">\r\n                <h3>Agregue tres fechas</h3>\r\n                <br>\r\n                <br>\r\n            </div>\r\n");
#nullable restore
#line 54 "C:\Users\joela\Documents\UTM\Repositorios\4AOrganiZa21\OrganiZa.Web\Views\Calendario\Generar.cshtml"
             using (Html.BeginForm())
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 56 "C:\Users\joela\Documents\UTM\Repositorios\4AOrganiZa21\OrganiZa.Web\Views\Calendario\Generar.cshtml"
           Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
                WriteLiteral("                <div class=\"sep\"></div>\r\n");
                WriteLiteral("                <div class=\"inputs\">\r\n                    ");
#nullable restore
#line 62 "C:\Users\joela\Documents\UTM\Repositorios\4AOrganiZa21\OrganiZa.Web\Views\Calendario\Generar.cshtml"
               Write(Html.EditorFor(model => model.Calendario.MesPago, new { htmlAttributes = new { @class = "form-control", @placeholder = "Mes", @autofocus_autocomplete = "off", @type = "month" } }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"


                    <div class=""col-md-12"">
                        <br>
                        <br>
                        <br>
                    </div>
                    <button id=""submit"" class=""btn btn-success btn-block"" type=""submit"">Agregar</button>
                </div>
");
#nullable restore
#line 72 "C:\Users\joela\Documents\UTM\Repositorios\4AOrganiZa21\OrganiZa.Web\Views\Calendario\Generar.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0b4d568ae653074899bd69497181cea1230146f813962", async() => {
                    WriteLiteral("Ver fechas agregadas");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 74 "C:\Users\joela\Documents\UTM\Repositorios\4AOrganiZa21\OrganiZa.Web\Views\Calendario\Generar.cshtml"
        }
        else if (Model.Escuelas.ModoP == "Anual")
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <div class=\"col-md-12\">\r\n                <h3>Agregue una fecha</h3>\r\n                <br>\r\n                <br>\r\n            </div>\r\n");
#nullable restore
#line 82 "C:\Users\joela\Documents\UTM\Repositorios\4AOrganiZa21\OrganiZa.Web\Views\Calendario\Generar.cshtml"
             using (Html.BeginForm())
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 84 "C:\Users\joela\Documents\UTM\Repositorios\4AOrganiZa21\OrganiZa.Web\Views\Calendario\Generar.cshtml"
           Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
                WriteLiteral("                <div class=\"sep\"></div>\r\n");
                WriteLiteral("                <div class=\"inputs\">\r\n                    ");
#nullable restore
#line 90 "C:\Users\joela\Documents\UTM\Repositorios\4AOrganiZa21\OrganiZa.Web\Views\Calendario\Generar.cshtml"
               Write(Html.EditorFor(model => model.Calendario.MesPago, new { htmlAttributes = new { @class = "form-control", @placeholder = "Mes", @autofocus_autocomplete = "off", @type = "month" } }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"


                    <div class=""col-md-12"">
                        <br>
                        <br>
                        <br>
                    </div>
                    <button id=""submit"" class=""btn btn-success btn-block"" type=""submit"">Agregar</button>
                </div>
");
#nullable restore
#line 100 "C:\Users\joela\Documents\UTM\Repositorios\4AOrganiZa21\OrganiZa.Web\Views\Calendario\Generar.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0b4d568ae653074899bd69497181cea1230146f817570", async() => {
                    WriteLiteral("Ver fechas agregadas");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 102 "C:\Users\joela\Documents\UTM\Repositorios\4AOrganiZa21\OrganiZa.Web\Views\Calendario\Generar.cshtml"
        }
        else if (Model.Escuelas.ModoP == "Mensual")
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <div class=\"col-md-12\">\r\n                <h3>Agregue doce fechas</h3>\r\n                <br>\r\n                <br>\r\n            </div>\r\n");
#nullable restore
#line 110 "C:\Users\joela\Documents\UTM\Repositorios\4AOrganiZa21\OrganiZa.Web\Views\Calendario\Generar.cshtml"
             using (Html.BeginForm())
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 112 "C:\Users\joela\Documents\UTM\Repositorios\4AOrganiZa21\OrganiZa.Web\Views\Calendario\Generar.cshtml"
           Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
                WriteLiteral("                <div class=\"sep\"></div>\r\n");
                WriteLiteral("                <div class=\"inputs\">\r\n                    ");
#nullable restore
#line 118 "C:\Users\joela\Documents\UTM\Repositorios\4AOrganiZa21\OrganiZa.Web\Views\Calendario\Generar.cshtml"
               Write(Html.EditorFor(model => model.Calendario.MesPago, new { htmlAttributes = new { @class = "form-control", @placeholder = "Mes", @autofocus_autocomplete = "off", @type = "month" } }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"


                    <div class=""col-md-12"">
                        <br>
                        <br>
                        <br>
                    </div>
                    <button id=""submit"" class=""btn btn-success btn-block"" type=""submit"">Agregar</button>
                </div>
");
#nullable restore
#line 128 "C:\Users\joela\Documents\UTM\Repositorios\4AOrganiZa21\OrganiZa.Web\Views\Calendario\Generar.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0b4d568ae653074899bd69497181cea1230146f821186", async() => {
                    WriteLiteral("Ver fechas agregadas");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 130 "C:\Users\joela\Documents\UTM\Repositorios\4AOrganiZa21\OrganiZa.Web\Views\Calendario\Generar.cshtml"
        }
        else if (Model.Escuelas.ModoP == "Bimestral")
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <div class=\"col-md-12\">\r\n                <h3>Agregue seis fechas</h3>\r\n                <br>\r\n                <br>\r\n            </div>\r\n");
#nullable restore
#line 138 "C:\Users\joela\Documents\UTM\Repositorios\4AOrganiZa21\OrganiZa.Web\Views\Calendario\Generar.cshtml"
             using (Html.BeginForm())
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 140 "C:\Users\joela\Documents\UTM\Repositorios\4AOrganiZa21\OrganiZa.Web\Views\Calendario\Generar.cshtml"
           Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
                WriteLiteral("                <div class=\"sep\"></div>\r\n");
                WriteLiteral("                <div class=\"inputs\">\r\n                    ");
#nullable restore
#line 146 "C:\Users\joela\Documents\UTM\Repositorios\4AOrganiZa21\OrganiZa.Web\Views\Calendario\Generar.cshtml"
               Write(Html.EditorFor(model => model.Calendario.MesPago, new { htmlAttributes = new { @class = "form-control", @placeholder = "Mes", @autofocus_autocomplete = "off", @type = "month" } }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"


                    <div class=""col-md-12"">
                        <br>
                        <br>
                        <br>
                    </div>
                    <button id=""submit"" class=""btn btn-success btn-block"" type=""submit"">Agregar</button>
                </div>
");
#nullable restore
#line 156 "C:\Users\joela\Documents\UTM\Repositorios\4AOrganiZa21\OrganiZa.Web\Views\Calendario\Generar.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0b4d568ae653074899bd69497181cea1230146f824804", async() => {
                    WriteLiteral("Ver fechas agregadas");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 158 "C:\Users\joela\Documents\UTM\Repositorios\4AOrganiZa21\OrganiZa.Web\Views\Calendario\Generar.cshtml"
        }
        else if (Model.Escuelas.ModoP == "Semestral")
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <div class=\"col-md-12\">\r\n                <h3>Agregue dos fechas</h3>\r\n                <br>\r\n                <br>\r\n            </div>\r\n");
#nullable restore
#line 166 "C:\Users\joela\Documents\UTM\Repositorios\4AOrganiZa21\OrganiZa.Web\Views\Calendario\Generar.cshtml"
             using (Html.BeginForm())
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 168 "C:\Users\joela\Documents\UTM\Repositorios\4AOrganiZa21\OrganiZa.Web\Views\Calendario\Generar.cshtml"
           Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
                WriteLiteral("                <div class=\"sep\"></div>\r\n");
                WriteLiteral("                <div class=\"inputs\">\r\n                    ");
#nullable restore
#line 174 "C:\Users\joela\Documents\UTM\Repositorios\4AOrganiZa21\OrganiZa.Web\Views\Calendario\Generar.cshtml"
               Write(Html.EditorFor(model => model.Calendario.MesPago, new { htmlAttributes = new { @class = "form-control", @placeholder = "Mes", @autofocus_autocomplete = "off", @type = "month" } }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"


                    <div class=""col-md-12"">
                        <br>
                        <br>
                        <br>
                    </div>
                    <button id=""submit"" class=""btn btn-success btn-block"" type=""submit"">Agregar</button>
                </div>
");
#nullable restore
#line 184 "C:\Users\joela\Documents\UTM\Repositorios\4AOrganiZa21\OrganiZa.Web\Views\Calendario\Generar.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0b4d568ae653074899bd69497181cea1230146f828421", async() => {
                    WriteLiteral("Ver fechas agregadas");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 186 "C:\Users\joela\Documents\UTM\Repositorios\4AOrganiZa21\OrganiZa.Web\Views\Calendario\Generar.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CalendarioModels> Html { get; private set; }
    }
}
#pragma warning restore 1591