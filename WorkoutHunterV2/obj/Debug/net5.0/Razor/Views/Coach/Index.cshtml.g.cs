#pragma checksum "D:\Documents\repo\IIFIDB\WorkoutHunterV2\Views\Coach\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3128bb187d9316c579d981d364033a8faaf54403"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Coach_Index), @"mvc.1.0.view", @"/Views/Coach/Index.cshtml")]
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
#nullable restore
#line 1 "D:\Documents\repo\IIFIDB\WorkoutHunterV2\Views\_ViewImports.cshtml"
using WorkoutHunterV2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Documents\repo\IIFIDB\WorkoutHunterV2\Views\_ViewImports.cshtml"
using WorkoutHunterV2.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3128bb187d9316c579d981d364033a8faaf54403", @"/Views/Coach/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2abd6266556f2f159f525da65ff1c131f0f7178f", @"/Views/_ViewImports.cshtml")]
    public class Views_Coach_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<WorkoutHunterV2.Models.DbModels.UserInfo>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/coach/newCoach.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/coach/jquery.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/coach/bootstrap.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/coach/bootstrap.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/coach/popper.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("StudentInformation"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/coach/Coach.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Coach/Index"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("InPut"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/signalr/dist/browser/signalr.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3128bb187d9316c579d981d364033a8faaf544038269", async() => {
                WriteLiteral("\r\n    <meta charset=\"UTF-8\" />\r\n    <meta http-equiv=\"X-UA-Compatible\" content=\"IE=edge\" />\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\" />\r\n    <title>Document</title>\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3128bb187d9316c579d981d364033a8faaf544038747", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3128bb187d9316c579d981d364033a8faaf544039925", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3128bb187d9316c579d981d364033a8faaf5440311024", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3128bb187d9316c579d981d364033a8faaf5440312203", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3128bb187d9316c579d981d364033a8faaf5440313303", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
    <style type=""text/css"">
        .bglmg {
            width: 100%;
            height: 100vh;
            background-image: url(/coach/img/背景2.png);
            background-size: cover;
            z-index: 1;
            overflow-y: auto;
            max-width: 100%;
        }

        h1 {
            text-align: center;
        }
    </style>
");
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3128bb187d9316c579d981d364033a8faaf5440315473", async() => {
                WriteLiteral(@"
    <div class=""bglmg"">
        <div class=""container-fluid containerSet"">
            <div class=""row row-cols-lg-2"" id=""fillrow"">
                <div class=""col-sm-2 col-lg-2 col-xl-2"" style=""align-items: center; text-align: center"">
                    <nav class=""navbar navbar-dark"" id=""navbarTitle"">
                        <div class=""container-fluid"">
                            <button class=""navbar-toggler""
                                    type=""button""
                                    data-bs-toggle=""collapse""
                                    data-bs-target=""#navbarToggleExternalContent""
                                    aria-controls=""navbarToggleExternalContent""
                                    aria-expanded=""false""
                                    aria-label=""Toggle navigation ""
                                    style=""position: relative; color: rgb(87, 85, 85); background: rgb(87, 85, 85); width: 530px"">
                                <span class=""navbar-toggl");
                WriteLiteral(@"er-icon""></span>
                            </button>
                        </div>
                    </nav>
                    <div class=""collapse"" id=""navbarToggleExternalContent"">
                        <div class=""t"" style=""text-align: center"">
                            <h5 class=""text-white h4"" style=""margin-bottom: 0px; background: rgb(15, 209, 209); width: 100%"">學員</h5>
                            <div id=""uid"" style=""display:none;""></div>
                            <ul id=""stList"" class=""students"" style=""list-style-type: none; padding-left: 0px; margin-bottom: 0px"">

");
#nullable restore
#line 56 "D:\Documents\repo\IIFIDB\WorkoutHunterV2\Views\Coach\Index.cshtml"
                                 foreach (var item in Model)
                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    <li class=\"student\">\r\n                                        <button class=\"tablinks\"");
                BeginWriteAttribute("onclick", " onclick=\"", 2798, "\"", 2857, 7);
                WriteAttributeValue("", 2808, "student_display(event,", 2808, 22, true);
                WriteAttributeValue(" ", 2830, "\'", 2831, 2, true);
#nullable restore
#line 59 "D:\Documents\repo\IIFIDB\WorkoutHunterV2\Views\Coach\Index.cshtml"
WriteAttributeValue("", 2832, item.Uid, 2832, 9, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 2841, "\',", 2841, 2, true);
                WriteAttributeValue(" ", 2843, "\'", 2844, 2, true);
#nullable restore
#line 59 "D:\Documents\repo\IIFIDB\WorkoutHunterV2\Views\Coach\Index.cshtml"
WriteAttributeValue("", 2845, item.Name, 2845, 10, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 2855, "\')", 2855, 2, true);
                EndWriteAttribute();
                WriteLiteral(" id=\"defaultOpen\">\r\n                                            ");
#nullable restore
#line 60 "D:\Documents\repo\IIFIDB\WorkoutHunterV2\Views\Coach\Index.cshtml"
                                       Write(item.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                        </button>\r\n                                    </li>\r\n");
#nullable restore
#line 63 "D:\Documents\repo\IIFIDB\WorkoutHunterV2\Views\Coach\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                            </ul>
                        </div>
                        <!-- 設定(齒輪) -->
                        <button id=""setbtn"" type=""button"" data-bs-toggle=""modal"" data-bs-target=""#staticBackdrop"">
                            <img src=""/coach/img/settings.png""");
                BeginWriteAttribute("alt", " alt=\"", 3349, "\"", 3355, 0);
                EndWriteAttribute();
                WriteLiteral(@" style=""width: 100px; height: 100px; align-items: center"" />
                        </button>
                    </div>
                </div>

                <div class=""col-sm-6 col-lg-6 col-xl-7"" style=""align-items: center; text-align: center"">
                    <div class=""StudentInformationOut"">
                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3128bb187d9316c579d981d364033a8faaf5440320217", async() => {
                    WriteLiteral(@"
                            <div style=""padding-bottom: 2%; border-bottom: 2px white solid"">
                                <h1>學生資訊</h1>
                            </div><br>
                            <!-- 學員 -->
                            <div class=""row"">
                                <div class=""col-sm-3 StudentContentFormat"">
                                    <h4>學員姓名：</h4>
                                </div>
                                <div class=""col-sm-7 studentPointColumn"">
                                    <input class=""st_inputName"" id=""SName"" name=""Name""
                                           style="" text-align: center;"">
                                </div>
                            </div><br>
                            <div class=""row"">
                                <div class=""col-sm-3 StudentContentFormat"">
                                    <h4>學員ID：</h4>
                                </div>
                                <div class=""col-sm-");
                    WriteLiteral(@"7 studentPointColumn"">
                                    <input class=""st_inputName"" id=""SID"" name=""UID""
                                           style="" text-align: center;"">
                                </div>
                            </div><br>
                            <!-- 上肢 -->
                            <br /><br />
                            <div class=""row"">
                                <div class=""col-sm-3 StudentContentFormat"">
                                    <h2>上肢</h2>
                                </div>
                                <div class=""col-sm-7 studentPointColumn"">
                                    <input class=""st_inputName"" id=""n1"" />
                                    <!--上肢值數 -->
                                </div>
                            </div>
                            <br /><br /><br /><br />
                            <!-- 核心 -->
                            <div class=""row"">
                                <div class=""co");
                    WriteLiteral(@"l-sm-3 StudentContentFormat"">
                                    <h2>核心</h2>
                                </div>
                                <div class=""col-sm-7 studentPointColumn"">
                                    <input class=""st_inputName"" id=""n2"" />
                                    <!--核心值數 -->
                                </div>
                            </div>
                            <br /><br /><br /><br />
                            <!-- 下肢 -->
                            <div class=""row"">
                                <div class=""col-sm-3 StudentContentFormat"">
                                    <h2>下肢</h2>
                                </div>
                                <div class=""col-sm-7 studentPointColumn"">
                                    <input class=""st_inputName"" id=""n3"" />
                                    <!--下肢值數 -->
                                </div>
                            </div>
                            <br /><br /><b");
                    WriteLiteral(@"r />
                            <div class=""row"">
                                <div class=""col-sm-12"" style=""display: inline"">
                                    <div class=""col-12"" style=""justify-content: center; text-align: center"">
                                        <div>

                                            <button type=""button"" id=""select_determine"" class=""btn btn-primary btn-lg"" data-bs-toggle=""modal"" data-bs-target=""#submitwindow"">
                                                送出
                                            </button>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_7.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    </div>\r\n                </div>\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3128bb187d9316c579d981d364033a8faaf5440326003", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
            </div>
        </div>
    </div>

    <!-- 案設定(齒輪)之後出現隻畫面(Bootstrap) -->
    <div class=""modal fade""
         id=""staticBackdrop""
         data-bs-backdrop=""static""
         data-bs-keyboard=""false""
         tabindex=""-1""
         aria-labelledby=""staticBackdropLabel""
         aria-hidden=""true"">
        <div class=""modal-dialog modal-dialog-centered modal-dialog-scrollable modal-dialog modal-lg"">
            <div class=""modal-content"">
                <div class=""modal-header"">
                    <div style=""text-align: center; width: 760px"">
                        <h5 class=""modal-title"" id=""staticBackdropLabel"" style=""display: inline-block"">系統設定</h5>
                    </div>
                    <button type=""button"" class=""btn-close"" data-bs-dismiss=""modal"" aria-label=""Close"" style=""margin-left: 0%""></button>
                </div>
                <div class=""modal-body"">
                    <div class=""d-grid gap-2 col-6 mx-auto"">
                        <a href=""/C");
                WriteLiteral(@"oach/Register"" class=""btn btn-brown btn-primary"">註冊帳號</a>
                        <a href=""/Home/Logoff"" class=""btn btn-brown btn-primary"">帳號登出</a>
                        <a href=""/Home/ForgotPassword"" class=""btn btn-brown btn-primary"">修改密碼</a>
                    </div>
                    <br /><br />
                </div>
                <div class=""modal-footer"">
                    <button type=""button"" id=""exit"" class=""btn btn-primary"" data-bs-dismiss=""modal"">離開</button>
                </div>
            </div>
        </div>
    </div>

    <!--確認送出資料 視窗 -->
    <div class=""modal fade""
         id=""submitwindow""
         data-bs-backdrop=""static""
         data-bs-keyboard=""false""
         tabindex=""-1""
         aria-labelledby=""submitwindowLabel""
         aria-hidden=""true"">
        <div class=""modal-dialog modal-dialog-centered modal-dialog-scrollable modal-dialog modal-lg"">
            <div class=""modal-content"">
                <div class=""modal-header"">
                  ");
                WriteLiteral(@"  <div style=""text-align: center; width: 100px"">
                        <h5 class=""modal-title"" id=""submitwindowLabel"" style=""display: inline-block"">確認送出</h5>
                    </div>
                    <button type=""button"" class=""btn-close"" data-bs-dismiss=""modal"" aria-label=""Close"" style=""margin-left: 0%""></button>
                </div>
                <div class=""modal-body"">
                    <div class=""d-grid gap-2 col-6 mx-auto"" style=""text-align:center"">
                        <div id=""checkMsg"" style=""text-align:left"">
                            確認送出嗎?
                            <hr>
                            上肢： <br>
                            核心： <br>
                            下肢：
                        </div>
                    </div>
                    <br /><br />
                </div>
                <div class=""modal-footer"">
                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3128bb187d9316c579d981d364033a8faaf5440330242", async() => {
                    WriteLiteral(@"
                        <input id=""str"" name=""str"" style=""display:none"" />
                        <input id=""vit"" name=""vit"" style=""display:none"" />
                        <input id=""agi"" name=""agi"" style=""display:none"" />
                        <input id=""uidpost"" name=""uid"" style=""display:none"" />
                        <button type=""button"" id=""exit"" class=""btn btn-danger"" data-bs-dismiss=""modal"">取消</button>
                        <button type=""submit"" id=""exit"" class=""btn btn-success"" data-bs-dismiss=""modal"">確認</button>
                    ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_7.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_11);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                </div>
            </div>
        </div>
    </div>

    <script>
        document.getElementById(""select_determine"").addEventListener(""click"", function () {
            var id = document.getElementById(""uid"").innerText;
            var name = document.getElementById(""SName"").value;

            document.getElementById(""str"").value = document.getElementById(""n1"").value;
            document.getElementById(""vit"").value = document.getElementById(""n2"").value;
            document.getElementById(""agi"").value = document.getElementById(""n3"").value;
            document.getElementById(""uidpost"").value = id;

            var str2 = document.getElementById(""str"").value;
            var vit2 = document.getElementById(""vit"").value;
            var agi2 = document.getElementById(""agi"").value;


            console.log(id);

            document.getElementById(""checkMsg"").innerHTML =
                `確認送出成長點數嗎？
                            <hr>
                            學員姓名：【${");
                WriteLiteral(@"name}】
                            <hr>
                            學員ID：【${id}】
                            <hr>
                            上肢：【${str2}】 || 核心：【${vit2}】 || 下肢：【${agi2}】
                            <hr>`;
        });

        document.getElementById(""SName"").value = """";
        document.getElementById(""SID"").value = """";
    </script>

    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3128bb187d9316c579d981d364033a8faaf5440333987", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_12);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
    <script>

        var FormPut = document.getElementById(""InPut"");

        FormPut.addEventListener(""submit"", function () {
            alert(""學員成長點數已送出"");

            var connection = new signalR.HubConnectionBuilder().withUrl(""/chatHub"").build();

            var str = document.getElementById(""str"").value;
            var vit = document.getElementById(""vit"").value;
            var agi = document.getElementById(""agi"").value;
            var uid = document.getElementById(""uidpost"").value;

            connection
                .start()
                .catch(function (err) {
                    return console.error(err.toString());
                });

            connection
                .invoke(""SendMessage"", uid, str, vit, agi)
                .then(function () {
                    document.getElementById(""n1"").value = """";
                    document.getElementById(""n2"").value = """";
                    document.getElementById(""n3"").value = """";
                })
     ");
                WriteLiteral("           .catch(function (err) {\r\n                    return console.error(err.toString());\r\n                });\r\n        });\r\n    </script>\r\n");
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
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<WorkoutHunterV2.Models.DbModels.UserInfo>> Html { get; private set; }
    }
}
#pragma warning restore 1591
