#pragma checksum "C:\Users\User\source\repos\MyApplication\MyApplication\Views\Service\Incoming.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "16dba13e2a960e40e8902dedf9c3f9ad4b8028dc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Service_Incoming), @"mvc.1.0.view", @"/Views/Service/Incoming.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Service/Incoming.cshtml", typeof(AspNetCore.Views_Service_Incoming))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"16dba13e2a960e40e8902dedf9c3f9ad4b8028dc", @"/Views/Service/Incoming.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2120c96a385f5d4cca84fc368fa2fffbd127b30d", @"/Views/_ViewImports.cshtml")]
    public class Views_Service_Incoming : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MyApplication.Models.ViewModels.IncomingModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("sendmessage"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\User\source\repos\MyApplication\MyApplication\Views\Service\Incoming.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(108, 29, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            EndContext();
            BeginContext(137, 103, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f1e0a4ee72d846858bc2bc41e0961567", async() => {
                BeginContext(143, 90, true);
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>Incoming</title>\r\n");
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
            BeginContext(240, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(242, 6867, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "82c0a3c2604c4aeab3e42aa07591285c", async() => {
                BeginContext(248, 1051, true);
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
                    <a href=""https://www.facebook.com"">
                        <i class=""fab fa-facebook"">

                        </i>
                    </a>
                    <a href=""https://www.instagram.com"">
                        <i class=""fab fa-instagram""></i>
                    </a>
                </li>

            </div>
        </div>


    </nav>

    <section id=""main"">

        <div class");
                WriteLiteral("=\"col-sm-12\">\r\n            ");
                EndContext();
                BeginContext(1299, 54, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "87293fd569f34a82abd91bae8a8d79d5", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 1309, "~/images/", 1309, 9, true);
#line 64 "C:\Users\User\source\repos\MyApplication\MyApplication\Views\Service\Incoming.cshtml"
AddHtmlAttributeValue("", 1318, Model.TitleAndSubTitle.ImagePath, 1318, 33, false);

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
                BeginContext(1353, 34, true);
                WriteLiteral("\r\n            <div class=\"title\"> ");
                EndContext();
                BeginContext(1388, 32, false);
#line 65 "C:\Users\User\source\repos\MyApplication\MyApplication\Views\Service\Incoming.cshtml"
                           Write(Model.TitleAndSubTitle.ImageText);

#line default
#line hidden
                EndContext();
                BeginContext(1420, 248, true);
                WriteLiteral("</div>\r\n        </div>\r\n    </section>\r\n\r\n    <section id=\"subMain\">\r\n        <div class=\"container\">\r\n            <div class=\"row\">\r\n                <div class=\"col-md-12\">\r\n                    <div class=\"proposalTitle\">\r\n                        ");
                EndContext();
                BeginContext(1669, 28, false);
#line 74 "C:\Users\User\source\repos\MyApplication\MyApplication\Views\Service\Incoming.cshtml"
                   Write(Model.TitleAndSubTitle.Title);

#line default
#line hidden
                EndContext();
                BeginContext(1697, 106, true);
                WriteLiteral("\r\n                    </div>\r\n                    <div class=\"proposalSubTitle\">\r\n                        ");
                EndContext();
                BeginContext(1804, 31, false);
#line 77 "C:\Users\User\source\repos\MyApplication\MyApplication\Views\Service\Incoming.cshtml"
                   Write(Model.TitleAndSubTitle.SubTitle);

#line default
#line hidden
                EndContext();
                BeginContext(1835, 208, true);
                WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </section>\r\n\r\n    <section id=\"incomingTours\">\r\n        <div class=\"container\">\r\n            <div class=\"row\">\r\n\r\n");
                EndContext();
#line 88 "C:\Users\User\source\repos\MyApplication\MyApplication\Views\Service\Incoming.cshtml"
                 foreach (var item in Model.Incomings)
                {

#line default
#line hidden
                BeginContext(2118, 68, true);
                WriteLiteral("                    <div class=\"col-lg-4\">\r\n                        ");
                EndContext();
                BeginContext(2186, 36, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "1669625626b54d7d9d07ffc9d237eb73", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 2196, "~/images/", 2196, 9, true);
#line 91 "C:\Users\User\source\repos\MyApplication\MyApplication\Views\Service\Incoming.cshtml"
AddHtmlAttributeValue("", 2205, item.TourImage, 2205, 15, false);

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
                BeginContext(2222, 28, true);
                WriteLiteral("\r\n                        <i");
                EndContext();
                BeginWriteAttribute("class", " class=\"", 2250, "\"", 2276, 2);
                WriteAttributeValue("", 2258, "fas", 2258, 3, true);
#line 92 "C:\Users\User\source\repos\MyApplication\MyApplication\Views\Service\Incoming.cshtml"
WriteAttributeValue(" ", 2261, item.TourIcon, 2262, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2277, 49, true);
                WriteLiteral("></i>\r\n                        <i id=\"secondRate\"");
                EndContext();
                BeginWriteAttribute("class", " class=\"", 2326, "\"", 2352, 2);
                WriteAttributeValue("", 2334, "fas", 2334, 3, true);
#line 93 "C:\Users\User\source\repos\MyApplication\MyApplication\Views\Service\Incoming.cshtml"
WriteAttributeValue(" ", 2337, item.TourIcon, 2338, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2353, 48, true);
                WriteLiteral("></i>\r\n                        <i id=\"thirdRate\"");
                EndContext();
                BeginWriteAttribute("class", " class=\"", 2401, "\"", 2427, 2);
                WriteAttributeValue("", 2409, "fas", 2409, 3, true);
#line 94 "C:\Users\User\source\repos\MyApplication\MyApplication\Views\Service\Incoming.cshtml"
WriteAttributeValue(" ", 2412, item.TourIcon, 2413, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2428, 36, true);
                WriteLiteral("></i>\r\n                        <h4> ");
                EndContext();
                BeginContext(2465, 13, false);
#line 95 "C:\Users\User\source\repos\MyApplication\MyApplication\Views\Service\Incoming.cshtml"
                        Write(item.TourName);

#line default
#line hidden
                EndContext();
                BeginContext(2478, 54, true);
                WriteLiteral(" </h4>\r\n                        <span class=\"Goygol\"> ");
                EndContext();
                BeginContext(2533, 14, false);
#line 96 "C:\Users\User\source\repos\MyApplication\MyApplication\Views\Service\Incoming.cshtml"
                                         Write(item.TourTitle);

#line default
#line hidden
                EndContext();
                BeginContext(2547, 35, true);
                WriteLiteral("</span>\r\n                        <i");
                EndContext();
                BeginWriteAttribute("class", " class=\"", 2582, "\"", 2604, 1);
#line 97 "C:\Users\User\source\repos\MyApplication\MyApplication\Views\Service\Incoming.cshtml"
WriteAttributeValue("", 2590, item.TourTime, 2590, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2605, 52, true);
                WriteLiteral("></i>\r\n\r\n                        <span class=\"text\">");
                EndContext();
                BeginContext(2658, 13, false);
#line 99 "C:\Users\User\source\repos\MyApplication\MyApplication\Views\Service\Incoming.cshtml"
                                      Write(item.Duration);

#line default
#line hidden
                EndContext();
                BeginContext(2671, 35, true);
                WriteLiteral("</span>\r\n                        <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 2706, "\"", 2729, 1);
#line 100 "C:\Users\User\source\repos\MyApplication\MyApplication\Views\Service\Incoming.cshtml"
WriteAttributeValue("", 2713, item.TourAction, 2713, 16, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2730, 121, true);
                WriteLiteral(">\r\n                            <button> Daha Ətraflı</button>\r\n                        </a>\r\n                    </div>\r\n");
                EndContext();
#line 104 "C:\Users\User\source\repos\MyApplication\MyApplication\Views\Service\Incoming.cshtml"
                }

#line default
#line hidden
                BeginContext(2870, 136, true);
                WriteLiteral("\r\n\r\n            </div>\r\n        </div>\r\n    </section>\r\n\r\n    <section id=\"contacts\">\r\n\r\n        <div class=\"container\">\r\n\r\n            ");
                EndContext();
                BeginContext(3006, 2097, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5f101dd7ae6d4f679ff1e1e358947da6", async() => {
                    BeginContext(3031, 18, true);
                    WriteLiteral("\r\n                ");
                    EndContext();
                    BeginContext(3050, 23, false);
#line 116 "C:\Users\User\source\repos\MyApplication\MyApplication\Views\Service\Incoming.cshtml"
           Write(Html.AntiForgeryToken());

#line default
#line hidden
                    EndContext();
                    BeginContext(3073, 2023, true);
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
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(5103, 38, true);
                WriteLiteral("\r\n\r\n        </div>\r\n\r\n    </section>\r\n");
                EndContext();
                DefineSection("script", async() => {
                    BeginContext(5162, 1933, true);
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
                    let __Reque");
                    WriteLiteral(@"stVerificationToken = $(""input[name='__RequestVerificationToken']"").val();
                    $.ajax({
                        url: ""/Service/Incoming"",
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
                BeginContext(7098, 4, true);
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
            BeginContext(7109, 11, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MyApplication.Models.ViewModels.IncomingModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
