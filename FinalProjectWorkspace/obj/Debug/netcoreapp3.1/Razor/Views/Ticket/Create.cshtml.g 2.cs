#pragma checksum "/Users/slomeli/Desktop/Sophomore Year/First Semester/MIS 333K/Projects/Final Project/FinalProjectWorkspace/FinalProject/FinalProjectWorkspace/Views/Ticket/Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e6b993d711a665de25b229d9364dbff4bc112477"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(FinalProjectWorkspace.Views.Ticket.Views_Ticket_Create), @"mvc.1.0.view", @"/Views/Ticket/Create.cshtml")]
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
#line 2 "/Users/slomeli/Desktop/Sophomore Year/First Semester/MIS 333K/Projects/Final Project/FinalProjectWorkspace/FinalProject/FinalProjectWorkspace/Views/_ViewImports.cshtml"
using FinalProjectWorkspace.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e6b993d711a665de25b229d9364dbff4bc112477", @"/Views/Ticket/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9daefa0269a9261bb659ce4728f692443d8481bc", @"/Views/_ViewImports.cshtml")]
    public class Views_Ticket_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FinalProjectWorkspace.Models.Ticket>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("control-label"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "text", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("output"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("keyboard"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "/Users/slomeli/Desktop/Sophomore Year/First Semester/MIS 333K/Projects/Final Project/FinalProjectWorkspace/FinalProject/FinalProjectWorkspace/Views/Ticket/Create.cshtml"
  
    ViewData["Title"] = "Create";

#line default
#line hidden
#nullable disable
            WriteLiteral("<script src=\"https://ajax.googleapis.com/ajax/libs/jquery/2.1.1/jquery.min.js\"></script>\n\n");
#nullable restore
#line 8 "/Users/slomeli/Desktop/Sophomore Year/First Semester/MIS 333K/Projects/Final Project/FinalProjectWorkspace/FinalProject/FinalProjectWorkspace/Views/Ticket/Create.cshtml"
  List<string> seatsAvailable = ViewBag.AllSeatsAvailable;

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<br />\n<h1 class=\"text-center text-danger\">Create Ticket</h1>\n<hr style=\"height:2px;border-width:0;color:#d0faff;background-color:#d0faff\">\n<br />\n\n<div class=\"text-center\">\n    <div class=\"text-center\">\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e6b993d711a665de25b229d9364dbff4bc1124777862", async() => {
                WriteLiteral("\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e6b993d711a665de25b229d9364dbff4bc1124778128", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
#nullable restore
#line 18 "/Users/slomeli/Desktop/Sophomore Year/First Semester/MIS 333K/Projects/Final Project/FinalProjectWorkspace/FinalProject/FinalProjectWorkspace/Views/Ticket/Create.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary = global::Microsoft.AspNetCore.Mvc.Rendering.ValidationSummary.All;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-summary", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n            ");
#nullable restore
#line 19 "/Users/slomeli/Desktop/Sophomore Year/First Semester/MIS 333K/Projects/Final Project/FinalProjectWorkspace/FinalProject/FinalProjectWorkspace/Views/Ticket/Create.cshtml"
       Write(Html.HiddenFor(model => model.Order.OrderID));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n            ");
#nullable restore
#line 20 "/Users/slomeli/Desktop/Sophomore Year/First Semester/MIS 333K/Projects/Final Project/FinalProjectWorkspace/FinalProject/FinalProjectWorkspace/Views/Ticket/Create.cshtml"
       Write(Html.HiddenFor(model => model.Order.Purchaser));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n            <div class=\"form-group\">\n                <label class=\"control-label\">Showing:</label>\n                ");
#nullable restore
#line 23 "/Users/slomeli/Desktop/Sophomore Year/First Semester/MIS 333K/Projects/Final Project/FinalProjectWorkspace/FinalProject/FinalProjectWorkspace/Views/Ticket/Create.cshtml"
           Write(Html.DropDownList("SelectedShowing", (SelectList)ViewBag.AllShowings, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
            </div>
            <div class=""text-center"">
                <h3 class=""text-danger text-center"">S C R E E N</h3>
            </div>
            <div>
                
                <div style=""display:inline-flex;grid-column-gap:15px"">
                    <input type=""button"" id=""A1"" value=""A1""");
                BeginWriteAttribute("class", "\n                           class=\"", 1209, "\"", 1307, 3);
                WriteAttributeValue("", 1244, "btn", 1244, 3, true);
                WriteAttributeValue(" ", 1247, "btn-", 1248, 5, true);
#nullable restore
#line 32 "/Users/slomeli/Desktop/Sophomore Year/First Semester/MIS 333K/Projects/Final Project/FinalProjectWorkspace/FinalProject/FinalProjectWorkspace/Views/Ticket/Create.cshtml"
WriteAttributeValue("", 1252, seatsAvailable.Contains("A1") ? "success" : "danger", 1252, 55, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\n                    <input type=\"button\" id=\"A2\" value=\"A2\"");
                BeginWriteAttribute("class", "\n                           class=\"", 1369, "\"", 1467, 3);
                WriteAttributeValue("", 1404, "btn", 1404, 3, true);
                WriteAttributeValue(" ", 1407, "btn-", 1408, 5, true);
#nullable restore
#line 34 "/Users/slomeli/Desktop/Sophomore Year/First Semester/MIS 333K/Projects/Final Project/FinalProjectWorkspace/FinalProject/FinalProjectWorkspace/Views/Ticket/Create.cshtml"
WriteAttributeValue("", 1412, seatsAvailable.Contains("A2") ? "success" : "danger", 1412, 55, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\n                    <input type=\"button\" id=\"A3\" value=\"A3\"");
                BeginWriteAttribute("class", "\n                           class=\"", 1529, "\"", 1627, 3);
                WriteAttributeValue("", 1564, "btn", 1564, 3, true);
                WriteAttributeValue(" ", 1567, "btn-", 1568, 5, true);
#nullable restore
#line 36 "/Users/slomeli/Desktop/Sophomore Year/First Semester/MIS 333K/Projects/Final Project/FinalProjectWorkspace/FinalProject/FinalProjectWorkspace/Views/Ticket/Create.cshtml"
WriteAttributeValue("", 1572, seatsAvailable.Contains("A3") ? "success" : "danger", 1572, 55, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\n                    <input type=\"button\" id=\"A4\" value=\"A4\"");
                BeginWriteAttribute("class", "\n                           class=\"", 1689, "\"", 1787, 3);
                WriteAttributeValue("", 1724, "btn", 1724, 3, true);
                WriteAttributeValue(" ", 1727, "btn-", 1728, 5, true);
#nullable restore
#line 38 "/Users/slomeli/Desktop/Sophomore Year/First Semester/MIS 333K/Projects/Final Project/FinalProjectWorkspace/FinalProject/FinalProjectWorkspace/Views/Ticket/Create.cshtml"
WriteAttributeValue("", 1732, seatsAvailable.Contains("A4") ? "success" : "danger", 1732, 55, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\n                    <input type=\"button\" id=\"A5\" value=\"A5\"");
                BeginWriteAttribute("class", "\n                           class=\"", 1849, "\"", 1947, 3);
                WriteAttributeValue("", 1884, "btn", 1884, 3, true);
                WriteAttributeValue(" ", 1887, "btn-", 1888, 5, true);
#nullable restore
#line 40 "/Users/slomeli/Desktop/Sophomore Year/First Semester/MIS 333K/Projects/Final Project/FinalProjectWorkspace/FinalProject/FinalProjectWorkspace/Views/Ticket/Create.cshtml"
WriteAttributeValue("", 1892, seatsAvailable.Contains("A5") ? "success" : "danger", 1892, 55, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\n                </div>\n                <br />\n                <div style=\"display:inline-flex;grid-column-gap:15px\">\n                    <input type=\"button\" id=\"B1\" value=\"B1\"");
                BeginWriteAttribute("class", "\n                           class=\"", 2126, "\"", 2224, 3);
                WriteAttributeValue("", 2161, "btn", 2161, 3, true);
                WriteAttributeValue(" ", 2164, "btn-", 2165, 5, true);
#nullable restore
#line 45 "/Users/slomeli/Desktop/Sophomore Year/First Semester/MIS 333K/Projects/Final Project/FinalProjectWorkspace/FinalProject/FinalProjectWorkspace/Views/Ticket/Create.cshtml"
WriteAttributeValue("", 2169, seatsAvailable.Contains("B1") ? "success" : "danger", 2169, 55, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\n                    <input type=\"button\" id=\"B2\" value=\"B2\"");
                BeginWriteAttribute("class", "\n                           class=\"", 2286, "\"", 2384, 3);
                WriteAttributeValue("", 2321, "btn", 2321, 3, true);
                WriteAttributeValue(" ", 2324, "btn-", 2325, 5, true);
#nullable restore
#line 47 "/Users/slomeli/Desktop/Sophomore Year/First Semester/MIS 333K/Projects/Final Project/FinalProjectWorkspace/FinalProject/FinalProjectWorkspace/Views/Ticket/Create.cshtml"
WriteAttributeValue("", 2329, seatsAvailable.Contains("B2") ? "success" : "danger", 2329, 55, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\n                    <input type=\"button\" id=\"B3\" value=\"B3\"");
                BeginWriteAttribute("class", "\n                           class=\"", 2446, "\"", 2544, 3);
                WriteAttributeValue("", 2481, "btn", 2481, 3, true);
                WriteAttributeValue(" ", 2484, "btn-", 2485, 5, true);
#nullable restore
#line 49 "/Users/slomeli/Desktop/Sophomore Year/First Semester/MIS 333K/Projects/Final Project/FinalProjectWorkspace/FinalProject/FinalProjectWorkspace/Views/Ticket/Create.cshtml"
WriteAttributeValue("", 2489, seatsAvailable.Contains("B3") ? "success" : "danger", 2489, 55, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\n                    <input type=\"button\" id=\"B4\" value=\"B4\"");
                BeginWriteAttribute("class", "\n                           class=\"", 2606, "\"", 2704, 3);
                WriteAttributeValue("", 2641, "btn", 2641, 3, true);
                WriteAttributeValue(" ", 2644, "btn-", 2645, 5, true);
#nullable restore
#line 51 "/Users/slomeli/Desktop/Sophomore Year/First Semester/MIS 333K/Projects/Final Project/FinalProjectWorkspace/FinalProject/FinalProjectWorkspace/Views/Ticket/Create.cshtml"
WriteAttributeValue("", 2649, seatsAvailable.Contains("B4") ? "success" : "danger", 2649, 55, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\n                    <input type=\"button\" id=\"B5\" value=\"B5\"");
                BeginWriteAttribute("class", "\n                           class=\"", 2766, "\"", 2864, 3);
                WriteAttributeValue("", 2801, "btn", 2801, 3, true);
                WriteAttributeValue(" ", 2804, "btn-", 2805, 5, true);
#nullable restore
#line 53 "/Users/slomeli/Desktop/Sophomore Year/First Semester/MIS 333K/Projects/Final Project/FinalProjectWorkspace/FinalProject/FinalProjectWorkspace/Views/Ticket/Create.cshtml"
WriteAttributeValue("", 2809, seatsAvailable.Contains("B5") ? "success" : "danger", 2809, 55, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\n                </div>\n                <br />\n                <div style=\"display:inline-flex;grid-column-gap:15px\">\n                    <input type=\"button\" id=\"C1\" value=\"C1\"");
                BeginWriteAttribute("class", "\n                           class=\"", 3043, "\"", 3141, 3);
                WriteAttributeValue("", 3078, "btn", 3078, 3, true);
                WriteAttributeValue(" ", 3081, "btn-", 3082, 5, true);
#nullable restore
#line 58 "/Users/slomeli/Desktop/Sophomore Year/First Semester/MIS 333K/Projects/Final Project/FinalProjectWorkspace/FinalProject/FinalProjectWorkspace/Views/Ticket/Create.cshtml"
WriteAttributeValue("", 3086, seatsAvailable.Contains("C1") ? "success" : "danger", 3086, 55, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\n                    <input type=\"button\" id=\"C2\" value=\"C2\"");
                BeginWriteAttribute("class", "\n                           class=\"", 3203, "\"", 3301, 3);
                WriteAttributeValue("", 3238, "btn", 3238, 3, true);
                WriteAttributeValue(" ", 3241, "btn-", 3242, 5, true);
#nullable restore
#line 60 "/Users/slomeli/Desktop/Sophomore Year/First Semester/MIS 333K/Projects/Final Project/FinalProjectWorkspace/FinalProject/FinalProjectWorkspace/Views/Ticket/Create.cshtml"
WriteAttributeValue("", 3246, seatsAvailable.Contains("C2") ? "success" : "danger", 3246, 55, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\n                    <input type=\"button\" id=\"C3\" value=\"C3\"");
                BeginWriteAttribute("class", "\n                           class=\"", 3363, "\"", 3461, 3);
                WriteAttributeValue("", 3398, "btn", 3398, 3, true);
                WriteAttributeValue(" ", 3401, "btn-", 3402, 5, true);
#nullable restore
#line 62 "/Users/slomeli/Desktop/Sophomore Year/First Semester/MIS 333K/Projects/Final Project/FinalProjectWorkspace/FinalProject/FinalProjectWorkspace/Views/Ticket/Create.cshtml"
WriteAttributeValue("", 3406, seatsAvailable.Contains("C3") ? "success" : "danger", 3406, 55, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\n                    <input type=\"button\" id=\"C4\" value=\"C4\"");
                BeginWriteAttribute("class", "\n                           class=\"", 3523, "\"", 3621, 3);
                WriteAttributeValue("", 3558, "btn", 3558, 3, true);
                WriteAttributeValue(" ", 3561, "btn-", 3562, 5, true);
#nullable restore
#line 64 "/Users/slomeli/Desktop/Sophomore Year/First Semester/MIS 333K/Projects/Final Project/FinalProjectWorkspace/FinalProject/FinalProjectWorkspace/Views/Ticket/Create.cshtml"
WriteAttributeValue("", 3566, seatsAvailable.Contains("C4") ? "success" : "danger", 3566, 55, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\n                    <input type=\"button\" id=\"C5\" value=\"C5\"");
                BeginWriteAttribute("class", "\n                           class=\"", 3683, "\"", 3781, 3);
                WriteAttributeValue("", 3718, "btn", 3718, 3, true);
                WriteAttributeValue(" ", 3721, "btn-", 3722, 5, true);
#nullable restore
#line 66 "/Users/slomeli/Desktop/Sophomore Year/First Semester/MIS 333K/Projects/Final Project/FinalProjectWorkspace/FinalProject/FinalProjectWorkspace/Views/Ticket/Create.cshtml"
WriteAttributeValue("", 3726, seatsAvailable.Contains("C5") ? "success" : "danger", 3726, 55, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\n                </div>\n                <br />\n                <div style=\"display:inline-flex;grid-column-gap:15px\">\n                    <input type=\"button\" id=\"D1\" value=\"D1\"");
                BeginWriteAttribute("class", "\n                           class=\"", 3960, "\"", 4058, 3);
                WriteAttributeValue("", 3995, "btn", 3995, 3, true);
                WriteAttributeValue(" ", 3998, "btn-", 3999, 5, true);
#nullable restore
#line 71 "/Users/slomeli/Desktop/Sophomore Year/First Semester/MIS 333K/Projects/Final Project/FinalProjectWorkspace/FinalProject/FinalProjectWorkspace/Views/Ticket/Create.cshtml"
WriteAttributeValue("", 4003, seatsAvailable.Contains("D1") ? "success" : "danger", 4003, 55, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\n                    <input type=\"button\" id=\"D2\" value=\"D2\"");
                BeginWriteAttribute("class", "\n                           class=\"", 4120, "\"", 4218, 3);
                WriteAttributeValue("", 4155, "btn", 4155, 3, true);
                WriteAttributeValue(" ", 4158, "btn-", 4159, 5, true);
#nullable restore
#line 73 "/Users/slomeli/Desktop/Sophomore Year/First Semester/MIS 333K/Projects/Final Project/FinalProjectWorkspace/FinalProject/FinalProjectWorkspace/Views/Ticket/Create.cshtml"
WriteAttributeValue("", 4163, seatsAvailable.Contains("D2") ? "success" : "danger", 4163, 55, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\n                    <input type=\"button\" id=\"D3\" value=\"D3\"");
                BeginWriteAttribute("class", "\n                           class=\"", 4280, "\"", 4378, 3);
                WriteAttributeValue("", 4315, "btn", 4315, 3, true);
                WriteAttributeValue(" ", 4318, "btn-", 4319, 5, true);
#nullable restore
#line 75 "/Users/slomeli/Desktop/Sophomore Year/First Semester/MIS 333K/Projects/Final Project/FinalProjectWorkspace/FinalProject/FinalProjectWorkspace/Views/Ticket/Create.cshtml"
WriteAttributeValue("", 4323, seatsAvailable.Contains("D3") ? "success" : "danger", 4323, 55, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\n                    <input type=\"button\" id=\"D4\" value=\"D4\"");
                BeginWriteAttribute("class", "\n                           class=\"", 4440, "\"", 4538, 3);
                WriteAttributeValue("", 4475, "btn", 4475, 3, true);
                WriteAttributeValue(" ", 4478, "btn-", 4479, 5, true);
#nullable restore
#line 77 "/Users/slomeli/Desktop/Sophomore Year/First Semester/MIS 333K/Projects/Final Project/FinalProjectWorkspace/FinalProject/FinalProjectWorkspace/Views/Ticket/Create.cshtml"
WriteAttributeValue("", 4483, seatsAvailable.Contains("D4") ? "success" : "danger", 4483, 55, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\n                    <input type=\"button\" id=\"D5\" value=\"D5\"");
                BeginWriteAttribute("class", "\n                           class=\"", 4600, "\"", 4698, 3);
                WriteAttributeValue("", 4635, "btn", 4635, 3, true);
                WriteAttributeValue(" ", 4638, "btn-", 4639, 5, true);
#nullable restore
#line 79 "/Users/slomeli/Desktop/Sophomore Year/First Semester/MIS 333K/Projects/Final Project/FinalProjectWorkspace/FinalProject/FinalProjectWorkspace/Views/Ticket/Create.cshtml"
WriteAttributeValue("", 4643, seatsAvailable.Contains("D5") ? "success" : "danger", 4643, 55, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\n                </div>\n                <br />\n                <p></p>\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e6b993d711a665de25b229d9364dbff4bc11247726455", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#nullable restore
#line 83 "/Users/slomeli/Desktop/Sophomore Year/First Semester/MIS 333K/Projects/Final Project/FinalProjectWorkspace/FinalProject/FinalProjectWorkspace/Views/Ticket/Create.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.SeatNumber);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e6b993d711a665de25b229d9364dbff4bc11247728119", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 84 "/Users/slomeli/Desktop/Sophomore Year/First Semester/MIS 333K/Projects/Final Project/FinalProjectWorkspace/FinalProject/FinalProjectWorkspace/Views/Ticket/Create.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.SeatNumber);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e6b993d711a665de25b229d9364dbff4bc11247729991", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#nullable restore
#line 85 "/Users/slomeli/Desktop/Sophomore Year/First Semester/MIS 333K/Projects/Final Project/FinalProjectWorkspace/FinalProject/FinalProjectWorkspace/Views/Ticket/Create.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.SeatNumber);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
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
    <div class=""form-group"">
        <label asp-for=""SeatNumber"" class=""control-label""></label>
        <input asp-for=""SeatNumber"" class=""form-control"" />
        <span asp-validation-for=""SeatNumber"" class=""text-danger""></span>
    </div>
        -->
            <br/>
            <div class=""form-group"">
                <input type=""submit"" value=""Add to Order"" class=""btn btn-outline-primary"" />
                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e6b993d711a665de25b229d9364dbff4bc11247732184", async() => {
                    WriteLiteral("Back to Home");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n            </div>\n\n\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
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



<script>$('#A1').click(function () {
        $('#output').val($(this).val());
        console.log($(this).val());

    })
    $('#A2').click(function () {
        $('#output').val($(this).val());
        console.log($(this).val());
    })
    $('#A3').click(function () {
        $('#output').val($(this).val());
        console.log($(this).val());
    })
    $('#A4').click(function () {
        $('#output').val($(this).val());
        console.log($(this).val());
    })
    $('#A5').click(function () {
        $('#output').val($(this).val());
        console.log($(this).val());
    })
    $('#B1').click(function () {
        $('#output').val($(this).val());
        console.log($(this).val());
    })
    $('#B2').click(function () {
        $('#output').val($(this).val());
        console.log($(this).val());
    })
    $('#B3').click(function () {
        $('#output').val($(this).val());
        console.log($(this).val());
    })
    $('#B4').click(function () {
        $('#output').val($(t");
            WriteLiteral(@"his).val());
        console.log($(this).val());
    })
    $('#B5').click(function () {
        $('#output').val($(this).val());
        console.log($(this).val());
    })
    $('#C1').click(function () {
        $('#output').val($(this).val());
        console.log($(this).val());
    })
    $('#C2').click(function () {
        $('#output').val($(this).val());
        console.log($(this).val());
    })
    $('#C3').click(function () {
        $('#output').val($(this).val());
        console.log($(this).val());
    })
    $('#C4').click(function () {
        $('#output').val($(this).val());
        console.log($(this).val());
    })
    $('#C5').click(function () {
        $('#output').val($(this).val());
        console.log($(this).val());

    })
    $('#D1').click(function () {
        $('#output').val($(this).val());
        console.log($(this).val());
    })
    $('#D2').click(function () {
        $('#output').val($(this).val());

    })
    $('#D3').click(function () {
        $('#output').val($(this).");
            WriteLiteral(@"val());
        console.log($(this).val());
    })
    $('#D4').click(function () {
        $('#output').val($(this).val());
        console.log($(this).val());
    })
    $('#D5').click(function () {
        $('#output').val($(this).val());
        console.log($(this).val());
    })
    /*
    $('').click(function () {
        var $this = $(this);
        if ($('').hasClass('btn btn-success')) {
            $('').removeClass('btn btn-success')
            $('').addClass('btn btn-info');

        })
        */</script>


");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FinalProjectWorkspace.Models.Ticket> Html { get; private set; }
    }
}
#pragma warning restore 1591
