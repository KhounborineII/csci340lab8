#pragma checksum "C:\Users\metam\Desktop\School Stuff\SEM 1 SOP\DATA\csci340lab8\SharleyanAcademy\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c665f34784e11f07580484caf78ff72a8c185138"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(SharleyanAcademy.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
namespace SharleyanAcademy.Pages
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
#line 1 "C:\Users\metam\Desktop\School Stuff\SEM 1 SOP\DATA\csci340lab8\SharleyanAcademy\Pages\_ViewImports.cshtml"
using SharleyanAcademy;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c665f34784e11f07580484caf78ff72a8c185138", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f55905458fb198ae608e0d241aeaee0d67938051", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\metam\Desktop\School Stuff\SEM 1 SOP\DATA\csci340lab8\SharleyanAcademy\Pages\Index.cshtml"
  
    ViewData["Title"] = "Home page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""row mb-auto"">
    <div class=""col-md-4"">
        <div class=""row no-gutters border mb-4"">
            <div class=""col p-4 mb-4 "">
                <p class=""card-text"">
                    Sharleyan Academy is specifically I. Khounborine's Lab 8 that
                    demonstrates how to use Entity Framework Core in an
                    ASP.NET Core Razor Pages web app.
                </p>
            </div>
        </div>
    </div>
    <div class=""col-md-4"">
        <div class=""row no-gutters border mb-4"">
            <div class=""col p-4 d-flex flex-column position-static"">
                <p class=""card-text mb-auto"">
                    You can build the application by following the steps in a series of tutorials.
                </p>
                <p>
                    <a href=""https://docs.microsoft.com/aspnet/core/data/ef-rp/intro"" class=""stretched-link"">See the tutorial</a>
                </p>
            </div>
        </div>
    </div>
    <div class=""c");
            WriteLiteral(@"ol-md-4"">
        <div class=""row no-gutters border mb-4"">
            <div class=""col p-4 d-flex flex-column"">
                <p class=""card-text mb-auto"">
                    You can download the completed project from GitHub(I don't own that lol).
                </p>
                <p>
                    <a href=""https://github.com/dotnet/AspNetCore.Docs/tree/main/aspnetcore/data/ef-rp/intro/samples"" class=""stretched-link"">See project source code</a>
                </p>
            </div>
        </div>
    </div>
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
