#pragma checksum "C:\Users\Missael Ching R&M\Desktop\4AOrganiZa2\OrganiZa.Web\Views\Pagos\Comprobacion.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1251e951710923e06ba9daa6d6b3fefaa56fc950"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pagos_Comprobacion), @"mvc.1.0.view", @"/Views/Pagos/Comprobacion.cshtml")]
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
#line 1 "C:\Users\Missael Ching R&M\Desktop\4AOrganiZa2\OrganiZa.Web\Views\_ViewImports.cshtml"
using OrganiZa.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Missael Ching R&M\Desktop\4AOrganiZa2\OrganiZa.Web\Views\_ViewImports.cshtml"
using OrganiZa.Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1251e951710923e06ba9daa6d6b3fefaa56fc950", @"/Views/Pagos/Comprobacion.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8b5fa6f82ce3f61704c19d7d8960f1f8b2898c5a", @"/Views/_ViewImports.cshtml")]
    public class Views_Pagos_Comprobacion : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ComprobacionModels>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Pagos", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Aprobacion", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("    <h1>Comprobar Pagos</h1>\r\n    <br />\r\n    <br />\r\n    <br />\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1251e951710923e06ba9daa6d6b3fefaa56fc9504749", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 9 "C:\Users\Missael Ching R&M\Desktop\4AOrganiZa2\OrganiZa.Web\Views\Pagos\Comprobacion.cshtml"
         if (Model.Pagos.Any())
        {



#line default
#line hidden
#nullable disable
                WriteLiteral(@"            <table class=""table table-bordered"">
                <thead>
                    <tr>
                        <th scope=""col"">Id</th>
                        <th scope=""col"">Nombre Tutor</th>
                        <th scope=""col"">Alumno</th>
                        <th scope=""col"">Mes pagado</th>
                        <th scope=""col"">Fecha</th>
                        <th scope=""col"">Verificar Documentos</th>
                    </tr>

                </thead>
                <tbody>
");
#nullable restore
#line 26 "C:\Users\Missael Ching R&M\Desktop\4AOrganiZa2\OrganiZa.Web\Views\Pagos\Comprobacion.cshtml"
                     foreach (var item in Model.Pagos)
                    {


#line default
#line hidden
#nullable disable
                WriteLiteral("                        <tr>\r\n                            <td scope=\"row\">");
#nullable restore
#line 30 "C:\Users\Missael Ching R&M\Desktop\4AOrganiZa2\OrganiZa.Web\Views\Pagos\Comprobacion.cshtml"
                                       Write(Html.DisplayFor(m => item.Id));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 31 "C:\Users\Missael Ching R&M\Desktop\4AOrganiZa2\OrganiZa.Web\Views\Pagos\Comprobacion.cshtml"
                           Write(Html.DisplayFor(m => item.NombreT));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 32 "C:\Users\Missael Ching R&M\Desktop\4AOrganiZa2\OrganiZa.Web\Views\Pagos\Comprobacion.cshtml"
                           Write(Html.DisplayFor(m => item.Alumno));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                            <th>");
#nullable restore
#line 33 "C:\Users\Missael Ching R&M\Desktop\4AOrganiZa2\OrganiZa.Web\Views\Pagos\Comprobacion.cshtml"
                           Write(Html.DisplayFor(m => item.Mespagado));

#line default
#line hidden
#nullable disable
                WriteLiteral("</th>\r\n                            <th>");
#nullable restore
#line 34 "C:\Users\Missael Ching R&M\Desktop\4AOrganiZa2\OrganiZa.Web\Views\Pagos\Comprobacion.cshtml"
                           Write(Html.DisplayFor(m => item.Fecha));

#line default
#line hidden
#nullable disable
                WriteLiteral("</th>\r\n\r\n                            <td>\r\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1251e951710923e06ba9daa6d6b3fefaa56fc9507808", async() => {
                    WriteLiteral("Aprobar");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 37 "C:\Users\Missael Ching R&M\Desktop\4AOrganiZa2\OrganiZa.Web\Views\Pagos\Comprobacion.cshtml"
                                                                                    WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 40 "C:\Users\Missael Ching R&M\Desktop\4AOrganiZa2\OrganiZa.Web\Views\Pagos\Comprobacion.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                </tbody>\r\n\r\n            </table>\r\n");
#nullable restore
#line 44 "C:\Users\Missael Ching R&M\Desktop\4AOrganiZa2\OrganiZa.Web\Views\Pagos\Comprobacion.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <div class=\"mx-auto text-center\">\r\n                <span class=\"text-danger\">No se encontraron ningun registro</span>\r\n            </div>\r\n");
#nullable restore
#line 50 "C:\Users\Missael Ching R&M\Desktop\4AOrganiZa2\OrganiZa.Web\Views\Pagos\Comprobacion.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ComprobacionModels> Html { get; private set; }
    }
}
#pragma warning restore 1591