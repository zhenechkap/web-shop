#pragma checksum "C:\Users\ronnie\source\repos\Asp.Net2\Section 4\02. End\LittlePacktBookstore\LittlePacktBookstore\Views\Shared\admin\_Header.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "db010c8d3d1ec3749c690805383898379c4d1c1a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_admin__Header), @"mvc.1.0.view", @"/Views/Shared/admin/_Header.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/admin/_Header.cshtml", typeof(AspNetCore.Views_Shared_admin__Header))]
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
#line 1 "C:\Users\ronnie\source\repos\Asp.Net2\Section 4\02. End\LittlePacktBookstore\LittlePacktBookstore\Views\_ViewImports.cshtml"
using LittlePacktBookstore.ViewModels;

#line default
#line hidden
#line 2 "C:\Users\ronnie\source\repos\Asp.Net2\Section 4\02. End\LittlePacktBookstore\LittlePacktBookstore\Views\_ViewImports.cshtml"
using LittlePacktBookstore.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"db010c8d3d1ec3749c690805383898379c4d1c1a", @"/Views/Shared/admin/_Header.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6d92cb761646fb4d9f41c0d674984d9b6dc823bc", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_admin__Header : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2186, true);
            WriteLiteral(@"<nav class=""navbar navbar-expand navbar-dark bg-dark static-top"">
	<a class=""navbar-brand mr-1"" href=""index.html"">LiitlePackt Bookstore</a>
	<button class=""btn btn-link btn-sm text-white order-1 order-sm-0"" id=""sidebarToggle"" href=""#"">
		<i class=""fas fa-bars""></i>
	</button>
	
	<!-- Navbar -->
	<ul class=""navbar-nav ml-auto ml-md-0"">
		<li class=""nav-item dropdown no-arrow mx-1"">
			<a class=""nav-link dropdown-toggle"" href=""#"" id=""alertsDropdown"" role=""button"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
				<i class=""fas fa-bell fa-fw""></i>
				<span class=""badge badge-danger"">9+</span>
			</a>
			<div class=""dropdown-menu dropdown-menu-right"" aria-labelledby=""alertsDropdown"">
				<a class=""dropdown-item"" href=""#"">Action</a>
				<a class=""dropdown-item"" href=""#"">Another action</a>
				<div class=""dropdown-divider""></div>
				<a class=""dropdown-item"" href=""#"">Something else here</a>
			</div>
		</li>
		<li class=""nav-item dropdown no-arrow mx-1"">
			<a class=""nav-li");
            WriteLiteral(@"nk dropdown-toggle"" href=""#"" id=""messagesDropdown"" role=""button"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
				<i class=""fas fa-envelope fa-fw""></i>
				<span class=""badge badge-danger"">7</span>
			</a>
			<div class=""dropdown-menu dropdown-menu-right"" aria-labelledby=""messagesDropdown"">
				<a class=""dropdown-item"" href=""#"">Action</a>
				<a class=""dropdown-item"" href=""#"">Another action</a>
				<div class=""dropdown-divider""></div>
				<a class=""dropdown-item"" href=""#"">Something else here</a>
			</div>
		</li>
		<li class=""nav-item dropdown no-arrow"">
			<a class=""nav-link dropdown-toggle"" href=""#"" id=""userDropdown"" role=""button"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
				<i class=""fas fa-user-circle fa-fw""></i>
			</a>
			<div class=""dropdown-menu dropdown-menu-right"" aria-labelledby=""userDropdown"">
				<a class=""dropdown-item"" href=""#"">Settings</a>
				<a class=""dropdown-item"" href=""#"">Activity Log</a>
				<div class=""dropdown-divider""><");
            WriteLiteral("/div>\r\n\t\t\t\t<a class=\"dropdown-item\" href=\"#\" data-toggle=\"modal\" data-target=\"#logoutModal\">Logout</a>\r\n\t\t\t</div>\r\n\t\t</li>\r\n\t</ul>\r\n</nav>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
