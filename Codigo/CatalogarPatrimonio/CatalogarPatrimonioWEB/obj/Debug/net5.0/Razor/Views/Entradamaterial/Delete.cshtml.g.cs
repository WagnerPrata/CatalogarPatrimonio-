#pragma checksum "C:\Users\Wagner Prata\Documents\A UFS 2020.1\ESII\CatalogarPatrimonio\Codigo\CatalogarPatrimonio\CatalogarPatrimonioWEB\Views\Entradamaterial\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d4ff2724a00b4ec8a51bf60b933059edd8c1d71b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Entradamaterial_Delete), @"mvc.1.0.view", @"/Views/Entradamaterial/Delete.cshtml")]
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
#line 1 "C:\Users\Wagner Prata\Documents\A UFS 2020.1\ESII\CatalogarPatrimonio\Codigo\CatalogarPatrimonio\CatalogarPatrimonioWEB\Views\_ViewImports.cshtml"
using CatalogarPatrimonioWEB;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Wagner Prata\Documents\A UFS 2020.1\ESII\CatalogarPatrimonio\Codigo\CatalogarPatrimonio\CatalogarPatrimonioWEB\Views\_ViewImports.cshtml"
using CatalogarPatrimonioWEB.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d4ff2724a00b4ec8a51bf60b933059edd8c1d71b", @"/Views/Entradamaterial/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"707f9857d1ac4a6931fda82426dd3037ca11462b", @"/Views/_ViewImports.cshtml")]
    public class Views_Entradamaterial_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CatalogarPatrimonioWEB.Models.EntradamaterialModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Wagner Prata\Documents\A UFS 2020.1\ESII\CatalogarPatrimonio\Codigo\CatalogarPatrimonio\CatalogarPatrimonioWEB\Views\Entradamaterial\Delete.cshtml"
  
    ViewData["Title"] = "Remover Entrada de Material";
    Layout = "_LayoutInside";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Remover</h1>\r\n\r\n<h3>Você tem certeza que deseja remover?</h3>\r\n<div>\r\n    <h4>Entrada de Material: <b>");
#nullable restore
#line 12 "C:\Users\Wagner Prata\Documents\A UFS 2020.1\ESII\CatalogarPatrimonio\Codigo\CatalogarPatrimonio\CatalogarPatrimonioWEB\Views\Entradamaterial\Delete.cshtml"
                           Write(Html.DisplayFor(model => model.IdMaterial));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</b> </h4>
    <hr />
    <div class = ""col-md-8"">    
        <div class=""card"">
            <div class=""card-body"">
                <dl class=""row"">
                    <dt class = ""col-sm-2 list-group-item list-group-item-danger"">
                        ");
#nullable restore
#line 19 "C:\Users\Wagner Prata\Documents\A UFS 2020.1\ESII\CatalogarPatrimonio\Codigo\CatalogarPatrimonio\CatalogarPatrimonioWEB\Views\Entradamaterial\Delete.cshtml"
                   Write(Html.DisplayNameFor(model => model.IdMaterial));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dt>\r\n                    <dd class = \"col-sm-10 list-group-item\">\r\n                        ");
#nullable restore
#line 22 "C:\Users\Wagner Prata\Documents\A UFS 2020.1\ESII\CatalogarPatrimonio\Codigo\CatalogarPatrimonio\CatalogarPatrimonioWEB\Views\Entradamaterial\Delete.cshtml"
                   Write(Html.DisplayFor(model => model.IdMaterial));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dd>\r\n                    <dt class = \"col-sm-2 list-group-item list-group-item-danger\">\r\n                        ");
#nullable restore
#line 25 "C:\Users\Wagner Prata\Documents\A UFS 2020.1\ESII\CatalogarPatrimonio\Codigo\CatalogarPatrimonio\CatalogarPatrimonioWEB\Views\Entradamaterial\Delete.cshtml"
                   Write(Html.DisplayNameFor(model => model.IdEntrada));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dt>\r\n                    <dd class = \"col-sm-10 list-group-item\">\r\n                        ");
#nullable restore
#line 28 "C:\Users\Wagner Prata\Documents\A UFS 2020.1\ESII\CatalogarPatrimonio\Codigo\CatalogarPatrimonio\CatalogarPatrimonioWEB\Views\Entradamaterial\Delete.cshtml"
                   Write(Html.DisplayFor(model => model.IdEntrada));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dd>\r\n                    <dt class = \"col-sm-2 list-group-item list-group-item-danger\">\r\n                        ");
#nullable restore
#line 31 "C:\Users\Wagner Prata\Documents\A UFS 2020.1\ESII\CatalogarPatrimonio\Codigo\CatalogarPatrimonio\CatalogarPatrimonioWEB\Views\Entradamaterial\Delete.cshtml"
                   Write(Html.DisplayNameFor(model => model.Quantidade));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dt>\r\n                    <dd class = \"col-sm-10 list-group-item\">\r\n                        ");
#nullable restore
#line 34 "C:\Users\Wagner Prata\Documents\A UFS 2020.1\ESII\CatalogarPatrimonio\Codigo\CatalogarPatrimonio\CatalogarPatrimonioWEB\Views\Entradamaterial\Delete.cshtml"
                   Write(Html.DisplayFor(model => model.Quantidade));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dd>\r\n                    <dt class = \"col-sm-2 list-group-item list-group-item-danger\">\r\n                        ");
#nullable restore
#line 37 "C:\Users\Wagner Prata\Documents\A UFS 2020.1\ESII\CatalogarPatrimonio\Codigo\CatalogarPatrimonio\CatalogarPatrimonioWEB\Views\Entradamaterial\Delete.cshtml"
                   Write(Html.DisplayNameFor(model => model.Valor));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dt>\r\n                    <dd class = \"col-sm-10 list-group-item\">\r\n                        ");
#nullable restore
#line 40 "C:\Users\Wagner Prata\Documents\A UFS 2020.1\ESII\CatalogarPatrimonio\Codigo\CatalogarPatrimonio\CatalogarPatrimonioWEB\Views\Entradamaterial\Delete.cshtml"
                   Write(Html.DisplayFor(model => model.Valor));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dd>\r\n                    <dt class = \"col-sm-2 list-group-item list-group-item-danger\">\r\n                        ");
#nullable restore
#line 43 "C:\Users\Wagner Prata\Documents\A UFS 2020.1\ESII\CatalogarPatrimonio\Codigo\CatalogarPatrimonio\CatalogarPatrimonioWEB\Views\Entradamaterial\Delete.cshtml"
                   Write(Html.DisplayNameFor(model => model.QuantidadeUtilizada));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dt>\r\n                    <dd class = \"col-sm-10 list-group-item\">\r\n                        ");
#nullable restore
#line 46 "C:\Users\Wagner Prata\Documents\A UFS 2020.1\ESII\CatalogarPatrimonio\Codigo\CatalogarPatrimonio\CatalogarPatrimonioWEB\Views\Entradamaterial\Delete.cshtml"
                   Write(Html.DisplayFor(model => model.QuantidadeUtilizada));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dd>\r\n                </dl>\r\n            </div>\r\n            <div class=\"card-footer\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d4ff2724a00b4ec8a51bf60b933059edd8c1d71b10473", async() => {
                WriteLiteral("\r\n                    <input type=\"submit\" value=\"Remover\" class=\"btn btn-danger\" />\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d4ff2724a00b4ec8a51bf60b933059edd8c1d71b10844", async() => {
                    WriteLiteral("Cancelar");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CatalogarPatrimonioWEB.Models.EntradamaterialModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
