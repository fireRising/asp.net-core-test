#pragma checksum "/Users/firerising/Projects/ClassifProject/Views/Home/DeleteSpeciality.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f144b7a0fa7cabac5e4d8c6e0e6acdacdb514bf7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_DeleteSpeciality), @"mvc.1.0.view", @"/Views/Home/DeleteSpeciality.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/DeleteSpeciality.cshtml", typeof(AspNetCore.Views_Home_DeleteSpeciality))]
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
#line 1 "/Users/firerising/Projects/ClassifProject/Views/_ViewImports.cshtml"
using ClassifProject;

#line default
#line hidden
#line 2 "/Users/firerising/Projects/ClassifProject/Views/_ViewImports.cshtml"
using ClassifProject.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f144b7a0fa7cabac5e4d8c6e0e6acdacdb514bf7", @"/Views/Home/DeleteSpeciality.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"891674d0947b95de12326091a50fd498c64ac1a3", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_DeleteSpeciality : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ClassifProject.Models.Specialties>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteSpeciality", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "/Users/firerising/Projects/ClassifProject/Views/Home/DeleteSpeciality.cshtml"
  
    ViewData["Title"] = "Delete Speciality";

#line default
#line hidden
            BeginContext(95, 477, true);
            WriteLiteral(@"
<div>
    <table class=""table"">
        <thead>
            <tr>
                <th scope=""col"">Id</th>
                <th scope=""col"">Code spec</th>
                <th scope=""col"">Name spec</th>
                <th scope=""col"">Id Enlarged Group</th>
                <th scope=""col"">Id classifier</th>
                <th scope=""col"">Id Education Level</th>
            </tr>
        </thead>
        <tbody>
            <tr>
                <td scope=""row"">");
            EndContext();
            BeginContext(573, 13, false);
#line 20 "/Users/firerising/Projects/ClassifProject/Views/Home/DeleteSpeciality.cshtml"
                           Write(Model.id_spec);

#line default
#line hidden
            EndContext();
            BeginContext(586, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(614, 15, false);
#line 21 "/Users/firerising/Projects/ClassifProject/Views/Home/DeleteSpeciality.cshtml"
               Write(Model.code_spec);

#line default
#line hidden
            EndContext();
            BeginContext(629, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(657, 15, false);
#line 22 "/Users/firerising/Projects/ClassifProject/Views/Home/DeleteSpeciality.cshtml"
               Write(Model.name_spec);

#line default
#line hidden
            EndContext();
            BeginContext(672, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(700, 13, false);
#line 23 "/Users/firerising/Projects/ClassifProject/Views/Home/DeleteSpeciality.cshtml"
               Write(Model.id_engr);

#line default
#line hidden
            EndContext();
            BeginContext(713, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(741, 14, false);
#line 24 "/Users/firerising/Projects/ClassifProject/Views/Home/DeleteSpeciality.cshtml"
               Write(Model.id_class);

#line default
#line hidden
            EndContext();
            BeginContext(755, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(783, 15, false);
#line 25 "/Users/firerising/Projects/ClassifProject/Views/Home/DeleteSpeciality.cshtml"
               Write(Model.id_edulvl);

#line default
#line hidden
            EndContext();
            BeginContext(798, 77, true);
            WriteLiteral("</td>\r\n            </tr>\r\n        </tbody>\r\n    </table>\r\n    <div>\r\n        ");
            EndContext();
            BeginContext(875, 228, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c4909595e8894bc881a5d80e6fda338a", async() => {
                BeginContext(947, 149, true);
                WriteLiteral("\r\n            <div class=\"form-group\">\r\n                <input type=\"submit\" class=\"btn btn-default\" value=\"Удалить\" />\r\n            </div>\r\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1103, 20, true);
            WriteLiteral("\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ClassifProject.Models.Specialties> Html { get; private set; }
    }
}
#pragma warning restore 1591
