#pragma checksum "C:\Users\Haroon\Documents\GitHub\CO550-Blockbusters\Code\Razor Pages\blockbusters\Pages\Explore.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cf3abcc491ace2b5bc628721bd6c09164a8b1f00"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(blockbusters.Pages.Pages_Explore), @"mvc.1.0.razor-page", @"/Pages/Explore.cshtml")]
namespace blockbusters.Pages
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
#line 1 "C:\Users\Haroon\Documents\GitHub\CO550-Blockbusters\Code\Razor Pages\blockbusters\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Haroon\Documents\GitHub\CO550-Blockbusters\Code\Razor Pages\blockbusters\Pages\_ViewImports.cshtml"
using blockbusters;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Haroon\Documents\GitHub\CO550-Blockbusters\Code\Razor Pages\blockbusters\Pages\_ViewImports.cshtml"
using blockbusters.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cf3abcc491ace2b5bc628721bd6c09164a8b1f00", @"/Pages/Explore.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7c3d7d21fabd7b7db4aecaebdea7d5cce5215738", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Explore : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "\\Video", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 3 "C:\Users\Haroon\Documents\GitHub\CO550-Blockbusters\Code\Razor Pages\blockbusters\Pages\Explore.cshtml"
  
    int columnNo = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<header class=\"jumbotron\">\r\n    <h1>BlockBuster Movies</h1>\r\n</header>\r\n\r\n<section>        \r\n    <div class=\"row\">\r\n");
#nullable restore
#line 13 "C:\Users\Haroon\Documents\GitHub\CO550-Blockbusters\Code\Razor Pages\blockbusters\Pages\Explore.cshtml"
         foreach (var item in Model.Movie) 
        {
            if (columnNo > 0 && columnNo % 3 == 0)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                ");
            WriteLiteral("</div><div class=\"row\">\r\n");
#nullable restore
#line 18 "C:\Users\Haroon\Documents\GitHub\CO550-Blockbusters\Code\Razor Pages\blockbusters\Pages\Explore.cshtml"
            }
        

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-lg-4\">\r\n                <div class=\"card\" style=\"width: 18rem;\">\r\n                    <img");
            BeginWriteAttribute("src", " src=\"", 504, "\"", 539, 2);
            WriteAttributeValue("", 510, "/images/", 510, 8, true);
#nullable restore
#line 22 "C:\Users\Haroon\Documents\GitHub\CO550-Blockbusters\Code\Razor Pages\blockbusters\Pages\Explore.cshtml"
WriteAttributeValue("", 518, item.ContentLocation, 518, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" \r\n                         class=\"card-img-top\" alt=\"Movie 001\" width=\"200\"/>\r\n                    <div class=\"card-body\">\r\n                        <h5 class=\"card-title\">");
#nullable restore
#line 25 "C:\Users\Haroon\Documents\GitHub\CO550-Blockbusters\Code\Razor Pages\blockbusters\Pages\Explore.cshtml"
                                          Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                        <p class=\"card-text\">");
#nullable restore
#line 26 "C:\Users\Haroon\Documents\GitHub\CO550-Blockbusters\Code\Razor Pages\blockbusters\Pages\Explore.cshtml"
                                        Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cf3abcc491ace2b5bc628721bd6c09164a8b1f006442", async() => {
                WriteLiteral("View Movie");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 27 "C:\Users\Haroon\Documents\GitHub\CO550-Blockbusters\Code\Razor Pages\blockbusters\Pages\Explore.cshtml"
                                               WriteLiteral(item.MovieID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 31 "C:\Users\Haroon\Documents\GitHub\CO550-Blockbusters\Code\Razor Pages\blockbusters\Pages\Explore.cshtml"

            columnNo++;
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<blockbusters.Pages.ExploreModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<blockbusters.Pages.ExploreModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<blockbusters.Pages.ExploreModel>)PageContext?.ViewData;
        public blockbusters.Pages.ExploreModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
