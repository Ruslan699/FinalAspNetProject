#pragma checksum "C:\Users\User\source\repos\MyApplication\MyApplication\Views\Service\Transport.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b46f52d59d74e1fd7670abc9bde6aeebf1ed5482"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Service_Transport), @"mvc.1.0.view", @"/Views/Service/Transport.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Service/Transport.cshtml", typeof(AspNetCore.Views_Service_Transport))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b46f52d59d74e1fd7670abc9bde6aeebf1ed5482", @"/Views/Service/Transport.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2120c96a385f5d4cca84fc368fa2fffbd127b30d", @"/Views/_ViewImports.cshtml")]
    public class Views_Service_Transport : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MyApplication.Models.ViewModels.TransportViewModel>
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
#line 2 "C:\Users\User\source\repos\MyApplication\MyApplication\Views\Service\Transport.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(113, 29, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            EndContext();
            BeginContext(142, 116, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "567da553cfdf449eaaa42f95c174e140", async() => {
                BeginContext(148, 103, true);
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>Transport</title>\r\n   \r\n\r\n   \r\n");
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
            BeginContext(258, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(260, 7425, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f422bf742d934f10a5c9915e4df6cb64", async() => {
                BeginContext(266, 588, true);
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
                BeginWriteAttribute("href", " href=", 854, "", 885, 1);
#line 36 "C:\Users\User\source\repos\MyApplication\MyApplication\Views\Service\Transport.cshtml"
WriteAttributeValue("", 860, ViewBag.Setting.Facebook, 860, 25, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(885, 134, true);
                WriteLiteral(">\r\n                        <i class=\"fab fa-facebook\">\r\n                        </i>\r\n                    </a>\r\n                    <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 1019, "\"", 1052, 1);
#line 40 "C:\Users\User\source\repos\MyApplication\MyApplication\Views\Service\Transport.cshtml"
WriteAttributeValue("", 1026, ViewBag.Setting.Instagram, 1026, 26, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1053, 270, true);
                WriteLiteral(@">
                        <i class=""fab fa-instagram""></i>
                    </a>
                </li>

            </div>
        </div>
    </nav>

    <section id=""main"">
        <div class=""col-sm-12 big"">
            <div id=""image"">
                ");
                EndContext();
                BeginContext(1323, 47, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "dd65904635b54c2eae14ec6a420f64a7", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 1333, "~/images/", 1333, 9, true);
#line 52 "C:\Users\User\source\repos\MyApplication\MyApplication\Views\Service\Transport.cshtml"
AddHtmlAttributeValue("", 1342, Model.Transport.ImagePath, 1342, 26, false);

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
                BeginContext(1370, 111, true);
                WriteLiteral("\r\n            </div>\r\n            <div class=\"info\">\r\n                <div class=\"title\">\r\n                    ");
                EndContext();
                BeginContext(1482, 26, false);
#line 56 "C:\Users\User\source\repos\MyApplication\MyApplication\Views\Service\Transport.cshtml"
               Write(Model.Transport.ImageTitle);

#line default
#line hidden
                EndContext();
                BeginContext(1508, 330, true);
                WriteLiteral(@"
                </div>
            </div>
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
                BeginContext(1839, 21, false);
#line 72 "C:\Users\User\source\repos\MyApplication\MyApplication\Views\Service\Transport.cshtml"
                       Write(Model.Transport.Title);

#line default
#line hidden
                EndContext();
                BeginContext(1860, 126, true);
                WriteLiteral("\r\n\r\n\r\n                        </div>\r\n\r\n                        <div class=\"proposalSubTitle\">\r\n\r\n                            ");
                EndContext();
                BeginContext(1987, 24, false);
#line 79 "C:\Users\User\source\repos\MyApplication\MyApplication\Views\Service\Transport.cshtml"
                       Write(Model.Transport.SubTitle);

#line default
#line hidden
                EndContext();
                BeginContext(2011, 434, true);
                WriteLiteral(@"

                        </div>
                    </div>
                </div>

                <div class=""row"">

                    <div class=""col-md-6"">
                        <div class=""paragraph"">

                            <p> Aşağıdakı xidmətlərdən istifadə etmək üçün, qiymətlər barədə məlumat almaq üçün bizə yazın. </p>

                            <p> Avtomobil kirayəsi xidməti çərçivəsində:</p>

");
                EndContext();
#line 94 "C:\Users\User\source\repos\MyApplication\MyApplication\Views\Service\Transport.cshtml"
                             foreach (var item in Model.TransportDescriptions)
                            {

#line default
#line hidden
                BeginContext(2556, 36, true);
                WriteLiteral("                                <p> ");
                EndContext();
                BeginContext(2593, 19, false);
#line 96 "C:\Users\User\source\repos\MyApplication\MyApplication\Views\Service\Transport.cshtml"
                               Write(item.AboutTransport);

#line default
#line hidden
                EndContext();
                BeginContext(2612, 7, true);
                WriteLiteral(" </p>\r\n");
                EndContext();
#line 97 "C:\Users\User\source\repos\MyApplication\MyApplication\Views\Service\Transport.cshtml"
                            }

#line default
#line hidden
                BeginContext(2650, 180, true);
                WriteLiteral("\r\n                            <p> ------------------------------------------------------ </p>\r\n\r\n                            <p> Əlaqə Üçün: </p>\r\n\r\n                            <p>");
                EndContext();
                BeginContext(2831, 21, false);
#line 103 "C:\Users\User\source\repos\MyApplication\MyApplication\Views\Service\Transport.cshtml"
                          Write(Model.Transport.Phone);

#line default
#line hidden
                EndContext();
                BeginContext(2852, 5, true);
                WriteLiteral("<br> ");
                EndContext();
                BeginContext(2858, 26, false);
#line 103 "C:\Users\User\source\repos\MyApplication\MyApplication\Views\Service\Transport.cshtml"
                                                     Write(Model.Transport.OtherPhone);

#line default
#line hidden
                EndContext();
                BeginContext(2884, 12, true);
                WriteLiteral("<br> Email: ");
                EndContext();
                BeginContext(2897, 21, false);
#line 103 "C:\Users\User\source\repos\MyApplication\MyApplication\Views\Service\Transport.cshtml"
                                                                                            Write(Model.Transport.Email);

#line default
#line hidden
                EndContext();
                BeginContext(2918, 4, true);
                WriteLiteral("<br>");
                EndContext();
                BeginContext(2923, 27, false);
#line 103 "C:\Users\User\source\repos\MyApplication\MyApplication\Views\Service\Transport.cshtml"
                                                                                                                      Write(Model.Transport.SiteAddress);

#line default
#line hidden
                EndContext();
                BeginContext(2950, 4, true);
                WriteLiteral("<br>");
                EndContext();
                BeginContext(2955, 23, false);
#line 103 "C:\Users\User\source\repos\MyApplication\MyApplication\Views\Service\Transport.cshtml"
                                                                                                                                                      Write(Model.Transport.Address);

#line default
#line hidden
                EndContext();
                BeginContext(2978, 599, true);
                WriteLiteral(@"</p>


                        </div>
                    </div>

                    <div class=""col-md-6"">

                        <script type=""text/javascript"" charset=""utf-8"" async src=""https://api-maps.yandex.ru/services/constructor/1.0/js/?um=constructor%3A90cc95d52bd1aba201ffdd8079b0786c4b83a93c65763da1df41acab9023117d&amp;width=350&amp;height=300&amp;lang=ru_RU&amp;scroll=true""></script>
                    </div>
                </div>

            </div>

        </section>
    </main>

    <section id=""contacts"">

        <div class=""container"">

            ");
                EndContext();
                BeginContext(3577, 2095, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "65c4d005c2614cac90bbadd333ffcd6c", async() => {
                    BeginContext(3602, 18, true);
                    WriteLiteral("\r\n                ");
                    EndContext();
                    BeginContext(3621, 23, false);
#line 125 "C:\Users\User\source\repos\MyApplication\MyApplication\Views\Service\Transport.cshtml"
           Write(Html.AntiForgeryToken());

#line default
#line hidden
                    EndContext();
                    BeginContext(3644, 2021, true);
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
                BeginContext(5672, 44, true);
                WriteLiteral("\r\n\r\n        </div>\r\n\r\n    </section>\r\n\r\n\r\n\r\n");
                EndContext();
                DefineSection("script", async() => {
                    BeginContext(5737, 1934, true);
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
                        url: ""/Service/Transport"",
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
                BeginContext(7674, 4, true);
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
            BeginContext(7685, 11, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MyApplication.Models.ViewModels.TransportViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
