#pragma checksum "D:\PROJECTS\Ideo\IdeoTask\IdeoTask\Views\Home\IndexPartialView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e642446a7bdc4a8e555bb8d566b1da5f9570ae13"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(IdeoTask.Services.DTO.Views_Home_IndexPartialView), @"mvc.1.0.view", @"/Views/Home/IndexPartialView.cshtml")]
namespace IdeoTask.Services.DTO
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
#line 1 "D:\PROJECTS\Ideo\IdeoTask\IdeoTask\Views\_ViewImports.cshtml"
using IdeoTask;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\PROJECTS\Ideo\IdeoTask\IdeoTask\Views\_ViewImports.cshtml"
using IdeoTask.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e642446a7bdc4a8e555bb8d566b1da5f9570ae13", @"/Views/Home/IndexPartialView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c161552d92ba033890cb5ed1e79a0f49f95482a7", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_IndexPartialView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IdeoTask.Models.CatalogViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "IndexPartialView", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\PROJECTS\Ideo\IdeoTask\IdeoTask\Views\Home\IndexPartialView.cshtml"
 foreach (var item in Model.BranchList)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <ul>\r\n        <li>\r\n            ");
#nullable restore
#line 7 "D:\PROJECTS\Ideo\IdeoTask\IdeoTask\Views\Home\IndexPartialView.cshtml"
       Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <i class=\"fa fa-angle-right\" aria-hidden=\"true\"></i>\r\n            <i class=\"fa fa-plus-square-o\" aria-hidden=\"true\"></i>\r\n        </li>\r\n\r\n");
#nullable restore
#line 11 "D:\PROJECTS\Ideo\IdeoTask\IdeoTask\Views\Home\IndexPartialView.cshtml"
         if (item.BranchChildren != null)
        {
            CatalogViewModel obj = new CatalogViewModel
            {
                BranchList = item.BranchChildren
            };


#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e642446a7bdc4a8e555bb8d566b1da5f9570ae134390", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 18 "D:\PROJECTS\Ideo\IdeoTask\IdeoTask\Views\Home\IndexPartialView.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = obj;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 19 "D:\PROJECTS\Ideo\IdeoTask\IdeoTask\Views\Home\IndexPartialView.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </ul>\r\n");
#nullable restore
#line 21 "D:\PROJECTS\Ideo\IdeoTask\IdeoTask\Views\Home\IndexPartialView.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IdeoTask.Models.CatalogViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591