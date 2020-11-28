#pragma checksum "/Users/jennifertruong/Documents/GitHub/FinalProject/FinalProjectWorkspace/Views/Ticket/ReportSearchResults.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "de2ba60ce1732bb2dac6e2971464482c76ae0e5a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(FinalProjectWorkspace.Views.Ticket.Views_Ticket_ReportSearchResults), @"mvc.1.0.view", @"/Views/Ticket/ReportSearchResults.cshtml")]
namespace FinalProjectWorkspace.Views.Ticket
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"de2ba60ce1732bb2dac6e2971464482c76ae0e5a", @"/Views/Ticket/ReportSearchResults.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3077373090091c5850da6e8c6a3970a3b8885491", @"/Views/_ViewImports.cshtml")]
    public class Views_Ticket_ReportSearchResults : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FinalProjectWorkspace.Models.ReportViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ReportIndex", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Transactions", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "/Users/jennifertruong/Documents/GitHub/FinalProject/FinalProjectWorkspace/Views/Ticket/ReportSearchResults.cshtml"
   ViewData["Title"] = "Revenue Report"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    <br />\n<h1 class=\"text-center text-danger\">Report</h1>\n<hr style=\"height:2px;border-width:0;color:#d0faff;background-color:#d0faff\">\n<br />\n\n<div>\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "de2ba60ce1732bb2dac6e2971464482c76ae0e5a4808", async() => {
                WriteLiteral("Back to Reports");
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
            WriteLiteral("\n</div>\n<br />\n");
#nullable restore
#line 14 "/Users/jennifertruong/Documents/GitHub/FinalProject/FinalProjectWorkspace/Views/Ticket/ReportSearchResults.cshtml"
 if (Model.TotalRevenue != 0 || Model.TotalSeatsSold != 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h3>Revenue Report</h3>\n    <br />\n    <table class=\"table table-hover text-center\">\n        <thead>\n            <tr class=\"table-primary text-center\">\n");
#nullable restore
#line 21 "/Users/jennifertruong/Documents/GitHub/FinalProject/FinalProjectWorkspace/Views/Ticket/ReportSearchResults.cshtml"
                 if (Model.TotalRevenue != 0)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <th>\n                        ");
#nullable restore
#line 24 "/Users/jennifertruong/Documents/GitHub/FinalProject/FinalProjectWorkspace/Views/Ticket/ReportSearchResults.cshtml"
                   Write(Html.DisplayNameFor(model => model.TotalRevenue));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </th>\n");
#nullable restore
#line 26 "/Users/jennifertruong/Documents/GitHub/FinalProject/FinalProjectWorkspace/Views/Ticket/ReportSearchResults.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "/Users/jennifertruong/Documents/GitHub/FinalProject/FinalProjectWorkspace/Views/Ticket/ReportSearchResults.cshtml"
                 if (Model.TotalSeatsSold != 0)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <th>\n                        ");
#nullable restore
#line 30 "/Users/jennifertruong/Documents/GitHub/FinalProject/FinalProjectWorkspace/Views/Ticket/ReportSearchResults.cshtml"
                   Write(Html.DisplayNameFor(model => model.TotalSeatsSold));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </th>\n");
#nullable restore
#line 32 "/Users/jennifertruong/Documents/GitHub/FinalProject/FinalProjectWorkspace/Views/Ticket/ReportSearchResults.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </tr>\n        </thead>\n        <tbody>\n            <tr class=\"table-secondary text-center text-dark\">\n");
#nullable restore
#line 38 "/Users/jennifertruong/Documents/GitHub/FinalProject/FinalProjectWorkspace/Views/Ticket/ReportSearchResults.cshtml"
                 if (Model.TotalRevenue != 0)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td>\n                        ");
#nullable restore
#line 41 "/Users/jennifertruong/Documents/GitHub/FinalProject/FinalProjectWorkspace/Views/Ticket/ReportSearchResults.cshtml"
                   Write(Html.DisplayFor(model => model.TotalRevenue));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </td>\n");
#nullable restore
#line 43 "/Users/jennifertruong/Documents/GitHub/FinalProject/FinalProjectWorkspace/Views/Ticket/ReportSearchResults.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 44 "/Users/jennifertruong/Documents/GitHub/FinalProject/FinalProjectWorkspace/Views/Ticket/ReportSearchResults.cshtml"
                 if (Model.TotalSeatsSold != 0)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td>\n                        ");
#nullable restore
#line 47 "/Users/jennifertruong/Documents/GitHub/FinalProject/FinalProjectWorkspace/Views/Ticket/ReportSearchResults.cshtml"
                   Write(Html.DisplayFor(model => model.TotalSeatsSold));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </td>\n");
#nullable restore
#line 49 "/Users/jennifertruong/Documents/GitHub/FinalProject/FinalProjectWorkspace/Views/Ticket/ReportSearchResults.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </tr>\n        </tbody>\n    </table>\n");
#nullable restore
#line 54 "/Users/jennifertruong/Documents/GitHub/FinalProject/FinalProjectWorkspace/Views/Ticket/ReportSearchResults.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n\n\n");
#nullable restore
#line 59 "/Users/jennifertruong/Documents/GitHub/FinalProject/FinalProjectWorkspace/Views/Ticket/ReportSearchResults.cshtml"
 if (Model.AppUsers != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h3>Customer Report</h3>\n    <br />\n    <table class=\"table table-hover text-center\">\n        <thead>\n            <tr class=\"table-primary text-center\">\n                <th>\n                    ");
#nullable restore
#line 67 "/Users/jennifertruong/Documents/GitHub/FinalProject/FinalProjectWorkspace/Views/Ticket/ReportSearchResults.cshtml"
               Write(Html.DisplayNameFor(model => Model.AppUsers));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </th>\n                <th>\n                    ");
#nullable restore
#line 70 "/Users/jennifertruong/Documents/GitHub/FinalProject/FinalProjectWorkspace/Views/Ticket/ReportSearchResults.cshtml"
               Write(Html.DisplayNameFor(model => model.TotalRevenue));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </th>\n                <th>\n                    ");
#nullable restore
#line 73 "/Users/jennifertruong/Documents/GitHub/FinalProject/FinalProjectWorkspace/Views/Ticket/ReportSearchResults.cshtml"
               Write(Html.DisplayNameFor(model => model.TotalSeatsSold));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </th>\n                <th>\n                    Transactions\n                </th>\n            </tr>\n        </thead>\n        <tbody>\n");
#nullable restore
#line 81 "/Users/jennifertruong/Documents/GitHub/FinalProject/FinalProjectWorkspace/Views/Ticket/ReportSearchResults.cshtml"
             foreach (var item in Model.AppUsers)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr class=\"table-secondary text-center text-dark\">\n                    <td>\n                        ");
#nullable restore
#line 85 "/Users/jennifertruong/Documents/GitHub/FinalProject/FinalProjectWorkspace/Views/Ticket/ReportSearchResults.cshtml"
                   Write(Html.DisplayFor(modelItem => item.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 85 "/Users/jennifertruong/Documents/GitHub/FinalProject/FinalProjectWorkspace/Views/Ticket/ReportSearchResults.cshtml"
                                                                 Write(Html.DisplayFor(modelItem => item.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </td>\n                    <td>\n");
#nullable restore
#line 88 "/Users/jennifertruong/Documents/GitHub/FinalProject/FinalProjectWorkspace/Views/Ticket/ReportSearchResults.cshtml"
                          Decimal totalRevenue = item.OrdersPurchased.DefaultIfEmpty().Sum(item => item.OrderSubtotal);

#line default
#line hidden
#nullable disable
            WriteLiteral("                        ");
#nullable restore
#line 89 "/Users/jennifertruong/Documents/GitHub/FinalProject/FinalProjectWorkspace/Views/Ticket/ReportSearchResults.cshtml"
                   Write(totalRevenue);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </td>\n                    <td>\n");
#nullable restore
#line 92 "/Users/jennifertruong/Documents/GitHub/FinalProject/FinalProjectWorkspace/Views/Ticket/ReportSearchResults.cshtml"
                          Int32 totalSeats = item.OrdersPurchased.DefaultIfEmpty().Sum(item => item.Tickets.Count());

#line default
#line hidden
#nullable disable
            WriteLiteral("                        ");
#nullable restore
#line 93 "/Users/jennifertruong/Documents/GitHub/FinalProject/FinalProjectWorkspace/Views/Ticket/ReportSearchResults.cshtml"
                   Write(totalSeats);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </td>\n                    <td>\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "de2ba60ce1732bb2dac6e2971464482c76ae0e5a14498", async() => {
                WriteLiteral("Transactions");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 96 "/Users/jennifertruong/Documents/GitHub/FinalProject/FinalProjectWorkspace/Views/Ticket/ReportSearchResults.cshtml"
                                                                                       WriteLiteral(item.Id);

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
            WriteLiteral("\n                    </td>\n                </tr>\n");
#nullable restore
#line 99 "/Users/jennifertruong/Documents/GitHub/FinalProject/FinalProjectWorkspace/Views/Ticket/ReportSearchResults.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\n    </table>\n");
#nullable restore
#line 102 "/Users/jennifertruong/Documents/GitHub/FinalProject/FinalProjectWorkspace/Views/Ticket/ReportSearchResults.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
#nullable restore
#line 104 "/Users/jennifertruong/Documents/GitHub/FinalProject/FinalProjectWorkspace/Views/Ticket/ReportSearchResults.cshtml"
 if (Model.PopcornPointTickets != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h3>Popcorn Points Report</h3>\n    <br />\n");
            WriteLiteral(@"    <table class=""table table-hover text-center"">
        <thead>
            <tr class=""table-primary text-center"">
                <th>
                    Customer
                </th>
                <th>
                    Movie Title
                </th>
                <th>
                    Movie Date
                </th>
                <th>
                    Order Date
                </th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 127 "/Users/jennifertruong/Documents/GitHub/FinalProject/FinalProjectWorkspace/Views/Ticket/ReportSearchResults.cshtml"
             foreach (var item in Model.PopcornPointTickets)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr class=\"table-secondary text-center text-dark\">\n                    <td>\n                        ");
#nullable restore
#line 131 "/Users/jennifertruong/Documents/GitHub/FinalProject/FinalProjectWorkspace/Views/Ticket/ReportSearchResults.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Order.Purchaser.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 131 "/Users/jennifertruong/Documents/GitHub/FinalProject/FinalProjectWorkspace/Views/Ticket/ReportSearchResults.cshtml"
                                                                                 Write(Html.DisplayFor(modelItem => item.Order.Purchaser.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </td>\n                    <td>\n                        ");
#nullable restore
#line 134 "/Users/jennifertruong/Documents/GitHub/FinalProject/FinalProjectWorkspace/Views/Ticket/ReportSearchResults.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Showing.Movie.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </td>\n                    <td>\n                        ");
#nullable restore
#line 137 "/Users/jennifertruong/Documents/GitHub/FinalProject/FinalProjectWorkspace/Views/Ticket/ReportSearchResults.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Showing.ShowingDate));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 137 "/Users/jennifertruong/Documents/GitHub/FinalProject/FinalProjectWorkspace/Views/Ticket/ReportSearchResults.cshtml"
                                                                           Write(Html.DisplayFor(modelItem => item.Showing.StartTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </td>\n\n                    <td>\n                        ");
#nullable restore
#line 141 "/Users/jennifertruong/Documents/GitHub/FinalProject/FinalProjectWorkspace/Views/Ticket/ReportSearchResults.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Order.OrderDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </td>\n                </tr>\n");
#nullable restore
#line 144 "/Users/jennifertruong/Documents/GitHub/FinalProject/FinalProjectWorkspace/Views/Ticket/ReportSearchResults.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\n    </table>\n");
#nullable restore
#line 147 "/Users/jennifertruong/Documents/GitHub/FinalProject/FinalProjectWorkspace/Views/Ticket/ReportSearchResults.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FinalProjectWorkspace.Models.ReportViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
