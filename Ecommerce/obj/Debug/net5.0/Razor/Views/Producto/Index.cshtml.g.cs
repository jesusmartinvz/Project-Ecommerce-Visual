#pragma checksum "F:\CIBERTEC\Ciclo 05- Cibertec\Desarrollo de Servicios WEB 1\WordSpace\Ecommerce\Ecommerce\Views\Producto\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "933ed78a48165558c1f94cb258db12e4318187c0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Producto_Index), @"mvc.1.0.view", @"/Views/Producto/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"933ed78a48165558c1f94cb258db12e4318187c0", @"/Views/Producto/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6bbcd7c65731fc074a835809e73fcf2cf9014c29", @"/Views/_ViewImports.cshtml")]
    public class Views_Producto_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Ecommerce.Models.Producto>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "F:\CIBERTEC\Ciclo 05- Cibertec\Desarrollo de Servicios WEB 1\WordSpace\Ecommerce\Ecommerce\Views\Producto\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Maintenance.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "933ed78a48165558c1f94cb258db12e4318187c03879", async() => {
                WriteLiteral("Create New");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 17 "F:\CIBERTEC\Ciclo 05- Cibertec\Desarrollo de Servicios WEB 1\WordSpace\Ecommerce\Ecommerce\Views\Producto\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.CodProducto));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 20 "F:\CIBERTEC\Ciclo 05- Cibertec\Desarrollo de Servicios WEB 1\WordSpace\Ecommerce\Ecommerce\Views\Producto\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Descripcion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 23 "F:\CIBERTEC\Ciclo 05- Cibertec\Desarrollo de Servicios WEB 1\WordSpace\Ecommerce\Ecommerce\Views\Producto\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Precio));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 26 "F:\CIBERTEC\Ciclo 05- Cibertec\Desarrollo de Servicios WEB 1\WordSpace\Ecommerce\Ecommerce\Views\Producto\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Stock));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 29 "F:\CIBERTEC\Ciclo 05- Cibertec\Desarrollo de Servicios WEB 1\WordSpace\Ecommerce\Ecommerce\Views\Producto\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Garantia));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 32 "F:\CIBERTEC\Ciclo 05- Cibertec\Desarrollo de Servicios WEB 1\WordSpace\Ecommerce\Ecommerce\Views\Producto\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Descuento));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 38 "F:\CIBERTEC\Ciclo 05- Cibertec\Desarrollo de Servicios WEB 1\WordSpace\Ecommerce\Ecommerce\Views\Producto\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 41 "F:\CIBERTEC\Ciclo 05- Cibertec\Desarrollo de Servicios WEB 1\WordSpace\Ecommerce\Ecommerce\Views\Producto\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.CodProducto));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 44 "F:\CIBERTEC\Ciclo 05- Cibertec\Desarrollo de Servicios WEB 1\WordSpace\Ecommerce\Ecommerce\Views\Producto\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Descripcion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 47 "F:\CIBERTEC\Ciclo 05- Cibertec\Desarrollo de Servicios WEB 1\WordSpace\Ecommerce\Ecommerce\Views\Producto\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Precio));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 50 "F:\CIBERTEC\Ciclo 05- Cibertec\Desarrollo de Servicios WEB 1\WordSpace\Ecommerce\Ecommerce\Views\Producto\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Stock));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 53 "F:\CIBERTEC\Ciclo 05- Cibertec\Desarrollo de Servicios WEB 1\WordSpace\Ecommerce\Ecommerce\Views\Producto\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Garantia));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 56 "F:\CIBERTEC\Ciclo 05- Cibertec\Desarrollo de Servicios WEB 1\WordSpace\Ecommerce\Ecommerce\Views\Producto\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Descuento));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 59 "F:\CIBERTEC\Ciclo 05- Cibertec\Desarrollo de Servicios WEB 1\WordSpace\Ecommerce\Ecommerce\Views\Producto\Index.cshtml"
           Write(Html.ActionLink("Editar", "Edit", new { id=item.IdProducto }, new { @class = "btn btn-outline-primary" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                ");
#nullable restore
#line 60 "F:\CIBERTEC\Ciclo 05- Cibertec\Desarrollo de Servicios WEB 1\WordSpace\Ecommerce\Ecommerce\Views\Producto\Index.cshtml"
           Write(Html.ActionLink("Detalles", "Details", new { id=item.IdProducto }, new { @class = "btn btn-outline-info" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                ");
#nullable restore
#line 61 "F:\CIBERTEC\Ciclo 05- Cibertec\Desarrollo de Servicios WEB 1\WordSpace\Ecommerce\Ecommerce\Views\Producto\Index.cshtml"
           Write(Html.ActionLink("Eliminar", "Delete", new { id=item.IdProducto }, new { @class = "btn btn-outline-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 64 "F:\CIBERTEC\Ciclo 05- Cibertec\Desarrollo de Servicios WEB 1\WordSpace\Ecommerce\Ecommerce\Views\Producto\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n<div>\r\n    ");
#nullable restore
#line 68 "F:\CIBERTEC\Ciclo 05- Cibertec\Desarrollo de Servicios WEB 1\WordSpace\Ecommerce\Ecommerce\Views\Producto\Index.cshtml"
Write(ViewBag.mensaje);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Ecommerce.Models.Producto>> Html { get; private set; }
    }
}
#pragma warning restore 1591
