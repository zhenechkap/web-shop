#pragma checksum "C:\Users\ronnie\source\repos\Asp.Net2\Section 10\01\LittlePacktBookstore\LittlePacktBookstore\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d8f417c32c1a4ba4d5b946727a4ded090266a1ff"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d8f417c32c1a4ba4d5b946727a4ded090266a1ff", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6d92cb761646fb4d9f41c0d674984d9b6dc823bc", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeIndexViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img img-rounded"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("140"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\ronnie\source\repos\Asp.Net2\Section 10\01\LittlePacktBookstore\LittlePacktBookstore\Views\Home\Index.cshtml"
  
	ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(65, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(68, 42, false);
#line 6 "C:\Users\ronnie\source\repos\Asp.Net2\Section 10\01\LittlePacktBookstore\LittlePacktBookstore\Views\Home\Index.cshtml"
Write(Html.Partial("_Carousel", Model.Carousels));

#line default
#line hidden
            EndContext();
            BeginContext(110, 106, true);
            WriteLiteral("\r\n\r\n<h2 class=\"text text-center\">Books\' List</h2>\r\n<div class=\"container marketing\">\r\n\t<div class=\"row\">\r\n");
            EndContext();
#line 11 "C:\Users\ronnie\source\repos\Asp.Net2\Section 10\01\LittlePacktBookstore\LittlePacktBookstore\Views\Home\Index.cshtml"
         foreach (var item in Model.Books)
		{

#line default
#line hidden
            BeginContext(259, 31, true);
            WriteLiteral("\t\t\t<div class=\"col-lg-4\">\r\n\t\t\t\t");
            EndContext();
            BeginContext(290, 86, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "2bafb458aa594a3795df7c294122ce25", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 324, "~/Images/", 324, 9, true);
#line 14 "C:\Users\ronnie\source\repos\Asp.Net2\Section 10\01\LittlePacktBookstore\LittlePacktBookstore\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 333, item.image, 333, 11, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 14 "C:\Users\ronnie\source\repos\Asp.Net2\Section 10\01\LittlePacktBookstore\LittlePacktBookstore\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 351, item.Title, 351, 11, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(376, 10, true);
            WriteLiteral("\r\n\t\t\t\t<h5>");
            EndContext();
            BeginContext(387, 10, false);
#line 15 "C:\Users\ronnie\source\repos\Asp.Net2\Section 10\01\LittlePacktBookstore\LittlePacktBookstore\Views\Home\Index.cshtml"
               Write(item.Title);

#line default
#line hidden
            EndContext();
            BeginContext(397, 42, true);
            WriteLiteral("</h5>\r\n\t\t\t\t<p><a class=\"btn btn-secondary\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 439, "\"", 468, 2);
            WriteAttributeValue("", 446, "/home/details/", 446, 14, true);
#line 16 "C:\Users\ronnie\source\repos\Asp.Net2\Section 10\01\LittlePacktBookstore\LittlePacktBookstore\Views\Home\Index.cshtml"
WriteAttributeValue("", 460, item.Id, 460, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(469, 69, true);
            WriteLiteral(" role=\"button\">View details »</a></p>\r\n\t\t\t</div><!-- /.col-lg-4 -->\r\n");
            EndContext();
#line 18 "C:\Users\ronnie\source\repos\Asp.Net2\Section 10\01\LittlePacktBookstore\LittlePacktBookstore\Views\Home\Index.cshtml"
		}

#line default
#line hidden
            BeginContext(543, 15, true);
            WriteLiteral("\t</div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomeIndexViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
