#pragma checksum "C:\Users\ronnie\source\repos\Asp.Net2\Section 2\02. End\LittlePacktBookstore\LittlePacktBookstore\Pages\ListBooks.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ce6970bc21fa9ae5f111647ee8a7ee9ab51c236b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_ListBooks), @"mvc.1.0.razor-page", @"/Pages/ListBooks.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/ListBooks.cshtml", typeof(AspNetCore.Pages_ListBooks), null)]
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
#line 1 "C:\Users\ronnie\source\repos\Asp.Net2\Section 2\02. End\LittlePacktBookstore\LittlePacktBookstore\Pages\_ViewImports.cshtml"
using LittlePacktBookstore.Pages;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ce6970bc21fa9ae5f111647ee8a7ee9ab51c236b", @"/Pages/ListBooks.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"406048005780529444e819368f23c71dd84ab402", @"/Pages/_ViewImports.cshtml")]
    public class Pages_ListBooks : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./EditBook", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\ronnie\source\repos\Asp.Net2\Section 2\02. End\LittlePacktBookstore\LittlePacktBookstore\Pages\ListBooks.cshtml"
  
	Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(81, 193, true);
            WriteLiteral("\r\n<div class=\"container\">\r\n\t<div class=\"jumbotron\">\r\n\t\t<h2 class=\"text-center\">List All Books</h2>\r\n\t</div>\r\n\t<div class=\"row\">\r\n\t\t<table class=\"table\">\r\n\t\t\t<thead>\r\n\t\t\t\t<tr>\r\n\t\t\t\t\t<th>\r\n\t\t\t\t\t\t");
            EndContext();
            BeginContext(275, 42, false);
#line 16 "C:\Users\ronnie\source\repos\Asp.Net2\Section 2\02. End\LittlePacktBookstore\LittlePacktBookstore\Pages\ListBooks.cshtml"
                   Write(Html.DisplayNameFor(x => x.Books[0].Title));

#line default
#line hidden
            EndContext();
            BeginContext(317, 31, true);
            WriteLiteral("\r\n\t\t\t\t\t</th>\r\n\t\t\t\t\t<th>\r\n\t\t\t\t\t\t");
            EndContext();
            BeginContext(349, 48, false);
#line 19 "C:\Users\ronnie\source\repos\Asp.Net2\Section 2\02. End\LittlePacktBookstore\LittlePacktBookstore\Pages\ListBooks.cshtml"
                   Write(Html.DisplayNameFor(x => x.Books[0].Description));

#line default
#line hidden
            EndContext();
            BeginContext(397, 31, true);
            WriteLiteral("\r\n\t\t\t\t\t</th>\r\n\t\t\t\t\t<th>\r\n\t\t\t\t\t\t");
            EndContext();
            BeginContext(429, 43, false);
#line 22 "C:\Users\ronnie\source\repos\Asp.Net2\Section 2\02. End\LittlePacktBookstore\LittlePacktBookstore\Pages\ListBooks.cshtml"
                   Write(Html.DisplayNameFor(x => x.Books[0].Author));

#line default
#line hidden
            EndContext();
            BeginContext(472, 31, true);
            WriteLiteral("\r\n\t\t\t\t\t</th>\r\n\t\t\t\t\t<th>\r\n\t\t\t\t\t\t");
            EndContext();
            BeginContext(504, 48, false);
#line 25 "C:\Users\ronnie\source\repos\Asp.Net2\Section 2\02. End\LittlePacktBookstore\LittlePacktBookstore\Pages\ListBooks.cshtml"
                   Write(Html.DisplayNameFor(x => x.Books[0].PublishDate));

#line default
#line hidden
            EndContext();
            BeginContext(552, 31, true);
            WriteLiteral("\r\n\t\t\t\t\t</th>\r\n\t\t\t\t\t<th>\r\n\t\t\t\t\t\t");
            EndContext();
            BeginContext(584, 42, false);
#line 28 "C:\Users\ronnie\source\repos\Asp.Net2\Section 2\02. End\LittlePacktBookstore\LittlePacktBookstore\Pages\ListBooks.cshtml"
                   Write(Html.DisplayNameFor(x => x.Books[0].Price));

#line default
#line hidden
            EndContext();
            BeginContext(626, 31, true);
            WriteLiteral("\r\n\t\t\t\t\t</th>\r\n\t\t\t\t\t<th>\r\n\t\t\t\t\t\t");
            EndContext();
            BeginContext(658, 42, false);
#line 31 "C:\Users\ronnie\source\repos\Asp.Net2\Section 2\02. End\LittlePacktBookstore\LittlePacktBookstore\Pages\ListBooks.cshtml"
                   Write(Html.DisplayNameFor(x => x.Books[0].image));

#line default
#line hidden
            EndContext();
            BeginContext(700, 66, true);
            WriteLiteral("\r\n\t\t\t\t\t</th>\r\n\t\t\t\t\t<th></th>\r\n\t\t\t\t</tr>\r\n\t\t\t</thead>\r\n\t\t\t<tbody>\r\n");
            EndContext();
#line 37 "C:\Users\ronnie\source\repos\Asp.Net2\Section 2\02. End\LittlePacktBookstore\LittlePacktBookstore\Pages\ListBooks.cshtml"
                 foreach (var item in Model.Books)
				{

#line default
#line hidden
            BeginContext(813, 30, true);
            WriteLiteral("\t\t\t\t\t<tr>\r\n\t\t\t\t\t\t<td>\r\n\t\t\t\t\t\t\t");
            EndContext();
            BeginContext(844, 32, false);
#line 41 "C:\Users\ronnie\source\repos\Asp.Net2\Section 2\02. End\LittlePacktBookstore\LittlePacktBookstore\Pages\ListBooks.cshtml"
                       Write(Html.DisplayFor(x => item.Title));

#line default
#line hidden
            EndContext();
            BeginContext(876, 34, true);
            WriteLiteral("\r\n\t\t\t\t\t\t</td>\r\n\t\t\t\t\t\t<td>\r\n\t\t\t\t\t\t\t");
            EndContext();
            BeginContext(911, 38, false);
#line 44 "C:\Users\ronnie\source\repos\Asp.Net2\Section 2\02. End\LittlePacktBookstore\LittlePacktBookstore\Pages\ListBooks.cshtml"
                       Write(Html.DisplayFor(x => item.Description));

#line default
#line hidden
            EndContext();
            BeginContext(949, 34, true);
            WriteLiteral("\r\n\t\t\t\t\t\t</td>\r\n\t\t\t\t\t\t<td>\r\n\t\t\t\t\t\t\t");
            EndContext();
            BeginContext(984, 33, false);
#line 47 "C:\Users\ronnie\source\repos\Asp.Net2\Section 2\02. End\LittlePacktBookstore\LittlePacktBookstore\Pages\ListBooks.cshtml"
                       Write(Html.DisplayFor(x => item.Author));

#line default
#line hidden
            EndContext();
            BeginContext(1017, 34, true);
            WriteLiteral("\r\n\t\t\t\t\t\t</td>\r\n\t\t\t\t\t\t<td>\r\n\t\t\t\t\t\t\t");
            EndContext();
            BeginContext(1052, 38, false);
#line 50 "C:\Users\ronnie\source\repos\Asp.Net2\Section 2\02. End\LittlePacktBookstore\LittlePacktBookstore\Pages\ListBooks.cshtml"
                       Write(Html.DisplayFor(x => item.PublishDate));

#line default
#line hidden
            EndContext();
            BeginContext(1090, 34, true);
            WriteLiteral("\r\n\t\t\t\t\t\t</td>\r\n\t\t\t\t\t\t<td>\r\n\t\t\t\t\t\t\t");
            EndContext();
            BeginContext(1125, 32, false);
#line 53 "C:\Users\ronnie\source\repos\Asp.Net2\Section 2\02. End\LittlePacktBookstore\LittlePacktBookstore\Pages\ListBooks.cshtml"
                       Write(Html.DisplayFor(x => item.Price));

#line default
#line hidden
            EndContext();
            BeginContext(1157, 34, true);
            WriteLiteral("\r\n\t\t\t\t\t\t</td>\r\n\t\t\t\t\t\t<td>\r\n\t\t\t\t\t\t\t");
            EndContext();
            BeginContext(1192, 32, false);
#line 56 "C:\Users\ronnie\source\repos\Asp.Net2\Section 2\02. End\LittlePacktBookstore\LittlePacktBookstore\Pages\ListBooks.cshtml"
                       Write(Html.DisplayFor(x => item.image));

#line default
#line hidden
            EndContext();
            BeginContext(1224, 34, true);
            WriteLiteral("\r\n\t\t\t\t\t\t</td>\r\n\t\t\t\t\t\t<td>\r\n\t\t\t\t\t\t\t");
            EndContext();
            BeginContext(1258, 57, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "04d502c6790e407e983e6152bfb88cc8", async() => {
                BeginContext(1307, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 59 "C:\Users\ronnie\source\repos\Asp.Net2\Section 2\02. End\LittlePacktBookstore\LittlePacktBookstore\Pages\ListBooks.cshtml"
                                                       WriteLiteral(item.Id);

#line default
#line hidden
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
            EndContext();
            BeginContext(1315, 27, true);
            WriteLiteral("\r\n\t\t\t\t\t\t</td>\r\n\t\t\t\t\t</tr>\r\n");
            EndContext();
#line 62 "C:\Users\ronnie\source\repos\Asp.Net2\Section 2\02. End\LittlePacktBookstore\LittlePacktBookstore\Pages\ListBooks.cshtml"
				}

#line default
#line hidden
            BeginContext(1349, 44, true);
            WriteLiteral("\t\t\t</tbody>\r\n\r\n\t\t</table>\r\n\t</div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ListBooksModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ListBooksModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ListBooksModel>)PageContext?.ViewData;
        public ListBooksModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
