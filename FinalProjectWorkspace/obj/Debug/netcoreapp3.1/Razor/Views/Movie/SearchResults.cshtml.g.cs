#pragma checksum "/Users/jennifertruong/Documents/GitHub/FinalProject/FinalProjectWorkspace/Views/Movie/SearchResults.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e84896debf7063d7e7ed932ef884b00d2134a81f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(FinalProjectWorkspace.Views.Movie.Views_Movie_SearchResults), @"mvc.1.0.view", @"/Views/Movie/SearchResults.cshtml")]
namespace FinalProjectWorkspace.Views.Movie
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
#line 2 "/Users/jennifertruong/Documents/GitHub/FinalProject/FinalProjectWorkspace/Views/_ViewImports.cshtml"
using FinalProjectWorkspace.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e84896debf7063d7e7ed932ef884b00d2134a81f", @"/Views/Movie/SearchResults.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3077373090091c5850da6e8c6a3970a3b8885491", @"/Views/_ViewImports.cshtml")]
    public class Views_Movie_SearchResults : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<FinalProjectWorkspace.Models.Movie>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Browse", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("color:white"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "/Users/jennifertruong/Documents/GitHub/FinalProject/FinalProjectWorkspace/Views/Movie/SearchResults.cshtml"
   ViewData["Title"] = "Movie Search Results"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h1>Movies</h1>\n\n<div>\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e84896debf7063d7e7ed932ef884b00d2134a81f3953", async() => {
                WriteLiteral("Back to Search");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
</div>

<!--
<form asp-action=""Index"" asp-controller=""Home"" method=""get"">
    <p class=""form-group"">
        Search: <input name=""SearchString"" class=""form-control"" /><br />
        <button type=""submit"" class=""btn btn-primary"">Search</button>
        <a asp-action=""DetailedSearch"" class=""btn btn-success"">Detailed Search</a>
        <a asp-action=""Index"" class=""btn btn-danger"">Show All</a>
    </p>
</form>
    -->
<!--<p> Displaying ViewBag.SelectedJobs of ViewBag.AllJobs Job Postings</p>-->

<table class=""table table-hover text-center"" >
    <thead>
        <tr class=""text-light text-center"">
            <th>
                ");
#nullable restore
#line 27 "/Users/jennifertruong/Documents/GitHub/FinalProject/FinalProjectWorkspace/Views/Movie/SearchResults.cshtml"
           Write(Html.DisplayNameFor(model => model.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <!--\n            <th>\n        Html.DisplayNameFor(model => model.Overview)\n            </th>\n            -->\n            <th>\n                ");
#nullable restore
#line 35 "/Users/jennifertruong/Documents/GitHub/FinalProject/FinalProjectWorkspace/Views/Movie/SearchResults.cshtml"
           Write(Html.DisplayNameFor(model => model.Tagline));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 38 "/Users/jennifertruong/Documents/GitHub/FinalProject/FinalProjectWorkspace/Views/Movie/SearchResults.cshtml"
           Write(Html.DisplayNameFor(model => model.RunTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 41 "/Users/jennifertruong/Documents/GitHub/FinalProject/FinalProjectWorkspace/Views/Movie/SearchResults.cshtml"
           Write(Html.DisplayNameFor(model => model.Year));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <!--\n            <th>\n                Html.DisplayNameFor(model => model.Actors)\n            </th>\n            -->\n            <th>\n                ");
#nullable restore
#line 49 "/Users/jennifertruong/Documents/GitHub/FinalProject/FinalProjectWorkspace/Views/Movie/SearchResults.cshtml"
           Write(Html.DisplayNameFor(model => model.MPAARating));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 52 "/Users/jennifertruong/Documents/GitHub/FinalProject/FinalProjectWorkspace/Views/Movie/SearchResults.cshtml"
           Write(Html.DisplayNameFor(model => model.Genre.GenreName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                Find Showings Now!\n            </th>\n        </tr>\n    </thead>\n    <tbody>\n");
#nullable restore
#line 60 "/Users/jennifertruong/Documents/GitHub/FinalProject/FinalProjectWorkspace/Views/Movie/SearchResults.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr class=\"table-secondary text-center text-dark\">\n            <td>\n                ");
#nullable restore
#line 64 "/Users/jennifertruong/Documents/GitHub/FinalProject/FinalProjectWorkspace/Views/Movie/SearchResults.cshtml"
           Write(Html.DisplayFor(modelItem => item.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <!--\n            <td>\n                Html.DisplayFor(modelItem => item.Overview)\n            </td>\n            -->\n            <td>\n                ");
#nullable restore
#line 72 "/Users/jennifertruong/Documents/GitHub/FinalProject/FinalProjectWorkspace/Views/Movie/SearchResults.cshtml"
           Write(Html.DisplayFor(modelItem => item.Tagline));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 75 "/Users/jennifertruong/Documents/GitHub/FinalProject/FinalProjectWorkspace/Views/Movie/SearchResults.cshtml"
           Write(Html.DisplayFor(modelItem => item.RunTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 78 "/Users/jennifertruong/Documents/GitHub/FinalProject/FinalProjectWorkspace/Views/Movie/SearchResults.cshtml"
           Write(Html.DisplayFor(modelItem => item.Year));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <!--\n            <td>\n                Html.DisplayFor(modelItem => item.Actors)\n            </td>\n            --->\n            <td>\n                ");
#nullable restore
#line 86 "/Users/jennifertruong/Documents/GitHub/FinalProject/FinalProjectWorkspace/Views/Movie/SearchResults.cshtml"
           Write(Html.DisplayFor(modelItem => item.MPAARating));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 89 "/Users/jennifertruong/Documents/GitHub/FinalProject/FinalProjectWorkspace/Views/Movie/SearchResults.cshtml"
           Write(Html.DisplayFor(modelItem => item.Genre.GenreName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 92 "/Users/jennifertruong/Documents/GitHub/FinalProject/FinalProjectWorkspace/Views/Movie/SearchResults.cshtml"
           Write(Html.ActionLink("Showing Times", "Details", new { id = item.MovieID }, new { style = "color:red" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n        </tr>\n");
#nullable restore
#line 95 "/Users/jennifertruong/Documents/GitHub/FinalProject/FinalProjectWorkspace/Views/Movie/SearchResults.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\n</table>\n\n<div>\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e84896debf7063d7e7ed932ef884b00d2134a81f11385", async() => {
                WriteLiteral("Back to Search");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n</div>\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<FinalProjectWorkspace.Models.Movie>> Html { get; private set; }
    }
}
#pragma warning restore 1591
