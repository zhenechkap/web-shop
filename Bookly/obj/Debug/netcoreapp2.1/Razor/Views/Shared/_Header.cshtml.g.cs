#pragma checksum "C:\Users\ronnie\source\repos\Asp.Net2\Section 10\01\LittlePacktBookstore\LittlePacktBookstore\Views\Shared\_Header.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "87cd33f0fc7afed774924c43e8f597df12998fa9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Header), @"mvc.1.0.view", @"/Views/Shared/_Header.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_Header.cshtml", typeof(AspNetCore.Views_Shared__Header))]
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
#line 1 "C:\Users\ronnie\source\repos\Asp.Net2\Section 10\01\LittlePacktBookstore\LittlePacktBookstore\Views\Shared\_Header.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"87cd33f0fc7afed774924c43e8f597df12998fa9", @"/Views/Shared/_Header.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6d92cb761646fb4d9f41c0d674984d9b6dc823bc", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Header : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("dropdown-item"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "profile", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "user", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "changepassword", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
#line 3 "C:\Users\ronnie\source\repos\Asp.Net2\Section 10\01\LittlePacktBookstore\LittlePacktBookstore\Views\Shared\_Header.cshtml"
   
	var user = userManager.Users.FirstOrDefault(x => x.Email == User.Identity.Name);

#line default
#line hidden
            BeginContext(172, 554, true);
            WriteLiteral(@"<header>
	<nav class=""navbar navbar-expand-md navbar-dark fixed-top bg-dark"">
		<a class=""navbar-brand"" href=""/home/index"">LittlePackt BookStore</a>
		<button class=""navbar-toggler"" type=""button"" data-toggle=""collapse"" data-target=""#navbarCollapse"" aria-controls=""navbarCollapse"" aria-expanded=""false"" aria-label=""Toggle navigation"">
			<span class=""navbar-toggler-icon""></span>
		</button>
		<div class=""collapse navbar-collapse"" id=""navbarCollapse"">
			<ul class=""navbar-nav mr-auto"">
				<li class=""nav-item "">
					<a class=""nav-link active""");
            EndContext();
            BeginWriteAttribute("href", " href=", 726, "", 759, 1);
#line 15 "C:\Users\ronnie\source\repos\Asp.Net2\Section 10\01\LittlePacktBookstore\LittlePacktBookstore\Views\Shared\_Header.cshtml"
WriteAttributeValue("", 732, Url.Action("Index","Home"), 732, 27, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(759, 491, true);
            WriteLiteral(@">Home<span class=""sr-only"">(current)</span></a>
				</li>
				<li class=""nav-item"">
					<a class=""nav-link"" href=""#"">About Us</a>
				</li>
				<li class=""nav-item"">
					<a class=""nav-link"" href=""#"">Contact</a>
				</li>
			</ul>
		</div>
		<ul class=""navbar-nav mr-auto float-right"">
			<li class=""nav-item dropdown no-arrow"">
				<a class=""nav-link dropdown-toggle"" href=""#"" id=""userDropdown"" role=""button"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
");
            EndContext();
#line 28 "C:\Users\ronnie\source\repos\Asp.Net2\Section 10\01\LittlePacktBookstore\LittlePacktBookstore\Views\Shared\_Header.cshtml"
                     if (!User.Identity.IsAuthenticated)
					{

#line default
#line hidden
            BeginContext(1301, 41, true);
            WriteLiteral("\t\t\t\t\t\t<i class=\"fa fa-sign-in-alt\"></i>\r\n");
            EndContext();
#line 31 "C:\Users\ronnie\source\repos\Asp.Net2\Section 10\01\LittlePacktBookstore\LittlePacktBookstore\Views\Shared\_Header.cshtml"
					}
					else
					{

#line default
#line hidden
            BeginContext(1369, 48, true);
            WriteLiteral("\t\t\t\t\t\t<i class=\"fas fa-user-circle fa-fw\"></i>\r\n");
            EndContext();
#line 35 "C:\Users\ronnie\source\repos\Asp.Net2\Section 10\01\LittlePacktBookstore\LittlePacktBookstore\Views\Shared\_Header.cshtml"
					}

#line default
#line hidden
            BeginContext(1425, 94, true);
            WriteLiteral("\t\t\t\t</a>\r\n\t\t\t\t<div class=\"dropdown-menu dropdown-menu-right\" aria-labelledby=\"userDropdown\">\r\n");
            EndContext();
#line 38 "C:\Users\ronnie\source\repos\Asp.Net2\Section 10\01\LittlePacktBookstore\LittlePacktBookstore\Views\Shared\_Header.cshtml"
                     if (User.Identity.IsAuthenticated)
					{

#line default
#line hidden
            BeginContext(1569, 52, true);
            WriteLiteral("\t\t\t\t\t\t<div class=\"text-center\"><label>Hello <strong>");
            EndContext();
            BeginContext(1622, 14, false);
#line 40 "C:\Users\ronnie\source\repos\Asp.Net2\Section 10\01\LittlePacktBookstore\LittlePacktBookstore\Views\Shared\_Header.cshtml"
                                                                 Write(user.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(1636, 31, true);
            WriteLiteral("</strong></label></div>\r\n\t\t\t\t\t\t");
            EndContext();
            BeginContext(1667, 133, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d90844d889ac4bdb9a16be46fd5f7ecf", async() => {
                BeginContext(1735, 61, true);
                WriteLiteral("\r\n\t\t\t\t\t\t\t<span class=\"fa fa-user-alt\"></span> Profile\r\n\t\t\t\t\t\t");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1800, 8, true);
            WriteLiteral("\r\n\t\t\t\t\t\t");
            EndContext();
            BeginContext(1808, 143, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "545045d1218f40ec83290ca145481598", async() => {
                BeginContext(1883, 64, true);
                WriteLiteral("\r\n\t\t\t\t\t\t\t<span class=\"fa fa-key\"></span> Change Password\r\n\t\t\t\t\t\t");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1951, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(1957, 44, true);
            WriteLiteral("\t\t\t\t\t\t<div class=\"dropdown-divider\"></div>\r\n");
            EndContext();
#line 50 "C:\Users\ronnie\source\repos\Asp.Net2\Section 10\01\LittlePacktBookstore\LittlePacktBookstore\Views\Shared\_Header.cshtml"
                         if (User.IsInRole("Admin"))
						{

#line default
#line hidden
            BeginContext(2046, 7, true);
            WriteLiteral("\t\t\t\t\t\t\t");
            EndContext();
            BeginContext(2053, 81, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "162a5d9f62e84b4191051f49f49cc9ed", async() => {
                BeginContext(2120, 10, true);
                WriteLiteral("Admin Page");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2134, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 53 "C:\Users\ronnie\source\repos\Asp.Net2\Section 10\01\LittlePacktBookstore\LittlePacktBookstore\Views\Shared\_Header.cshtml"
						}

#line default
#line hidden
            BeginContext(2147, 30, true);
            WriteLiteral("\t\t\t\t\t\t<a class=\"dropdown-item\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2177, "\"", 2216, 1);
#line 55 "C:\Users\ronnie\source\repos\Asp.Net2\Section 10\01\LittlePacktBookstore\LittlePacktBookstore\Views\Shared\_Header.cshtml"
WriteAttributeValue("", 2184, Url.Action("logout", "Account"), 2184, 32, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2217, 101, true);
            WriteLiteral(" data-toggle=\"modal\" data-target=\"#logoutModal\"><span class=\"fa fa-sign-out-alt\"> Logout</span></a>\r\n");
            EndContext();
#line 56 "C:\Users\ronnie\source\repos\Asp.Net2\Section 10\01\LittlePacktBookstore\LittlePacktBookstore\Views\Shared\_Header.cshtml"
					}
					else
					{

#line default
#line hidden
            BeginContext(2345, 30, true);
            WriteLiteral("\t\t\t\t\t\t<a class=\"dropdown-item\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2375, "\"", 2413, 1);
#line 59 "C:\Users\ronnie\source\repos\Asp.Net2\Section 10\01\LittlePacktBookstore\LittlePacktBookstore\Views\Shared\_Header.cshtml"
WriteAttributeValue("", 2382, Url.Action("login", "Account"), 2382, 31, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2414, 69, true);
            WriteLiteral(">\r\n\t\t\t\t\t\t\t<span class=\"fa fa-sign-in-alt\"></span> Login\r\n\t\t\t\t\t\t</a>\r\n");
            EndContext();
#line 62 "C:\Users\ronnie\source\repos\Asp.Net2\Section 10\01\LittlePacktBookstore\LittlePacktBookstore\Views\Shared\_Header.cshtml"
					}

#line default
#line hidden
            BeginContext(2491, 51, true);
            WriteLiteral("\t\t\t\t</div>\r\n\t\t\t</li>\r\n\t\t</ul>\r\n\t</nav>\r\n</header>\r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<SiteUser> userManager { get; private set; }
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
