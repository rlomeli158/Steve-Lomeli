#pragma checksum "/Users/jennifertruong/Documents/GitHub/FinalProject/FinalProjectWorkspace/Views/Account/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cba34b03ecc89010cf064f21612d031371a2e0a2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(FinalProjectWorkspace.Views.Account.Views_Account_Index), @"mvc.1.0.view", @"/Views/Account/Index.cshtml")]
namespace FinalProjectWorkspace.Views.Account
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cba34b03ecc89010cf064f21612d031371a2e0a2", @"/Views/Account/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3077373090091c5850da6e8c6a3970a3b8885491", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IndexViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditAccount", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-primary text-center"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ChangePassword", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-danger text-center"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "/Users/jennifertruong/Documents/GitHub/FinalProject/FinalProjectWorkspace/Views/Account/Index.cshtml"
  
    ViewBag.Title = "Account Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h2>");
#nullable restore
#line 6 "/Users/jennifertruong/Documents/GitHub/FinalProject/FinalProjectWorkspace/Views/Account/Index.cshtml"
Write(ViewBag.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\n\n<div>\n    <hr />\n    <dl class=\"dl-horizontal\">\n        <dt>User Name:</dt>\n        <dd>");
#nullable restore
#line 12 "/Users/jennifertruong/Documents/GitHub/FinalProject/FinalProjectWorkspace/Views/Account/Index.cshtml"
       Write(Model.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\n\n        <dt>Popcorn Points:</dt>\n        <dd>");
#nullable restore
#line 15 "/Users/jennifertruong/Documents/GitHub/FinalProject/FinalProjectWorkspace/Views/Account/Index.cshtml"
       Write(Model.PCPBalance);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\n\n        <dt>Email:</dt>\n        <dd>");
#nullable restore
#line 18 "/Users/jennifertruong/Documents/GitHub/FinalProject/FinalProjectWorkspace/Views/Account/Index.cshtml"
       Write(Model.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\n\n        <dt>Phone Number:</dt>\n        <dd>");
#nullable restore
#line 21 "/Users/jennifertruong/Documents/GitHub/FinalProject/FinalProjectWorkspace/Views/Account/Index.cshtml"
       Write(Model.PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\n\n        <dt>First Name:</dt>\n        <dd>");
#nullable restore
#line 24 "/Users/jennifertruong/Documents/GitHub/FinalProject/FinalProjectWorkspace/Views/Account/Index.cshtml"
       Write(Model.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\n\n        <dt>Middle Initial:</dt>\n        <dd>");
#nullable restore
#line 27 "/Users/jennifertruong/Documents/GitHub/FinalProject/FinalProjectWorkspace/Views/Account/Index.cshtml"
       Write(Model.MiddleInitial);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\n\n        <dt>Last Name:</dt>\n        <dd>");
#nullable restore
#line 30 "/Users/jennifertruong/Documents/GitHub/FinalProject/FinalProjectWorkspace/Views/Account/Index.cshtml"
       Write(Model.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\n\n        <dt>Address:</dt>\n        <dd>");
#nullable restore
#line 33 "/Users/jennifertruong/Documents/GitHub/FinalProject/FinalProjectWorkspace/Views/Account/Index.cshtml"
       Write(Model.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\n\n        <dt>City:</dt>\n        <dd>");
#nullable restore
#line 36 "/Users/jennifertruong/Documents/GitHub/FinalProject/FinalProjectWorkspace/Views/Account/Index.cshtml"
       Write(Model.City);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\n\n        <dt>State:</dt>\n        <dd>");
#nullable restore
#line 39 "/Users/jennifertruong/Documents/GitHub/FinalProject/FinalProjectWorkspace/Views/Account/Index.cshtml"
       Write(Model.State);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\n\n        <dt>Zip:</dt>\n        <dd>");
#nullable restore
#line 42 "/Users/jennifertruong/Documents/GitHub/FinalProject/FinalProjectWorkspace/Views/Account/Index.cshtml"
       Write(Model.Zip);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\n\n        <dt>Birthday:</dt>\n        <dd>");
#nullable restore
#line 45 "/Users/jennifertruong/Documents/GitHub/FinalProject/FinalProjectWorkspace/Views/Account/Index.cshtml"
       Write(Model.Birthday);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\n\n        \n        <dt>Account Status:</dt>\n        <dd>");
#nullable restore
#line 49 "/Users/jennifertruong/Documents/GitHub/FinalProject/FinalProjectWorkspace/Views/Account/Index.cshtml"
       Write(Model.AccountStatus);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\n        <br/>\n\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cba34b03ecc89010cf064f21612d031371a2e0a28571", async() => {
                WriteLiteral("Edit Account");
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
#line 52 "/Users/jennifertruong/Documents/GitHub/FinalProject/FinalProjectWorkspace/Views/Account/Index.cshtml"
                                      WriteLiteral(Model.UserID);

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
            WriteLiteral("\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cba34b03ecc89010cf064f21612d031371a2e0a210808", async() => {
                WriteLiteral("Change password");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 53 "/Users/jennifertruong/Documents/GitHub/FinalProject/FinalProjectWorkspace/Views/Account/Index.cshtml"
                                         WriteLiteral(Model.UserID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\n    </dl>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
