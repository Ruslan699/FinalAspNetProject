#pragma checksum "C:\Users\User\source\repos\MyApplication\MyApplication\Views\Service\Vip.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e05a7efe6a21176d96ad79ab4e61fea352ca40d0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Service_Vip), @"mvc.1.0.view", @"/Views/Service/Vip.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Service/Vip.cshtml", typeof(AspNetCore.Views_Service_Vip))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e05a7efe6a21176d96ad79ab4e61fea352ca40d0", @"/Views/Service/Vip.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2120c96a385f5d4cca84fc368fa2fffbd127b30d", @"/Views/_ViewImports.cshtml")]
    public class Views_Service_Vip : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MyApplication.Models.Vip>
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
#line 2 "C:\Users\User\source\repos\MyApplication\MyApplication\Views\Service\Vip.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(87, 29, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            EndContext();
            BeginContext(116, 98, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "db557ef65872476fa67b823e2293a816", async() => {
                BeginContext(122, 85, true);
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>Vip</title>\r\n");
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
            BeginContext(214, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(216, 7475, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "76293b884d064ed897f3e934a7fba951", async() => {
                BeginContext(222, 616, true);
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
                BeginWriteAttribute("href", " href=", 838, "", 869, 1);
#line 47 "C:\Users\User\source\repos\MyApplication\MyApplication\Views\Service\Vip.cshtml"
WriteAttributeValue("", 844, ViewBag.Setting.Facebook, 844, 25, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(869, 136, true);
                WriteLiteral(">\r\n                        <i class=\"fab fa-facebook\">\r\n\r\n                        </i>\r\n                    </a>\r\n                    <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 1005, "\"", 1038, 1);
#line 52 "C:\Users\User\source\repos\MyApplication\MyApplication\Views\Service\Vip.cshtml"
WriteAttributeValue("", 1012, ViewBag.Setting.Instagram, 1012, 26, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1039, 238, true);
                WriteLiteral(">\r\n                        <i class=\"fab fa-instagram\"></i>\r\n                    </a>\r\n                </li>\r\n\r\n            </div>\r\n        </div>\r\n\r\n\r\n    </nav>\r\n\r\n    <section id=\"main\">\r\n\r\n        <div class=\"col-sm-12\">\r\n            ");
                EndContext();
                BeginContext(1277, 37, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "2b0386d8cce946139e03fda8c47ceab8", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 1287, "~/images/", 1287, 9, true);
#line 66 "C:\Users\User\source\repos\MyApplication\MyApplication\Views\Service\Vip.cshtml"
AddHtmlAttributeValue("", 1296, Model.ImagePath, 1296, 16, false);

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
                BeginContext(1314, 34, true);
                WriteLiteral("\r\n            <div class=\"title\"> ");
                EndContext();
                BeginContext(1349, 16, false);
#line 67 "C:\Users\User\source\repos\MyApplication\MyApplication\Views\Service\Vip.cshtml"
                           Write(Model.ImageTitle);

#line default
#line hidden
                EndContext();
                BeginContext(1365, 285, true);
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
                BeginContext(1651, 11, false);
#line 77 "C:\Users\User\source\repos\MyApplication\MyApplication\Views\Service\Vip.cshtml"
                       Write(Model.Title);

#line default
#line hidden
                EndContext();
                BeginContext(1662, 118, true);
                WriteLiteral("\r\n                        </div>\r\n                        <div class=\"proposalSubTitle\">\r\n                            ");
                EndContext();
                BeginContext(1781, 14, false);
#line 80 "C:\Users\User\source\repos\MyApplication\MyApplication\Views\Service\Vip.cshtml"
                       Write(Model.SubTitle);

#line default
#line hidden
                EndContext();
                BeginContext(1795, 995, true);
                WriteLiteral(@"
                        </div>
                    </div>
                </div>

                <div class=""row"">
                    <div class=""col-md-12"">
                        <div class=""proposalText"">
                            VİP kateqoriyaya daxil olan şirkət rəhbərlərinə və fərdi şəxslərə  aşağıda göstərilən xidmətlər peşəkar komandamız tərəfindən ən qısa zamanda və yüksək səviyyədə xidmət göstərəcək: <br> <br>
                            <p> 1. VİP transfer. </p>
                            <p> 2. Hava limanında növbəsiz qeydiyyat və minik.</p>
                            <p> 3. Heydər Əliyev Beynəlxalq Hava Limanında gediş zamanı prosedurlardan “sürətli keçid” xidməti və fərdi kömək. </p>
                            <p> 4. Baqajın daşınması və bir çox xüsusi üstünlüklərdən faydalanma fürsəti. </p>
                            <p> 5. İstədiyiniz növ Vip avtomobil ilə qarşılanma və yola salınma. </p> <br> <br> <br> <br>
                            <p> ");
                EndContext();
                BeginContext(2791, 10, false);
#line 94 "C:\Users\User\source\repos\MyApplication\MyApplication\Views\Service\Vip.cshtml"
                           Write(Model.Text);

#line default
#line hidden
                EndContext();
                BeginContext(2801, 87, true);
                WriteLiteral(" </p> <br> <br> <br>\r\n                            <p>\r\n                                ");
                EndContext();
                BeginContext(2889, 13, false);
#line 96 "C:\Users\User\source\repos\MyApplication\MyApplication\Views\Service\Vip.cshtml"
                           Write(Model.SubText);

#line default
#line hidden
                EndContext();
                BeginContext(2902, 72, true);
                WriteLiteral("\r\n                                <br>\r\n                                ");
                EndContext();
                BeginContext(2975, 11, false);
#line 98 "C:\Users\User\source\repos\MyApplication\MyApplication\Views\Service\Vip.cshtml"
                           Write(Model.Phone);

#line default
#line hidden
                EndContext();
                BeginContext(2986, 72, true);
                WriteLiteral("\r\n                                <br>\r\n                                ");
                EndContext();
                BeginContext(3059, 16, false);
#line 100 "C:\Users\User\source\repos\MyApplication\MyApplication\Views\Service\Vip.cshtml"
                           Write(Model.OtherPhone);

#line default
#line hidden
                EndContext();
                BeginContext(3075, 79, true);
                WriteLiteral("\r\n                                <br>\r\n                                Email: ");
                EndContext();
                BeginContext(3155, 11, false);
#line 102 "C:\Users\User\source\repos\MyApplication\MyApplication\Views\Service\Vip.cshtml"
                                  Write(Model.Email);

#line default
#line hidden
                EndContext();
                BeginContext(3166, 72, true);
                WriteLiteral("\r\n                                <br>\r\n                                ");
                EndContext();
                BeginContext(3239, 17, false);
#line 104 "C:\Users\User\source\repos\MyApplication\MyApplication\Views\Service\Vip.cshtml"
                           Write(Model.SiteAddress);

#line default
#line hidden
                EndContext();
                BeginContext(3256, 72, true);
                WriteLiteral("\r\n                                <br>\r\n                                ");
                EndContext();
                BeginContext(3329, 13, false);
#line 106 "C:\Users\User\source\repos\MyApplication\MyApplication\Views\Service\Vip.cshtml"
                           Write(Model.Address);

#line default
#line hidden
                EndContext();
                BeginContext(3342, 251, true);
                WriteLiteral("\r\n                            </p>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </section>\r\n    </main>\r\n    <section id=\"contacts\">\r\n\r\n        <div class=\"container\">\r\n\r\n            ");
                EndContext();
                BeginContext(3593, 2095, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4c498c9832be493483a0371099650487", async() => {
                    BeginContext(3618, 18, true);
                    WriteLiteral("\r\n                ");
                    EndContext();
                    BeginContext(3637, 23, false);
#line 119 "C:\Users\User\source\repos\MyApplication\MyApplication\Views\Service\Vip.cshtml"
           Write(Html.AntiForgeryToken());

#line default
#line hidden
                    EndContext();
                    BeginContext(3660, 2021, true);
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
                BeginContext(5688, 40, true);
                WriteLiteral("\r\n\r\n        </div>\r\n\r\n    </section>\r\n\r\n");
                EndContext();
                DefineSection("script", async() => {
                    BeginContext(5749, 1928, true);
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
                        url: ""/Service/Vip"",
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
                BeginContext(7680, 4, true);
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
            BeginContext(7691, 11, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MyApplication.Models.Vip> Html { get; private set; }
    }
}
#pragma warning restore 1591
