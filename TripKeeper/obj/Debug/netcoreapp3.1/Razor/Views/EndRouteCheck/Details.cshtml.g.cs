#pragma checksum "C:\Users\peter\OneDrive\Desktop\TripKeeper\TripKeeper\Views\EndRouteCheck\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "88cad47c8af21995ff99e9db5aedbf60080d4e64"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_EndRouteCheck_Details), @"mvc.1.0.view", @"/Views/EndRouteCheck/Details.cshtml")]
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
#line 1 "C:\Users\peter\OneDrive\Desktop\TripKeeper\TripKeeper\Views\_ViewImports.cshtml"
using TripKeeper;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\peter\OneDrive\Desktop\TripKeeper\TripKeeper\Views\_ViewImports.cshtml"
using TripKeeper.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"88cad47c8af21995ff99e9db5aedbf60080d4e64", @"/Views/EndRouteCheck/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"84ccfb464e7e95718c4bbff02e6e42744fcdb6c3", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_EndRouteCheck_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TripKeeper.Models.EndRouteCheck>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\peter\OneDrive\Desktop\TripKeeper\TripKeeper\Views\EndRouteCheck\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>EndRouteCheck</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n");
            WriteLiteral("        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 20 "C:\Users\peter\OneDrive\Desktop\TripKeeper\TripKeeper\Views\EndRouteCheck\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 23 "C:\Users\peter\OneDrive\Desktop\TripKeeper\TripKeeper\Views\EndRouteCheck\Details.cshtml"
       Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 26 "C:\Users\peter\OneDrive\Desktop\TripKeeper\TripKeeper\Views\EndRouteCheck\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Tractor));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 29 "C:\Users\peter\OneDrive\Desktop\TripKeeper\TripKeeper\Views\EndRouteCheck\Details.cshtml"
       Write(Html.DisplayFor(model => model.Tractor));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 32 "C:\Users\peter\OneDrive\Desktop\TripKeeper\TripKeeper\Views\EndRouteCheck\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Epj));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 35 "C:\Users\peter\OneDrive\Desktop\TripKeeper\TripKeeper\Views\EndRouteCheck\Details.cshtml"
       Write(Html.DisplayFor(model => model.Epj));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 38 "C:\Users\peter\OneDrive\Desktop\TripKeeper\TripKeeper\Views\EndRouteCheck\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Date));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 41 "C:\Users\peter\OneDrive\Desktop\TripKeeper\TripKeeper\Views\EndRouteCheck\Details.cshtml"
       Write(Html.DisplayFor(model => model.Date));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 44 "C:\Users\peter\OneDrive\Desktop\TripKeeper\TripKeeper\Views\EndRouteCheck\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Trailer));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 47 "C:\Users\peter\OneDrive\Desktop\TripKeeper\TripKeeper\Views\EndRouteCheck\Details.cshtml"
       Write(Html.DisplayFor(model => model.Trailer));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 50 "C:\Users\peter\OneDrive\Desktop\TripKeeper\TripKeeper\Views\EndRouteCheck\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.RouteNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 53 "C:\Users\peter\OneDrive\Desktop\TripKeeper\TripKeeper\Views\EndRouteCheck\Details.cshtml"
       Write(Html.DisplayFor(model => model.RouteNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 56 "C:\Users\peter\OneDrive\Desktop\TripKeeper\TripKeeper\Views\EndRouteCheck\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.LoadQualitySurvey));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 59 "C:\Users\peter\OneDrive\Desktop\TripKeeper\TripKeeper\Views\EndRouteCheck\Details.cshtml"
       Write(Html.DisplayFor(model => model.LoadQualitySurvey));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 62 "C:\Users\peter\OneDrive\Desktop\TripKeeper\TripKeeper\Views\EndRouteCheck\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.TurnInBols));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 65 "C:\Users\peter\OneDrive\Desktop\TripKeeper\TripKeeper\Views\EndRouteCheck\Details.cshtml"
       Write(Html.DisplayFor(model => model.TurnInBols));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 68 "C:\Users\peter\OneDrive\Desktop\TripKeeper\TripKeeper\Views\EndRouteCheck\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.TurnInAllPaperwork));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 71 "C:\Users\peter\OneDrive\Desktop\TripKeeper\TripKeeper\Views\EndRouteCheck\Details.cshtml"
       Write(Html.DisplayFor(model => model.TurnInAllPaperwork));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 74 "C:\Users\peter\OneDrive\Desktop\TripKeeper\TripKeeper\Views\EndRouteCheck\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.PalletJack));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 77 "C:\Users\peter\OneDrive\Desktop\TripKeeper\TripKeeper\Views\EndRouteCheck\Details.cshtml"
       Write(Html.DisplayFor(model => model.PalletJack));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 80 "C:\Users\peter\OneDrive\Desktop\TripKeeper\TripKeeper\Views\EndRouteCheck\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ReturnMisPicks));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 83 "C:\Users\peter\OneDrive\Desktop\TripKeeper\TripKeeper\Views\EndRouteCheck\Details.cshtml"
       Write(Html.DisplayFor(model => model.ReturnMisPicks));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 86 "C:\Users\peter\OneDrive\Desktop\TripKeeper\TripKeeper\Views\EndRouteCheck\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ClearTrailer));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 89 "C:\Users\peter\OneDrive\Desktop\TripKeeper\TripKeeper\Views\EndRouteCheck\Details.cshtml"
       Write(Html.DisplayFor(model => model.ClearTrailer));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 92 "C:\Users\peter\OneDrive\Desktop\TripKeeper\TripKeeper\Views\EndRouteCheck\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.SweepTrailer));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 95 "C:\Users\peter\OneDrive\Desktop\TripKeeper\TripKeeper\Views\EndRouteCheck\Details.cshtml"
       Write(Html.DisplayFor(model => model.SweepTrailer));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 98 "C:\Users\peter\OneDrive\Desktop\TripKeeper\TripKeeper\Views\EndRouteCheck\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ReportTrailer));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 101 "C:\Users\peter\OneDrive\Desktop\TripKeeper\TripKeeper\Views\EndRouteCheck\Details.cshtml"
       Write(Html.DisplayFor(model => model.ReportTrailer));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 104 "C:\Users\peter\OneDrive\Desktop\TripKeeper\TripKeeper\Views\EndRouteCheck\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.RetunDvir));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 107 "C:\Users\peter\OneDrive\Desktop\TripKeeper\TripKeeper\Views\EndRouteCheck\Details.cshtml"
       Write(Html.DisplayFor(model => model.RetunDvir));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 110 "C:\Users\peter\OneDrive\Desktop\TripKeeper\TripKeeper\Views\EndRouteCheck\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ReportEquipmentDamages));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 113 "C:\Users\peter\OneDrive\Desktop\TripKeeper\TripKeeper\Views\EndRouteCheck\Details.cshtml"
       Write(Html.DisplayFor(model => model.ReportEquipmentDamages));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 116 "C:\Users\peter\OneDrive\Desktop\TripKeeper\TripKeeper\Views\EndRouteCheck\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.StrapsHanding));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 119 "C:\Users\peter\OneDrive\Desktop\TripKeeper\TripKeeper\Views\EndRouteCheck\Details.cshtml"
       Write(Html.DisplayFor(model => model.StrapsHanding));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 122 "C:\Users\peter\OneDrive\Desktop\TripKeeper\TripKeeper\Views\EndRouteCheck\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.TrailerShuttle));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 125 "C:\Users\peter\OneDrive\Desktop\TripKeeper\TripKeeper\Views\EndRouteCheck\Details.cshtml"
       Write(Html.DisplayFor(model => model.TrailerShuttle));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 128 "C:\Users\peter\OneDrive\Desktop\TripKeeper\TripKeeper\Views\EndRouteCheck\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.TrailerLocation));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 131 "C:\Users\peter\OneDrive\Desktop\TripKeeper\TripKeeper\Views\EndRouteCheck\Details.cshtml"
       Write(Html.DisplayFor(model => model.TrailerLocation));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 134 "C:\Users\peter\OneDrive\Desktop\TripKeeper\TripKeeper\Views\EndRouteCheck\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DriverSignature));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 137 "C:\Users\peter\OneDrive\Desktop\TripKeeper\TripKeeper\Views\EndRouteCheck\Details.cshtml"
       Write(Html.DisplayFor(model => model.DriverSignature));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "88cad47c8af21995ff99e9db5aedbf60080d4e6417572", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 142 "C:\Users\peter\OneDrive\Desktop\TripKeeper\TripKeeper\Views\EndRouteCheck\Details.cshtml"
                           WriteLiteral(Model.Id);

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
            WriteLiteral(" |\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "88cad47c8af21995ff99e9db5aedbf60080d4e6419725", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TripKeeper.Models.EndRouteCheck> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
