#pragma checksum "C:\Users\ronnie\source\repos\Asp.Net2\Section 10\02\LittlePacktBookstore\LittlePacktBookstore\Views\User\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f416cbcc24c99468284981d1086cdd89f38faa8a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_Details), @"mvc.1.0.view", @"/Views/User/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/User/Details.cshtml", typeof(AspNetCore.Views_User_Details))]
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
#line 1 "C:\Users\ronnie\source\repos\Asp.Net2\Section 10\02\LittlePacktBookstore\LittlePacktBookstore\Views\_ViewImports.cshtml"
using LittlePacktBookstore.ViewModels;

#line default
#line hidden
#line 2 "C:\Users\ronnie\source\repos\Asp.Net2\Section 10\02\LittlePacktBookstore\LittlePacktBookstore\Views\_ViewImports.cshtml"
using LittlePacktBookstore.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f416cbcc24c99468284981d1086cdd89f38faa8a", @"/Views/User/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6d92cb761646fb4d9f41c0d674984d9b6dc823bc", @"/Views/_ViewImports.cshtml")]
    public class Views_User_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LittlePacktBookstore.ViewModels.UserViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\ronnie\source\repos\Asp.Net2\Section 10\02\LittlePacktBookstore\LittlePacktBookstore\Views\User\Details.cshtml"
  
	ViewData["Title"] = "Details";
	Layout = "~/Views/Shared/admin/_AdminLayout.cshtml";

#line default
#line hidden
            BeginContext(149, 108, true);
            WriteLiteral("\r\n<h2>Details</h2>\r\n<div class=\"container\">\r\n\t<div class=\"row\">\r\n\t\t<dl class=\"dl-horizontal\">\r\n\t\t\t<dt>\r\n\t\t\t\t");
            EndContext();
            BeginContext(258, 45, false);
#line 12 "C:\Users\ronnie\source\repos\Asp.Net2\Section 10\02\LittlePacktBookstore\LittlePacktBookstore\Views\User\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(303, 25, true);
            WriteLiteral("\r\n\t\t\t</dt>\r\n\t\t\t<dd>\r\n\t\t\t\t");
            EndContext();
            BeginContext(329, 41, false);
#line 15 "C:\Users\ronnie\source\repos\Asp.Net2\Section 10\02\LittlePacktBookstore\LittlePacktBookstore\Views\User\Details.cshtml"
           Write(Html.DisplayFor(model => model.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(370, 25, true);
            WriteLiteral("\r\n\t\t\t</dd>\r\n\t\t\t<dt>\r\n\t\t\t\t");
            EndContext();
            BeginContext(396, 44, false);
#line 18 "C:\Users\ronnie\source\repos\Asp.Net2\Section 10\02\LittlePacktBookstore\LittlePacktBookstore\Views\User\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(440, 25, true);
            WriteLiteral("\r\n\t\t\t</dt>\r\n\t\t\t<dd>\r\n\t\t\t\t");
            EndContext();
            BeginContext(466, 40, false);
#line 21 "C:\Users\ronnie\source\repos\Asp.Net2\Section 10\02\LittlePacktBookstore\LittlePacktBookstore\Views\User\Details.cshtml"
           Write(Html.DisplayFor(model => model.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(506, 25, true);
            WriteLiteral("\r\n\t\t\t</dd>\r\n\t\t\t<dt>\r\n\t\t\t\t");
            EndContext();
            BeginContext(532, 41, false);
#line 24 "C:\Users\ronnie\source\repos\Asp.Net2\Section 10\02\LittlePacktBookstore\LittlePacktBookstore\Views\User\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(573, 25, true);
            WriteLiteral("\r\n\t\t\t</dt>\r\n\t\t\t<dd>\r\n\t\t\t\t");
            EndContext();
            BeginContext(599, 37, false);
#line 27 "C:\Users\ronnie\source\repos\Asp.Net2\Section 10\02\LittlePacktBookstore\LittlePacktBookstore\Views\User\Details.cshtml"
           Write(Html.DisplayFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(636, 25, true);
            WriteLiteral("\r\n\t\t\t</dd>\r\n\t\t\t<dt>\r\n\t\t\t\t");
            EndContext();
            BeginContext(662, 41, false);
#line 30 "C:\Users\ronnie\source\repos\Asp.Net2\Section 10\02\LittlePacktBookstore\LittlePacktBookstore\Views\User\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Phone));

#line default
#line hidden
            EndContext();
            BeginContext(703, 25, true);
            WriteLiteral("\r\n\t\t\t</dt>\r\n\t\t\t<dd>\r\n\t\t\t\t");
            EndContext();
            BeginContext(729, 37, false);
#line 33 "C:\Users\ronnie\source\repos\Asp.Net2\Section 10\02\LittlePacktBookstore\LittlePacktBookstore\Views\User\Details.cshtml"
           Write(Html.DisplayFor(model => model.Phone));

#line default
#line hidden
            EndContext();
            BeginContext(766, 148, true);
            WriteLiteral("\r\n\t\t\t</dd>\r\n\t\t</dl>\r\n\t</div>\r\n\t<div class=\"container\">\r\n\t\t<div class=\"row\">\r\n\t\t\t<label>User in the roles</label>\r\n\t\t</div>\r\n\t\t<div class=\"row\">\r\n\t\t\t");
            EndContext();
            BeginContext(914, 427, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8512f4716b1d43388b4337496a1d4904", async() => {
                BeginContext(941, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 43 "C:\Users\ronnie\source\repos\Asp.Net2\Section 10\02\LittlePacktBookstore\LittlePacktBookstore\Views\User\Details.cshtml"
                 for (int i = 0; i < Model.UserInRoles.Count; i++)
				{

#line default
#line hidden
                BeginContext(1006, 18, true);
                WriteLiteral("\t\t\t\t\t<div>\r\n\t\t\t\t\t\t");
                EndContext();
                BeginContext(1025, 44, false);
#line 46 "C:\Users\ronnie\source\repos\Asp.Net2\Section 10\02\LittlePacktBookstore\LittlePacktBookstore\Views\User\Details.cshtml"
                   Write(Html.HiddenFor(x => Model.UserInRoles[i].Id));

#line default
#line hidden
                EndContext();
                BeginContext(1069, 8, true);
                WriteLiteral("\r\n\t\t\t\t\t\t");
                EndContext();
                BeginContext(1078, 89, false);
#line 47 "C:\Users\ronnie\source\repos\Asp.Net2\Section 10\02\LittlePacktBookstore\LittlePacktBookstore\Views\User\Details.cshtml"
                   Write(Html.CheckBoxFor(x => Model.UserInRoles[i].Selected, new { @class = "form-check-input" }));

#line default
#line hidden
                EndContext();
                BeginContext(1167, 40, true);
                WriteLiteral("\r\n\t\t\t\t\t\t<label class=\"form-check-label\">");
                EndContext();
                BeginContext(1208, 25, false);
#line 48 "C:\Users\ronnie\source\repos\Asp.Net2\Section 10\02\LittlePacktBookstore\LittlePacktBookstore\Views\User\Details.cshtml"
                                                   Write(Model.UserInRoles[i].Name);

#line default
#line hidden
                EndContext();
                BeginContext(1233, 23, true);
                WriteLiteral("</label>\r\n\t\t\t\t\t</div>\r\n");
                EndContext();
#line 50 "C:\Users\ronnie\source\repos\Asp.Net2\Section 10\02\LittlePacktBookstore\LittlePacktBookstore\Views\User\Details.cshtml"
				}

#line default
#line hidden
                BeginContext(1263, 71, true);
                WriteLiteral("\t\t\t\t<input type=\"submit\" value=\"Update\" class=\"btn btn-success\" />\r\n\t\t\t");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1341, 37, true);
            WriteLiteral("\r\n\t\t</div>\r\n\t</div>\r\n</div>\r\n<div>\r\n\t");
            EndContext();
            BeginContext(1378, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c7406e08a5e44abf8272ac9755b84544", async() => {
                BeginContext(1400, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1416, 12, true);
            WriteLiteral("\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LittlePacktBookstore.ViewModels.UserViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591