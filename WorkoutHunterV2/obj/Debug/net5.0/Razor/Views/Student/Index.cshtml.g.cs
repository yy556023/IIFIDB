#pragma checksum "C:\Users\ub\Desktop\github\IIFIDB\WorkoutHunterV2\Views\Student\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "66837ebcb320b281890eede0d26be76eb087f012"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Student_Index), @"mvc.1.0.view", @"/Views/Student/Index.cshtml")]
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
#line 1 "C:\Users\ub\Desktop\github\IIFIDB\WorkoutHunterV2\Views\_ViewImports.cshtml"
using WorkoutHunterV2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ub\Desktop\github\IIFIDB\WorkoutHunterV2\Views\_ViewImports.cshtml"
using WorkoutHunterV2.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"66837ebcb320b281890eede0d26be76eb087f012", @"/Views/Student/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ade2848f6e6c2b85a6e5e0359cdcd44f6f531ae2", @"/Views/_ViewImports.cshtml")]
    public class Views_Student_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WorkoutHunterV2.Models.DbModels.ForIndex>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/student/css/bootstrap.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/student/js/bootstrap.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/student/dist/rpgui.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/student/main.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "66837ebcb320b281890eede0d26be76eb087f0125607", async() => {
                WriteLiteral(@"
    <!-- <link href =""main.css"" rel=""stylesheet"" type=""text/css""> -->

    <title>Main</title>
    <meta http-equiv=""content-type"" content=""text/html; charset=utf-8"">
    <link href='https://fonts.googleapis.com/css?family=Press+Start+2P' rel='stylesheet' type='text/css'>
    <!-- include rpgui -->
    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "66837ebcb320b281890eede0d26be76eb087f0126184", async() => {
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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "66837ebcb320b281890eede0d26be76eb087f0127363", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "66837ebcb320b281890eede0d26be76eb087f0128542", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "66837ebcb320b281890eede0d26be76eb087f0129808", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"


    <style type=""text/css"">
        body {
            background-image: url(/student/img/indexBG.gif);
            background-repeat: no-repeat;
            background-position: center center;
            background-attachment: fixed;
            -o-background-size: 100% 100%, auto;
            -moz-background-size: 100% 100%, auto;
            -webkit-background-size: 100% 100%, auto;
            background-size: 100% 100%, auto;
        }
        html,body{
            height :100%;
        }
        .header_div {
            height: 22vh;
        }

        .nav_div {
            height: 55vh;
        }

        .logo_div {
            background: rgba(255, 255, 255, 0.452);
            border-radius: 2vh;
            height: 18vh;
            text-align: center;
            line-height: 18vh;
        }

            .logo_div > img {
                max-width: 90%;
            }

        .border_style {
            border-image-width: 0.5vh;
            border-wid");
                WriteLiteral(@"th: 0.5vh;
            box-sizing: border-box;
            border-image-repeat: repeat;
            padding: 0.5vh;
            border-style: solid;
            border-image-source: url(/student/dist/img/border-image-gold.png);
            border-image-slice: 3 3 3 3;
            -moz-box-sizing: border-box;
            -webkit-box-sizing: border-box;
            background: rgba(32, 32, 32, 0.637);
            background-clip: padding-box;
            background-origin: padding-box;
        }


        .info_div {
            height: 3vh;
        }

        .rpgFont_style {
            color: white;
            text-shadow: 1px black;
            font-style: normal;
            line-height: 1vh;
            text-shadow: 0.2em 0.2em 0.2em black
        }

        /* pop div seat */
        .pop_div {
            margin-left: 30vh;
            margin-top: 25vh;
        }

        #slot_1, #slot_2, #AdvBtn {
            image-rendering: optimize-contrast; /* CSS3 Proposed  */
");
                WriteLiteral("            image-rendering: crisp-edges; /* CSS4 Proposed  */\r\n            image-rendering: pixelated; /* CSS4 Proposed  */\r\n            -ms-interpolation-mode: nearest-neighbor;\r\n        }\r\n\r\n        \r\n    </style>\r\n");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "66837ebcb320b281890eede0d26be76eb087f01214041", async() => {
                WriteLiteral(@"
    <!-- 目前版面在4K解析度下會跑圖 ==>展示會用手機版面 -->
    <div class=""container-fluid"">
        <div class=""center_div"">
            <div class=""row"">
                <div class=""col-12 header_div"">
                    <div class=""row "">
                        <div class=""col-lg-2 col-3 text-center"">
                            <img id=""RankPicture"" src=""/student/img/rankIcon_S.png"" alt=""lost"" class=""img-fluid m-2"">
                        </div>
                        <div class=""col-lg-6 col-9"">
                            <div class=""row m-3"">
                                <div class=""col-12 border_style rpgFont_style "">
                                    <div>
                                        <h3>ID:");
#nullable restore
#line 110 "C:\Users\ub\Desktop\github\IIFIDB\WorkoutHunterV2\Views\Student\Index.cshtml"
                                          Write(Model.Uid);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h3>\r\n                                    </div><br>\r\n                                    <div>\r\n                                        <h3>$:");
#nullable restore
#line 113 "C:\Users\ub\Desktop\github\IIFIDB\WorkoutHunterV2\Views\Student\Index.cshtml"
                                         Write(Model.Money);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h3>\r\n                                    </div>\r\n                                </div>\r\n                                <div class=\"col-4 border_style rpgFont_style \">\r\n                                    <h5>STR:");
#nullable restore
#line 117 "C:\Users\ub\Desktop\github\IIFIDB\WorkoutHunterV2\Views\Student\Index.cshtml"
                                       Write(Model.Strength);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h5>\r\n                                </div>\r\n                                <div class=\"col-4 border_style rpgFont_style \">\r\n                                    <h5>VIT:");
#nullable restore
#line 120 "C:\Users\ub\Desktop\github\IIFIDB\WorkoutHunterV2\Views\Student\Index.cshtml"
                                       Write(Model.Vitality);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h5>\r\n                                </div>\r\n                                <div class=\"col-4 border_style rpgFont_style \">\r\n                                    <h5>AGI:");
#nullable restore
#line 123 "C:\Users\ub\Desktop\github\IIFIDB\WorkoutHunterV2\Views\Student\Index.cshtml"
                                       Write(Model.Agility);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</h5>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <div class=""col-12 "">
                    <div class=""row justify-content-center align-items-center"">
                        <div class=""col-lg-9 col-12 nav_div"">
                            <div class=""row"">
                                <div class=""col-3 "">
                                    <div class=""logo_div"">
                                        <a href=""javascript:void(0)""
                                           onclick=""document.getElementById('openBag').style.display='block';""
                                           class=""btn"">
                                            <img src=""/student/img/box.png""");
                BeginWriteAttribute("alt", " alt=\"", 5268, "\"", 5274, 0);
                EndWriteAttribute();
                WriteLiteral(@" class=""img-fluid p-2 Btn"">
                                        </a>
                                    </div>

                                    <div class=""logo_div"">
                                        <a href=""javascript:void(0)""
                                           onclick=""document.getElementById('openNew').style.display='block';""
                                           class=""Btn"">
                                            <img src=""/student/img/scroll.png""");
                BeginWriteAttribute("alt", " alt=\"", 5773, "\"", 5779, 0);
                EndWriteAttribute();
                WriteLiteral(@" class=""img-fluid p-2 Btn"">
                                        </a>
                                    </div>

                                    <div class=""logo_div"">
                                        <img src=""/student/img/shop.png"" onclick=""location.href='/Student/Shop'""");
                BeginWriteAttribute("alt", " alt=\"", 6073, "\"", 6079, 0);
                EndWriteAttribute();
                WriteLiteral(@" class=""img-fluid p-2 Btn"">
                                    </div>
                                </div>
                                <div class=""col-6 d-flex align-items-sm-start flex-column"">
                                    <div class=""mt-auto text-center"">
                                        <img src=""/student/img/main.gif""");
                BeginWriteAttribute("alt", " alt=\"", 6429, "\"", 6435, 0);
                EndWriteAttribute();
                WriteLiteral(@" class=""img-fluid"" style=""height:50vh;"">
                                    </div>
                                </div>
                                <div class=""col-3 "">
                                    <div class=""logo_div"">
                                        <img src=""/student/img/workout.png"" onclick=""location.href='/Student/PowerUp'""");
                BeginWriteAttribute("alt", " alt=\"", 6794, "\"", 6800, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"img-fluid p-2 Btn\">\r\n                                    </div>\r\n                                    <div class=\"logo_div\">\r\n                                        <img src=\"/student/img/skillBook.png\" onclick=\"location.href=\'/Student/SkillTree\'\"");
                BeginWriteAttribute("alt", " alt=\"", 7056, "\"", 7062, 0);
                EndWriteAttribute();
                WriteLiteral(@" class=""img-fluid p-2 Btn"">
                                    </div>
                                    <div class=""logo_div"">
                                        <img src=""/student/img/setting.png"" onclick=""location.href='/Student/PasswordChange'""");
                BeginWriteAttribute("alt", " alt=\"", 7321, "\"", 7327, 0);
                EndWriteAttribute();
                WriteLiteral(@" class=""img-fluid p-2 Btn"">
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <div class=""col-12"">
                    <div class=""row"">
                        <div class=""col-md-4 col-12 info_div""></div>
                        <div class=""col-md-4 col-12 border_style text-center"">
                            <div class=""rpgui-icon potion-slot mx-4"" id=""slot_1""></div>
                            <div class=""rpgui-icon magic-slot mx-4"" id=""slot_2""></div>
                        </div>
                        <div class=""col-md-1 col-12"">
                        </div>
                        <div class=""col-md-3 col-12 text-center"">
                            <button type=""button"" onclick=""location.href='/Adventure/Index'"" class=""btn rpgui-button rpgFont_style m-1"" id=""AdvBtn"">
                                <h3 class=""fw-bolde");
                WriteLiteral(@"r"">Adventure!!</h3>
                            </button>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>

    <div class=""rpgui-content pop_div"" id=""openBag"" style=""display: none; width:auto; height:auto"">
        <div class=""rpgui-container framed rpgui-draggable"" id=""inventory"">
            <div>
                <a href=""javascript:void(0)"" onclick=""document.getElementById('openBag').style.display='none';"">
                    X Close
                </a>
            </div>


            <hr />

");
#nullable restore
#line 205 "C:\Users\ub\Desktop\github\IIFIDB\WorkoutHunterV2\Views\Student\Index.cshtml"
              
                int index = 0;
                int tempNumber = 0;
                for (int i = 0; i < 20; i++)
                {
                    if (i != 0 && i % 4 == 0)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <br /><br />\r\n");
#nullable restore
#line 213 "C:\Users\ub\Desktop\github\IIFIDB\WorkoutHunterV2\Views\Student\Index.cshtml"
                    };

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <div class=\"rpgui-icon empty-slot\">\r\n");
#nullable restore
#line 215 "C:\Users\ub\Desktop\github\IIFIDB\WorkoutHunterV2\Views\Student\Index.cshtml"
                         if (index < ViewBag.Items.Count)
                        {
                            if (i < ViewBag.Items[index].quantity + tempNumber - 1)
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <div class=\"itemImg item_001 Btn itemIcon\" onclick=\"pdItem(this)\"");
                BeginWriteAttribute("style", " style=\"", 9592, "\"", 9676, 3);
                WriteAttributeValue("", 9600, "background-image:url(\'/student/xMallPic/", 9600, 40, true);
#nullable restore
#line 219 "C:\Users\ub\Desktop\github\IIFIDB\WorkoutHunterV2\Views\Student\Index.cshtml"
WriteAttributeValue("", 9640, ViewBag.Items[index].Item.ItemPic, 9640, 34, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 9674, "\')", 9674, 2, true);
                EndWriteAttribute();
                WriteLiteral(">\r\n                                    <div class=\"disc\">\r\n                                        <div class=\"rpgui-container framed-grey\" style=\"width:100%; height:100%; left:0px; top:0px;\">\r\n                                            <label>");
#nullable restore
#line 222 "C:\Users\ub\Desktop\github\IIFIDB\WorkoutHunterV2\Views\Student\Index.cshtml"
                                              Write(ViewBag.Items[index].Item.ItemInfo);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n                                        </div>\r\n                                    </div>\r\n                                </div>\r\n");
#nullable restore
#line 226 "C:\Users\ub\Desktop\github\IIFIDB\WorkoutHunterV2\Views\Student\Index.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <div class=\"itemImg item_001 Btn itemIcon\" onclick=\"pdItem(this)\"");
                BeginWriteAttribute("style", " style=\"", 10292, "\"", 10428, 7);
                WriteAttributeValue("", 10300, "background-image:", 10300, 17, true);
                WriteAttributeValue(" ", 10317, "url(\'/student/xMallPic/", 10318, 24, true);
#nullable restore
#line 229 "C:\Users\ub\Desktop\github\IIFIDB\WorkoutHunterV2\Views\Student\Index.cshtml"
WriteAttributeValue("", 10341, ViewBag.Items[index].Item.ItemPic, 10341, 34, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 10375, "\');width:", 10375, 9, true);
                WriteAttributeValue(" ", 10384, "100%;height:", 10385, 13, true);
                WriteAttributeValue(" ", 10397, "100%;background-size:", 10398, 22, true);
                WriteAttributeValue(" ", 10419, "contain;", 10420, 9, true);
                EndWriteAttribute();
                WriteLiteral(">\r\n                                    <div class=\"disc\">\r\n                                        <div class=\"rpgui-container framed-grey\" style=\"width:100%; height:100%; left:0px; top:0px;\">\r\n                                            <label>");
#nullable restore
#line 232 "C:\Users\ub\Desktop\github\IIFIDB\WorkoutHunterV2\Views\Student\Index.cshtml"
                                              Write(ViewBag.Items[index].Item.ItemInfo);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n                                        </div>\r\n                                    </div>\r\n                                </div>\r\n");
#nullable restore
#line 236 "C:\Users\ub\Desktop\github\IIFIDB\WorkoutHunterV2\Views\Student\Index.cshtml"
                                tempNumber += ViewBag.Items[index].quantity;
                                index++;
                            }
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("                    </div>\r\n");
#nullable restore
#line 241 "C:\Users\ub\Desktop\github\IIFIDB\WorkoutHunterV2\Views\Student\Index.cshtml"
                }
            

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
        </div>
    </div>

    <!-- news modal -->
    <div id=""openNew"" class=""rpgui-content pop_div"" style=""display:none;"">
        <div class=""rpgui-container framed rpgui-draggable"" id=""inventory"">
            <div>
                <a href=""javascript:void(0)"" onclick=""document.getElementById('openNew').style.display='none'"">
                    X Close
                </a>
            </div>
            <hr>
            <div>
                just write something here to see
            </div>
        </div>
    </div>

");
#nullable restore
#line 262 "C:\Users\ub\Desktop\github\IIFIDB\WorkoutHunterV2\Views\Student\Index.cshtml"
     if (ViewBag.SkillPic != null)
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <div style=\"display:none\" id=\"NowSkillPic\">");
#nullable restore
#line 264 "C:\Users\ub\Desktop\github\IIFIDB\WorkoutHunterV2\Views\Student\Index.cshtml"
                                              Write(ViewBag.SkillPic);

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n");
#nullable restore
#line 265 "C:\Users\ub\Desktop\github\IIFIDB\WorkoutHunterV2\Views\Student\Index.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <div style=\"display:none\" id=\"NowSkillPic\"></div>\r\n");
#nullable restore
#line 269 "C:\Users\ub\Desktop\github\IIFIDB\WorkoutHunterV2\Views\Student\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 270 "C:\Users\ub\Desktop\github\IIFIDB\WorkoutHunterV2\Views\Student\Index.cshtml"
     if (ViewBag.NowItem != null)
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <div style=\"display:none\" id=\"NowItemPic\">");
#nullable restore
#line 272 "C:\Users\ub\Desktop\github\IIFIDB\WorkoutHunterV2\Views\Student\Index.cshtml"
                                             Write(ViewBag.NowItem.ItemPic);

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n        <div style=\"display:none\" id=\"NowItemInfo\">");
#nullable restore
#line 273 "C:\Users\ub\Desktop\github\IIFIDB\WorkoutHunterV2\Views\Student\Index.cshtml"
                                              Write(ViewBag.NowItem.ItemInfo);

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n");
#nullable restore
#line 274 "C:\Users\ub\Desktop\github\IIFIDB\WorkoutHunterV2\Views\Student\Index.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <div style=\"display:none\" id=\"NowItemPic\"></div>\r\n        <div style=\"display:none\" id=\"NowItemInfo\"></div>\r\n");
#nullable restore
#line 279 "C:\Users\ub\Desktop\github\IIFIDB\WorkoutHunterV2\Views\Student\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
                WriteLiteral("    <div id=\"SQLrank\" style=\"display:none\">");
#nullable restore
#line 280 "C:\Users\ub\Desktop\github\IIFIDB\WorkoutHunterV2\Views\Student\Index.cshtml"
                                      Write(Model.Class);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</div>

    <script src=""/student/js/popper.min.js""></script>
    <script src=""/student/js/bootstrap.min.js""></script>
    <script>
        var RankStage = [""S"", ""A"", ""B"", ""C"", ""D""];
        var StrRankPicture = ""rankIcon_D.png"";
        for (let i = 0; i < RankStage.length; i++) {
            if (SQLrank.innerText == RankStage[i])
                StrRankPicture = `rankIcon_${SQLrank.innerText}.png`;
        }
        RankPicture.src = `/student/img/${StrRankPicture}`;

        // 現在技能圖片綁定
        var img = document.createElement(""img"");
        var NowSkillPic = document.querySelector(""#NowSkillPic"").innerText;
        if (NowSkillPic != """") {
            img.src = `/student/img/skill_icon/${NowSkillPic}`;
            img.style.width = ""100%"";
            img.style.height = ""100%"";
            img.className = ""itemIcon"";
            img.style.verticalAlign = ""inherit"";
            document.querySelector(""#slot_2"").appendChild(img);
        }
        ////

        // 現在道具圖片綁定
      ");
                WriteLiteral(@"  var container = document.createElement(""div"");
        var container2 = document.createElement(""div"");
        var img = document.createElement(""div"");
        var info = document.createElement(""label"");
        var NowItemPic = document.querySelector(""#NowItemPic"").innerText;
        var NowItemInfo = document.querySelector(""#NowItemInfo"").innerText;
        // 製作道具元素
        if (NowItemPic != """") {
            container.className = ""itemImg item_001 Btn itemIcon"";
            container.style.position = ""relative"";
            container.onclick = function () {
                pdItem(this);
            }
            container.style.backgroundImage = `url(/student/xMallPic/${NowItemPic})`;
            container2.className = ""disc"";
            img.className = ""rpgui-container framed-grey"";
            img.style.width = ""100%"";
            img.style.height = ""100%"";
            img.style.left = ""0px"";
            img.style.top = ""0px"";
            img.style.verticalAlign = ""inherit"";
    ");
                WriteLiteral(@"        info.innerText = NowItemInfo;

            container.appendChild(container2);
            container2.appendChild(img);
            img.appendChild(info);
            document.querySelector(""#slot_1"").appendChild(container);
        }
        ////

        // 裝備道具 -> 回傳後端資訊data => 圖片數字，後端儲存
        function pdItem(e) {
            //// 元素 ////
            // 獲取圖片數字
            var reg = /Icon(\d*).png/;
            var elementPicture = e.style.backgroundImage;
            var data = reg.exec(elementPicture)[1];
            // 裝備道具欄位的道具
            var equipBox = document.querySelector(""#slot_1 div"")
            /////////////////////////

            //// 布林 ////
            // 取消裝備道具
            var cancelItem = equipBox == e;
            if (cancelItem) {
                data = (parseInt(data) + 100).toString();
            }
            ////
            // 重複道具判定
            var repeatItem = false;
            if (equipBox != null)
                repeatItem = equipBox.s");
                WriteLiteral(@"tyle.backgroundImage == e.style.backgroundImage;

            //// 傳送後端資料 ////
            if (!repeatItem || cancelItem) {
                var rqs = new XMLHttpRequest();
                rqs.open(""post"", ""/student/saveNowItem"");
                rqs.setRequestHeader(""Content-type"", ""application/x-www-form-urlencoded"")
                rqs.onload = function () {
                    console.log(rqs.responseText);
                }
                rqs.send(`data=${data}`);
                delete rqs;
            }
        }
        /////////////////////////
        //裝備藥水:實現藥水單向(若裝備欄內沒藥水可直接裝備)、雙向置換(若裝備欄內已經有藥水，直接點擊新藥水會進行置換)，

        var x = document.getElementsByClassName('rpgui-icon empty-slot')
        for (let i = 0; i < x.length; i++) {
            x[i].addEventListener(""click"", function () {
                var Data = document.getElementById('slot_1')
                if (Data.firstElementChild != null) {
                    var x_baby = x[i].firstElementChild
                    x_baby");
                WriteLiteral(@".remove();
                    x_baby.style.position = ""relative"";
                    Data.style.position = ""static"";
                    x[i].append(Data.firstElementChild)
                    Data.append(x_baby);
                }
                else {
                    var x_baby = x[i].firstElementChild
                    x_baby.remove();
                    x_baby.style.position = ""relative"";
                    Data.append(x_baby);
                }
            })
        }

        //解除藥水:可透過點擊下方藥水裝備欄返回藥水回倉庫，會自動找空格填入

        var y = document.getElementById('slot_1')
        y.addEventListener(""click"", function () {
            var y_baby = y.firstElementChild
            if (y_baby != null) {
                var Data = document.getElementsByClassName('rpgui-icon empty-slot')
                y_baby.style.position = ""static"";
                for (var i = 0; i <= 19; i++) {
                    if (Data[i].firstElementChild == null) {
                        Data[i].append(y_");
                WriteLiteral("baby);\r\n                        break;\r\n                    }\r\n                }\r\n            }\r\n        })\r\n\r\n    </script>\r\n\r\n");
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
            WriteLiteral("\r\n</html>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WorkoutHunterV2.Models.DbModels.ForIndex> Html { get; private set; }
    }
}
#pragma warning restore 1591
