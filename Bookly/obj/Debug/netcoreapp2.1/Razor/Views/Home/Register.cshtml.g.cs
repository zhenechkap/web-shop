#pragma checksum "C:\Users\ronnie\source\repos\Asp.Net2\Section 10\01\LittlePacktBookstore\LittlePacktBookstore\Views\Home\Register.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "68d7bfb33c44286e4d106ff3ebdf911832d26acd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Register), @"mvc.1.0.view", @"/Views/Home/Register.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Register.cshtml", typeof(AspNetCore.Views_Home_Register))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\ronnie\source\repos\Asp.Net2\Section 10\01\LittlePacktBookstore\LittlePacktBookstore\Views\_ViewImports.cshtml"
using LittlePacktBookstore.ViewModels;

#line default
#line hidden
#line 2 "C:\Users\ronnie\source\repos\Asp.Net2\Section 10\01\LittlePacktBookstore\LittlePacktBookstore\Views\_ViewImports.cshtml"
using LittlePacktBookstore.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"68d7bfb33c44286e4d106ff3ebdf911832d26acd", @"/Views/Home/Register.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6d92cb761646fb4d9f41c0d674984d9b6dc823bc", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Register : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LittlePacktBookstore.Models.Registration>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\ronnie\source\repos\Asp.Net2\Section 10\01\LittlePacktBookstore\LittlePacktBookstore\Views\Home\Register.cshtml"
  
	ViewData["Title"] = "Register";

#line default
#line hidden
            BeginContext(90, 171, true);
            WriteLiteral("\r\n<div class=\"container\">\r\n\t<div class=\"jumbotron\">\r\n\t\t<h2 class=\"text-center\">Register using HTML Tag Helper</h2>\r\n\t</div>\r\n\t<div class=\"row\">\r\n\t\t<div class=\"col-md-8\">\r\n");
            EndContext();
#line 12 "C:\Users\ronnie\source\repos\Asp.Net2\Section 10\01\LittlePacktBookstore\LittlePacktBookstore\Views\Home\Register.cshtml"
             using (Html.BeginForm("Register", "Home", FormMethod.Post))
			{
				

#line default
#line hidden
            BeginContext(337, 65, false);
#line 14 "C:\Users\ronnie\source\repos\Asp.Net2\Section 10\01\LittlePacktBookstore\LittlePacktBookstore\Views\Home\Register.cshtml"
           Write(Html.ValidationSummary(false, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
#line 14 "C:\Users\ronnie\source\repos\Asp.Net2\Section 10\01\LittlePacktBookstore\LittlePacktBookstore\Views\Home\Register.cshtml"
                                                                                  ;

#line default
#line hidden
            BeginContext(405, 35, true);
            WriteLiteral("\t\t\t\t<div class=\"form-group\">\r\n\t\t\t\t\t");
            EndContext();
            BeginContext(441, 71, false);
#line 16 "C:\Users\ronnie\source\repos\Asp.Net2\Section 10\01\LittlePacktBookstore\LittlePacktBookstore\Views\Home\Register.cshtml"
               Write(Html.Label("FirstName", "First Name", new { @class = "control-label" }));

#line default
#line hidden
            EndContext();
            BeginContext(512, 7, true);
            WriteLiteral("\r\n\t\t\t\t\t");
            EndContext();
            BeginContext(520, 89, false);
#line 17 "C:\Users\ronnie\source\repos\Asp.Net2\Section 10\01\LittlePacktBookstore\LittlePacktBookstore\Views\Home\Register.cshtml"
               Write(Html.TextBox("FirstName", "", new { @class = "form-control", placeholder = "FirstName" }));

#line default
#line hidden
            EndContext();
            BeginContext(609, 7, true);
            WriteLiteral("\r\n\t\t\t\t\t");
            EndContext();
            BeginContext(617, 71, false);
#line 18 "C:\Users\ronnie\source\repos\Asp.Net2\Section 10\01\LittlePacktBookstore\LittlePacktBookstore\Views\Home\Register.cshtml"
               Write(Html.ValidationMessage("FirstName", "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(688, 49, true);
            WriteLiteral("\r\n\t\t\t\t</div>\r\n\t\t\t\t<div class=\"form-group\">\r\n\t\t\t\t\t");
            EndContext();
            BeginContext(738, 69, false);
#line 21 "C:\Users\ronnie\source\repos\Asp.Net2\Section 10\01\LittlePacktBookstore\LittlePacktBookstore\Views\Home\Register.cshtml"
               Write(Html.Label("LastName", "Last Name", new { @class = "control-label" }));

#line default
#line hidden
            EndContext();
            BeginContext(807, 7, true);
            WriteLiteral("\r\n\t\t\t\t\t");
            EndContext();
            BeginContext(815, 88, false);
#line 22 "C:\Users\ronnie\source\repos\Asp.Net2\Section 10\01\LittlePacktBookstore\LittlePacktBookstore\Views\Home\Register.cshtml"
               Write(Html.TextBox("LastName", "", new { @class = "form-control", placeholder = "Last Name" }));

#line default
#line hidden
            EndContext();
            BeginContext(903, 7, true);
            WriteLiteral("\r\n\t\t\t\t\t");
            EndContext();
            BeginContext(911, 70, false);
#line 23 "C:\Users\ronnie\source\repos\Asp.Net2\Section 10\01\LittlePacktBookstore\LittlePacktBookstore\Views\Home\Register.cshtml"
               Write(Html.ValidationMessage("LastName", "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(981, 49, true);
            WriteLiteral("\r\n\t\t\t\t</div>\r\n\t\t\t\t<div class=\"form-group\">\r\n\t\t\t\t\t");
            EndContext();
            BeginContext(1031, 61, false);
#line 26 "C:\Users\ronnie\source\repos\Asp.Net2\Section 10\01\LittlePacktBookstore\LittlePacktBookstore\Views\Home\Register.cshtml"
               Write(Html.Label("Email", "Email", new { @class = "control-label"}));

#line default
#line hidden
            EndContext();
            BeginContext(1092, 7, true);
            WriteLiteral("\r\n\t\t\t\t\t");
            EndContext();
            BeginContext(1100, 80, false);
#line 27 "C:\Users\ronnie\source\repos\Asp.Net2\Section 10\01\LittlePacktBookstore\LittlePacktBookstore\Views\Home\Register.cshtml"
               Write(Html.TextBox("Email", "", new { @class = "form-control", placeholder = "Email"}));

#line default
#line hidden
            EndContext();
            BeginContext(1180, 7, true);
            WriteLiteral("\r\n\t\t\t\t\t");
            EndContext();
            BeginContext(1188, 67, false);
#line 28 "C:\Users\ronnie\source\repos\Asp.Net2\Section 10\01\LittlePacktBookstore\LittlePacktBookstore\Views\Home\Register.cshtml"
               Write(Html.ValidationMessage("Email", "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(1255, 14, true);
            WriteLiteral("\r\n\t\t\t\t</div>\r\n");
            EndContext();
            BeginContext(3306, 59, false);
#line 60 "C:\Users\ronnie\source\repos\Asp.Net2\Section 10\01\LittlePacktBookstore\LittlePacktBookstore\Views\Home\Register.cshtml"
           Write(await Component.InvokeAsync("Address",Model.MailingAddress));

#line default
#line hidden
            EndContext();
            BeginContext(3367, 113, true);
            WriteLiteral("\t\t\t\t<div class=\"form-group\">\r\n\t\t\t\t\t<input type=\"submit\" value=\"Register\" class=\"btn btn-default\" />\r\n\t\t\t\t</div>\r\n");
            EndContext();
#line 64 "C:\Users\ronnie\source\repos\Asp.Net2\Section 10\01\LittlePacktBookstore\LittlePacktBookstore\Views\Home\Register.cshtml"
			}

#line default
#line hidden
            BeginContext(3486, 27, true);
            WriteLiteral("\t\t</div>\r\n\t</div>\r\n</div>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LittlePacktBookstore.Models.Registration> Html { get; private set; }
    }
}
#pragma warning restore 1591
