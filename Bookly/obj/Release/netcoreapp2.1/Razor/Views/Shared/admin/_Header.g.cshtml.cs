#pragma checksum "/Users/alexvahrusev/workspace/web-shop/Bookly/Views/Shared/admin/_Header.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aaa191abde409509c7048bcb33d7b8676f1669b8"
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
#line 1 "/Users/alexvahrusev/workspace/web-shop/Bookly/Views/_ViewImports.cshtml"
using Bookly.ViewModels;

#line default
#line hidden
#line 2 "/Users/alexvahrusev/workspace/web-shop/Bookly/Views/_ViewImports.cshtml"
using Bookly.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aaa191abde409509c7048bcb33d7b8676f1669b8", @"/Views/Shared/admin/_Header.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6315c3d512eb2553a2f3337827c50f3ae9766e1d", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_admin__Header : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2281, true);
            WriteLiteral(@"<nav class=""navbar navbar-expand navbar-dark bg-dark static-top"">
	<a class=""navbar-brand mr-1"" href=""index.html"">LiitlePackt Bookstore</a>
	<button class=""btn btn-link btn-sm text-white order-1 order-sm-0"" id=""sidebarToggle"" href=""#"">
		<i class=""fas fa-bars""></i>
	</button>

	<!-- Navbar -->
	<div class=""ml-auto mr-0 mr-md-3 my-2 my-md-0"">
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
			<l");
            WriteLiteral(@"i class=""nav-item dropdown no-arrow mx-1"">
				<a class=""nav-link dropdown-toggle"" href=""#"" id=""messagesDropdown"" role=""button"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
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
					<a cla");
            WriteLiteral("ss=\"dropdown-item\" href=\"#\">Activity Log</a>\r\n\t\t\t\t\t<div class=\"dropdown-divider\"></div>\r\n\t\t\t\t\t<a class=\"dropdown-item\" href=\"#\" data-toggle=\"modal\" data-target=\"#logoutModal\">Logout</a>\r\n\t\t\t\t</div>\r\n\t\t\t</li>\r\n\t\t</ul>\r\n\t</div>\r\n</nav>");
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