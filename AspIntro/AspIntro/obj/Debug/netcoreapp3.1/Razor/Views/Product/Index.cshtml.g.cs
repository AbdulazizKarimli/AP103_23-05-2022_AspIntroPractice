#pragma checksum "D:\Programming\CodeAcademy\Work\AzTU\AP103\ASP.NET\AP103_23-05-2022_AspIntroPractice\AspIntro\AspIntro\Views\Product\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9749886380d0721a8fd9c67615b11739a4461cc1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Index), @"mvc.1.0.view", @"/Views/Product/Index.cshtml")]
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
#line 1 "D:\Programming\CodeAcademy\Work\AzTU\AP103\ASP.NET\AP103_23-05-2022_AspIntroPractice\AspIntro\AspIntro\Views\_ViewImports.cshtml"
using AspIntro.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9749886380d0721a8fd9c67615b11739a4461cc1", @"/Views/Product/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ea58b3f3185f6aeba56e719505fa3099f9e46c52", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Product_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Product>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-img-top"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "D:\Programming\CodeAcademy\Work\AzTU\AP103\ASP.NET\AP103_23-05-2022_AspIntroPractice\AspIntro\AspIntro\Views\Product\Index.cshtml"
  
    ViewData["Title"] = "Product";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row mt-5\">\r\n");
#nullable restore
#line 7 "D:\Programming\CodeAcademy\Work\AzTU\AP103\ASP.NET\AP103_23-05-2022_AspIntroPractice\AspIntro\AspIntro\Views\Product\Index.cshtml"
     foreach (var product in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"col-md-4\">\r\n            <div class=\"card\" style=\"width: 18rem;\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "9749886380d0721a8fd9c67615b11739a4461cc14098", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 247, "~/uploads/images/", 247, 17, true);
#nullable restore
#line 11 "D:\Programming\CodeAcademy\Work\AzTU\AP103\ASP.NET\AP103_23-05-2022_AspIntroPractice\AspIntro\AspIntro\Views\Product\Index.cshtml"
AddHtmlAttributeValue("", 264, product.Image, 264, 14, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 11 "D:\Programming\CodeAcademy\Work\AzTU\AP103\ASP.NET\AP103_23-05-2022_AspIntroPractice\AspIntro\AspIntro\Views\Product\Index.cshtml"
AddHtmlAttributeValue("", 306, product.Name, 306, 13, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                <div class=\"card-body\">\r\n                    <h5 class=\"card-title\">");
#nullable restore
#line 13 "D:\Programming\CodeAcademy\Work\AzTU\AP103\ASP.NET\AP103_23-05-2022_AspIntroPractice\AspIntro\AspIntro\Views\Product\Index.cshtml"
                                      Write(product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                    <p class=\"card-text\">");
#nullable restore
#line 14 "D:\Programming\CodeAcademy\Work\AzTU\AP103\ASP.NET\AP103_23-05-2022_AspIntroPractice\AspIntro\AspIntro\Views\Product\Index.cshtml"
                                    Write(product.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <p class=\"card-text\">Price: ");
#nullable restore
#line 15 "D:\Programming\CodeAcademy\Work\AzTU\AP103\ASP.NET\AP103_23-05-2022_AspIntroPractice\AspIntro\AspIntro\Views\Product\Index.cshtml"
                                           Write(product.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" $</p>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 19 "D:\Programming\CodeAcademy\Work\AzTU\AP103\ASP.NET\AP103_23-05-2022_AspIntroPractice\AspIntro\AspIntro\Views\Product\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Product>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
