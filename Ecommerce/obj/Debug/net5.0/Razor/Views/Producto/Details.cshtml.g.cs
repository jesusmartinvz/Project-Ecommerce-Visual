#pragma checksum "F:\CIBERTEC\Ciclo 05- Cibertec\Desarrollo de Servicios WEB 1\WordSpace\Ecommerce\Ecommerce\Views\Producto\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "497fc82a397259bada0ad804db3e9aa1344cea69"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Producto_Details), @"mvc.1.0.view", @"/Views/Producto/Details.cshtml")]
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
#line 1 "F:\CIBERTEC\Ciclo 05- Cibertec\Desarrollo de Servicios WEB 1\WordSpace\Ecommerce\Ecommerce\Views\_ViewImports.cshtml"
using Ecommerce;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\CIBERTEC\Ciclo 05- Cibertec\Desarrollo de Servicios WEB 1\WordSpace\Ecommerce\Ecommerce\Views\_ViewImports.cshtml"
using Ecommerce.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"497fc82a397259bada0ad804db3e9aa1344cea69", @"/Views/Producto/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6bbcd7c65731fc074a835809e73fcf2cf9014c29", @"/Views/_ViewImports.cshtml")]
    public class Views_Producto_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Ecommerce.Models.Producto>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "F:\CIBERTEC\Ciclo 05- Cibertec\Desarrollo de Servicios WEB 1\WordSpace\Ecommerce\Ecommerce\Views\Producto\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/_Maintenance.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>Producto</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 15 "F:\CIBERTEC\Ciclo 05- Cibertec\Desarrollo de Servicios WEB 1\WordSpace\Ecommerce\Ecommerce\Views\Producto\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.IdProducto));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 18 "F:\CIBERTEC\Ciclo 05- Cibertec\Desarrollo de Servicios WEB 1\WordSpace\Ecommerce\Ecommerce\Views\Producto\Details.cshtml"
       Write(Html.DisplayFor(model => model.IdProducto));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 21 "F:\CIBERTEC\Ciclo 05- Cibertec\Desarrollo de Servicios WEB 1\WordSpace\Ecommerce\Ecommerce\Views\Producto\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CodProducto));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 24 "F:\CIBERTEC\Ciclo 05- Cibertec\Desarrollo de Servicios WEB 1\WordSpace\Ecommerce\Ecommerce\Views\Producto\Details.cshtml"
       Write(Html.DisplayFor(model => model.CodProducto));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 27 "F:\CIBERTEC\Ciclo 05- Cibertec\Desarrollo de Servicios WEB 1\WordSpace\Ecommerce\Ecommerce\Views\Producto\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Descripcion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 30 "F:\CIBERTEC\Ciclo 05- Cibertec\Desarrollo de Servicios WEB 1\WordSpace\Ecommerce\Ecommerce\Views\Producto\Details.cshtml"
       Write(Html.DisplayFor(model => model.Descripcion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 33 "F:\CIBERTEC\Ciclo 05- Cibertec\Desarrollo de Servicios WEB 1\WordSpace\Ecommerce\Ecommerce\Views\Producto\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Precio));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 36 "F:\CIBERTEC\Ciclo 05- Cibertec\Desarrollo de Servicios WEB 1\WordSpace\Ecommerce\Ecommerce\Views\Producto\Details.cshtml"
       Write(Html.DisplayFor(model => model.Precio));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 39 "F:\CIBERTEC\Ciclo 05- Cibertec\Desarrollo de Servicios WEB 1\WordSpace\Ecommerce\Ecommerce\Views\Producto\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Stock));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 42 "F:\CIBERTEC\Ciclo 05- Cibertec\Desarrollo de Servicios WEB 1\WordSpace\Ecommerce\Ecommerce\Views\Producto\Details.cshtml"
       Write(Html.DisplayFor(model => model.Stock));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 45 "F:\CIBERTEC\Ciclo 05- Cibertec\Desarrollo de Servicios WEB 1\WordSpace\Ecommerce\Ecommerce\Views\Producto\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Garantia));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 48 "F:\CIBERTEC\Ciclo 05- Cibertec\Desarrollo de Servicios WEB 1\WordSpace\Ecommerce\Ecommerce\Views\Producto\Details.cshtml"
       Write(Html.DisplayFor(model => model.Garantia));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 51 "F:\CIBERTEC\Ciclo 05- Cibertec\Desarrollo de Servicios WEB 1\WordSpace\Ecommerce\Ecommerce\Views\Producto\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Descuento));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 54 "F:\CIBERTEC\Ciclo 05- Cibertec\Desarrollo de Servicios WEB 1\WordSpace\Ecommerce\Ecommerce\Views\Producto\Details.cshtml"
       Write(Html.DisplayFor(model => model.Descuento));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 57 "F:\CIBERTEC\Ciclo 05- Cibertec\Desarrollo de Servicios WEB 1\WordSpace\Ecommerce\Ecommerce\Views\Producto\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.IdCategoria));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 60 "F:\CIBERTEC\Ciclo 05- Cibertec\Desarrollo de Servicios WEB 1\WordSpace\Ecommerce\Ecommerce\Views\Producto\Details.cshtml"
       Write(Html.DisplayFor(model => model.IdCategoria));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 63 "F:\CIBERTEC\Ciclo 05- Cibertec\Desarrollo de Servicios WEB 1\WordSpace\Ecommerce\Ecommerce\Views\Producto\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Foto));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            <img");
            BeginWriteAttribute("src", " src=\"", 2072, "\"", 2102, 1);
#nullable restore
#line 66 "F:\CIBERTEC\Ciclo 05- Cibertec\Desarrollo de Servicios WEB 1\WordSpace\Ecommerce\Ecommerce\Views\Producto\Details.cshtml"
WriteAttributeValue("", 2078, Url.Content(Model.Foto), 2078, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"300\" height=\"300\" style=\"border:2px solid\"/>\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
#nullable restore
#line 71 "F:\CIBERTEC\Ciclo 05- Cibertec\Desarrollo de Servicios WEB 1\WordSpace\Ecommerce\Ecommerce\Views\Producto\Details.cshtml"
Write(Html.ActionLink("Edit", "Edit", new { id = Model.IdProducto }, new { @class = "btn btn-warning" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "497fc82a397259bada0ad804db3e9aa1344cea6911407", async() => {
                WriteLiteral("Regresar");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Ecommerce.Models.Producto> Html { get; private set; }
    }
}
#pragma warning restore 1591
