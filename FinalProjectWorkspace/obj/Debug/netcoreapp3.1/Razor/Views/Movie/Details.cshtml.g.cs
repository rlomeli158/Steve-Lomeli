#pragma checksum "/Users/slomeli/Desktop/Sophomore Year/First Semester/MIS 333K/Projects/Final Project/FinalProjectWorkspace/FinalProject/FinalProjectWorkspace/Views/Movie/Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4d5918bab4d1a4cf186744bc5b483691b4cd66b4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(FinalProjectWorkspace.Views.Movie.Views_Movie_Details), @"mvc.1.0.view", @"/Views/Movie/Details.cshtml")]
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
#line 2 "/Users/slomeli/Desktop/Sophomore Year/First Semester/MIS 333K/Projects/Final Project/FinalProjectWorkspace/FinalProject/FinalProjectWorkspace/Views/_ViewImports.cshtml"
using FinalProjectWorkspace.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4d5918bab4d1a4cf186744bc5b483691b4cd66b4", @"/Views/Movie/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9daefa0269a9261bb659ce4728f692443d8481bc", @"/Views/_ViewImports.cshtml")]
    public class Views_Movie_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FinalProjectWorkspace.Models.Movie>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("color:white"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\n");
#nullable restore
#line 3 "/Users/slomeli/Desktop/Sophomore Year/First Semester/MIS 333K/Projects/Final Project/FinalProjectWorkspace/FinalProject/FinalProjectWorkspace/Views/Movie/Details.cshtml"
   ViewData["Title"] = "Details"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<p></p>\n<h3>\n    ");
#nullable restore
#line 7 "/Users/slomeli/Desktop/Sophomore Year/First Semester/MIS 333K/Projects/Final Project/FinalProjectWorkspace/FinalProject/FinalProjectWorkspace/Views/Movie/Details.cshtml"
Write(Html.DisplayFor(model => model.Tagline));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n</h3>\n\n<div class=\"list-group\">\n    <a class=\"list-group-item list-group-item-action flex-column align-items-start\">\n        <div class=\"d-flex w-100 justify-content-between\">\n            <h5 class=\"mb-1\">\n                ");
#nullable restore
#line 14 "/Users/slomeli/Desktop/Sophomore Year/First Semester/MIS 333K/Projects/Final Project/FinalProjectWorkspace/FinalProject/FinalProjectWorkspace/Views/Movie/Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </h5>\n            <small class=\"text-muted\">\n                Released in ");
#nullable restore
#line 17 "/Users/slomeli/Desktop/Sophomore Year/First Semester/MIS 333K/Projects/Final Project/FinalProjectWorkspace/FinalProject/FinalProjectWorkspace/Views/Movie/Details.cshtml"
                       Write(Html.DisplayFor(model => model.Year));

#line default
#line hidden
#nullable disable
            WriteLiteral(". Run Time: ");
#nullable restore
#line 17 "/Users/slomeli/Desktop/Sophomore Year/First Semester/MIS 333K/Projects/Final Project/FinalProjectWorkspace/FinalProject/FinalProjectWorkspace/Views/Movie/Details.cshtml"
                                                                        Write(Html.DisplayFor(model => model.RunTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </small>\n        </div>\n        <p class=\"mb-1\">\n            ");
#nullable restore
#line 21 "/Users/slomeli/Desktop/Sophomore Year/First Semester/MIS 333K/Projects/Final Project/FinalProjectWorkspace/FinalProject/FinalProjectWorkspace/Views/Movie/Details.cshtml"
       Write(Html.DisplayFor(model => model.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </p>\n    </a>\n    <a class=\"list-group-item list-group-item-action flex-column align-items-start\">\n        <div class=\"d-flex w-100 justify-content-between\">\n            <h5 class=\"mb-1\">\n                ");
#nullable restore
#line 27 "/Users/slomeli/Desktop/Sophomore Year/First Semester/MIS 333K/Projects/Final Project/FinalProjectWorkspace/FinalProject/FinalProjectWorkspace/Views/Movie/Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Overview));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </h5>\n        </div>\n        <p class=\"mb-1\">\n            ");
#nullable restore
#line 31 "/Users/slomeli/Desktop/Sophomore Year/First Semester/MIS 333K/Projects/Final Project/FinalProjectWorkspace/FinalProject/FinalProjectWorkspace/Views/Movie/Details.cshtml"
       Write(Html.DisplayFor(model => model.Overview));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </p>\n    </a>\n    <a class=\"list-group-item list-group-item-action flex-column align-items-start\">\n        <div class=\"d-flex w-100 justify-content-between\">\n            <h5 class=\"mb-1\">\n                ");
#nullable restore
#line 37 "/Users/slomeli/Desktop/Sophomore Year/First Semester/MIS 333K/Projects/Final Project/FinalProjectWorkspace/FinalProject/FinalProjectWorkspace/Views/Movie/Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Actors));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </h5>\n        </div>\n        <p class=\"mb-1\">\n            ");
#nullable restore
#line 41 "/Users/slomeli/Desktop/Sophomore Year/First Semester/MIS 333K/Projects/Final Project/FinalProjectWorkspace/FinalProject/FinalProjectWorkspace/Views/Movie/Details.cshtml"
       Write(Html.DisplayFor(model => model.Actors));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </p>\n    </a>\n    <a class=\"list-group-item list-group-item-action flex-column align-items-start\">\n        <div class=\"d-flex w-100 justify-content-between\">\n            <h5 class=\"mb-1\">\n                ");
#nullable restore
#line 47 "/Users/slomeli/Desktop/Sophomore Year/First Semester/MIS 333K/Projects/Final Project/FinalProjectWorkspace/FinalProject/FinalProjectWorkspace/Views/Movie/Details.cshtml"
           Write(Html.DisplayNameFor(model => model.MPAARating));

#line default
#line hidden
#nullable disable
            WriteLiteral(" & ");
#nullable restore
#line 47 "/Users/slomeli/Desktop/Sophomore Year/First Semester/MIS 333K/Projects/Final Project/FinalProjectWorkspace/FinalProject/FinalProjectWorkspace/Views/Movie/Details.cshtml"
                                                             Write(Html.DisplayNameFor(model => model.Genre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </h5>\n        </div>\n        <p class=\"mb-1\">\n            ");
#nullable restore
#line 51 "/Users/slomeli/Desktop/Sophomore Year/First Semester/MIS 333K/Projects/Final Project/FinalProjectWorkspace/FinalProject/FinalProjectWorkspace/Views/Movie/Details.cshtml"
       Write(Html.DisplayFor(model => model.MPAARating));

#line default
#line hidden
#nullable disable
            WriteLiteral(" and\n            ");
#nullable restore
#line 52 "/Users/slomeli/Desktop/Sophomore Year/First Semester/MIS 333K/Projects/Final Project/FinalProjectWorkspace/FinalProject/FinalProjectWorkspace/Views/Movie/Details.cshtml"
       Write(Html.DisplayFor(model => model.Genre.GenreName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </p>\n    </a>\n    <a class=\"list-group-item list-group-item-action flex-column align-items-start\">\n        <div class=\"d-flex w-100 justify-content-between\">\n            <h5 class=\"mb-1\">\n                ");
#nullable restore
#line 58 "/Users/slomeli/Desktop/Sophomore Year/First Semester/MIS 333K/Projects/Final Project/FinalProjectWorkspace/FinalProject/FinalProjectWorkspace/Views/Movie/Details.cshtml"
           Write(Html.DisplayNameFor(model => model.AverageReviewRating));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </h5>\n        </div>\n        <p class=\"mb-1\">\n            ");
#nullable restore
#line 62 "/Users/slomeli/Desktop/Sophomore Year/First Semester/MIS 333K/Projects/Final Project/FinalProjectWorkspace/FinalProject/FinalProjectWorkspace/Views/Movie/Details.cshtml"
       Write(Html.DisplayFor(model => model.AverageReviewRating));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </p>\n    </a>\n</div>\n\n<table class=\"table table-hover text-center\">\n    <tr class=\"text-light text-center\">\n        <th>Showing Date</th>\n        <th>Start Time</th>\n        <th>End Time</th>\n        <th>Theatre</th>\n    </tr>\n");
#nullable restore
#line 74 "/Users/slomeli/Desktop/Sophomore Year/First Semester/MIS 333K/Projects/Final Project/FinalProjectWorkspace/FinalProject/FinalProjectWorkspace/Views/Movie/Details.cshtml"
     foreach (Showing p in Model.Showings)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("<tr class=\"table-secondary text-center text-dark\">\n    <td>");
#nullable restore
#line 77 "/Users/slomeli/Desktop/Sophomore Year/First Semester/MIS 333K/Projects/Final Project/FinalProjectWorkspace/FinalProject/FinalProjectWorkspace/Views/Movie/Details.cshtml"
   Write(Html.DisplayFor(modelItem => p.ShowingDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n    <td>");
#nullable restore
#line 78 "/Users/slomeli/Desktop/Sophomore Year/First Semester/MIS 333K/Projects/Final Project/FinalProjectWorkspace/FinalProject/FinalProjectWorkspace/Views/Movie/Details.cshtml"
   Write(Html.DisplayFor(modelItem => p.StartTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n    <td>");
#nullable restore
#line 79 "/Users/slomeli/Desktop/Sophomore Year/First Semester/MIS 333K/Projects/Final Project/FinalProjectWorkspace/FinalProject/FinalProjectWorkspace/Views/Movie/Details.cshtml"
   Write(Html.DisplayFor(modelItem => p.EndTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n    <td>");
#nullable restore
#line 80 "/Users/slomeli/Desktop/Sophomore Year/First Semester/MIS 333K/Projects/Final Project/FinalProjectWorkspace/FinalProject/FinalProjectWorkspace/Views/Movie/Details.cshtml"
   Write(Html.DisplayFor(modelItem => p.Theatre));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n</tr>");
#nullable restore
#line 81 "/Users/slomeli/Desktop/Sophomore Year/First Semester/MIS 333K/Projects/Final Project/FinalProjectWorkspace/FinalProject/FinalProjectWorkspace/Views/Movie/Details.cshtml"
     }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\n<div>\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4d5918bab4d1a4cf186744bc5b483691b4cd66b413468", async() => {
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
#line 84 "/Users/slomeli/Desktop/Sophomore Year/First Semester/MIS 333K/Projects/Final Project/FinalProjectWorkspace/FinalProject/FinalProjectWorkspace/Views/Movie/Details.cshtml"
                           WriteLiteral(Model.MovieID);

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
            WriteLiteral(" |\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4d5918bab4d1a4cf186744bc5b483691b4cd66b415754", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
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
