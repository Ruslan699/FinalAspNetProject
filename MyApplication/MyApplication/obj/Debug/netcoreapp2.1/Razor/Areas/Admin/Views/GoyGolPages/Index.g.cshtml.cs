#pragma checksum "C:\Users\User\source\repos\MyApplication\MyApplication\Areas\Admin\Views\GoyGolPages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b9460d95c53e8a11135de611299ed1668d946022"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_GoyGolPages_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/GoyGolPages/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/GoyGolPages/Index.cshtml", typeof(AspNetCore.Areas_Admin_Views_GoyGolPages_Index))]
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
#line 1 "C:\Users\User\source\repos\MyApplication\MyApplication\Areas\Admin\Views\_ViewImports.cshtml"
using MyApplication.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b9460d95c53e8a11135de611299ed1668d946022", @"/Areas/Admin/Views/GoyGolPages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2120c96a385f5d4cca84fc368fa2fffbd127b30d", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_GoyGolPages_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MyApplication.Models.GoyGolPage>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(53, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\User\source\repos\MyApplication\MyApplication\Areas\Admin\Views\GoyGolPages\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Areas/Admin/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(155, 235, true);
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-lg-12\">\r\n        <h1 class=\"page-header\">GoyGol Page</h1>\r\n    </div>\r\n    <!-- /.col-lg-12 -->\r\n</div>\r\n<!-- /.row -->\r\n<div class=\"row\">\r\n    <div class=\"col-lg-12\">\r\n        <p>\r\n            ");
            EndContext();
            BeginContext(390, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c126eb66fa674ac985246575673b9326", async() => {
                BeginContext(413, 10, true);
                WriteLiteral("Create New");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(427, 154, true);
            WriteLiteral("\r\n        </p>\r\n        <table class=\"table table-striped\">\r\n            <thead>\r\n                <tr>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(582, 45, false);
#line 24 "C:\Users\User\source\repos\MyApplication\MyApplication\Areas\Admin\Views\GoyGolPages\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.ImagePath));

#line default
#line hidden
            EndContext();
            BeginContext(627, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(707, 45, false);
#line 27 "C:\Users\User\source\repos\MyApplication\MyApplication\Areas\Admin\Views\GoyGolPages\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.ImageText));

#line default
#line hidden
            EndContext();
            BeginContext(752, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(832, 41, false);
#line 30 "C:\Users\User\source\repos\MyApplication\MyApplication\Areas\Admin\Views\GoyGolPages\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Title));

#line default
#line hidden
            EndContext();
            BeginContext(873, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(953, 44, false);
#line 33 "C:\Users\User\source\repos\MyApplication\MyApplication\Areas\Admin\Views\GoyGolPages\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.SubTitle));

#line default
#line hidden
            EndContext();
            BeginContext(997, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(1077, 44, false);
#line 36 "C:\Users\User\source\repos\MyApplication\MyApplication\Areas\Admin\Views\GoyGolPages\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Duration));

#line default
#line hidden
            EndContext();
            BeginContext(1121, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(1201, 40, false);
#line 39 "C:\Users\User\source\repos\MyApplication\MyApplication\Areas\Admin\Views\GoyGolPages\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Code));

#line default
#line hidden
            EndContext();
            BeginContext(1241, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(1321, 41, false);
#line 42 "C:\Users\User\source\repos\MyApplication\MyApplication\Areas\Admin\Views\GoyGolPages\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Price));

#line default
#line hidden
            EndContext();
            BeginContext(1362, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(1442, 49, false);
#line 45 "C:\Users\User\source\repos\MyApplication\MyApplication\Areas\Admin\Views\GoyGolPages\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.AboutTourText));

#line default
#line hidden
            EndContext();
            BeginContext(1491, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(1571, 51, false);
#line 48 "C:\Users\User\source\repos\MyApplication\MyApplication\Areas\Admin\Views\GoyGolPages\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.AboutTourNumber));

#line default
#line hidden
            EndContext();
            BeginContext(1622, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(1702, 45, false);
#line 51 "C:\Users\User\source\repos\MyApplication\MyApplication\Areas\Admin\Views\GoyGolPages\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.TourImage));

#line default
#line hidden
            EndContext();
            BeginContext(1747, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(1827, 44, false);
#line 54 "C:\Users\User\source\repos\MyApplication\MyApplication\Areas\Admin\Views\GoyGolPages\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.TourName));

#line default
#line hidden
            EndContext();
            BeginContext(1871, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(1951, 51, false);
#line 57 "C:\Users\User\source\repos\MyApplication\MyApplication\Areas\Admin\Views\GoyGolPages\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.TourInformation));

#line default
#line hidden
            EndContext();
            BeginContext(2002, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(2082, 45, false);
#line 60 "C:\Users\User\source\repos\MyApplication\MyApplication\Areas\Admin\Views\GoyGolPages\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.TourVideo));

#line default
#line hidden
            EndContext();
            BeginContext(2127, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(2207, 47, false);
#line 63 "C:\Users\User\source\repos\MyApplication\MyApplication\Areas\Admin\Views\GoyGolPages\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.TourCheckIn));

#line default
#line hidden
            EndContext();
            BeginContext(2254, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(2334, 44, false);
#line 66 "C:\Users\User\source\repos\MyApplication\MyApplication\Areas\Admin\Views\GoyGolPages\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.TourText));

#line default
#line hidden
            EndContext();
            BeginContext(2378, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(2458, 44, false);
#line 69 "C:\Users\User\source\repos\MyApplication\MyApplication\Areas\Admin\Views\GoyGolPages\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.TourTime));

#line default
#line hidden
            EndContext();
            BeginContext(2502, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(2582, 50, false);
#line 72 "C:\Users\User\source\repos\MyApplication\MyApplication\Areas\Admin\Views\GoyGolPages\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.TourAdditional));

#line default
#line hidden
            EndContext();
            BeginContext(2632, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(2712, 42, false);
#line 75 "C:\Users\User\source\repos\MyApplication\MyApplication\Areas\Admin\Views\GoyGolPages\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Number));

#line default
#line hidden
            EndContext();
            BeginContext(2754, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(2834, 48, false);
#line 78 "C:\Users\User\source\repos\MyApplication\MyApplication\Areas\Admin\Views\GoyGolPages\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.SecondNumber));

#line default
#line hidden
            EndContext();
            BeginContext(2882, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(2962, 41, false);
#line 81 "C:\Users\User\source\repos\MyApplication\MyApplication\Areas\Admin\Views\GoyGolPages\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(3003, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(3083, 47, false);
#line 84 "C:\Users\User\source\repos\MyApplication\MyApplication\Areas\Admin\Views\GoyGolPages\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.SiteAddress));

#line default
#line hidden
            EndContext();
            BeginContext(3130, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(3210, 43, false);
#line 87 "C:\Users\User\source\repos\MyApplication\MyApplication\Areas\Admin\Views\GoyGolPages\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Address));

#line default
#line hidden
            EndContext();
            BeginContext(3253, 126, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th></th>\r\n                </tr>\r\n            </thead>\r\n            <tbody>\r\n");
            EndContext();
#line 93 "C:\Users\User\source\repos\MyApplication\MyApplication\Areas\Admin\Views\GoyGolPages\Index.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
            BeginContext(3444, 84, true);
            WriteLiteral("                    <tr>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(3529, 44, false);
#line 97 "C:\Users\User\source\repos\MyApplication\MyApplication\Areas\Admin\Views\GoyGolPages\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.ImagePath));

#line default
#line hidden
            EndContext();
            BeginContext(3573, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(3665, 44, false);
#line 100 "C:\Users\User\source\repos\MyApplication\MyApplication\Areas\Admin\Views\GoyGolPages\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.ImageText));

#line default
#line hidden
            EndContext();
            BeginContext(3709, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(3801, 40, false);
#line 103 "C:\Users\User\source\repos\MyApplication\MyApplication\Areas\Admin\Views\GoyGolPages\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Title));

#line default
#line hidden
            EndContext();
            BeginContext(3841, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(3933, 43, false);
#line 106 "C:\Users\User\source\repos\MyApplication\MyApplication\Areas\Admin\Views\GoyGolPages\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.SubTitle));

#line default
#line hidden
            EndContext();
            BeginContext(3976, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(4068, 43, false);
#line 109 "C:\Users\User\source\repos\MyApplication\MyApplication\Areas\Admin\Views\GoyGolPages\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Duration));

#line default
#line hidden
            EndContext();
            BeginContext(4111, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(4203, 39, false);
#line 112 "C:\Users\User\source\repos\MyApplication\MyApplication\Areas\Admin\Views\GoyGolPages\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Code));

#line default
#line hidden
            EndContext();
            BeginContext(4242, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(4334, 40, false);
#line 115 "C:\Users\User\source\repos\MyApplication\MyApplication\Areas\Admin\Views\GoyGolPages\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Price));

#line default
#line hidden
            EndContext();
            BeginContext(4374, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(4466, 48, false);
#line 118 "C:\Users\User\source\repos\MyApplication\MyApplication\Areas\Admin\Views\GoyGolPages\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.AboutTourText));

#line default
#line hidden
            EndContext();
            BeginContext(4514, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(4606, 50, false);
#line 121 "C:\Users\User\source\repos\MyApplication\MyApplication\Areas\Admin\Views\GoyGolPages\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.AboutTourNumber));

#line default
#line hidden
            EndContext();
            BeginContext(4656, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(4748, 44, false);
#line 124 "C:\Users\User\source\repos\MyApplication\MyApplication\Areas\Admin\Views\GoyGolPages\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.TourImage));

#line default
#line hidden
            EndContext();
            BeginContext(4792, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(4884, 43, false);
#line 127 "C:\Users\User\source\repos\MyApplication\MyApplication\Areas\Admin\Views\GoyGolPages\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.TourName));

#line default
#line hidden
            EndContext();
            BeginContext(4927, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(5019, 50, false);
#line 130 "C:\Users\User\source\repos\MyApplication\MyApplication\Areas\Admin\Views\GoyGolPages\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.TourInformation));

#line default
#line hidden
            EndContext();
            BeginContext(5069, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(5161, 44, false);
#line 133 "C:\Users\User\source\repos\MyApplication\MyApplication\Areas\Admin\Views\GoyGolPages\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.TourVideo));

#line default
#line hidden
            EndContext();
            BeginContext(5205, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(5297, 46, false);
#line 136 "C:\Users\User\source\repos\MyApplication\MyApplication\Areas\Admin\Views\GoyGolPages\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.TourCheckIn));

#line default
#line hidden
            EndContext();
            BeginContext(5343, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(5435, 43, false);
#line 139 "C:\Users\User\source\repos\MyApplication\MyApplication\Areas\Admin\Views\GoyGolPages\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.TourText));

#line default
#line hidden
            EndContext();
            BeginContext(5478, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(5570, 43, false);
#line 142 "C:\Users\User\source\repos\MyApplication\MyApplication\Areas\Admin\Views\GoyGolPages\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.TourTime));

#line default
#line hidden
            EndContext();
            BeginContext(5613, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(5705, 49, false);
#line 145 "C:\Users\User\source\repos\MyApplication\MyApplication\Areas\Admin\Views\GoyGolPages\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.TourAdditional));

#line default
#line hidden
            EndContext();
            BeginContext(5754, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(5846, 41, false);
#line 148 "C:\Users\User\source\repos\MyApplication\MyApplication\Areas\Admin\Views\GoyGolPages\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Number));

#line default
#line hidden
            EndContext();
            BeginContext(5887, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(5979, 47, false);
#line 151 "C:\Users\User\source\repos\MyApplication\MyApplication\Areas\Admin\Views\GoyGolPages\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.SecondNumber));

#line default
#line hidden
            EndContext();
            BeginContext(6026, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(6118, 40, false);
#line 154 "C:\Users\User\source\repos\MyApplication\MyApplication\Areas\Admin\Views\GoyGolPages\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
            EndContext();
            BeginContext(6158, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(6250, 46, false);
#line 157 "C:\Users\User\source\repos\MyApplication\MyApplication\Areas\Admin\Views\GoyGolPages\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.SiteAddress));

#line default
#line hidden
            EndContext();
            BeginContext(6296, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(6388, 42, false);
#line 160 "C:\Users\User\source\repos\MyApplication\MyApplication\Areas\Admin\Views\GoyGolPages\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Address));

#line default
#line hidden
            EndContext();
            BeginContext(6430, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(6521, 53, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e6a0c4bf16a94d69b08207e378af9956", async() => {
                BeginContext(6566, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 163 "C:\Users\User\source\repos\MyApplication\MyApplication\Areas\Admin\Views\GoyGolPages\Index.cshtml"
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
            BeginContext(6574, 32, true);
            WriteLiteral(" |\r\n                            ");
            EndContext();
            BeginContext(6606, 59, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1433f2024d614bfea615cf1bda187aeb", async() => {
                BeginContext(6654, 7, true);
                WriteLiteral("Details");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 164 "C:\Users\User\source\repos\MyApplication\MyApplication\Areas\Admin\Views\GoyGolPages\Index.cshtml"
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
            BeginContext(6665, 32, true);
            WriteLiteral(" |\r\n                            ");
            EndContext();
            BeginContext(6697, 57, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b40e27da5d514bad8b54eb4c4afca647", async() => {
                BeginContext(6744, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 165 "C:\Users\User\source\repos\MyApplication\MyApplication\Areas\Admin\Views\GoyGolPages\Index.cshtml"
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
            BeginContext(6754, 60, true);
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
            EndContext();
#line 168 "C:\Users\User\source\repos\MyApplication\MyApplication\Areas\Admin\Views\GoyGolPages\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(6833, 58, true);
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MyApplication.Models.GoyGolPage>> Html { get; private set; }
    }
}
#pragma warning restore 1591
