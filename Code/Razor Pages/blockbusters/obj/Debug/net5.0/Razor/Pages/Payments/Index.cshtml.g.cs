#pragma checksum "C:\Users\Haroon\Downloads\CO550-Blockbusters-985e7c3357c6c82058d617eff157f8bf76a0c13a\CO550-Blockbusters-985e7c3357c6c82058d617eff157f8bf76a0c13a\Code\Razor Pages\blockbusters\Pages\Payments\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5ee989f5ce65abce70526a11967a54193bad9c19"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(blockbusters.Pages.Payments.Pages_Payments_Index), @"mvc.1.0.razor-page", @"/Pages/Payments/Index.cshtml")]
namespace blockbusters.Pages.Payments
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
#line 1 "C:\Users\Haroon\Downloads\CO550-Blockbusters-985e7c3357c6c82058d617eff157f8bf76a0c13a\CO550-Blockbusters-985e7c3357c6c82058d617eff157f8bf76a0c13a\Code\Razor Pages\blockbusters\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Haroon\Downloads\CO550-Blockbusters-985e7c3357c6c82058d617eff157f8bf76a0c13a\CO550-Blockbusters-985e7c3357c6c82058d617eff157f8bf76a0c13a\Code\Razor Pages\blockbusters\Pages\_ViewImports.cshtml"
using blockbusters;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Haroon\Downloads\CO550-Blockbusters-985e7c3357c6c82058d617eff157f8bf76a0c13a\CO550-Blockbusters-985e7c3357c6c82058d617eff157f8bf76a0c13a\Code\Razor Pages\blockbusters\Pages\_ViewImports.cshtml"
using blockbusters.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5ee989f5ce65abce70526a11967a54193bad9c19", @"/Pages/Payments/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cfcc27950b7094bfaeb261a4a0ac109efb44fc40", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Payments_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\n");
#nullable restore
#line 4 "C:\Users\Haroon\Downloads\CO550-Blockbusters-985e7c3357c6c82058d617eff157f8bf76a0c13a\CO550-Blockbusters-985e7c3357c6c82058d617eff157f8bf76a0c13a\Code\Razor Pages\blockbusters\Pages\Payments\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h1>Index</h1>\n\n<p>\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5ee989f5ce65abce70526a11967a54193bad9c195379", async() => {
                WriteLiteral("Create New");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n</p>\n<table class=\"table\">\n    <thead>\n        <tr>\n            <th>\n                ");
#nullable restore
#line 17 "C:\Users\Haroon\Downloads\CO550-Blockbusters-985e7c3357c6c82058d617eff157f8bf76a0c13a\CO550-Blockbusters-985e7c3357c6c82058d617eff157f8bf76a0c13a\Code\Razor Pages\blockbusters\Pages\Payments\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Payment[0].CardholderName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 20 "C:\Users\Haroon\Downloads\CO550-Blockbusters-985e7c3357c6c82058d617eff157f8bf76a0c13a\CO550-Blockbusters-985e7c3357c6c82058d617eff157f8bf76a0c13a\Code\Razor Pages\blockbusters\Pages\Payments\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Payment[0].CardNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 23 "C:\Users\Haroon\Downloads\CO550-Blockbusters-985e7c3357c6c82058d617eff157f8bf76a0c13a\CO550-Blockbusters-985e7c3357c6c82058d617eff157f8bf76a0c13a\Code\Razor Pages\blockbusters\Pages\Payments\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Payment[0].ExpirationDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 26 "C:\Users\Haroon\Downloads\CO550-Blockbusters-985e7c3357c6c82058d617eff157f8bf76a0c13a\CO550-Blockbusters-985e7c3357c6c82058d617eff157f8bf76a0c13a\Code\Razor Pages\blockbusters\Pages\Payments\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Payment[0].CCV));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th></th>\n        </tr>\n    </thead>\n    <tbody>\n");
#nullable restore
#line 32 "C:\Users\Haroon\Downloads\CO550-Blockbusters-985e7c3357c6c82058d617eff157f8bf76a0c13a\CO550-Blockbusters-985e7c3357c6c82058d617eff157f8bf76a0c13a\Code\Razor Pages\blockbusters\Pages\Payments\Index.cshtml"
 foreach (var item in Model.Payment) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\n            <td>\n                ");
#nullable restore
#line 35 "C:\Users\Haroon\Downloads\CO550-Blockbusters-985e7c3357c6c82058d617eff157f8bf76a0c13a\CO550-Blockbusters-985e7c3357c6c82058d617eff157f8bf76a0c13a\Code\Razor Pages\blockbusters\Pages\Payments\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.CardholderName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 38 "C:\Users\Haroon\Downloads\CO550-Blockbusters-985e7c3357c6c82058d617eff157f8bf76a0c13a\CO550-Blockbusters-985e7c3357c6c82058d617eff157f8bf76a0c13a\Code\Razor Pages\blockbusters\Pages\Payments\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.CardNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 41 "C:\Users\Haroon\Downloads\CO550-Blockbusters-985e7c3357c6c82058d617eff157f8bf76a0c13a\CO550-Blockbusters-985e7c3357c6c82058d617eff157f8bf76a0c13a\Code\Razor Pages\blockbusters\Pages\Payments\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.ExpirationDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 44 "C:\Users\Haroon\Downloads\CO550-Blockbusters-985e7c3357c6c82058d617eff157f8bf76a0c13a\CO550-Blockbusters-985e7c3357c6c82058d617eff157f8bf76a0c13a\Code\Razor Pages\blockbusters\Pages\Payments\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.CCV));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5ee989f5ce65abce70526a11967a54193bad9c1910606", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 47 "C:\Users\Haroon\Downloads\CO550-Blockbusters-985e7c3357c6c82058d617eff157f8bf76a0c13a\CO550-Blockbusters-985e7c3357c6c82058d617eff157f8bf76a0c13a\Code\Razor Pages\blockbusters\Pages\Payments\Index.cshtml"
                                       WriteLiteral(item.PaymentID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5ee989f5ce65abce70526a11967a54193bad9c1912899", async() => {
                WriteLiteral("Details");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 48 "C:\Users\Haroon\Downloads\CO550-Blockbusters-985e7c3357c6c82058d617eff157f8bf76a0c13a\CO550-Blockbusters-985e7c3357c6c82058d617eff157f8bf76a0c13a\Code\Razor Pages\blockbusters\Pages\Payments\Index.cshtml"
                                          WriteLiteral(item.PaymentID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5ee989f5ce65abce70526a11967a54193bad9c1915198", async() => {
                WriteLiteral("Delete");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 49 "C:\Users\Haroon\Downloads\CO550-Blockbusters-985e7c3357c6c82058d617eff157f8bf76a0c13a\CO550-Blockbusters-985e7c3357c6c82058d617eff157f8bf76a0c13a\Code\Razor Pages\blockbusters\Pages\Payments\Index.cshtml"
                                         WriteLiteral(item.PaymentID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n            </td>\n        </tr>\n");
#nullable restore
#line 52 "C:\Users\Haroon\Downloads\CO550-Blockbusters-985e7c3357c6c82058d617eff157f8bf76a0c13a\CO550-Blockbusters-985e7c3357c6c82058d617eff157f8bf76a0c13a\Code\Razor Pages\blockbusters\Pages\Payments\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\n</table>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<blockbusters.Pages.Payments.IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<blockbusters.Pages.Payments.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<blockbusters.Pages.Payments.IndexModel>)PageContext?.ViewData;
        public blockbusters.Pages.Payments.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
