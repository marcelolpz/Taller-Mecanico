#pragma checksum "C:\Users\Marcelo Lopez\Documents\GitHub\TallerMecanico\TallerMecanico\Views\Access\Recovery.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3ccb7fbdc87ea4453fadaacad135422254b34b29"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Access_Recovery), @"mvc.1.0.view", @"/Views/Access/Recovery.cshtml")]
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
#line 1 "C:\Users\Marcelo Lopez\Documents\GitHub\TallerMecanico\TallerMecanico\Views\_ViewImports.cshtml"
using TallerMecanico;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Marcelo Lopez\Documents\GitHub\TallerMecanico\TallerMecanico\Views\_ViewImports.cshtml"
using TallerMecanico.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Marcelo Lopez\Documents\GitHub\TallerMecanico\TallerMecanico\Views\Access\Recovery.cshtml"
using TallerMecanico.Models.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3ccb7fbdc87ea4453fadaacad135422254b34b29", @"/Views/Access/Recovery.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7101151fd0d31cc00d151cbadba888642d3901ed", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Access_Recovery : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RecoveryPasswordVm>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 3 "C:\Users\Marcelo Lopez\Documents\GitHub\TallerMecanico\TallerMecanico\Views\Access\Recovery.cshtml"
  
    ViewData["Title"] = "Recovery";
    Layout = "~/Views/Shared/_LayoutLogin.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"form-box\">\r\n\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3ccb7fbdc87ea4453fadaacad135422254b34b294516", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 11 "C:\Users\Marcelo Lopez\Documents\GitHub\TallerMecanico\TallerMecanico\Views\Access\Recovery.cshtml"
         if (!string.IsNullOrEmpty(@ViewBag.Error))
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <div");
                BeginWriteAttribute("class", " class=\"", 355, "\"", 384, 1);
#nullable restore
#line 13 "C:\Users\Marcelo Lopez\Documents\GitHub\TallerMecanico\TallerMecanico\Views\Access\Recovery.cshtml"
WriteAttributeValue("", 363, ViewBag.ClaseMensaje, 363, 21, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" role=\"alert\" id=\"success-alert\">\r\n                <strong> ");
#nullable restore
#line 14 "C:\Users\Marcelo Lopez\Documents\GitHub\TallerMecanico\TallerMecanico\Views\Access\Recovery.cshtml"
                    Write(ViewBag.Error);

#line default
#line hidden
#nullable disable
                WriteLiteral("</strong>\r\n            </div>\r\n");
#nullable restore
#line 16 "C:\Users\Marcelo Lopez\Documents\GitHub\TallerMecanico\TallerMecanico\Views\Access\Recovery.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"

        <ul>
            <li style=""color:white;""> <i class=""bi bi-gear-fill""></i> Taller Mecánico Ensigna</li>

        </ul>

        <br>
        <br>
        <div class=""card"" style=""text-align:center;"">
            <div class=""card-header"" style=""background-color:#060724; color: white;""> Cambio de contraseña </div>
            <br>
            ");
#nullable restore
#line 29 "C:\Users\Marcelo Lopez\Documents\GitHub\TallerMecanico\TallerMecanico\Views\Access\Recovery.cshtml"
       Write(Html.HiddenFor(d=>d.token));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            <label class=\"form-control\">Escribe tu nueva contraseña</label>\r\n            ");
#nullable restore
#line 31 "C:\Users\Marcelo Lopez\Documents\GitHub\TallerMecanico\TallerMecanico\Views\Access\Recovery.cshtml"
       Write(Html.PasswordFor(d=>d.Password,new{@class="form-control"}));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            <label class=\"form-control\">Ingresa nuevamente tu contraseña</label>\r\n            ");
#nullable restore
#line 33 "C:\Users\Marcelo Lopez\Documents\GitHub\TallerMecanico\TallerMecanico\Views\Access\Recovery.cshtml"
       Write(Html.PasswordFor(d=>d.Password2,new{@class="form-control"}));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            <br />\r\n            <button type=\"submit\" class=\"boton\" id=\"botonRecovery\">Recuperar</button>\r\n        </div>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 10 "C:\Users\Marcelo Lopez\Documents\GitHub\TallerMecanico\TallerMecanico\Views\Access\Recovery.cshtml"
AddHtmlAttributeValue("", 224, Url.Content("~/Access/Recovery"), 224, 33, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RecoveryPasswordVm> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
