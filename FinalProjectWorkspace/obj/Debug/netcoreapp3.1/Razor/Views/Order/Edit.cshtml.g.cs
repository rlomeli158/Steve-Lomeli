#pragma checksum "/Users/audreyhsien/Desktop/Fall2020/MIS333K/KILLER K Final Project/GitHub/FinalProject/FinalProjectWorkspace/Views/Order/Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c96afbf6601a3d76a26b1a7255639cb36458ec5b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(FinalProjectWorkspace.Views.Order.Views_Order_Edit), @"mvc.1.0.view", @"/Views/Order/Edit.cshtml")]
namespace FinalProjectWorkspace.Views.Order
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c96afbf6601a3d76a26b1a7255639cb36458ec5b", @"/Views/Order/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3077373090091c5850da6e8c6a3970a3b8885491", @"/Views/_ViewImports.cshtml")]
    public class Views_Order_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FinalProjectWorkspace.Models.Order>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Ticket", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "/Users/audreyhsien/Desktop/Fall2020/MIS333K/KILLER K Final Project/GitHub/FinalProject/FinalProjectWorkspace/Views/Order/Edit.cshtml"
  
    ViewData["Title"] = "Edit";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    <br />
<h1 class=""text-center text-danger"">Edit Order</h1>
<hr style=""height:2px;border-width:0;color:#d0faff;background-color:#d0faff"">
<br />

<!--
<div class=""row"">
    <div class=""col-md-4"">
        <form asp-action=""Edit"">
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
            <input type=""hidden"" asp-for=""OrderID"" />
            <div class=""form-group"">
                <input type=""submit"" value=""Save"" class=""btn btn-primary"" />
            </div>
        </form>
    </div>
</div>
-->

<hr style=""border:1px solid white"" />

<h5>Tickets on this Order</h5>
<table class=""table table-hover text-center"">
    <tr class=""text-light text-center"">
        <th>Movie Title</th>
        <th>Date</th>
        <th>Seat Number</th>
        <th>Ticket Price</th>
        <th>Discount Amount</th>
        <th>Discount Name</th>
        <th>Total Cost</th>
");
#nullable restore
#line 38 "/Users/audreyhsien/Desktop/Fall2020/MIS333K/KILLER K Final Project/GitHub/FinalProject/FinalProjectWorkspace/Views/Order/Edit.cshtml"
         if (Model.OrderStatus == "Active")
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <th>Edit</th>\n            <th>Delete</th>\n");
#nullable restore
#line 42 "/Users/audreyhsien/Desktop/Fall2020/MIS333K/KILLER K Final Project/GitHub/FinalProject/FinalProjectWorkspace/Views/Order/Edit.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tr>\n");
#nullable restore
#line 44 "/Users/audreyhsien/Desktop/Fall2020/MIS333K/KILLER K Final Project/GitHub/FinalProject/FinalProjectWorkspace/Views/Order/Edit.cshtml"
     foreach (Ticket t in Model.Tickets)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr class=\"table-secondary text-center text-dark\">\n            <td>");
#nullable restore
#line 47 "/Users/audreyhsien/Desktop/Fall2020/MIS333K/KILLER K Final Project/GitHub/FinalProject/FinalProjectWorkspace/Views/Order/Edit.cshtml"
           Write(Html.DisplayFor(ModelItem => t.Showing.Movie.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>");
#nullable restore
#line 48 "/Users/audreyhsien/Desktop/Fall2020/MIS333K/KILLER K Final Project/GitHub/FinalProject/FinalProjectWorkspace/Views/Order/Edit.cshtml"
           Write(Html.DisplayFor(ModelItem => t.Showing.ShowingDate));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 48 "/Users/audreyhsien/Desktop/Fall2020/MIS333K/KILLER K Final Project/GitHub/FinalProject/FinalProjectWorkspace/Views/Order/Edit.cshtml"
                                                                Write(Html.DisplayFor(ModelItem => t.Showing.StartTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>");
#nullable restore
#line 49 "/Users/audreyhsien/Desktop/Fall2020/MIS333K/KILLER K Final Project/GitHub/FinalProject/FinalProjectWorkspace/Views/Order/Edit.cshtml"
           Write(Html.DisplayFor(ModelItem => t.SeatNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>");
#nullable restore
#line 50 "/Users/audreyhsien/Desktop/Fall2020/MIS333K/KILLER K Final Project/GitHub/FinalProject/FinalProjectWorkspace/Views/Order/Edit.cshtml"
           Write(Html.DisplayFor(ModelItem => t.TicketPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>");
#nullable restore
#line 51 "/Users/audreyhsien/Desktop/Fall2020/MIS333K/KILLER K Final Project/GitHub/FinalProject/FinalProjectWorkspace/Views/Order/Edit.cshtml"
           Write(Html.DisplayFor(ModelItem => t.DiscountAmount));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n");
#nullable restore
#line 52 "/Users/audreyhsien/Desktop/Fall2020/MIS333K/KILLER K Final Project/GitHub/FinalProject/FinalProjectWorkspace/Views/Order/Edit.cshtml"
             if (t.DiscountName == DiscountNames.Matinee)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <td>Matinee</td>\n");
#nullable restore
#line 55 "/Users/audreyhsien/Desktop/Fall2020/MIS333K/KILLER K Final Project/GitHub/FinalProject/FinalProjectWorkspace/Views/Order/Edit.cshtml"
            }
            else if (t.DiscountName == DiscountNames.Tuesday_Discount)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <td>Discount Tuesday</td>\n");
#nullable restore
#line 59 "/Users/audreyhsien/Desktop/Fall2020/MIS333K/KILLER K Final Project/GitHub/FinalProject/FinalProjectWorkspace/Views/Order/Edit.cshtml"
            }
            else if (t.DiscountName == DiscountNames.Senior_Discounts)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <td>Senior</td>\n");
#nullable restore
#line 63 "/Users/audreyhsien/Desktop/Fall2020/MIS333K/KILLER K Final Project/GitHub/FinalProject/FinalProjectWorkspace/Views/Order/Edit.cshtml"
            }
            else if (t.DiscountName == DiscountNames.Matinee_and_Senior)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <td>Matinee &amp; Senior</td>\n");
#nullable restore
#line 67 "/Users/audreyhsien/Desktop/Fall2020/MIS333K/KILLER K Final Project/GitHub/FinalProject/FinalProjectWorkspace/Views/Order/Edit.cshtml"
            }
            else if (t.DiscountName == DiscountNames.Tuesday_and_Senior)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <td>Discount Tuesday &amp; Senior</td>\n");
#nullable restore
#line 71 "/Users/audreyhsien/Desktop/Fall2020/MIS333K/KILLER K Final Project/GitHub/FinalProject/FinalProjectWorkspace/Views/Order/Edit.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <td>None</td>\n");
#nullable restore
#line 75 "/Users/audreyhsien/Desktop/Fall2020/MIS333K/KILLER K Final Project/GitHub/FinalProject/FinalProjectWorkspace/Views/Order/Edit.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            <td>");
#nullable restore
#line 76 "/Users/audreyhsien/Desktop/Fall2020/MIS333K/KILLER K Final Project/GitHub/FinalProject/FinalProjectWorkspace/Views/Order/Edit.cshtml"
           Write(Html.DisplayFor(ModelItem => t.TotalCost));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c96afbf6601a3d76a26b1a7255639cb36458ec5b12860", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 78 "/Users/audreyhsien/Desktop/Fall2020/MIS333K/KILLER K Final Project/GitHub/FinalProject/FinalProjectWorkspace/Views/Order/Edit.cshtml"
                                                               WriteLiteral(t.TicketID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n            </td>\n            <td>\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c96afbf6601a3d76a26b1a7255639cb36458ec5b15394", async() => {
                WriteLiteral("Delete");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 81 "/Users/audreyhsien/Desktop/Fall2020/MIS333K/KILLER K Final Project/GitHub/FinalProject/FinalProjectWorkspace/Views/Order/Edit.cshtml"
                                                                 WriteLiteral(t.TicketID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n            </td>\n        </tr>\n");
#nullable restore
#line 84 "/Users/audreyhsien/Desktop/Fall2020/MIS333K/KILLER K Final Project/GitHub/FinalProject/FinalProjectWorkspace/Views/Order/Edit.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\n\n<div class=\"text-center\">\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c96afbf6601a3d76a26b1a7255639cb36458ec5b18202", async() => {
                WriteLiteral("Add More Tickets");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-orderid", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 88 "/Users/audreyhsien/Desktop/Fall2020/MIS333K/KILLER K Final Project/GitHub/FinalProject/FinalProjectWorkspace/Views/Order/Edit.cshtml"
                                                          WriteLiteral(Model.OrderID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["orderid"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-orderid", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["orderid"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c96afbf6601a3d76a26b1a7255639cb36458ec5b20717", async() => {
                WriteLiteral("Edit Existing Tickets");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-orderid", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 89 "/Users/audreyhsien/Desktop/Fall2020/MIS333K/KILLER K Final Project/GitHub/FinalProject/FinalProjectWorkspace/Views/Order/Edit.cshtml"
                                                         WriteLiteral(Model.OrderID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["orderid"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-orderid", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["orderid"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c96afbf6601a3d76a26b1a7255639cb36458ec5b23236", async() => {
                WriteLiteral("Back to Order");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 90 "/Users/audreyhsien/Desktop/Fall2020/MIS333K/KILLER K Final Project/GitHub/FinalProject/FinalProjectWorkspace/Views/Order/Edit.cshtml"
                                                              WriteLiteral(Model.OrderID);

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FinalProjectWorkspace.Models.Order> Html { get; private set; }
    }
}
#pragma warning restore 1591
