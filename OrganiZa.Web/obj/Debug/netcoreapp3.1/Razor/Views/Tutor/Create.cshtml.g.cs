#pragma checksum "C:\Users\joela\Documents\UTM\Repositorios\4AOrganiZa21\OrganiZa.Web\Views\Tutor\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "12b1c4f174ced9fe6469bbd1f9d3974e9df25d2c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Tutor_Create), @"mvc.1.0.view", @"/Views/Tutor/Create.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"12b1c4f174ced9fe6469bbd1f9d3974e9df25d2c", @"/Views/Tutor/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8b5fa6f82ce3f61704c19d7d8960f1f8b2898c5a", @"/Views/_ViewImports.cshtml")]
    public class Views_Tutor_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RegistroTModelcs>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/StyleSheet.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("signup"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("mt-3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\joela\Documents\UTM\Repositorios\4AOrganiZa21\OrganiZa.Web\Views\Tutor\Create.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "12b1c4f174ced9fe6469bbd1f9d3974e9df25d2c5321", async() => {
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
            WriteLiteral(@"
<link rel=""stylesheet"" href=""https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css"" integrity=""sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T"" crossorigin=""anonymous"">
<script src=""https://code.jquery.com/jquery-3.3.1.slim.min.js"" integrity=""sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo"" crossorigin=""anonymous""></script>
<script src=""https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.7/umd/popper.min.js"" integrity=""sha384-UO2eT0CpHqdSJQ6hJty5KVphtPhzWj9WO1clHTMGa3JDZwrnQq4sF86dIHNDz0W1"" crossorigin=""anonymous""></script>
<script src=""https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/js/bootstrap.min.js"" integrity=""sha384-JjSmVgyd0p3pXB1rRibZUAYoIIy6OrQ6VrjIEaFf/nJGzIxFDsf4x0xIM+B07jRM"" crossorigin=""anonymous""></script>

<div class=""container-fluid"">
    <div class=""row"">
        <div class=""col-md-12"">
            <br>
            <br>
        </div>

    </div>
</div>
<div class=""container text-center"">
    <!-- Button ");
            WriteLiteral("trigger modal -->\r\n    <div class=\"row\">\r\n        <div class=\"col-md-4\">\r\n            <br />\r\n        </div>\r\n\r\n        <div class=\"col-md-4\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "12b1c4f174ced9fe6469bbd1f9d3974e9df25d2c7698", async() => {
                WriteLiteral("\r\n\r\n                <div class=\"header\">\r\n                    <br>\r\n                    <h3>Crear cuenta</h3>\r\n                    <p>Bienvenido</p>\r\n\r\n                </div>\r\n");
#nullable restore
#line 37 "C:\Users\joela\Documents\UTM\Repositorios\4AOrganiZa21\OrganiZa.Web\Views\Tutor\Create.cshtml"
                 using (Html.BeginForm())
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 39 "C:\Users\joela\Documents\UTM\Repositorios\4AOrganiZa21\OrganiZa.Web\Views\Tutor\Create.cshtml"
               Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <div class=\"sep\"></div>\r\n");
                WriteLiteral("                    <div class=\"inputs\">\r\n                        ");
#nullable restore
#line 44 "C:\Users\joela\Documents\UTM\Repositorios\4AOrganiZa21\OrganiZa.Web\Views\Tutor\Create.cshtml"
                   Write(Html.EditorFor(model => model.Tutor.NombreT, new { htmlAttributes = new { @class = "form-control", @placeholder = "Nombre", @autofocus_autocomplete = "off", @type = "text" } }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n                        ");
#nullable restore
#line 46 "C:\Users\joela\Documents\UTM\Repositorios\4AOrganiZa21\OrganiZa.Web\Views\Tutor\Create.cshtml"
                   Write(Html.EditorFor(model => model.Tutor.Alumno, new { htmlAttributes = new { @class = "form-control", @placeholder = "Nombre del hijo(a)", @autofocus_autocomplete = "off", @type = "text" } }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n                        ");
#nullable restore
#line 48 "C:\Users\joela\Documents\UTM\Repositorios\4AOrganiZa21\OrganiZa.Web\Views\Tutor\Create.cshtml"
                   Write(Html.EditorFor(model => model.Tutor.IdE, new { htmlAttributes = new { @class = "form-control", @placeholder = "codigo de la escuela a la que perteneces", @autofocus_autocomplete = "off", @type = "text" } }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n                        ");
#nullable restore
#line 50 "C:\Users\joela\Documents\UTM\Repositorios\4AOrganiZa21\OrganiZa.Web\Views\Tutor\Create.cshtml"
                   Write(Html.EditorFor(model => model.Usuario.Usuario, new { htmlAttributes = new { @class = "form-control", @placeholder = "E-mail", @autofocus_autocomplete = "off", @type = "email" } }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n                        ");
#nullable restore
#line 52 "C:\Users\joela\Documents\UTM\Repositorios\4AOrganiZa21\OrganiZa.Web\Views\Tutor\Create.cshtml"
                   Write(Html.EditorFor(model => model.Usuario.Contraseña, new { htmlAttributes = new { @class = "form-control", @placeholder = "password", @autofocus_autocomplete = "off", @type = "password" } }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"

                        <div class=""checkboxy"">
                            <input name=""cecky"" id=""checky"" value=""1"" type=""checkbox"" autocomplete=""off"" /><label class=""terms"">Acepto los terminos de uso</label>
                        </div>

                        <button id=""submit"" class=""btn btn-success btn-block"" type=""submit"">Registrar</button>
                        <a target=""_blank"" type=""button"" class=""btn btn-primary  btn-block"" href=""https://localhost:44374/Escuela/BuscarCodigo"">
                            Buscar Codigo de escuela
                        </a>

                    </div>
");
#nullable restore
#line 64 "C:\Users\joela\Documents\UTM\Repositorios\4AOrganiZa21\OrganiZa.Web\Views\Tutor\Create.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n     \r\n\r\n        <div class=\"col-md-4\">\r\n            <br />\r\n        </div>\r\n    </div>\r\n\r\n</div>\r\n<div class=\"col-md-12\">\r\n    <br />\r\n</div>\r\n<div class=\"col-md-12\">\r\n    <br />\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RegistroTModelcs> Html { get; private set; }
    }
}
#pragma warning restore 1591
