#pragma checksum "C:\Users\User\source\repos\MyApplication\MyApplication\Views\Event\Event.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4a626d5869ab6f111e2c3ac9c93e86aecda56215"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Event_Event), @"mvc.1.0.view", @"/Views/Event/Event.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Event/Event.cshtml", typeof(AspNetCore.Views_Event_Event))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4a626d5869ab6f111e2c3ac9c93e86aecda56215", @"/Views/Event/Event.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2120c96a385f5d4cca84fc368fa2fffbd127b30d", @"/Views/_ViewImports.cshtml")]
    public class Views_Event_Event : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MyApplication.Models.ViewModels.EventModel>
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
#line 2 "C:\Users\User\source\repos\MyApplication\MyApplication\Views\Event\Event.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(105, 29, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            EndContext();
            BeginContext(134, 100, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d08d086b8870474096051e9e2e93d7cd", async() => {
                BeginContext(140, 87, true);
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>Event</title>\r\n");
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
            BeginContext(234, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(236, 6538, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cb78e4cc0ff542eca8b88f32ceb695a9", async() => {
                BeginContext(242, 1053, true);
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

        <div cla");
                WriteLiteral("ss=\"col-sm-12\">\r\n            ");
                EndContext();
                BeginContext(1295, 54, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "33aeacf7770f4d8ba792ed3926695943", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 1305, "~/images/", 1305, 9, true);
#line 65 "C:\Users\User\source\repos\MyApplication\MyApplication\Views\Event\Event.cshtml"
AddHtmlAttributeValue("", 1314, Model.TitleAndSubTitle.ImagePath, 1314, 33, false);

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
                BeginContext(1349, 198, true);
                WriteLiteral("\r\n        </div>\r\n\r\n    </section>\r\n\r\n\r\n    <div class=\"container\">\r\n        <div class=\"row\">\r\n            <div class=\"col-md-12\">\r\n                <div class=\"textype\">\r\n\r\n                    <p> ");
                EndContext();
                BeginContext(1548, 28, false);
#line 76 "C:\Users\User\source\repos\MyApplication\MyApplication\Views\Event\Event.cshtml"
                   Write(Model.TitleAndSubTitle.Title);

#line default
#line hidden
                EndContext();
                BeginContext(1576, 178, true);
                WriteLiteral("</p>\r\n                </div>\r\n            </div>\r\n\r\n        </div>\r\n    </div>\r\n\r\n\r\n    <section id=\"control\">\r\n        <div class=\"container\">\r\n            <div class=\"row\">\r\n\r\n");
                EndContext();
#line 88 "C:\Users\User\source\repos\MyApplication\MyApplication\Views\Event\Event.cshtml"
                 foreach (var item in Model.Events)
                {

#line default
#line hidden
                BeginContext(1826, 68, true);
                WriteLiteral("                    <div class=\"col-lg-4\">\r\n                        ");
                EndContext();
                BeginContext(1894, 37, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "0f8fe78116da469f8bdcf66e2ef44066", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 1904, "~/images/", 1904, 9, true);
#line 91 "C:\Users\User\source\repos\MyApplication\MyApplication\Views\Event\Event.cshtml"
AddHtmlAttributeValue("", 1913, item.EventImage, 1913, 16, false);

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
                BeginContext(1931, 28, true);
                WriteLiteral("\r\n                        <i");
                EndContext();
                BeginWriteAttribute("class", " class=\"", 1959, "\"", 1986, 2);
                WriteAttributeValue("", 1967, "fas", 1967, 3, true);
#line 92 "C:\Users\User\source\repos\MyApplication\MyApplication\Views\Event\Event.cshtml"
WriteAttributeValue(" ", 1970, item.EventIcon, 1971, 15, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1987, 49, true);
                WriteLiteral("></i>\r\n                        <i id=\"secondRate\"");
                EndContext();
                BeginWriteAttribute("class", " class=\"", 2036, "\"", 2063, 2);
                WriteAttributeValue("", 2044, "fas", 2044, 3, true);
#line 93 "C:\Users\User\source\repos\MyApplication\MyApplication\Views\Event\Event.cshtml"
WriteAttributeValue(" ", 2047, item.EventIcon, 2048, 15, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2064, 48, true);
                WriteLiteral("></i>\r\n                        <i id=\"thirdRate\"");
                EndContext();
                BeginWriteAttribute("class", " class=\"", 2112, "\"", 2139, 2);
                WriteAttributeValue("", 2120, "fas", 2120, 3, true);
#line 94 "C:\Users\User\source\repos\MyApplication\MyApplication\Views\Event\Event.cshtml"
WriteAttributeValue(" ", 2123, item.EventIcon, 2124, 15, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2140, 36, true);
                WriteLiteral("></i>\r\n                        <h4> ");
                EndContext();
                BeginContext(2177, 14, false);
#line 95 "C:\Users\User\source\repos\MyApplication\MyApplication\Views\Event\Event.cshtml"
                        Write(item.EventName);

#line default
#line hidden
                EndContext();
                BeginContext(2191, 51, true);
                WriteLiteral(" </h4>\r\n                        <span class=\"Baku\">");
                EndContext();
                BeginContext(2243, 15, false);
#line 96 "C:\Users\User\source\repos\MyApplication\MyApplication\Views\Event\Event.cshtml"
                                      Write(item.EventTitle);

#line default
#line hidden
                EndContext();
                BeginContext(2258, 36, true);
                WriteLiteral(" </span>\r\n                        <i");
                EndContext();
                BeginWriteAttribute("class", " class=\"", 2294, "\"", 2317, 1);
#line 97 "C:\Users\User\source\repos\MyApplication\MyApplication\Views\Event\Event.cshtml"
WriteAttributeValue("", 2302, item.EventTime, 2302, 15, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2318, 53, true);
                WriteLiteral("></i>\r\n\r\n                        <span class=\"text\"> ");
                EndContext();
                BeginContext(2372, 13, false);
#line 99 "C:\Users\User\source\repos\MyApplication\MyApplication\Views\Event\Event.cshtml"
                                       Write(item.Duration);

#line default
#line hidden
                EndContext();
                BeginContext(2385, 38, true);
                WriteLiteral(" </span>\r\n\r\n                        <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 2423, "\"", 2447, 1);
#line 101 "C:\Users\User\source\repos\MyApplication\MyApplication\Views\Event\Event.cshtml"
WriteAttributeValue("", 2430, item.EventAction, 2430, 17, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2448, 66, true);
                WriteLiteral("> <button> Daha Ətraflı</button></a>\r\n                    </div>\r\n");
                EndContext();
#line 103 "C:\Users\User\source\repos\MyApplication\MyApplication\Views\Event\Event.cshtml"
                }

#line default
#line hidden
                BeginContext(2533, 134, true);
                WriteLiteral("            </div>\r\n        </div>\r\n    </section>\r\n\r\n\r\n    <section id=\"contacts\">\r\n\r\n        <div class=\"container\">\r\n\r\n            ");
                EndContext();
                BeginContext(2667, 2093, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bcb1eb871ca6488d88e7873943f8b62c", async() => {
                    BeginContext(2692, 18, true);
                    WriteLiteral("\r\n                ");
                    EndContext();
                    BeginContext(2711, 23, false);
#line 114 "C:\Users\User\source\repos\MyApplication\MyApplication\Views\Event\Event.cshtml"
           Write(Html.AntiForgeryToken());

#line default
#line hidden
                    EndContext();
                    BeginContext(2734, 2019, true);
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
                BeginContext(4760, 40, true);
                WriteLiteral("\r\n\r\n        </div>\r\n\r\n    </section>\r\n\r\n");
                EndContext();
                DefineSection("script", async() => {
                    BeginContext(4821, 1943, true);
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
                    let __Req");
                    WriteLiteral(@"uestVerificationToken = $(""input[name='__RequestVerificationToken']"").val();
                    $.ajax({
                        url: ""/Event"",
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
            BeginContext(6774, 11, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MyApplication.Models.ViewModels.EventModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
