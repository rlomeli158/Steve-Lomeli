#pragma checksum "/Users/audreyhsien/Desktop/Fall2020/MIS333K/KILLER K Final Project/GitHub/FinalProject/FinalProjectWorkspace/Views/RoleAdmin/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "edccd3c70f027f9a6a1e95ebc77b0d130c15817c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(FinalProjectWorkspace.Views.RoleAdmin.Views_RoleAdmin_Index), @"mvc.1.0.view", @"/Views/RoleAdmin/Index.cshtml")]
namespace FinalProjectWorkspace.Views.RoleAdmin
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
#nullable restore
#line 1 "/Users/audreyhsien/Desktop/Fall2020/MIS333K/KILLER K Final Project/GitHub/FinalProject/FinalProjectWorkspace/Views/RoleAdmin/Index.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"edccd3c70f027f9a6a1e95ebc77b0d130c15817c", @"/Views/RoleAdmin/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3077373090091c5850da6e8c6a3970a3b8885491", @"/Views/_ViewImports.cshtml")]
    public class Views_RoleAdmin_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<RoleEditModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 4 "/Users/audreyhsien/Desktop/Fall2020/MIS333K/KILLER K Final Project/GitHub/FinalProject/FinalProjectWorkspace/Views/RoleAdmin/Index.cshtml"
  
    ViewBag.Title = "Roles";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    <br />
<h1 class=""text-center text-danger"">Role Administration Home</h1>
<hr style=""height:2px;border-width:0;color:#d0faff;background-color:#d0faff"">
<br />

<div class=""panel panel-primary"">
    <div class=""panel-heading"">Roles</div>
    <table class=""table table-striped"">
        <tr>
            <th>ID</th>
            <th>Name</th>
            <th>Users</th>
            <th></th>
        </tr>
");
#nullable restore
#line 22 "/Users/audreyhsien/Desktop/Fall2020/MIS333K/KILLER K Final Project/GitHub/FinalProject/FinalProjectWorkspace/Views/RoleAdmin/Index.cshtml"
         if (User.IsInRole("Manager"))
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "/Users/audreyhsien/Desktop/Fall2020/MIS333K/KILLER K Final Project/GitHub/FinalProject/FinalProjectWorkspace/Views/RoleAdmin/Index.cshtml"
             if (Model.Count() == 0)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\n                    <td colspan=\"4\" class=\"text-center\">No roles</td>\n                </tr>\n");
#nullable restore
#line 29 "/Users/audreyhsien/Desktop/Fall2020/MIS333K/KILLER K Final Project/GitHub/FinalProject/FinalProjectWorkspace/Views/RoleAdmin/Index.cshtml"
            }
            else
            {
                foreach (RoleEditModel role in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\n                        <td>");
#nullable restore
#line 35 "/Users/audreyhsien/Desktop/Fall2020/MIS333K/KILLER K Final Project/GitHub/FinalProject/FinalProjectWorkspace/Views/RoleAdmin/Index.cshtml"
                       Write(role.Role.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>");
#nullable restore
#line 36 "/Users/audreyhsien/Desktop/Fall2020/MIS333K/KILLER K Final Project/GitHub/FinalProject/FinalProjectWorkspace/Views/RoleAdmin/Index.cshtml"
                       Write(role.Role.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>\n");
#nullable restore
#line 38 "/Users/audreyhsien/Desktop/Fall2020/MIS333K/KILLER K Final Project/GitHub/FinalProject/FinalProjectWorkspace/Views/RoleAdmin/Index.cshtml"
                             if (role.Members == null || role.Members.Count() == 0)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                ");
            WriteLiteral(" No Users in role\n");
#nullable restore
#line 41 "/Users/audreyhsien/Desktop/Fall2020/MIS333K/KILLER K Final Project/GitHub/FinalProject/FinalProjectWorkspace/Views/RoleAdmin/Index.cshtml"
                            }
                            else // if (role.Members.Equals("Customer"))
                                 //else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <p>");
#nullable restore
#line 45 "/Users/audreyhsien/Desktop/Fall2020/MIS333K/KILLER K Final Project/GitHub/FinalProject/FinalProjectWorkspace/Views/RoleAdmin/Index.cshtml"
                              Write(string.Join(", ", role.Members.Select(x => x.Email)));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n");
#nullable restore
#line 46 "/Users/audreyhsien/Desktop/Fall2020/MIS333K/KILLER K Final Project/GitHub/FinalProject/FinalProjectWorkspace/Views/RoleAdmin/Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </td>\n                        <td>\n                            ");
#nullable restore
#line 49 "/Users/audreyhsien/Desktop/Fall2020/MIS333K/KILLER K Final Project/GitHub/FinalProject/FinalProjectWorkspace/Views/RoleAdmin/Index.cshtml"
                       Write(Html.ActionLink("Edit", "Edit", new { id = role.Role.Id }, new { @class = "btn btn-primary" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </td>\n                    </tr>\n");
#nullable restore
#line 52 "/Users/audreyhsien/Desktop/Fall2020/MIS333K/KILLER K Final Project/GitHub/FinalProject/FinalProjectWorkspace/Views/RoleAdmin/Index.cshtml"
                }
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 53 "/Users/audreyhsien/Desktop/Fall2020/MIS333K/KILLER K Final Project/GitHub/FinalProject/FinalProjectWorkspace/Views/RoleAdmin/Index.cshtml"
             
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
#nullable restore
#line 56 "/Users/audreyhsien/Desktop/Fall2020/MIS333K/KILLER K Final Project/GitHub/FinalProject/FinalProjectWorkspace/Views/RoleAdmin/Index.cshtml"
         if (User.IsInRole("Employee"))
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 58 "/Users/audreyhsien/Desktop/Fall2020/MIS333K/KILLER K Final Project/GitHub/FinalProject/FinalProjectWorkspace/Views/RoleAdmin/Index.cshtml"
             if (Model.Count() == 0)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\n                    <td colspan=\"4\" class=\"text-center\">No roles</td>\n                </tr>\n");
#nullable restore
#line 63 "/Users/audreyhsien/Desktop/Fall2020/MIS333K/KILLER K Final Project/GitHub/FinalProject/FinalProjectWorkspace/Views/RoleAdmin/Index.cshtml"
            }
            else
            {
                foreach (RoleEditModel role in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\n                        <td>");
#nullable restore
#line 69 "/Users/audreyhsien/Desktop/Fall2020/MIS333K/KILLER K Final Project/GitHub/FinalProject/FinalProjectWorkspace/Views/RoleAdmin/Index.cshtml"
                       Write(role.Role.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>");
#nullable restore
#line 70 "/Users/audreyhsien/Desktop/Fall2020/MIS333K/KILLER K Final Project/GitHub/FinalProject/FinalProjectWorkspace/Views/RoleAdmin/Index.cshtml"
                       Write(role.Role.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>\n");
#nullable restore
#line 72 "/Users/audreyhsien/Desktop/Fall2020/MIS333K/KILLER K Final Project/GitHub/FinalProject/FinalProjectWorkspace/Views/RoleAdmin/Index.cshtml"
                             if (role.Members == null || role.Members.Count() == 0)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                ");
            WriteLiteral(" No Users in role\n");
#nullable restore
#line 75 "/Users/audreyhsien/Desktop/Fall2020/MIS333K/KILLER K Final Project/GitHub/FinalProject/FinalProjectWorkspace/Views/RoleAdmin/Index.cshtml"
                            }
                            else //if (role.Members.Equals("Customer"))
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <p>");
#nullable restore
#line 78 "/Users/audreyhsien/Desktop/Fall2020/MIS333K/KILLER K Final Project/GitHub/FinalProject/FinalProjectWorkspace/Views/RoleAdmin/Index.cshtml"
                              Write(string.Join(", ", role.Members.Select(x => x.Email)));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n");
#nullable restore
#line 79 "/Users/audreyhsien/Desktop/Fall2020/MIS333K/KILLER K Final Project/GitHub/FinalProject/FinalProjectWorkspace/Views/RoleAdmin/Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </td>\n                        <td>\n                            ");
#nullable restore
#line 82 "/Users/audreyhsien/Desktop/Fall2020/MIS333K/KILLER K Final Project/GitHub/FinalProject/FinalProjectWorkspace/Views/RoleAdmin/Index.cshtml"
                       Write(Html.ActionLink("Edit", "Edit", new { id = role.Role.Id }, new { @class = "btn btn-outline-primary" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </td>\n                    </tr>\n");
#nullable restore
#line 85 "/Users/audreyhsien/Desktop/Fall2020/MIS333K/KILLER K Final Project/GitHub/FinalProject/FinalProjectWorkspace/Views/RoleAdmin/Index.cshtml"
                }
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 86 "/Users/audreyhsien/Desktop/Fall2020/MIS333K/KILLER K Final Project/GitHub/FinalProject/FinalProjectWorkspace/Views/RoleAdmin/Index.cshtml"
             
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n    </table>\n</div>\n\n");
#nullable restore
#line 93 "/Users/audreyhsien/Desktop/Fall2020/MIS333K/KILLER K Final Project/GitHub/FinalProject/FinalProjectWorkspace/Views/RoleAdmin/Index.cshtml"
 if (User.Identity.IsAuthenticated)
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 95 "/Users/audreyhsien/Desktop/Fall2020/MIS333K/KILLER K Final Project/GitHub/FinalProject/FinalProjectWorkspace/Views/RoleAdmin/Index.cshtml"
     if (User.IsInRole("Manager"))
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 97 "/Users/audreyhsien/Desktop/Fall2020/MIS333K/KILLER K Final Project/GitHub/FinalProject/FinalProjectWorkspace/Views/RoleAdmin/Index.cshtml"
   Write(Html.ActionLink("Create", "Create", null, new { @class = "btn btn-outline-primary" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 97 "/Users/audreyhsien/Desktop/Fall2020/MIS333K/KILLER K Final Project/GitHub/FinalProject/FinalProjectWorkspace/Views/RoleAdmin/Index.cshtml"
                                                                                              
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 98 "/Users/audreyhsien/Desktop/Fall2020/MIS333K/KILLER K Final Project/GitHub/FinalProject/FinalProjectWorkspace/Views/RoleAdmin/Index.cshtml"
     
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<RoleEditModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
