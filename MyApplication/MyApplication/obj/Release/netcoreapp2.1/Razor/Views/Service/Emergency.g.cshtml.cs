#pragma checksum "C:\Users\User\source\repos\MyApplication\MyApplication\Views\Service\Emergency.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1a21743eac13b15e40a7abaac89e5cb88eb00d71"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Service_Emergency), @"mvc.1.0.view", @"/Views/Service/Emergency.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Service/Emergency.cshtml", typeof(AspNetCore.Views_Service_Emergency))]
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
#line 1 "C:\Users\User\source\repos\MyApplication\MyApplication\Views\_ViewImports.cshtml"
using MyApplication.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1a21743eac13b15e40a7abaac89e5cb88eb00d71", @"/Views/Service/Emergency.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2120c96a385f5d4cca84fc368fa2fffbd127b30d", @"/Views/_ViewImports.cshtml")]
    public class Views_Service_Emergency : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MyApplication.Models.Emergency>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("sendmessage"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Emergency", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\User\source\repos\MyApplication\MyApplication\Views\Service\Emergency.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(93, 29, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            EndContext();
            BeginContext(122, 104, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "86eb5d30a1234dbba5b07eec36d0522c", async() => {
                BeginContext(128, 91, true);
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>Emergency</title>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(226, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(228, 6205, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9ad5b124ec7148d2bd3937b490b91c3b", async() => {
                BeginContext(234, 622, true);
                WriteLiteral(@"
    <nav>


        <div class=""container"">



            <div class=""navbar"">


                <a href=""#"" id=""menu-icon""> <i class=""fas fa-bars""></i> </a>

                <a href=""/About""> Haqqımızda </a>


                <a href=""/Azerbaijan""> Azərbaycan </a>



                <a href=""/Service""> Xidmətlər </a>



                <a href=""/Event""> Coming Events </a>



                <a href=""/OnlinePayment""> Online Odəniş </a>



                <a href=""/Contact"">
                    Əlaqə
                </a>

                <li class=""sign"">
                    <a");
                EndContext();
                BeginWriteAttribute("href", " href=", 856, "", 887, 1);
#line 50 "C:\Users\User\source\repos\MyApplication\MyApplication\Views\Service\Emergency.cshtml"
WriteAttributeValue("", 862, ViewBag.Setting.Facebook, 862, 25, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(887, 136, true);
                WriteLiteral(">\r\n                        <i class=\"fab fa-facebook\">\r\n\r\n                        </i>\r\n                    </a>\r\n                    <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 1023, "\"", 1056, 1);
#line 55 "C:\Users\User\source\repos\MyApplication\MyApplication\Views\Service\Emergency.cshtml"
WriteAttributeValue("", 1030, ViewBag.Setting.Instagram, 1030, 26, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1057, 238, true);
                WriteLiteral(">\r\n                        <i class=\"fab fa-instagram\"></i>\r\n                    </a>\r\n                </li>\r\n\r\n            </div>\r\n        </div>\r\n\r\n\r\n    </nav>\r\n\r\n    <section id=\"main\">\r\n\r\n        <div class=\"col-sm-12\">\r\n            ");
                EndContext();
                BeginContext(1295, 37, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "46c04baba5194290a7e99f598214ef23", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 1305, "~/images/", 1305, 9, true);
#line 69 "C:\Users\User\source\repos\MyApplication\MyApplication\Views\Service\Emergency.cshtml"
AddHtmlAttributeValue("", 1314, Model.ImagePath, 1314, 16, false);

#line default
#line hidden
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1332, 34, true);
                WriteLiteral("\r\n            <div class=\"title\"> ");
                EndContext();
                BeginContext(1367, 16, false);
#line 70 "C:\Users\User\source\repos\MyApplication\MyApplication\Views\Service\Emergency.cshtml"
                           Write(Model.ImageTitle);

#line default
#line hidden
                EndContext();
                BeginContext(1383, 285, true);
                WriteLiteral(@" </div>
        </div>
    </section>

    <main>
        <section id=""subMain"">
            <div class=""container"">
                <div class=""row"">
                    <div class=""col-md-12"">
                        <div class=""proposalTitle"">
                            ");
                EndContext();
                BeginContext(1669, 11, false);
#line 80 "C:\Users\User\source\repos\MyApplication\MyApplication\Views\Service\Emergency.cshtml"
                       Write(Model.Title);

#line default
#line hidden
                EndContext();
                BeginContext(1680, 118, true);
                WriteLiteral("\r\n                        </div>\r\n                        <div class=\"proposalSubTitle\">\r\n                            ");
                EndContext();
                BeginContext(1799, 14, false);
#line 83 "C:\Users\User\source\repos\MyApplication\MyApplication\Views\Service\Emergency.cshtml"
                       Write(Model.Subtitle);

#line default
#line hidden
                EndContext();
                BeginContext(1813, 241, true);
                WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n                <div class=\"row\">\r\n                    <div class=\"col-md-12\">\r\n                        <div class=\"text\">\r\n                            <p>");
                EndContext();
                BeginContext(2055, 10, false);
#line 90 "C:\Users\User\source\repos\MyApplication\MyApplication\Views\Service\Emergency.cshtml"
                          Write(Model.Text);

#line default
#line hidden
                EndContext();
                BeginContext(2065, 223, true);
                WriteLiteral("</p>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </section>\r\n    </main>\r\n\r\n    <section id=\"contacts\">\r\n\r\n        <div class=\"container\">\r\n\r\n            ");
                EndContext();
                BeginContext(2288, 2132, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fc85989bfe7e4ab5a7e3fecd2b0ec2ca", async() => {
                    BeginContext(2350, 18, true);
                    WriteLiteral("\r\n                ");
                    EndContext();
                    BeginContext(2369, 23, false);
#line 103 "C:\Users\User\source\repos\MyApplication\MyApplication\Views\Service\Emergency.cshtml"
           Write(Html.AntiForgeryToken());

#line default
#line hidden
                    EndContext();
                    BeginContext(2392, 2021, true);
                    WriteLiteral(@"
                <div class=""row"">
                    <div class=""col-md-12"">
                        <div class=""titleWrite"">

                            BİZƏ YAZIN

                        </div>
                    </div>
                </div>

                <div class=""row"">
                    <div class=""col-md-4"">

                        <label for=""lname""> Ad </label>
                        <input type=""text"" name=""lname"" id=""name"" placeholder=""Adınızı daxil edin"">
                    </div>
                    <div class=""col-md-4"">

                        <label for=""lsurname""> Soyad </label>
                        <input type=""text"" name=""lsurname"" id=""surname"" placeholder=""Soyadınızı daxil edin"">
                    </div>
                    <div class=""col-md-4"">

                        <label for=""lsurname""> Email </label>
                        <input type=""text"" name=""email"" id=""email"" placeholder=""Email ünvanınızı daxil edin"">
                    </div>
");
                    WriteLiteral(@"                </div>

                <div class=""row"">


                    <div class=""col-md-4"">
                        <label for=""number""> Mobil Nömrəniz </label>
                        <input type=""number"" id=""number"" name=""number"" pattern=""[0-9]{3}-[2-9]{3}-[0-9]{2}-[0-9]{2}"" placeholder=""Mobil nömrənizi daxil edin"">
                    </div>

                    <div class=""col-md-8"">
                        <label for=""text""> Mesajınız</label>
                        <textarea name=""text"" id=""message"" placeholder=""Mesajınızı daxil edin""></textarea>
                    </div>

                </div>

                <div class=""row"">
                    <div class=""col-md-12"">

                        <div class=""submitBtn"">
                            <input type=""submit"" class=""button"" id=""button"" value=""Məktubu göndərin"" data-loading=""YÜklənir"">

                        </div>
                    </div>

                </div>
            ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
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
                BeginContext(4420, 40, true);
                WriteLiteral("\r\n\r\n        </div>\r\n\r\n    </section>\r\n\r\n");
                EndContext();
                DefineSection("script", async() => {
                    BeginContext(4481, 1938, true);
                    WriteLiteral(@"
        <script>
            $(document).ready(function () {
                $.ajax({
                    url: ""/Home/Footer"",
                    method: ""get"",
                    success: function (re) {

                        $("".same"").append(re.addreses);
                        $("".sameTwo"").append(re.faxes);
                        $("".sameThree"").append(re.numbers);
                        $("".sameFour"").append(re.mails);
                        $("".sameFive"").append(re.siteadress);
                        $(""#titleee"").append(re.title);
                        $("".longText"").append(re.desciption);


                    }
                })
                $(""#button"").click(function () {
                    let name = $(""#name"").val();
                    let surname = $(""#surname"").val();
                    let email = $(""#email"").val();
                    let phone = $(""#number"").val();
                    let message = $(""#message"").val();
                    let __R");
                    WriteLiteral(@"equestVerificationToken = $(""input[name='__RequestVerificationToken']"").val();
                    $.ajax({
                        url: ""/Service/Emergency"",
                        data: {
                            Name: name,
                            Surname: surname,
                            Email: email,
                            Number: phone,
                            Messaging: message,
                            __RequestVerificationToken: __RequestVerificationToken
                        },
                        method: ""post"",
                        success: function (re) {

                            alert('Message sent');
                        },
                        error: function (re) {
                            alert('Error');
                        }
                    })
                })
            });

        </script>
        ");
                    EndContext();
                }
                );
                BeginContext(6422, 4, true);
                WriteLiteral("    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(6433, 11, true);
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MyApplication.Models.Emergency> Html { get; private set; }
    }
}
#pragma warning restore 1591
