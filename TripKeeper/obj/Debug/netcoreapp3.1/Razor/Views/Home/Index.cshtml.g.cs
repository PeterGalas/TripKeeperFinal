#pragma checksum "C:\Users\peter\OneDrive\Desktop\TripKeeper\TripKeeper\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e7bf67f7ae5745909258fbee15312c4cfa43e652"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e7bf67f7ae5745909258fbee15312c4cfa43e652", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"84ccfb464e7e95718c4bbff02e6e42744fcdb6c3", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary text-white"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Trip", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "C:\Users\peter\OneDrive\Desktop\TripKeeper\TripKeeper\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""jumbotron jumbotron-fluid"">
    <div class=""container"">
        <h1 class=""display-4 text-center"">Trip Keeper</h1>
        <p class=""lead text-center"">Welcome to Trip Keeper! You can do all your paperwork electronically here.</p>
        <div class=""col text-center"">
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e7bf67f7ae5745909258fbee15312c4cfa43e6524582", async() => {
                WriteLiteral("Click here to get started");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
        </div>
    </div>
</div>

<div class=""row"">
    <div class=""col-sm-6"">
        <div class=""card"">
            <div class=""card-header"">
                Daily Pay
            </div>
            <div class=""card-body"">
                <canvas class=""my-4 h-25"" id=""myChart""></canvas>
            </div>
        </div>
    </div>
    <div class=""col-sm-6"">
        <div class=""card"">
            <div class=""card-header"">
                Miles Driven
            </div>
            <div class=""card-body"">
                <canvas class=""my-4 h-25"" id=""myChart2""></canvas>
            </div>
        </div>
    </div>
</div>
<script src=""https://cdnjs.cloudflare.com/ajax/libs/Chart.js/3.5.0/chart.min.js"" integrity=""sha512-asxKqQghC1oBShyhiBwA+YgotaSYKxGP1rcSYTDrB0U6DxwlJjU59B67U8+5/++uFjcuVM8Hh5cokLjZlhm3Vg=="" crossorigin=""anonymous"" referrerpolicy=""no-referrer""></script>
<script type=""text/javascript"">

    const labels = Date.Today
    var ctx = document.getElementById('myChart')");
            WriteLiteral(";\r\n    var myChart = new Chart(ctx, {\r\n        type: \'line\',\r\n        data: {\r\n            labels: [\r\n                \'");
#nullable restore
#line 46 "C:\Users\peter\OneDrive\Desktop\TripKeeper\TripKeeper\Views\Home\Index.cshtml"
            Write(DateTime.Now.ToString("MM-dd"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\',\r\n                \'");
#nullable restore
#line 47 "C:\Users\peter\OneDrive\Desktop\TripKeeper\TripKeeper\Views\Home\Index.cshtml"
            Write(DateTime.Now.AddDays(-1).ToString("MM-dd"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\',\r\n                \'");
#nullable restore
#line 48 "C:\Users\peter\OneDrive\Desktop\TripKeeper\TripKeeper\Views\Home\Index.cshtml"
            Write(DateTime.Now.AddDays(-2).ToString("MM-dd"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\',\r\n                \'");
#nullable restore
#line 49 "C:\Users\peter\OneDrive\Desktop\TripKeeper\TripKeeper\Views\Home\Index.cshtml"
            Write(DateTime.Now.AddDays(-3).ToString("MM-dd"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\',\r\n                \'");
#nullable restore
#line 50 "C:\Users\peter\OneDrive\Desktop\TripKeeper\TripKeeper\Views\Home\Index.cshtml"
            Write(DateTime.Now.AddDays(-4).ToString("MM-dd"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\',\r\n                \'");
#nullable restore
#line 51 "C:\Users\peter\OneDrive\Desktop\TripKeeper\TripKeeper\Views\Home\Index.cshtml"
            Write(DateTime.Now.AddDays(-5).ToString("MM-dd"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"'],
            datasets: [{
                label: 'Paid $',
                data: [490, 1455, 365, 794, 289, 310],
                backgroundColor: [
                    'rgba(255, 99, 132, 0.9)',
                    'rgba(54, 162, 235, 0.9)',
                    'rgba(255, 206, 86, 0.9)',
                    'rgba(75, 192, 192, 0.9)',
                    'rgba(153, 102, 255, 0.9)',
                    'rgba(255, 159, 64, 0.9)'
                ],
                borderColor: [
                    'rgba(255, 99, 132, 1)',
                    'rgba(54, 162, 235, 1)',
                    'rgba(255, 206, 86, 1)',
                    'rgba(75, 192, 192, 1)',
                    'rgba(153, 102, 255, 1)',
                    'rgba(255, 159, 64, 1)'
                ],
                borderWidth: 1,
                tension: 0.50
            }]
        },
        options: {
            scales: {
                y: {
                    beginAtZero: true
                }
            }
 ");
            WriteLiteral("       }\r\n    });\r\n    var ctx = document.getElementById(\'myChart2\');\r\n    var myChart2 = new Chart(ctx, {\r\n        type: \'bar\',\r\n        data: {\r\n            labels: [\r\n                \'");
#nullable restore
#line 88 "C:\Users\peter\OneDrive\Desktop\TripKeeper\TripKeeper\Views\Home\Index.cshtml"
            Write(DateTime.Now.ToString("MM-dd"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\',\r\n                \'");
#nullable restore
#line 89 "C:\Users\peter\OneDrive\Desktop\TripKeeper\TripKeeper\Views\Home\Index.cshtml"
            Write(DateTime.Now.AddDays(-1).ToString("MM-dd"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\',\r\n                \'");
#nullable restore
#line 90 "C:\Users\peter\OneDrive\Desktop\TripKeeper\TripKeeper\Views\Home\Index.cshtml"
            Write(DateTime.Now.AddDays(-2).ToString("MM-dd"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\',\r\n                \'");
#nullable restore
#line 91 "C:\Users\peter\OneDrive\Desktop\TripKeeper\TripKeeper\Views\Home\Index.cshtml"
            Write(DateTime.Now.AddDays(-3).ToString("MM-dd"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\',\r\n                \'");
#nullable restore
#line 92 "C:\Users\peter\OneDrive\Desktop\TripKeeper\TripKeeper\Views\Home\Index.cshtml"
            Write(DateTime.Now.AddDays(-4).ToString("MM-dd"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\',\r\n                \'");
#nullable restore
#line 93 "C:\Users\peter\OneDrive\Desktop\TripKeeper\TripKeeper\Views\Home\Index.cshtml"
            Write(DateTime.Now.AddDays(-5).ToString("MM-dd"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"'],
            datasets: [{
                label: 'Miles',
                data: [490, 360, 365, 794, 289, 310],
                backgroundColor: [
                    'rgba(255, 99, 132, 0.9)',
                    'rgba(54, 162, 235, 0.9)',
                    'rgba(255, 206, 86, 0.9)',
                    'rgba(75, 192, 192, 0.9)',
                    'rgba(153, 102, 255, 0.9)',
                    'rgba(255, 159, 64, 0.9)'
                ],
                borderColor: [
                    'rgba(255, 99, 132, 1)',
                    'rgba(54, 162, 235, 1)',
                    'rgba(255, 206, 86, 1)',
                    'rgba(75, 192, 192, 1)',
                    'rgba(153, 102, 255, 1)',
                    'rgba(255, 159, 64, 1)'
                ],
                borderWidth: 1
            }]
        },
        options: {
            scales: {
                y: {
                    beginAtZero: true
                }
            }
        }
    });

</script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
