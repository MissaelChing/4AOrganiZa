#pragma checksum "C:\Users\Missael Ching R&M\Desktop\Nueva carpeta (3)\Nuevo OrganiZa2\4AOrganiZa\OrganiZaUI\Pages\ComprobarPagos.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "66c7c1f8b36a9854e8afb17e0438b89871d9525b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(OrganiZaUI.Pages.Pages_ComprobarPagos), @"mvc.1.0.razor-page", @"/Pages/ComprobarPagos.cshtml")]
namespace OrganiZaUI.Pages
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
#line 1 "C:\Users\Missael Ching R&M\Desktop\Nueva carpeta (3)\Nuevo OrganiZa2\4AOrganiZa\OrganiZaUI\Pages\_ViewImports.cshtml"
using OrganiZaUI;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"66c7c1f8b36a9854e8afb17e0438b89871d9525b", @"/Pages/ComprobarPagos.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4f3a6bc0dac274252801cdc37cfcd5899dbdd776", @"/Pages/_ViewImports.cshtml")]
    public class Pages_ComprobarPagos : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "text", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Comprobarelpago", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 5 "C:\Users\Missael Ching R&M\Desktop\Nueva carpeta (3)\Nuevo OrganiZa2\4AOrganiZa\OrganiZaUI\Pages\ComprobarPagos.cshtml"
 if (Model.Users.Rolusuario == null)
{
    RedirectToPage("/Error");
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h1>Comprobar Pagos</h1>\r\n    <br />\r\n    <br />\r\n    <br />\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "66c7c1f8b36a9854e8afb17e0438b89871d9525b4999", async() => {
                WriteLiteral("\r\n        <p>\r\n            Buscar: ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "66c7c1f8b36a9854e8afb17e0438b89871d9525b5292", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 17 "C:\Users\Missael Ching R&M\Desktop\Nueva carpeta (3)\Nuevo OrganiZa2\4AOrganiZa\OrganiZaUI\Pages\ComprobarPagos.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.SearchString);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n            <input type=\"submit\" value=\"Filter\" />\r\n        </p>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "66c7c1f8b36a9854e8afb17e0438b89871d9525b8093", async() => {
                WriteLiteral("\r\n\r\n");
#nullable restore
#line 23 "C:\Users\Missael Ching R&M\Desktop\Nueva carpeta (3)\Nuevo OrganiZa2\4AOrganiZa\OrganiZaUI\Pages\ComprobarPagos.cshtml"
         if (Model.Movie.Any())
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <table class=\"table table-bordered\">\r\n                <thead>\r\n                    <tr>\r\n                        <th scope=\"col\">");
#nullable restore
#line 28 "C:\Users\Missael Ching R&M\Desktop\Nueva carpeta (3)\Nuevo OrganiZa2\4AOrganiZa\OrganiZaUI\Pages\ComprobarPagos.cshtml"
                                   Write(Html.DisplayNameFor(x => x.Movie.FirstOrDefault().NombreT));

#line default
#line hidden
#nullable disable
                WriteLiteral("</th>\r\n                        <th scope=\"col\">");
#nullable restore
#line 29 "C:\Users\Missael Ching R&M\Desktop\Nueva carpeta (3)\Nuevo OrganiZa2\4AOrganiZa\OrganiZaUI\Pages\ComprobarPagos.cshtml"
                                   Write(Html.DisplayNameFor(x => x.Movie.FirstOrDefault().Alumno));

#line default
#line hidden
#nullable disable
                WriteLiteral("</th>\r\n                        <th scope=\"col\">");
#nullable restore
#line 30 "C:\Users\Missael Ching R&M\Desktop\Nueva carpeta (3)\Nuevo OrganiZa2\4AOrganiZa\OrganiZaUI\Pages\ComprobarPagos.cshtml"
                                   Write(Html.DisplayNameFor(x => x.Movie.FirstOrDefault().Mespagado));

#line default
#line hidden
#nullable disable
                WriteLiteral("</th>\r\n                        <th scope=\"col\">");
#nullable restore
#line 31 "C:\Users\Missael Ching R&M\Desktop\Nueva carpeta (3)\Nuevo OrganiZa2\4AOrganiZa\OrganiZaUI\Pages\ComprobarPagos.cshtml"
                                   Write(Html.DisplayNameFor(x => x.Movie.FirstOrDefault().Fecha));

#line default
#line hidden
#nullable disable
                WriteLiteral("</th>\r\n                        <th scope=\"col\">");
#nullable restore
#line 32 "C:\Users\Missael Ching R&M\Desktop\Nueva carpeta (3)\Nuevo OrganiZa2\4AOrganiZa\OrganiZaUI\Pages\ComprobarPagos.cshtml"
                                   Write(Html.DisplayNameFor(x => x.Movie.FirstOrDefault().statusdepago));

#line default
#line hidden
#nullable disable
                WriteLiteral("</th>\r\n\r\n                        <th scope=\"col\">Verificar Documentos</th>\r\n                    </tr>\r\n\r\n                </thead>\r\n                <tbody>\r\n");
#nullable restore
#line 39 "C:\Users\Missael Ching R&M\Desktop\Nueva carpeta (3)\Nuevo OrganiZa2\4AOrganiZa\OrganiZaUI\Pages\ComprobarPagos.cshtml"
                     foreach (var item in Model.Movie)
                    {


#line default
#line hidden
#nullable disable
                WriteLiteral("                        <tr>\r\n                            <td scope=\"row\">");
#nullable restore
#line 43 "C:\Users\Missael Ching R&M\Desktop\Nueva carpeta (3)\Nuevo OrganiZa2\4AOrganiZa\OrganiZaUI\Pages\ComprobarPagos.cshtml"
                                       Write(Html.DisplayFor(m => item.NombreT));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 44 "C:\Users\Missael Ching R&M\Desktop\Nueva carpeta (3)\Nuevo OrganiZa2\4AOrganiZa\OrganiZaUI\Pages\ComprobarPagos.cshtml"
                           Write(Html.DisplayFor(m => item.Alumno));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                            <th>");
#nullable restore
#line 45 "C:\Users\Missael Ching R&M\Desktop\Nueva carpeta (3)\Nuevo OrganiZa2\4AOrganiZa\OrganiZaUI\Pages\ComprobarPagos.cshtml"
                           Write(Html.DisplayFor(m => item.Mespagado));

#line default
#line hidden
#nullable disable
                WriteLiteral("</th>\r\n                            <th>");
#nullable restore
#line 46 "C:\Users\Missael Ching R&M\Desktop\Nueva carpeta (3)\Nuevo OrganiZa2\4AOrganiZa\OrganiZaUI\Pages\ComprobarPagos.cshtml"
                           Write(Html.DisplayFor(m => item.Fecha));

#line default
#line hidden
#nullable disable
                WriteLiteral("</th>\r\n                            <th>");
#nullable restore
#line 47 "C:\Users\Missael Ching R&M\Desktop\Nueva carpeta (3)\Nuevo OrganiZa2\4AOrganiZa\OrganiZaUI\Pages\ComprobarPagos.cshtml"
                           Write(Html.DisplayFor(m => item.statusdepago));

#line default
#line hidden
#nullable disable
                WriteLiteral("</th>\r\n\r\n                            <td>\r\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "66c7c1f8b36a9854e8afb17e0438b89871d9525b13040", async() => {
                    WriteLiteral("Comprobar");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-ID", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 50 "C:\Users\Missael Ching R&M\Desktop\Nueva carpeta (3)\Nuevo OrganiZa2\4AOrganiZa\OrganiZaUI\Pages\ComprobarPagos.cshtml"
                                                                 WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["ID"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-ID", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["ID"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 53 "C:\Users\Missael Ching R&M\Desktop\Nueva carpeta (3)\Nuevo OrganiZa2\4AOrganiZa\OrganiZaUI\Pages\ComprobarPagos.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                </tbody>\r\n\r\n            </table>\r\n");
#nullable restore
#line 57 "C:\Users\Missael Ching R&M\Desktop\Nueva carpeta (3)\Nuevo OrganiZa2\4AOrganiZa\OrganiZaUI\Pages\ComprobarPagos.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <div class=\"mx-auto text-center\">\r\n                <span class=\"text-danger\">No se encontraron ningun registro</span>\r\n            </div>\r\n");
#nullable restore
#line 63 "C:\Users\Missael Ching R&M\Desktop\Nueva carpeta (3)\Nuevo OrganiZa2\4AOrganiZa\OrganiZaUI\Pages\ComprobarPagos.cshtml"
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
#nullable restore
#line 65 "C:\Users\Missael Ching R&M\Desktop\Nueva carpeta (3)\Nuevo OrganiZa2\4AOrganiZa\OrganiZaUI\Pages\ComprobarPagos.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OrganiZaUI.Pages.ComprobarPagosModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<OrganiZaUI.Pages.ComprobarPagosModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<OrganiZaUI.Pages.ComprobarPagosModel>)PageContext?.ViewData;
        public OrganiZaUI.Pages.ComprobarPagosModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
