#pragma checksum "/Users/audreyhsien/Desktop/Fall2020/MIS333K/KILLER K Final Project/GitHub/FinalProject/FinalProjectWorkspace/Views/Ticket/Transactions.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5aab602d79ebde0a82893daf0340262fe7ee2487"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(FinalProjectWorkspace.Views.Ticket.Views_Ticket_Transactions), @"mvc.1.0.view", @"/Views/Ticket/Transactions.cshtml")]
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
#line 2 "/Users/audreyhsien/Desktop/Fall2020/MIS333K/KILLER K Final Project/GitHub/FinalProject/FinalProjectWorkspace/Views/_ViewImports.cshtml"
using FinalProjectWorkspace.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5aab602d79ebde0a82893daf0340262fe7ee2487", @"/Views/Ticket/Transactions.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3077373090091c5850da6e8c6a3970a3b8885491", @"/Views/_ViewImports.cshtml")]
    public class Views_Ticket_Transactions : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<FinalProjectWorkspace.Models.Order>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "/Users/audreyhsien/Desktop/Fall2020/MIS333K/KILLER K Final Project/GitHub/FinalProject/FinalProjectWorkspace/Views/Ticket/Transactions.cshtml"
  
    ViewData["Title"] = "Transactions";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h1>Transactions</h1>\n\n<table class=\"table table-hover text-center\">\n    <thead>\n        <tr class=\"table-primary text-center\">\n            <th>\n                ");
#nullable restore
#line 13 "/Users/audreyhsien/Desktop/Fall2020/MIS333K/KILLER K Final Project/GitHub/FinalProject/FinalProjectWorkspace/Views/Ticket/Transactions.cshtml"
           Write(Html.DisplayNameFor(model => model.TransactionNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                Movie Title(s)\n            </th>\n            <th>\n                ");
#nullable restore
#line 19 "/Users/audreyhsien/Desktop/Fall2020/MIS333K/KILLER K Final Project/GitHub/FinalProject/FinalProjectWorkspace/Views/Ticket/Transactions.cshtml"
           Write(Html.DisplayNameFor(model => model.OrderDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 22 "/Users/audreyhsien/Desktop/Fall2020/MIS333K/KILLER K Final Project/GitHub/FinalProject/FinalProjectWorkspace/Views/Ticket/Transactions.cshtml"
           Write(Html.DisplayNameFor(model => model.OrderTotal));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 25 "/Users/audreyhsien/Desktop/Fall2020/MIS333K/KILLER K Final Project/GitHub/FinalProject/FinalProjectWorkspace/Views/Ticket/Transactions.cshtml"
           Write(Html.DisplayNameFor(model => model.OrderStatus));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                Seats Sold\n            </th>\n            <th>\n                ");
#nullable restore
#line 31 "/Users/audreyhsien/Desktop/Fall2020/MIS333K/KILLER K Final Project/GitHub/FinalProject/FinalProjectWorkspace/Views/Ticket/Transactions.cshtml"
           Write(Html.DisplayNameFor(model => model.PaidWithPopcornPoints));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n        </tr>\n    </thead>\n    <tbody>\n");
#nullable restore
#line 36 "/Users/audreyhsien/Desktop/Fall2020/MIS333K/KILLER K Final Project/GitHub/FinalProject/FinalProjectWorkspace/Views/Ticket/Transactions.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr class=\"table-secondary text-center text-dark\">\n            <td>\n                ");
#nullable restore
#line 40 "/Users/audreyhsien/Desktop/Fall2020/MIS333K/KILLER K Final Project/GitHub/FinalProject/FinalProjectWorkspace/Views/Ticket/Transactions.cshtml"
           Write(Html.DisplayFor(modelItem => item.TransactionNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n");
#nullable restore
#line 43 "/Users/audreyhsien/Desktop/Fall2020/MIS333K/KILLER K Final Project/GitHub/FinalProject/FinalProjectWorkspace/Views/Ticket/Transactions.cshtml"
                  List<string> moviesWatched = new List<string>(); 

#line default
#line hidden
#nullable disable
#nullable restore
#line 44 "/Users/audreyhsien/Desktop/Fall2020/MIS333K/KILLER K Final Project/GitHub/FinalProject/FinalProjectWorkspace/Views/Ticket/Transactions.cshtml"
                 foreach (var showing in item.Tickets)
                {
                    if (!moviesWatched.Contains(showing.Showing.Movie.Title))
                    {
                        moviesWatched.Add(showing.Showing.Movie.Title);
                    }
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 51 "/Users/audreyhsien/Desktop/Fall2020/MIS333K/KILLER K Final Project/GitHub/FinalProject/FinalProjectWorkspace/Views/Ticket/Transactions.cshtml"
                 foreach (string movie in moviesWatched)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 53 "/Users/audreyhsien/Desktop/Fall2020/MIS333K/KILLER K Final Project/GitHub/FinalProject/FinalProjectWorkspace/Views/Ticket/Transactions.cshtml"
               Write(movie);

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <br />\n");
#nullable restore
#line 55 "/Users/audreyhsien/Desktop/Fall2020/MIS333K/KILLER K Final Project/GitHub/FinalProject/FinalProjectWorkspace/Views/Ticket/Transactions.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </td>\n            <td>\n                ");
#nullable restore
#line 58 "/Users/audreyhsien/Desktop/Fall2020/MIS333K/KILLER K Final Project/GitHub/FinalProject/FinalProjectWorkspace/Views/Ticket/Transactions.cshtml"
           Write(Html.DisplayFor(modelItem => item.OrderDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 61 "/Users/audreyhsien/Desktop/Fall2020/MIS333K/KILLER K Final Project/GitHub/FinalProject/FinalProjectWorkspace/Views/Ticket/Transactions.cshtml"
           Write(Html.DisplayFor(modelItem => item.OrderTotal));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 64 "/Users/audreyhsien/Desktop/Fall2020/MIS333K/KILLER K Final Project/GitHub/FinalProject/FinalProjectWorkspace/Views/Ticket/Transactions.cshtml"
           Write(Html.DisplayFor(modelItem => item.OrderStatus));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n");
#nullable restore
#line 67 "/Users/audreyhsien/Desktop/Fall2020/MIS333K/KILLER K Final Project/GitHub/FinalProject/FinalProjectWorkspace/Views/Ticket/Transactions.cshtml"
                  Int32 seatsSold = item.Tickets.Count(); 

#line default
#line hidden
#nullable disable
            WriteLiteral("                ");
#nullable restore
#line 68 "/Users/audreyhsien/Desktop/Fall2020/MIS333K/KILLER K Final Project/GitHub/FinalProject/FinalProjectWorkspace/Views/Ticket/Transactions.cshtml"
           Write(seatsSold);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n");
#nullable restore
#line 71 "/Users/audreyhsien/Desktop/Fall2020/MIS333K/KILLER K Final Project/GitHub/FinalProject/FinalProjectWorkspace/Views/Ticket/Transactions.cshtml"
                 if (item.PaidWithPopcornPoints == true)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    ");
            WriteLiteral("Yes\n");
#nullable restore
#line 74 "/Users/audreyhsien/Desktop/Fall2020/MIS333K/KILLER K Final Project/GitHub/FinalProject/FinalProjectWorkspace/Views/Ticket/Transactions.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    ");
            WriteLiteral("No\n");
#nullable restore
#line 78 "/Users/audreyhsien/Desktop/Fall2020/MIS333K/KILLER K Final Project/GitHub/FinalProject/FinalProjectWorkspace/Views/Ticket/Transactions.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </td>\n        </tr>\n");
#nullable restore
#line 81 "/Users/audreyhsien/Desktop/Fall2020/MIS333K/KILLER K Final Project/GitHub/FinalProject/FinalProjectWorkspace/Views/Ticket/Transactions.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\n</table>\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<FinalProjectWorkspace.Models.Order>> Html { get; private set; }
    }
}
#pragma warning restore 1591
