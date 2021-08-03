#pragma checksum "D:\Documents\repo\IIFIDB\WorkoutHunterV2\Views\Adventure\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6bd32e33ecb64146dd2cbf1c5e093f609096631e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Adventure_Index), @"mvc.1.0.view", @"/Views/Adventure/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6bd32e33ecb64146dd2cbf1c5e093f609096631e", @"/Views/Adventure/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2abd6266556f2f159f525da65ff1c131f0f7178f", @"/Views/_ViewImports.cshtml")]
    public class Views_Adventure_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WorkoutHunterV2.Models.Adventure.ViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\n<html lang=\"en\">\n\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6bd32e33ecb64146dd2cbf1c5e093f609096631e3798", async() => {
                WriteLiteral(@"
    <meta charset=""UTF-8"">
    <title>Monster</title>
    <meta name=""viewport"" content=""width=device-width, initial-scale=1"">
    <link href=""./css/bootstrap.min.css"" rel=""stylesheet"">
    <link href=""./js/bootstrap.min.js"" rel=""stylesheet"">
    <link href=""./dist/rpgui.min.css"" rel=""stylesheet"" type=""text/css"">



    <style type=""text/css"">
        body {
            background-image: url(./image/BG5.png);
            background-repeat: no-repeat;
            background-position: center center;
            background-attachment: fixed;
            -o-background-size: 100% 100%, auto;
            -moz-background-size: 100% 100%, auto;
            -webkit-background-size: 100% 100%, auto;
            background-size: 100% 100%, auto;
        }

        .header_div {
            height: 12vh;
        }

        .nav_div {
            height: 65vh;
        }

            .nav_div > img {
                height: 65vh;
            }

        .info_div {
            border-image-width: 1.5vh;
            border-");
                WriteLiteral(@"width: 1.5vh;
            box-sizing: border-box;
            border-image-repeat: repeat;
            padding: 2vh;
            border-style: solid;
            border-image-source: url(./dist/img/border-image-golden.png);
            border-image-slice: 4 4 4 4;
            -moz-box-sizing: border-box;
            -webkit-box-sizing: border-box;
            background: url(./dist/img/background-image-golden.png) center;
            background-clip: padding-box;
            background-origin: padding-box;
        }

        .footer_div {
            height: 22vh;
        }

        p {
            margin: 2vh;
        }


        .endInfo_div {
            color: white;
            text-shadow: 1px black;
            font-family: 'Press Start 2P';
            font-style: normal;
            font-weight: 400;
            src: local('Press Start 2P'), local('PressStart2P-Regular'), url(https://fonts.gstatic.com/s/pressstart2p/v4/8Lg6LX8-ntOHUQnvQ0E7o3uGXJk6cuEylToZ-uuaubQ.ttf) format('truetype')
        }

   ");
                WriteLiteral(@"     .skillBtn1 {
            position: absolute;
            background-image: url(./image/skill.png);
            background-repeat: no-repeat;
            background-size: cover;
            right: 5%;
            bottom: 4%;
            height: 9vh;
            width: 10vh;
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
            WriteLiteral("\n\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6bd32e33ecb64146dd2cbf1c5e093f609096631e7206", async() => {
                WriteLiteral(@"

    <div class=""container-fluid"">
        <div class=""rpgui-content"">
            <div class=""center_div"">
                <div class=""row"">
                    <div class=""col-12 header_div"">
                        <div id=""hp-bar"" class=""rpgui-progress red ""></div>
");
                WriteLiteral(@"                        <p id=""ShowStage"" class=""font_s"">Stage:</p>
                    </div>
                    <div class=""col-lg-6 col-12"">
                    </div>
                    <div class=""col-lg-6 col-12 nav_div"">
                        <img src=""./image/DRG1.gif"" alt=""lost"" class=""img-fluid  rounded mx-auto d-block"" id=""monImg"">
                    </div>
                    <div class=""col-12"">
                        <div class=""col-12"">
                            <div class=""row"">
                                <div class=""col-md-10 col-12""></div>
                                <div class=""col-md-2 col-12 "">
                                    <button class=""skillBtn1 info_div footer_div"" id=""skillBtn""></button>
                                </div>
                            </div>
                        </div>
                        <div class=""row px-2 g-2"">
                            <div class=""col-md-5 col-12 info_div footer_div"">
                                <div id=""sta");
                WriteLiteral("mina-bar\" class=\"rpgui-progress green\"></div>\n");
                WriteLiteral(@"                                <p id=""ShowDPS"">DPS:</p>

                            </div>
                            <div class=""col-md-4 col-12"">
                            </div>
                            <div class=""col-md-2 col-12"">
                            </div>
                            <div class=""col-md-1 col-12"">
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>

    <!-- Modal -->
    <div class=""modal fade"" id=""exampleModal"" tabindex=""-1"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
        <div class=""modal-dialog modal-dialog-centered"">
            <div class=""modal-content endInfo_div info_div"">
                <div class=""modal-header justify-content-center"">
                    <h5 class=""modal-title"" id=""exampleModalLabel"">Result</h5>
                </div>
                <div id=""money"" class=""modal-body text-center"">
                    <img src=""./image/co");
                WriteLiteral("in-去背.png\"");
                BeginWriteAttribute("alt", " alt=\"", 4937, "\"", 4943, 0);
                EndWriteAttribute();
                WriteLiteral(@" style=""height: 5vh;"">
                    Coin:10
                </div>
                <div class=""modal-footer justify-content-center"">
                    <button type=""button"" class=""btn rpgui-button"" onclick=""reflash1()"">OK</button>
                </div>
            </div>
        </div>
    </div>
    <script src=""./dist/rpgui.min.js""></script>
    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6bd32e33ecb64146dd2cbf1c5e093f609096631e10588", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n    <script src=\"./js/popper.min.js\"></script>\n    <script src=\"./js/bootstrap.min.js\"></script>\n\n");
                WriteLiteral("    <div hidden id=\"monsterMaxHP\">");
#nullable restore
#line 155 "D:\Documents\repo\IIFIDB\WorkoutHunterV2\Views\Adventure\Index.cshtml"
                             Write(Model.VM.maxHP);

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\n    <div hidden id=\"monsterNowHP\">");
#nullable restore
#line 156 "D:\Documents\repo\IIFIDB\WorkoutHunterV2\Views\Adventure\Index.cshtml"
                             Write(Model.VM.HP);

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\n    <div hidden id=\"monsterDamage\">");
#nullable restore
#line 157 "D:\Documents\repo\IIFIDB\WorkoutHunterV2\Views\Adventure\Index.cshtml"
                              Write(Model.VM.AD);

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\n    <div hidden id=\"monImgName\">");
#nullable restore
#line 158 "D:\Documents\repo\IIFIDB\WorkoutHunterV2\Views\Adventure\Index.cshtml"
                           Write(Model.VM.Pic);

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\n    <div hidden id=\"monMoney\">");
#nullable restore
#line 159 "D:\Documents\repo\IIFIDB\WorkoutHunterV2\Views\Adventure\Index.cshtml"
                         Write(Model.VM.Money);

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\n    <div hidden id=\"playerMaxHP\">");
#nullable restore
#line 160 "D:\Documents\repo\IIFIDB\WorkoutHunterV2\Views\Adventure\Index.cshtml"
                            Write(Model.VH.maxHP);

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\n    <div hidden id=\"playerNowHP\">");
#nullable restore
#line 161 "D:\Documents\repo\IIFIDB\WorkoutHunterV2\Views\Adventure\Index.cshtml"
                            Write(Model.VH.HP);

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\n    <div hidden id=\"playerDPS\">");
#nullable restore
#line 162 "D:\Documents\repo\IIFIDB\WorkoutHunterV2\Views\Adventure\Index.cshtml"
                          Write(Model.VH.DPS);

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\n    <div hidden id=\"skillDamage\">");
#nullable restore
#line 163 "D:\Documents\repo\IIFIDB\WorkoutHunterV2\Views\Adventure\Index.cshtml"
                            Write(Model.VH.NowSkill.DmgSkill);

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\n    <div hidden id=\"skillCD\">");
#nullable restore
#line 164 "D:\Documents\repo\IIFIDB\WorkoutHunterV2\Views\Adventure\Index.cshtml"
                        Write(Model.VH.NowSkill.CD);

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\n    <div hidden id=\"skillImgName\">");
#nullable restore
#line 165 "D:\Documents\repo\IIFIDB\WorkoutHunterV2\Views\Adventure\Index.cshtml"
                             Write(Model.VH.NowSkill.PicSkill);

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\n    <div hidden id=\"Stage\">");
#nullable restore
#line 166 "D:\Documents\repo\IIFIDB\WorkoutHunterV2\Views\Adventure\Index.cshtml"
                      Write(Model.VM.CPoint);

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\n");
                WriteLiteral(@"
<script>
    //For DB data use
    //-------------------
    var monsterMaxHP = parseInt(document.querySelector(""#monsterMaxHP"").innerText);
    var monsterNowHP = parseInt(document.querySelector(""#monsterNowHP"").innerText);
    var monsterDamage = parseInt(document.querySelector(""#monsterDamage"").innerText);
    var monImgName = document.querySelector(""#monImgName"").innerText;
    var monMoney = parseInt(document.querySelector(""#monMoney"").innerText);
    var playerMaxHP = parseInt(document.querySelector(""#playerMaxHP"").innerText);
    var playerNowHP = parseInt(document.querySelector(""#playerNowHP"").innerText);
    var playerDPS = parseInt(document.querySelector(""#playerDPS"").innerText);
    var skillDamage = parseInt(document.querySelector(""#skillDamage"").innerText);
    var skillCD = parseInt(document.querySelector(""#skillCD"").innerText);
    var skillImgName = document.querySelector(""#skillImgName"").innerText;
    var Stage = parseInt(document.querySelector(""#Stage"").innerText);
    //------------------");
                WriteLiteral(@"--

    // 後端新增 START
    //console.log(`monsterMaxHP ${monsterMaxHP}`);
    //console.log(`monsterNowHP ${monsterNowHP}`);
    //console.log(`monsterDamage ${monsterDamage}`);
    //console.log(`monImgName ${monImgName}`);
    //console.log(`playerMaxHP ${playerMaxHP}`);
    //console.log(`playerNowHP ${playerNowHP}`);
    //console.log(`playerDPS ${playerDPS}`);
    //console.log(`skillDamage ${skillDamage}`);
    //console.log(`skillCD ${skillCD}`);
    //console.log(`skillImgName ${skillImgName}`);
    //console.log(`Stage ${Stage}`)
    document.querySelector(""#ShowStage"").innerText = `Stage: ${Stage}`;
    document.querySelector(""#ShowDPS"").innerText = `DPS: ${playerDPS}`;
    document.querySelector(""#skillBtn"").style.backgroundImage = `url(/student/img/skill_icon/${skillImgName})`;
    document.querySelector(""#monImg"").setAttribute(""src"", `./image/${monImgName}`);
    document.querySelector(""#money"").innerText = `Coin: ${monMoney}`;

    var monHpCounter = (monsterNowHP / monsterMaxHP).toFixed(2);
    ");
                WriteLiteral(@"var playerHpCounter = (playerNowHP / playerMaxHP).toFixed(2);
    var playerDamagePercentage = (playerDPS / monsterMaxHP).toFixed(2);
    var monsterDamagePercentage = (monsterDamage / playerMaxHP).toFixed(2);
    var skillDamagePercentage = (skillDamage / monsterMaxHP).toFixed(2);
    window.onload = function () {
        hpBarUpdate(playerHpCounter, ""stamina-bar"")
        hpBarUpdate(monHpCounter, ""hp-bar"")
    }
    // 後端新增 END
    var skillCDms = skillCD * 1000;
    var mon = window.setInterval(""monHpCnt()"", 1000);  //controll monster attack speed(ms)
    var player = window.setInterval(""playerHpCnt()"", 5000);  //controll player attack speed(ms)

    $(document).ready(function () {

        $(""#skillBtn"").click(function () {
            monHpCounter = monHpCounter - skillDamagePercentage;
            $(""#skillBtn"").prop('disabled', true);
            console.log('disable')
            setTimeout(function () {
                $(""#skillBtn"").prop('disabled', false);
                console.log('enable')
   ");
                WriteLiteral(@"         }, skillCDms)
        })


    });

    function monHpCnt() {
        if (monHpCounter - playerDamagePercentage <= 0) {
            hpBarUpdate(0, ""hp-bar"")
            //後端新增
            Stage++;
            ////
            endOfBattle();
        }
        else {
            monHpCounter = monHpCounter - playerDamagePercentage;
            hpBarUpdate(monHpCounter, ""hp-bar"")
        }
    }

    function playerHpCnt() {
        if (playerHpCounter - monsterDamagePercentage <= 0) {
            hpBarUpdate(0, ""stamina-bar"")
            //後端新增
            Stage--;
            monMoney = 0;
            ////
            endOfBattle();
        }
        else {
            playerHpCounter = playerHpCounter - monsterDamagePercentage;
            hpBarUpdate(playerHpCounter, ""stamina-bar"")
        }
        
    }

    function hpBarUpdate(HpCounter, controll) {
        var progress = document.getElementById(controll);
        RPGUI.set_value(progress, HpCounter);
    }

    function endOfBattle() {
       ");
                WriteLiteral(@" $(""#monImg"").fadeTo(3000, 0);
        var modalElement = new bootstrap.Modal(document.getElementById('exampleModal'), {
            keyboard: false
        })
        modalElement.show()
        window.clearInterval(mon)
        window.clearInterval(player)
    }

    function reflash1() {
        // 後端新增
        data = {
            Stage: Stage,
            Money: monMoney,
        };
        rqs = new XMLHttpRequest();
        rqs.onload = function () {
            console.log(rqs.responseText);
            if (rqs.responseText == ""OK"")
                history.go(0)
        }
<<<<<<< HEAD
        rqs.open(""POST"", ""/Adventure/NewRound"");
=======
        rqs.open(""POST"", ""/Adventure/NewRound""); 
>>>>>>> bf41df21e5fe8c2912a7e03b6f831d48b0de92c2
        rqs.setRequestHeader('Content-type', 'application/json');
        rqs.send(JSON.stringify(data));
        ////
    }


</script>

");
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
            WriteLiteral("\n\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WorkoutHunterV2.Models.Adventure.ViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591