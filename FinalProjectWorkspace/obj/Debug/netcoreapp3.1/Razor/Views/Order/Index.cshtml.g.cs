#pragma checksum "/Users/audreyhsien/Desktop/Fall2020/MIS333K/KILLER K Final Project/GitHub/FinalProject/FinalProjectWorkspace/Views/Order/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "62c1a1dac166c2c546641a72117b55fad3b5da89"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(FinalProjectWorkspace.Views.Order.Views_Order_Index), @"mvc.1.0.view", @"/Views/Order/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"62c1a1dac166c2c546641a72117b55fad3b5da89", @"/Views/Order/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3077373090091c5850da6e8c6a3970a3b8885491", @"/Views/_ViewImports.cshtml")]
    public class Views_Order_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<FinalProjectWorkspace.Models.Order>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Cancelled", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "/Users/audreyhsien/Desktop/Fall2020/MIS333K/KILLER K Final Project/GitHub/FinalProject/FinalProjectWorkspace/Views/Order/Index.cshtml"
  
    ViewData["Title"] = "Order History";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    <div class=""text-center"">
        <br />
        <h1 class=""text-center text-danger"">Order History</h1>
    </div>
<hr style=""height:2px;border-width:0;color:#d0faff;background-color:#d0faff"">
<br />

<!-- People shouldn't be able to start an order by clicking this, instead, they should add a ticket to their cart
<p>
    <a class=""btn btn-outline-primary"" asp-action=""Create"" >Create New</a>
</p>
-->

<table class=""table table-hover text-center"">
    <thead>
        <tr class=""text-light text-center"">
            <th>
                ");
#nullable restore
#line 24 "/Users/audreyhsien/Desktop/Fall2020/MIS333K/KILLER K Final Project/GitHub/FinalProject/FinalProjectWorkspace/Views/Order/Index.cshtml"
           Write(Html.DisplayNameFor(model => model.TransactionNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 27 "/Users/audreyhsien/Desktop/Fall2020/MIS333K/KILLER K Final Project/GitHub/FinalProject/FinalProjectWorkspace/Views/Order/Index.cshtml"
           Write(Html.DisplayNameFor(model => model.OrderDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 30 "/Users/audreyhsien/Desktop/Fall2020/MIS333K/KILLER K Final Project/GitHub/FinalProject/FinalProjectWorkspace/Views/Order/Index.cshtml"
           Write(Html.DisplayNameFor(model => model.OrderStatus));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 33 "/Users/audreyhsien/Desktop/Fall2020/MIS333K/KILLER K Final Project/GitHub/FinalProject/FinalProjectWorkspace/Views/Order/Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Purchaser));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 36 "/Users/audreyhsien/Desktop/Fall2020/MIS333K/KILLER K Final Project/GitHub/FinalProject/FinalProjectWorkspace/Views/Order/Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Seller));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                Actions\n            </th>\n        </tr>\n    </thead>\n    <tbody>\n");
#nullable restore
#line 44 "/Users/audreyhsien/Desktop/Fall2020/MIS333K/KILLER K Final Project/GitHub/FinalProject/FinalProjectWorkspace/Views/Order/Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr class=\"table-secondary text-center text-dark\">\n                <td>\n                    ");
#nullable restore
#line 48 "/Users/audreyhsien/Desktop/Fall2020/MIS333K/KILLER K Final Project/GitHub/FinalProject/FinalProjectWorkspace/Views/Order/Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.TransactionNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </td>\n                <td>\n                    ");
#nullable restore
#line 51 "/Users/audreyhsien/Desktop/Fall2020/MIS333K/KILLER K Final Project/GitHub/FinalProject/FinalProjectWorkspace/Views/Order/Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.OrderDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </td>\n                <td>\n                    ");
#nullable restore
#line 54 "/Users/audreyhsien/Desktop/Fall2020/MIS333K/KILLER K Final Project/GitHub/FinalProject/FinalProjectWorkspace/Views/Order/Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.OrderStatus));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </td>\n                <td>\n                    ");
#nullable restore
#line 57 "/Users/audreyhsien/Desktop/Fall2020/MIS333K/KILLER K Final Project/GitHub/FinalProject/FinalProjectWorkspace/Views/Order/Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Purchaser.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 57 "/Users/audreyhsien/Desktop/Fall2020/MIS333K/KILLER K Final Project/GitHub/FinalProject/FinalProjectWorkspace/Views/Order/Index.cshtml"
                                                                       Write(Html.DisplayFor(modelItem => item.Purchaser.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </td>\n                <td>\n                    ");
#nullable restore
#line 60 "/Users/audreyhsien/Desktop/Fall2020/MIS333K/KILLER K Final Project/GitHub/FinalProject/FinalProjectWorkspace/Views/Order/Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Seller.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 60 "/Users/audreyhsien/Desktop/Fall2020/MIS333K/KILLER K Final Project/GitHub/FinalProject/FinalProjectWorkspace/Views/Order/Index.cshtml"
                                                                    Write(Html.DisplayFor(modelItem => item.Seller.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </td>\n                <td>\n");
#nullable restore
#line 63 "/Users/audreyhsien/Desktop/Fall2020/MIS333K/KILLER K Final Project/GitHub/FinalProject/FinalProjectWorkspace/Views/Order/Index.cshtml"
                     if (item.OrderStatus == "Active")
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "62c1a1dac166c2c546641a72117b55fad3b5da8911090", async() => {
                WriteLiteral("Edit Tickets");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 65 "/Users/audreyhsien/Desktop/Fall2020/MIS333K/KILLER K Final Project/GitHub/FinalProject/FinalProjectWorkspace/Views/Order/Index.cshtml"
                                                                               WriteLiteral(item.OrderID);

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
            WriteLiteral("\n");
#nullable restore
#line 66 "/Users/audreyhsien/Desktop/Fall2020/MIS333K/KILLER K Final Project/GitHub/FinalProject/FinalProjectWorkspace/Views/Order/Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "62c1a1dac166c2c546641a72117b55fad3b5da8913675", async() => {
                WriteLiteral("View");
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
#line 67 "/Users/audreyhsien/Desktop/Fall2020/MIS333K/KILLER K Final Project/GitHub/FinalProject/FinalProjectWorkspace/Views/Order/Index.cshtml"
                                                                           WriteLiteral(item.OrderID);

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
            WriteLiteral("\n");
#nullable restore
#line 68 "/Users/audreyhsien/Desktop/Fall2020/MIS333K/KILLER K Final Project/GitHub/FinalProject/FinalProjectWorkspace/Views/Order/Index.cshtml"
                     if ((item.OrderStatus == "Paid" || item.OrderStatus == "Partially Cancelled") && !item.Tickets.Any(t => t.Showing.StartTime < DateTime.Now.AddHours(1)))
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "62c1a1dac166c2c546641a72117b55fad3b5da8916426", async() => {
                WriteLiteral("Cancel");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 70 "/Users/audreyhsien/Desktop/Fall2020/MIS333K/KILLER K Final Project/GitHub/FinalProject/FinalProjectWorkspace/Views/Order/Index.cshtml"
                                                                                   WriteLiteral(item.OrderID);

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
            WriteLiteral("\n");
#nullable restore
#line 71 "/Users/audreyhsien/Desktop/Fall2020/MIS333K/KILLER K Final Project/GitHub/FinalProject/FinalProjectWorkspace/Views/Order/Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </td>\n            </tr>\n");
#nullable restore
#line 74 "/Users/audreyhsien/Desktop/Fall2020/MIS333K/KILLER K Final Project/GitHub/FinalProject/FinalProjectWorkspace/Views/Order/Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\n</table>\n");
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
