#pragma checksum "/Users/slomeli/Desktop/Sophomore Year/First Semester/MIS 333K/Projects/Final Project/FinalProjectWorkspace/FinalProject/FinalProjectWorkspace/Views/Movie/SearchResultsShowing.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f7cef79478f26e31c710ff6ea774d15a6eb3eabb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(FinalProjectWorkspace.Views.Movie.Views_Movie_SearchResultsShowing), @"mvc.1.0.view", @"/Views/Movie/SearchResultsShowing.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f7cef79478f26e31c710ff6ea774d15a6eb3eabb", @"/Views/Movie/SearchResultsShowing.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9daefa0269a9261bb659ce4728f692443d8481bc", @"/Views/_ViewImports.cshtml")]
    public class Views_Movie_SearchResultsShowing : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<FinalProjectWorkspace.Models.Movie>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Browse", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "MovieReview", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "/Users/slomeli/Desktop/Sophomore Year/First Semester/MIS 333K/Projects/Final Project/FinalProjectWorkspace/FinalProject/FinalProjectWorkspace/Views/Movie/SearchResultsShowing.cshtml"
   ViewData["Title"] = "Movie Search Results"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n    <br />\n<h1 class=\"text-center text-danger\">Search Results</h1>\n<hr style=\"height:2px;border-width:0;color:#d0faff;background-color:#d0faff\">\n<br />\n\n<div>\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f7cef79478f26e31c710ff6ea774d15a6eb3eabb5624", async() => {
                WriteLiteral("Back to Search");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n</div>\n<br />\n<div>\n    <p>\n        Displaying ");
#nullable restore
#line 17 "/Users/slomeli/Desktop/Sophomore Year/First Semester/MIS 333K/Projects/Final Project/FinalProjectWorkspace/FinalProject/FinalProjectWorkspace/Views/Movie/SearchResultsShowing.cshtml"
              Write(ViewBag.SelectedMovies);

#line default
#line hidden
#nullable disable
            WriteLiteral(" out of ");
#nullable restore
#line 17 "/Users/slomeli/Desktop/Sophomore Year/First Semester/MIS 333K/Projects/Final Project/FinalProjectWorkspace/FinalProject/FinalProjectWorkspace/Views/Movie/SearchResultsShowing.cshtml"
                                             Write(ViewBag.AllMovies);

#line default
#line hidden
#nullable disable
            WriteLiteral(" All Movies\n    </p>\n</div>\n\n<table class=\"table table-hover text-center\">\n    <thead>\n        <tr class=\"text-light text-center\">\n            <th>\n                ");
#nullable restore
#line 25 "/Users/slomeli/Desktop/Sophomore Year/First Semester/MIS 333K/Projects/Final Project/FinalProjectWorkspace/FinalProject/FinalProjectWorkspace/Views/Movie/SearchResultsShowing.cshtml"
           Write(Html.DisplayNameFor(model => model.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 28 "/Users/slomeli/Desktop/Sophomore Year/First Semester/MIS 333K/Projects/Final Project/FinalProjectWorkspace/FinalProject/FinalProjectWorkspace/Views/Movie/SearchResultsShowing.cshtml"
           Write(Html.DisplayNameFor(model => model.MPAARating));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 31 "/Users/slomeli/Desktop/Sophomore Year/First Semester/MIS 333K/Projects/Final Project/FinalProjectWorkspace/FinalProject/FinalProjectWorkspace/Views/Movie/SearchResultsShowing.cshtml"
           Write(Html.DisplayNameFor(model => model.RunTime));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            </th>
            <th>
                Review Rating
            </th>
            <th>
                See Reviews
            </th>
            <th>
                Selected Show Date
            </th>
            <th>
                Seats Available
            </th>
            <th>
                Movie Details
            </th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 51 "/Users/slomeli/Desktop/Sophomore Year/First Semester/MIS 333K/Projects/Final Project/FinalProjectWorkspace/FinalProject/FinalProjectWorkspace/Views/Movie/SearchResultsShowing.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr class=\"table-secondary text-center text-dark\">\n                <td>\n                    ");
#nullable restore
#line 55 "/Users/slomeli/Desktop/Sophomore Year/First Semester/MIS 333K/Projects/Final Project/FinalProjectWorkspace/FinalProject/FinalProjectWorkspace/Views/Movie/SearchResultsShowing.cshtml"
               Write(Html.DisplayFor(modelItem => item.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </td>\n                <td>\n                    ");
#nullable restore
#line 58 "/Users/slomeli/Desktop/Sophomore Year/First Semester/MIS 333K/Projects/Final Project/FinalProjectWorkspace/FinalProject/FinalProjectWorkspace/Views/Movie/SearchResultsShowing.cshtml"
               Write(Html.DisplayFor(modelItem => item.MPAARating));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </td>\n                <td>\n                    ");
#nullable restore
#line 61 "/Users/slomeli/Desktop/Sophomore Year/First Semester/MIS 333K/Projects/Final Project/FinalProjectWorkspace/FinalProject/FinalProjectWorkspace/Views/Movie/SearchResultsShowing.cshtml"
               Write(Html.DisplayFor(modelItem => item.RunTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </td>\n                <td>\n");
#nullable restore
#line 64 "/Users/slomeli/Desktop/Sophomore Year/First Semester/MIS 333K/Projects/Final Project/FinalProjectWorkspace/FinalProject/FinalProjectWorkspace/Views/Movie/SearchResultsShowing.cshtml"
                      Double? avgReview = item.MovieReviews.Where(r => r.ApprovalStatus == true).Average(m => m.Rating);

#line default
#line hidden
#nullable disable
#nullable restore
#line 65 "/Users/slomeli/Desktop/Sophomore Year/First Semester/MIS 333K/Projects/Final Project/FinalProjectWorkspace/FinalProject/FinalProjectWorkspace/Views/Movie/SearchResultsShowing.cshtml"
                     if (avgReview != null)
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 67 "/Users/slomeli/Desktop/Sophomore Year/First Semester/MIS 333K/Projects/Final Project/FinalProjectWorkspace/FinalProject/FinalProjectWorkspace/Views/Movie/SearchResultsShowing.cshtml"
                   Write(avgReview);

#line default
#line hidden
#nullable disable
#nullable restore
#line 67 "/Users/slomeli/Desktop/Sophomore Year/First Semester/MIS 333K/Projects/Final Project/FinalProjectWorkspace/FinalProject/FinalProjectWorkspace/Views/Movie/SearchResultsShowing.cshtml"
                                  
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        ");
            WriteLiteral("0\n");
#nullable restore
#line 72 "/Users/slomeli/Desktop/Sophomore Year/First Semester/MIS 333K/Projects/Final Project/FinalProjectWorkspace/FinalProject/FinalProjectWorkspace/Views/Movie/SearchResultsShowing.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </td>\n                <td>\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f7cef79478f26e31c710ff6ea774d15a6eb3eabb12853", async() => {
                WriteLiteral("Reviews");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-movieid", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 76 "/Users/slomeli/Desktop/Sophomore Year/First Semester/MIS 333K/Projects/Final Project/FinalProjectWorkspace/FinalProject/FinalProjectWorkspace/Views/Movie/SearchResultsShowing.cshtml"
                                                                              WriteLiteral(item.MovieID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["movieid"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-movieid", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["movieid"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                </td>\n                <td>\n");
#nullable restore
#line 79 "/Users/slomeli/Desktop/Sophomore Year/First Semester/MIS 333K/Projects/Final Project/FinalProjectWorkspace/FinalProject/FinalProjectWorkspace/Views/Movie/SearchResultsShowing.cshtml"
                       Int32 showingCount = 0;

#line default
#line hidden
#nullable disable
#nullable restore
#line 80 "/Users/slomeli/Desktop/Sophomore Year/First Semester/MIS 333K/Projects/Final Project/FinalProjectWorkspace/FinalProject/FinalProjectWorkspace/Views/Movie/SearchResultsShowing.cshtml"
                     if (!item.Showings.Any())
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        ");
            WriteLiteral("None Upcoming!\n");
#nullable restore
#line 83 "/Users/slomeli/Desktop/Sophomore Year/First Semester/MIS 333K/Projects/Final Project/FinalProjectWorkspace/FinalProject/FinalProjectWorkspace/Views/Movie/SearchResultsShowing.cshtml"
                    }
                    else
                    {
                        if (ViewBag.showingDate != null)
                        {
                            foreach (var showing in item.Showings)
                            {
                                if (showing.ShowingDate == ViewBag.showingDate)
                                {
                                    showingCount = 1;
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 93 "/Users/slomeli/Desktop/Sophomore Year/First Semester/MIS 333K/Projects/Final Project/FinalProjectWorkspace/FinalProject/FinalProjectWorkspace/Views/Movie/SearchResultsShowing.cshtml"
                               Write(Html.DisplayFor(modelShowing => showing.ShowingDate));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
            WriteLiteral("at ");
#nullable restore
#line 93 "/Users/slomeli/Desktop/Sophomore Year/First Semester/MIS 333K/Projects/Final Project/FinalProjectWorkspace/FinalProject/FinalProjectWorkspace/Views/Movie/SearchResultsShowing.cshtml"
                                                                                          Write(Html.DisplayFor(modelShowing => showing.StartTime));

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\n");
#nullable restore
#line 94 "/Users/slomeli/Desktop/Sophomore Year/First Semester/MIS 333K/Projects/Final Project/FinalProjectWorkspace/FinalProject/FinalProjectWorkspace/Views/Movie/SearchResultsShowing.cshtml"
                                }
                            }
                        }
                        else
                        {
                            Int32 blankCount = 0;
                            Int32 totalCount = 0;
                            Int32 unpublishedCount = 0;
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 102 "/Users/slomeli/Desktop/Sophomore Year/First Semester/MIS 333K/Projects/Final Project/FinalProjectWorkspace/FinalProject/FinalProjectWorkspace/Views/Movie/SearchResultsShowing.cshtml"
                             foreach (var showing in item.Showings)
                            {
                                totalCount += 1;
                                DateTime showingTime = new DateTime(showing.StartTime.Year, showing.StartTime.Month, showing.StartTime.Day,
                                    showing.StartTime.Hour, showing.StartTime.Minute, showing.StartTime.Millisecond);
                                if (DateTime.Now < showingTime && showing.Status == "Published")
                                {
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 109 "/Users/slomeli/Desktop/Sophomore Year/First Semester/MIS 333K/Projects/Final Project/FinalProjectWorkspace/FinalProject/FinalProjectWorkspace/Views/Movie/SearchResultsShowing.cshtml"
                               Write(Html.DisplayFor(modelShowing => showing.ShowingDate));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
            WriteLiteral("at ");
#nullable restore
#line 109 "/Users/slomeli/Desktop/Sophomore Year/First Semester/MIS 333K/Projects/Final Project/FinalProjectWorkspace/FinalProject/FinalProjectWorkspace/Views/Movie/SearchResultsShowing.cshtml"
                                                                                          Write(Html.DisplayFor(modelShowing => showing.StartTime));

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\n                                    <br />\n");
#nullable restore
#line 111 "/Users/slomeli/Desktop/Sophomore Year/First Semester/MIS 333K/Projects/Final Project/FinalProjectWorkspace/FinalProject/FinalProjectWorkspace/Views/Movie/SearchResultsShowing.cshtml"

                                }
                                else
                                {
                                    blankCount += 1;
                                    if (showing.Status == "Unpublished")
                                    {
                                        unpublishedCount += 1;
                                    }
                                }
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 121 "/Users/slomeli/Desktop/Sophomore Year/First Semester/MIS 333K/Projects/Final Project/FinalProjectWorkspace/FinalProject/FinalProjectWorkspace/Views/Movie/SearchResultsShowing.cshtml"
                             
                            if (blankCount == totalCount)
                            {
                                if (unpublishedCount >= 1)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    ");
            WriteLiteral("Coming soon!\n");
#nullable restore
#line 127 "/Users/slomeli/Desktop/Sophomore Year/First Semester/MIS 333K/Projects/Final Project/FinalProjectWorkspace/FinalProject/FinalProjectWorkspace/Views/Movie/SearchResultsShowing.cshtml"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    ");
            WriteLiteral("None Upcoming\n");
#nullable restore
#line 131 "/Users/slomeli/Desktop/Sophomore Year/First Semester/MIS 333K/Projects/Final Project/FinalProjectWorkspace/FinalProject/FinalProjectWorkspace/Views/Movie/SearchResultsShowing.cshtml"

                                }
                            }
                        }
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </td>\n");
#nullable restore
#line 137 "/Users/slomeli/Desktop/Sophomore Year/First Semester/MIS 333K/Projects/Final Project/FinalProjectWorkspace/FinalProject/FinalProjectWorkspace/Views/Movie/SearchResultsShowing.cshtml"
                 if (showingCount == 1)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td>\n");
#nullable restore
#line 140 "/Users/slomeli/Desktop/Sophomore Year/First Semester/MIS 333K/Projects/Final Project/FinalProjectWorkspace/FinalProject/FinalProjectWorkspace/Views/Movie/SearchResultsShowing.cshtml"
                          Int32 seatCount = 0;

#line default
#line hidden
#nullable disable
#nullable restore
#line 141 "/Users/slomeli/Desktop/Sophomore Year/First Semester/MIS 333K/Projects/Final Project/FinalProjectWorkspace/FinalProject/FinalProjectWorkspace/Views/Movie/SearchResultsShowing.cshtml"
                         foreach (var showing in item.Showings)
                        {
                            if (showing.SeatsAvailable != null)
                            {
                                seatCount = showing.SeatsAvailable.Count();
                            }
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 148 "/Users/slomeli/Desktop/Sophomore Year/First Semester/MIS 333K/Projects/Final Project/FinalProjectWorkspace/FinalProject/FinalProjectWorkspace/Views/Movie/SearchResultsShowing.cshtml"
                         if (seatCount != 0)
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 150 "/Users/slomeli/Desktop/Sophomore Year/First Semester/MIS 333K/Projects/Final Project/FinalProjectWorkspace/FinalProject/FinalProjectWorkspace/Views/Movie/SearchResultsShowing.cshtml"
                       Write(seatCount);

#line default
#line hidden
#nullable disable
#nullable restore
#line 150 "/Users/slomeli/Desktop/Sophomore Year/First Semester/MIS 333K/Projects/Final Project/FinalProjectWorkspace/FinalProject/FinalProjectWorkspace/Views/Movie/SearchResultsShowing.cshtml"
                                      
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </td>\n");
#nullable restore
#line 153 "/Users/slomeli/Desktop/Sophomore Year/First Semester/MIS 333K/Projects/Final Project/FinalProjectWorkspace/FinalProject/FinalProjectWorkspace/Views/Movie/SearchResultsShowing.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td></td>\n");
#nullable restore
#line 157 "/Users/slomeli/Desktop/Sophomore Year/First Semester/MIS 333K/Projects/Final Project/FinalProjectWorkspace/FinalProject/FinalProjectWorkspace/Views/Movie/SearchResultsShowing.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                <td>\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f7cef79478f26e31c710ff6ea774d15a6eb3eabb25271", async() => {
                WriteLiteral("View");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 159 "/Users/slomeli/Desktop/Sophomore Year/First Semester/MIS 333K/Projects/Final Project/FinalProjectWorkspace/FinalProject/FinalProjectWorkspace/Views/Movie/SearchResultsShowing.cshtml"
                                              WriteLiteral(item.MovieID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                </td>\n            </tr>\n");
#nullable restore
#line 162 "/Users/slomeli/Desktop/Sophomore Year/First Semester/MIS 333K/Projects/Final Project/FinalProjectWorkspace/FinalProject/FinalProjectWorkspace/Views/Movie/SearchResultsShowing.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\n</table>\n\n<div class=\"text-center\">\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f7cef79478f26e31c710ff6ea774d15a6eb3eabb27982", async() => {
                WriteLiteral("Back to Search");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
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
