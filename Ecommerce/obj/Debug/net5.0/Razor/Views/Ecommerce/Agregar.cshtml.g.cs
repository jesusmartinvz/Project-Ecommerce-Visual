#pragma checksum "F:\CIBERTEC\Ciclo 05- Cibertec\Desarrollo de Servicios WEB 1\WordSpace\Ecommerce\Ecommerce\Views\Ecommerce\Agregar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8164faa9d2c2a628654dd62cdb898e0c40efd5cb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Ecommerce_Agregar), @"mvc.1.0.view", @"/Views/Ecommerce/Agregar.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8164faa9d2c2a628654dd62cdb898e0c40efd5cb", @"/Views/Ecommerce/Agregar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6bbcd7c65731fc074a835809e73fcf2cf9014c29", @"/Views/_ViewImports.cshtml")]
    public class Views_Ecommerce_Agregar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Ecommerce.Models.Producto>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/Layout/style/perzonalizado.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "F:\CIBERTEC\Ciclo 05- Cibertec\Desarrollo de Servicios WEB 1\WordSpace\Ecommerce\Ecommerce\Views\Ecommerce\Agregar.cshtml"
  
    ViewData["Title"] = "Agregar";
    Layout = "~/Views/Shared/_Master.cshtml";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "8164faa9d2c2a628654dd62cdb898e0c40efd5cb4261", async() => {
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

<br/>
<h2 style=""text-align: center;"">Adicionar Producto</h2>

<!-- SECTION -->
<div class=""section"">
    <!-- container -->
    <div class=""container"">
        <!-- row -->
        <div class=""row"">
            <!-- Product main img -->
            <div class=""col-md-5 col-md-push-2"">
                <div id=""product-main-img"">
                    <div class=""product-preview"">
                        <img");
            BeginWriteAttribute("src", " src=\"", 621, "\"", 651, 1);
#nullable restore
#line 22 "F:\CIBERTEC\Ciclo 05- Cibertec\Desarrollo de Servicios WEB 1\WordSpace\Ecommerce\Ecommerce\Views\Ecommerce\Agregar.cshtml"
WriteAttributeValue("", 627, Url.Content(Model.Foto), 627, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" />
                    </div>
                </div>
            </div>
            <!-- /Product main img -->
            <!-- Product thumb imgs -->
            <div class=""col-md-2  col-md-pull-5"">
            </div>
            <!-- /Product thumb imgs -->
            <!-- Product details -->
            <div class=""col-md-5"">
                <div class=""product-details"">
                    <h2 class=""product-name"">");
#nullable restore
#line 34 "F:\CIBERTEC\Ciclo 05- Cibertec\Desarrollo de Servicios WEB 1\WordSpace\Ecommerce\Ecommerce\Views\Ecommerce\Agregar.cshtml"
                                        Write(Html.DisplayFor(model => model.Descripcion));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h2>
                    <div>
                        <div class=""product-rating"">
                            <i class=""fa fa-star""></i>
                            <i class=""fa fa-star""></i>
                            <i class=""fa fa-star""></i>
                            <i class=""fa fa-star""></i>
                            <i class=""fa fa-star-o""></i>
                        </div>
                        <a class=""review-link"" href=""#"">10 Review(s) | Add your review</a>
                    </div>
                    <div>
                        <h3 class=""product-price"">S/");
#nullable restore
#line 46 "F:\CIBERTEC\Ciclo 05- Cibertec\Desarrollo de Servicios WEB 1\WordSpace\Ecommerce\Ecommerce\Views\Ecommerce\Agregar.cshtml"
                                               Write(Html.DisplayFor(model => model.precioFinal));

#line default
#line hidden
#nullable disable
            WriteLiteral("<del class=\"product-old-price\">");
#nullable restore
#line 46 "F:\CIBERTEC\Ciclo 05- Cibertec\Desarrollo de Servicios WEB 1\WordSpace\Ecommerce\Ecommerce\Views\Ecommerce\Agregar.cshtml"
                                                                                                                          Write(Html.DisplayFor(model => model.Precio));

#line default
#line hidden
#nullable disable
            WriteLiteral("</del></h3>\r\n                        <span class=\"product-available\">");
#nullable restore
#line 47 "F:\CIBERTEC\Ciclo 05- Cibertec\Desarrollo de Servicios WEB 1\WordSpace\Ecommerce\Ecommerce\Views\Ecommerce\Agregar.cshtml"
                                                   Write(Html.DisplayFor(model => model.Stock));

#line default
#line hidden
#nullable disable
            WriteLiteral(@" Stock</span>
                    </div>
                    <p>Uno de los mejores productos que encontraras en PCStore, ofreciendo productos de la mejor calidad, al mejor precio.</p>
                    <br/>
                    <div class=""add-to-cart"">
");
#nullable restore
#line 52 "F:\CIBERTEC\Ciclo 05- Cibertec\Desarrollo de Servicios WEB 1\WordSpace\Ecommerce\Ecommerce\Views\Ecommerce\Agregar.cshtml"
                         using (Html.BeginForm())
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 54 "F:\CIBERTEC\Ciclo 05- Cibertec\Desarrollo de Servicios WEB 1\WordSpace\Ecommerce\Ecommerce\Views\Ecommerce\Agregar.cshtml"
                       Write(Html.Hidden("id", Model.IdProducto));

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"qty-label\"> Cantidad </div>\r\n");
#nullable restore
#line 56 "F:\CIBERTEC\Ciclo 05- Cibertec\Desarrollo de Servicios WEB 1\WordSpace\Ecommerce\Ecommerce\Views\Ecommerce\Agregar.cshtml"
                       Write(Html.TextBox("cantidad", 1, new { @type = "number", @class = "txbox", @min = "1" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <br /><br />\r\n                            <div class=\"alert-txt\">\r\n                                ");
#nullable restore
#line 59 "F:\CIBERTEC\Ciclo 05- Cibertec\Desarrollo de Servicios WEB 1\WordSpace\Ecommerce\Ecommerce\Views\Ecommerce\Agregar.cshtml"
                           Write(ViewBag.mensaje);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </div>\r\n                            <button type=\"submit\" class=\"add-to-cart-btn\"><i class=\"fa fa-shopping-cart\"></i>Agregar al Carro</button>\r\n");
#nullable restore
#line 62 "F:\CIBERTEC\Ciclo 05- Cibertec\Desarrollo de Servicios WEB 1\WordSpace\Ecommerce\Ecommerce\Views\Ecommerce\Agregar.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </div>

                    <ul class=""product-links"">
                        <li>Category:</li>
                        <li><a href=""#"">Headphones</a></li>
                        <li><a href=""#"">Accessories</a></li>
                    </ul>

                    <ul class=""product-links"">
                        <li>Share:</li>
                        <li><a href=""#""><i class=""fa fa-facebook""></i></a></li>
                        <li><a href=""#""><i class=""fa fa-twitter""></i></a></li>
                        <li><a href=""#""><i class=""fa fa-google-plus""></i></a></li>
                        <li><a href=""#""><i class=""fa fa-envelope""></i></a></li>
                    </ul>

                </div>
            </div>
            <!-- /Product details -->
            
        </div>
        <!-- /row -->
    </div>
    <!-- /container -->
</div>
<!-- /SECTION -->
<div>
    ");
#nullable restore
#line 90 "F:\CIBERTEC\Ciclo 05- Cibertec\Desarrollo de Servicios WEB 1\WordSpace\Ecommerce\Ecommerce\Views\Ecommerce\Agregar.cshtml"
Write(ViewBag.mensaje);

#line default
#line hidden
#nullable disable
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
