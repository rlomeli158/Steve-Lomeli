#pragma checksum "/Users/guy/Documents/School/Year 3/Fall 2020/MIS 333K/Final Project/FinalProject/FinalProjectWorkspace/Views/Movie/SearchResults.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ead8c86163b36c76d51f8386303bebc100801758"
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
#line 2 "/Users/guy/Documents/School/Year 3/Fall 2020/MIS 333K/Final Project/FinalProject/FinalProjectWorkspace/Views/_ViewImports.cshtml"
using FinalProjectWorkspace.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ead8c86163b36c76d51f8386303bebc100801758", @"/Views/Movie/SearchResults.cshtml")]
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
#line 3 "/Users/guy/Documents/School/Year 3/Fall 2020/MIS 333K/Final Project/FinalProject/FinalProjectWorkspace/Views/Movie/SearchResults.cshtml"
   ViewData["Title"] = "Movie Search Results"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h1>Movies</h1>\n\n<div>\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ead8c86163b36c76d51f8386303bebc1008017584040", async() => {
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

<table class=""table"" style=""color:white"">
    <thead>
        <tr>
            <th>
                ");
#nullable restore
#line 27 "/Users/guy/Documents/School/Year 3/Fall 2020/MIS 333K/Final Project/FinalProject/FinalProjectWorkspace/Views/Movie/SearchResults.cshtml"
           Write(Html.DisplayNameFor(model => model.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 30 "/Users/guy/Documents/School/Year 3/Fall 2020/MIS 333K/Final Project/FinalProject/FinalProjectWorkspace/Views/Movie/SearchResults.cshtml"
           Write(Html.DisplayNameFor(model => model.Overview));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 33 "/Users/guy/Documents/School/Year 3/Fall 2020/MIS 333K/Final Project/FinalProject/FinalProjectWorkspace/Views/Movie/SearchResults.cshtml"
           Write(Html.DisplayNameFor(model => model.Tagline));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 36 "/Users/guy/Documents/School/Year 3/Fall 2020/MIS 333K/Final Project/FinalProject/FinalProjectWorkspace/Views/Movie/SearchResults.cshtml"
           Write(Html.DisplayNameFor(model => model.RunTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 39 "/Users/guy/Documents/School/Year 3/Fall 2020/MIS 333K/Final Project/FinalProject/FinalProjectWorkspace/Views/Movie/SearchResults.cshtml"
           Write(Html.DisplayNameFor(model => model.Year));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 42 "/Users/guy/Documents/School/Year 3/Fall 2020/MIS 333K/Final Project/FinalProject/FinalProjectWorkspace/Views/Movie/SearchResults.cshtml"
           Write(Html.DisplayNameFor(model => model.Actors));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 45 "/Users/guy/Documents/School/Year 3/Fall 2020/MIS 333K/Final Project/FinalProject/FinalProjectWorkspace/Views/Movie/SearchResults.cshtml"
           Write(Html.DisplayNameFor(model => model.MPAARating));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 48 "/Users/guy/Documents/School/Year 3/Fall 2020/MIS 333K/Final Project/FinalProject/FinalProjectWorkspace/Views/Movie/SearchResults.cshtml"
           Write(Html.DisplayNameFor(model => model.Genre.GenreName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th></th>\n        </tr>\n    </thead>\n    <tbody>\n");
#nullable restore
#line 54 "/Users/guy/Documents/School/Year 3/Fall 2020/MIS 333K/Final Project/FinalProject/FinalProjectWorkspace/Views/Movie/SearchResults.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\n            <td>\n                ");
#nullable restore
#line 58 "/Users/guy/Documents/School/Year 3/Fall 2020/MIS 333K/Final Project/FinalProject/FinalProjectWorkspace/Views/Movie/SearchResults.cshtml"
           Write(Html.DisplayFor(modelItem => item.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 61 "/Users/guy/Documents/School/Year 3/Fall 2020/MIS 333K/Final Project/FinalProject/FinalProjectWorkspace/Views/Movie/SearchResults.cshtml"
           Write(Html.DisplayFor(modelItem => item.Overview));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 64 "/Users/guy/Documents/School/Year 3/Fall 2020/MIS 333K/Final Project/FinalProject/FinalProjectWorkspace/Views/Movie/SearchResults.cshtml"
           Write(Html.DisplayFor(modelItem => item.Tagline));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 67 "/Users/guy/Documents/School/Year 3/Fall 2020/MIS 333K/Final Project/FinalProject/FinalProjectWorkspace/Views/Movie/SearchResults.cshtml"
           Write(Html.DisplayFor(modelItem => item.RunTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 70 "/Users/guy/Documents/School/Year 3/Fall 2020/MIS 333K/Final Project/FinalProject/FinalProjectWorkspace/Views/Movie/SearchResults.cshtml"
           Write(Html.DisplayFor(modelItem => item.Year));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 73 "/Users/guy/Documents/School/Year 3/Fall 2020/MIS 333K/Final Project/FinalProject/FinalProjectWorkspace/Views/Movie/SearchResults.cshtml"
           Write(Html.DisplayFor(modelItem => item.Actors));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 76 "/Users/guy/Documents/School/Year 3/Fall 2020/MIS 333K/Final Project/FinalProject/FinalProjectWorkspace/Views/Movie/SearchResults.cshtml"
           Write(Html.DisplayFor(modelItem => item.MPAARating));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 79 "/Users/guy/Documents/School/Year 3/Fall 2020/MIS 333K/Final Project/FinalProject/FinalProjectWorkspace/Views/Movie/SearchResults.cshtml"
           Write(Html.DisplayFor(modelItem => item.Genre.GenreName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 82 "/Users/guy/Documents/School/Year 3/Fall 2020/MIS 333K/Final Project/FinalProject/FinalProjectWorkspace/Views/Movie/SearchResults.cshtml"
           Write(Html.ActionLink("Details", "Details", new { id = item.MovieID }, new { Style = "color:white" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n        </tr>\n");
#nullable restore
#line 85 "/Users/guy/Documents/School/Year 3/Fall 2020/MIS 333K/Final Project/FinalProject/FinalProjectWorkspace/Views/Movie/SearchResults.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\n</table>\n\n<div>\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ead8c86163b36c76d51f8386303bebc10080175812680", async() => {
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