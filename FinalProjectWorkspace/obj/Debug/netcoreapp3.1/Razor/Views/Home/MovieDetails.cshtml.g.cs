#pragma checksum "/Users/audreyhsien/Desktop/Fall2020/MIS333K/KILLER K Final Project/GitHub/FinalProject/FinalProjectWorkspace/Views/Home/MovieDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "15ba3ce8e4d3c2f9245f692bbce14321aa6801a5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(FinalProjectWorkspace.Views.Home.Views_Home_MovieDetails), @"mvc.1.0.view", @"/Views/Home/MovieDetails.cshtml")]
namespace FinalProjectWorkspace.Views.Home
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
#line 2 "/Users/audreyhsien/Desktop/Fall2020/MIS333K/KILLER K Final Project/GitHub/FinalProject/FinalProjectWorkspace/Views/_ViewImports.cshtml"
using FinalProjectWorkspace.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"15ba3ce8e4d3c2f9245f692bbce14321aa6801a5", @"/Views/Home/MovieDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3077373090091c5850da6e8c6a3970a3b8885491", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_MovieDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FinalProjectWorkspace.Models.Movie>
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
            WriteLiteral("\n");
#nullable restore
#line 3 "/Users/audreyhsien/Desktop/Fall2020/MIS333K/KILLER K Final Project/GitHub/FinalProject/FinalProjectWorkspace/Views/Home/MovieDetails.cshtml"
   ViewData["Title"] = "Details"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    <br />\n<h1 class=\"text-center text-danger\">Details</h1>\n<hr style=\"height:2px;border-width:0;color:#d0faff;background-color:#d0faff\">\n<br />\n\n<div class=\"card bg-secondary mb-3\" style=\"max-width: 20rem;\">\n    <div class=\"card-header\">");
#nullable restore
#line 11 "/Users/audreyhsien/Desktop/Fall2020/MIS333K/KILLER K Final Project/GitHub/FinalProject/FinalProjectWorkspace/Views/Home/MovieDetails.cshtml"
                        Write(Html.DisplayNameFor(model => model.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n    <div class=\"card-body\">\n        <h4 class=\"card-title\">Secondary card title</h4>\n        <p class=\"card-text\">\n            ");
#nullable restore
#line 15 "/Users/audreyhsien/Desktop/Fall2020/MIS333K/KILLER K Final Project/GitHub/FinalProject/FinalProjectWorkspace/Views/Home/MovieDetails.cshtml"
       Write(Html.DisplayFor(model => model.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        </p>
    </div>
</div>

<div class=""list-group"">
    <a href=""#"" class=""list-group-item list-group-item-action flex-column align-items-start active"">
        <div class=""d-flex w-100 justify-content-between"">
            <h5 class=""mb-1"">
                ");
#nullable restore
#line 24 "/Users/audreyhsien/Desktop/Fall2020/MIS333K/KILLER K Final Project/GitHub/FinalProject/FinalProjectWorkspace/Views/Home/MovieDetails.cshtml"
           Write(Html.DisplayNameFor(model => model.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </h5>\n            <small>3 days ago</small>\n        </div>\n        <p class=\"mb-1\">\n            ");
#nullable restore
#line 29 "/Users/audreyhsien/Desktop/Fall2020/MIS333K/KILLER K Final Project/GitHub/FinalProject/FinalProjectWorkspace/Views/Home/MovieDetails.cshtml"
       Write(Html.DisplayFor(model => model.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        </p>
        <small>Donec id elit non mi porta.</small>
    </a>
    <a href=""#"" class=""list-group-item list-group-item-action flex-column align-items-start"">
        <div class=""d-flex w-100 justify-content-between"">
            <h5 class=""mb-1"">List group item heading</h5>
            <small class=""text-muted"">3 days ago</small>
        </div>
        <p class=""mb-1"">Donec id elit non mi porta gravida at eget metus. Maecenas sed diam eget risus varius blandit.</p>
        <small class=""text-muted"">Donec id elit non mi porta.</small>
    </a>
</div>

<div>
    <h4>Movie</h4>
    <hr />
    <dl class=""row"">
        <dt class=""col-sm-2"">
            ");
#nullable restore
#line 48 "/Users/audreyhsien/Desktop/Fall2020/MIS333K/KILLER K Final Project/GitHub/FinalProject/FinalProjectWorkspace/Views/Home/MovieDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dt class=\"col-sm-2\">\n            ");
#nullable restore
#line 51 "/Users/audreyhsien/Desktop/Fall2020/MIS333K/KILLER K Final Project/GitHub/FinalProject/FinalProjectWorkspace/Views/Home/MovieDetails.cshtml"
       Write(Html.DisplayFor(model => model.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-3\">\n            ");
#nullable restore
#line 54 "/Users/audreyhsien/Desktop/Fall2020/MIS333K/KILLER K Final Project/GitHub/FinalProject/FinalProjectWorkspace/Views/Home/MovieDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.Overview));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dd class=\"col-sm-3\">\n            ");
#nullable restore
#line 57 "/Users/audreyhsien/Desktop/Fall2020/MIS333K/KILLER K Final Project/GitHub/FinalProject/FinalProjectWorkspace/Views/Home/MovieDetails.cshtml"
       Write(Html.DisplayFor(model => model.Overview));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\">\n            ");
#nullable restore
#line 60 "/Users/audreyhsien/Desktop/Fall2020/MIS333K/KILLER K Final Project/GitHub/FinalProject/FinalProjectWorkspace/Views/Home/MovieDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.Tagline));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dt class=\"col-sm-2\">\n            ");
#nullable restore
#line 63 "/Users/audreyhsien/Desktop/Fall2020/MIS333K/KILLER K Final Project/GitHub/FinalProject/FinalProjectWorkspace/Views/Home/MovieDetails.cshtml"
       Write(Html.DisplayFor(model => model.Tagline));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dt class=\"col-sm-2\">\n            ");
#nullable restore
#line 66 "/Users/audreyhsien/Desktop/Fall2020/MIS333K/KILLER K Final Project/GitHub/FinalProject/FinalProjectWorkspace/Views/Home/MovieDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.MPAARating));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-2\">\n            ");
#nullable restore
#line 69 "/Users/audreyhsien/Desktop/Fall2020/MIS333K/KILLER K Final Project/GitHub/FinalProject/FinalProjectWorkspace/Views/Home/MovieDetails.cshtml"
       Write(Html.DisplayFor(model => model.MPAARating));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\">\n            ");
#nullable restore
#line 72 "/Users/audreyhsien/Desktop/Fall2020/MIS333K/KILLER K Final Project/GitHub/FinalProject/FinalProjectWorkspace/Views/Home/MovieDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.Genre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dt class=\"col-sm-2\">\n            ");
#nullable restore
#line 75 "/Users/audreyhsien/Desktop/Fall2020/MIS333K/KILLER K Final Project/GitHub/FinalProject/FinalProjectWorkspace/Views/Home/MovieDetails.cshtml"
       Write(Html.DisplayFor(model => model.Genre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-2\">\n            ");
#nullable restore
#line 78 "/Users/audreyhsien/Desktop/Fall2020/MIS333K/KILLER K Final Project/GitHub/FinalProject/FinalProjectWorkspace/Views/Home/MovieDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.Year));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dd class=\"col-sm-2\">\n            ");
#nullable restore
#line 81 "/Users/audreyhsien/Desktop/Fall2020/MIS333K/KILLER K Final Project/GitHub/FinalProject/FinalProjectWorkspace/Views/Home/MovieDetails.cshtml"
       Write(Html.DisplayFor(model => model.Year));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n    </dl>\n</div>\n<table class=\"table table-sm table-primary\">\n    <tr>\n        <th>Showings Near You</th>\n    </tr>\n");
#nullable restore
#line 89 "/Users/audreyhsien/Desktop/Fall2020/MIS333K/KILLER K Final Project/GitHub/FinalProject/FinalProjectWorkspace/Views/Home/MovieDetails.cshtml"
     foreach (Showing p in Model.Showings)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\n            <td>");
#nullable restore
#line 92 "/Users/audreyhsien/Desktop/Fall2020/MIS333K/KILLER K Final Project/GitHub/FinalProject/FinalProjectWorkspace/Views/Home/MovieDetails.cshtml"
           Write(Html.DisplayFor(modelItem => p.ShowingDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        </tr>\n");
#nullable restore
#line 94 "/Users/audreyhsien/Desktop/Fall2020/MIS333K/KILLER K Final Project/GitHub/FinalProject/FinalProjectWorkspace/Views/Home/MovieDetails.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\n<div>\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "15ba3ce8e4d3c2f9245f692bbce14321aa6801a511997", async() => {
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
#line 97 "/Users/audreyhsien/Desktop/Fall2020/MIS333K/KILLER K Final Project/GitHub/FinalProject/FinalProjectWorkspace/Views/Home/MovieDetails.cshtml"
                           WriteLiteral(Model.MovieID);

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
            WriteLiteral(" |\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "15ba3ce8e4d3c2f9245f692bbce14321aa6801a514172", async() => {
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
            WriteLiteral("\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FinalProjectWorkspace.Models.Movie> Html { get; private set; }
    }
}
#pragma warning restore 1591
