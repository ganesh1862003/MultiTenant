#pragma checksum "D:\_OFFICE\_SVN\_SCRUM\_APPLICATION\_VFS\MultiTenant\CODE\UI\MDM_UI\Views\Countries\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "725714a9bf6f87b2835ec6eed524c40bbf9208ab"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Countries_Delete), @"mvc.1.0.view", @"/Views/Countries/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Countries/Delete.cshtml", typeof(AspNetCore.Views_Countries_Delete))]
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
#line 1 "D:\_OFFICE\_SVN\_SCRUM\_APPLICATION\_VFS\MultiTenant\CODE\UI\MDM_UI\Views\_ViewImports.cshtml"
using MDM_UI;

#line default
#line hidden
#line 2 "D:\_OFFICE\_SVN\_SCRUM\_APPLICATION\_VFS\MultiTenant\CODE\UI\MDM_UI\Views\_ViewImports.cshtml"
using MDM_UI.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"725714a9bf6f87b2835ec6eed524c40bbf9208ab", @"/Views/Countries/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"82d1f68e16cba93a92c2b1bc6e24d59677e4532b", @"/Views/_ViewImports.cshtml")]
    public class Views_Countries_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MDM_UI.Models.Country>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(30, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\_OFFICE\_SVN\_SCRUM\_APPLICATION\_VFS\MultiTenant\CODE\UI\MDM_UI\Views\Countries\Delete.cshtml"
  
    ViewData["Title"] = "Delete";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(121, 168, true);
            WriteLiteral("\r\n<h2>Delete</h2>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>Country</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(290, 40, false);
#line 16 "D:\_OFFICE\_SVN\_SCRUM\_APPLICATION\_VFS\MultiTenant\CODE\UI\MDM_UI\Views\Countries\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(330, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(374, 36, false);
#line 19 "D:\_OFFICE\_SVN\_SCRUM\_APPLICATION\_VFS\MultiTenant\CODE\UI\MDM_UI\Views\Countries\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(410, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(454, 40, false);
#line 22 "D:\_OFFICE\_SVN\_SCRUM\_APPLICATION\_VFS\MultiTenant\CODE\UI\MDM_UI\Views\Countries\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Code));

#line default
#line hidden
            EndContext();
            BeginContext(494, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(538, 36, false);
#line 25 "D:\_OFFICE\_SVN\_SCRUM\_APPLICATION\_VFS\MultiTenant\CODE\UI\MDM_UI\Views\Countries\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Code));

#line default
#line hidden
            EndContext();
            BeginContext(574, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(618, 44, false);
#line 28 "D:\_OFFICE\_SVN\_SCRUM\_APPLICATION\_VFS\MultiTenant\CODE\UI\MDM_UI\Views\Countries\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Isocode2));

#line default
#line hidden
            EndContext();
            BeginContext(662, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(706, 40, false);
#line 31 "D:\_OFFICE\_SVN\_SCRUM\_APPLICATION\_VFS\MultiTenant\CODE\UI\MDM_UI\Views\Countries\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Isocode2));

#line default
#line hidden
            EndContext();
            BeginContext(746, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(790, 44, false);
#line 34 "D:\_OFFICE\_SVN\_SCRUM\_APPLICATION\_VFS\MultiTenant\CODE\UI\MDM_UI\Views\Countries\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Isocode3));

#line default
#line hidden
            EndContext();
            BeginContext(834, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(878, 40, false);
#line 37 "D:\_OFFICE\_SVN\_SCRUM\_APPLICATION\_VFS\MultiTenant\CODE\UI\MDM_UI\Views\Countries\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Isocode3));

#line default
#line hidden
            EndContext();
            BeginContext(918, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(962, 44, false);
#line 40 "D:\_OFFICE\_SVN\_SCRUM\_APPLICATION\_VFS\MultiTenant\CODE\UI\MDM_UI\Views\Countries\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.DialCode));

#line default
#line hidden
            EndContext();
            BeginContext(1006, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1050, 40, false);
#line 43 "D:\_OFFICE\_SVN\_SCRUM\_APPLICATION\_VFS\MultiTenant\CODE\UI\MDM_UI\Views\Countries\Delete.cshtml"
       Write(Html.DisplayFor(model => model.DialCode));

#line default
#line hidden
            EndContext();
            BeginContext(1090, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1134, 47, false);
#line 46 "D:\_OFFICE\_SVN\_SCRUM\_APPLICATION\_VFS\MultiTenant\CODE\UI\MDM_UI\Views\Countries\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Nationality));

#line default
#line hidden
            EndContext();
            BeginContext(1181, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1225, 43, false);
#line 49 "D:\_OFFICE\_SVN\_SCRUM\_APPLICATION\_VFS\MultiTenant\CODE\UI\MDM_UI\Views\Countries\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Nationality));

#line default
#line hidden
            EndContext();
            BeginContext(1268, 38, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    \r\n    ");
            EndContext();
            BeginContext(1306, 207, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b655f301ce964ea6a476475156d46168", async() => {
                BeginContext(1332, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(1342, 36, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "1a07cf2d2180495cb361878e59b9bb4e", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 54 "D:\_OFFICE\_SVN\_SCRUM\_APPLICATION\_VFS\MultiTenant\CODE\UI\MDM_UI\Views\Countries\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Id);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1378, 84, true);
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-default\" /> |\r\n        ");
                EndContext();
                BeginContext(1462, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f14317b37b8e4d50bc94de2e37139ced", async() => {
                    BeginContext(1484, 12, true);
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
                BeginContext(1500, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1513, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MDM_UI.Models.Country> Html { get; private set; }
    }
}
#pragma warning restore 1591
