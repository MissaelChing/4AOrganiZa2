#pragma checksum "C:\Users\joela\Documents\UTM\Repositorios\4AOrganiZa2\OrganiZa.Web\Views\Calendario\CTutor.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "141d3b78bb08db5ee4ab0d162c621a24e177c86e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Calendario_CTutor), @"mvc.1.0.view", @"/Views/Calendario/CTutor.cshtml")]
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
#line 1 "C:\Users\joela\Documents\UTM\Repositorios\4AOrganiZa2\OrganiZa.Web\Views\_ViewImports.cshtml"
using OrganiZa.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\joela\Documents\UTM\Repositorios\4AOrganiZa2\OrganiZa.Web\Views\_ViewImports.cshtml"
using OrganiZa.Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"141d3b78bb08db5ee4ab0d162c621a24e177c86e", @"/Views/Calendario/CTutor.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8b5fa6f82ce3f61704c19d7d8960f1f8b2898c5a", @"/Views/_ViewImports.cshtml")]
    public class Views_Calendario_CTutor : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CTutorModels>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("signup"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("mt-3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"container\">\r\n\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "141d3b78bb08db5ee4ab0d162c621a24e177c86e4309", async() => {
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
                    Nombre del tutor
                </dt>
                <dd class=""col-sm-10"">
                    ");
#nullable restore
#line 29 "C:\Users\joela\Documents\UTM\Repositorios\4AOrganiZa2\OrganiZa.Web\Views\Calendario\CTutor.cshtml"
               Write(Html.DisplayFor(model => model.Tutores.NombreT));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </dd>\r\n\r\n            </dl>\r\n            <dl class=\"row\">\r\n                <dt class=\"col-sm-2\">\r\n                    Nombre de la escuela\r\n                </dt>\r\n                <dd class=\"col-sm-10\">\r\n                    ");
#nullable restore
#line 38 "C:\Users\joela\Documents\UTM\Repositorios\4AOrganiZa2\OrganiZa.Web\Views\Calendario\CTutor.cshtml"
               Write(Html.DisplayFor(model => model.Escuela.NombreE));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </dd>\r\n\r\n            </dl>\r\n            <dl class=\"row\">\r\n                <dt class=\"col-sm-2\">\r\n                    Modo de pago\r\n                </dt>\r\n                <dd class=\"col-sm-10\">\r\n                    ");
#nullable restore
#line 47 "C:\Users\joela\Documents\UTM\Repositorios\4AOrganiZa2\OrganiZa.Web\Views\Calendario\CTutor.cshtml"
               Write(Html.DisplayFor(model => model.Escuela.ModoP));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </dd>\r\n\r\n            </dl>\r\n        </div>\r\n");
#nullable restore
#line 52 "C:\Users\joela\Documents\UTM\Repositorios\4AOrganiZa2\OrganiZa.Web\Views\Calendario\CTutor.cshtml"
         if (Model.calendarios.Any())
        {



#line default
#line hidden
#nullable disable
                WriteLiteral("            <table class=\"table table-bordered\">\r\n                <thead>\r\n                    <tr>\r\n                        <th scope=\"col\">Fecha de pago</th>\r\n                    </tr>\r\n\r\n                </thead>\r\n                <tbody>\r\n");
#nullable restore
#line 64 "C:\Users\joela\Documents\UTM\Repositorios\4AOrganiZa2\OrganiZa.Web\Views\Calendario\CTutor.cshtml"
                     foreach (var item in Model.calendarios)
                    {


#line default
#line hidden
#nullable disable
                WriteLiteral("                        <tr>\r\n                            <td>");
#nullable restore
#line 68 "C:\Users\joela\Documents\UTM\Repositorios\4AOrganiZa2\OrganiZa.Web\Views\Calendario\CTutor.cshtml"
                           Write(Html.DisplayFor(m => item.MesPago));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n\r\n\r\n                        </tr>\r\n");
#nullable restore
#line 72 "C:\Users\joela\Documents\UTM\Repositorios\4AOrganiZa2\OrganiZa.Web\Views\Calendario\CTutor.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                </tbody>\r\n\r\n            </table>\r\n");
#nullable restore
#line 76 "C:\Users\joela\Documents\UTM\Repositorios\4AOrganiZa2\OrganiZa.Web\Views\Calendario\CTutor.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CTutorModels> Html { get; private set; }
    }
}
#pragma warning restore 1591
