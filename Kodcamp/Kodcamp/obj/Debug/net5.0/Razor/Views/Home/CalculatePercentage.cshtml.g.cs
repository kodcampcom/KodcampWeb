#pragma checksum "C:\Users\user\Desktop\ReposKodcamp\RepoKodcamp\Dev\Kodcamp\Kodcamp\Views\Home\CalculatePercentage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dc0e4c8fae698181d9cfe2c00ead2ba0ac3179af"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_CalculatePercentage), @"mvc.1.0.view", @"/Views/Home/CalculatePercentage.cshtml")]
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
#line 1 "C:\Users\user\Desktop\ReposKodcamp\RepoKodcamp\Dev\Kodcamp\Kodcamp\Views\_ViewImports.cshtml"
using Kodcamp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\user\Desktop\ReposKodcamp\RepoKodcamp\Dev\Kodcamp\Kodcamp\Views\_ViewImports.cshtml"
using Kodcamp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dc0e4c8fae698181d9cfe2c00ead2ba0ac3179af", @"/Views/Home/CalculatePercentage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2b5280ab63654a7920e1468f98e11c2ed5684db1", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_CalculatePercentage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Kodcamp.Models.VMModels.VMChannels>
    #nullable disable
    {
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\user\Desktop\ReposKodcamp\RepoKodcamp\Dev\Kodcamp\Kodcamp\Views\Home\CalculatePercentage.cshtml"
  
    var newsList = Model.NewsList;
    var tags = Model.TagsKeyValue;
    double result = Convert.ToDouble(ViewData["Result"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dc0e4c8fae698181d9cfe2c00ead2ba0ac3179af3981", async() => {
                WriteLiteral("\n    <meta name=\"keywords\" content=\"Yüzde hesaplama, matematik, oran, hesap, indirim\">\n");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dc0e4c8fae698181d9cfe2c00ead2ba0ac3179af5036", async() => {
                WriteLiteral(@"
    <section id=""breadcrumbs"" class=""breadcrumbs"">
        <div class=""container"">

            <div class=""d-flex justify-content-between align-items-center"">

                <ol>
                    <li><a href=""/"">Anasayfa</a></li>
                    <li>Yüzde Hesaplama</li>
                </ol>
            </div>

        </div>
    </section>

    <section id=""blog"" class=""blog"">
        <div class=""container"" data-aos=""fade-up"">

            <div class=""row"">

                <div class=""col-lg-8 entries"">

                    <article class=""entry"">

                        <div class=""d-flex justify-content-center"">
                            <div>

                                <div class=""alert alert-danger"" role=""alert"" style=""text-align:center;"">
                                    <h4> Yüzde Hesaplama </h4>
                                </div>
                                <br />

                                <h4>Hesaplanacak sayıyı giriniz</h4>
                                <inpu");
                WriteLiteral("t id=\"number\" type=\"text\"");
                BeginWriteAttribute("value", " value=\"", 1334, "\"", 1342, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"form-control\" placeholder=\"100 veya 100.5\" />\n                                <br />\n\n                                <h4>Oranı giriniz</h4>\n                                <input id=\"ratio\" type=\"text\"");
                BeginWriteAttribute("value", " value=\"", 1553, "\"", 1561, 0);
                EndWriteAttribute();
                WriteLiteral(@" class=""form-control"" placeholder=""(% cinsinden)"" />
                                <br />
                                <div class=""d-flex justify-content-center"" style=""margin-top:5%;"">
                                    <button onclick=""yuzdeHesapla();"" style=""width:300px; cursor:pointer;"" type=""submit"" class=""btn btn-success center"">HESAPLA</button>
                                </div>
                                <br />
                                <hr />
                                <br />
                                <div id=""divResult"" class=""alert alert-success d-none"" role=""alert"" style=""text-align:center;"">
                                    <h2 id=""result"" class=""d-none"">  </h2>
                                </div>
                            </div>
                        </div>



                    </article><!-- End blog entry -->


                </div><!-- End blog entries list -->

                <div class=""col-lg-4"">

                    <div class=""sidebar"">

    ");
                WriteLiteral("                    <div class=\"sidebar-item \">\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dc0e4c8fae698181d9cfe2c00ead2ba0ac3179af8112", async() => {
                    WriteLiteral("\n                                <input type=\"text\" class=\"form-control\" placeholder=\"Ara...\" onkeyup=\"getQuestionsBySearch(this.value);\">\n                            ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                        </div><!-- End sidebar search formn-->


                        <h3 style=""margin-top:45px;"" class=""sidebar-title"">Uygulamalarımız</h3>
                        <div class=""sidebar-item tags"">
                            <ul>
                                <li><a style=""cursor:pointer;"" href=""/Uygulamalar/Kelime-Sayisi-Hesapla""> Kelime Sayısı Hesaplama Uygulaması</a></li>
                                <li><a style=""cursor:pointer;"" href=""/Uygulamalar/Indirim-Hesaplama""> İndirim Hesaplama Uygulaması</a></li>
                                <li><a style=""cursor:pointer;"" href=""/Uygulamalar/Yuzde-Hesaplama""> Yüzde Hesaplama Uygulaması</a></li>
                                <li><a style=""cursor:pointer;"" href=""/Uygulamalar/Kelime-Karakter-Degistirme""> Kelime Değiştirme Uygulaması </a></li>
                                <li><a style=""cursor:pointer;"" href=""/Uygulamalar/channels/-1""> Tartışma Kanalları </a></li>
                            </ul>
                        </div><!-- End");
                WriteLiteral(" sidebar tags-->\n\n                        <h3 style=\"margin-top:45px;\" class=\"sidebar-title\">Son Gönderiler</h3>\n                        <div class=\"sidebar-item recent-posts\">\n");
#nullable restore
#line 94 "C:\Users\user\Desktop\ReposKodcamp\RepoKodcamp\Dev\Kodcamp\Kodcamp\Views\Home\CalculatePercentage.cshtml"
                             foreach (var item in newsList)
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <div class=\"post-item clearfix\">\n                                    <img");
                BeginWriteAttribute("src", " src=\"", 4238, "\"", 4271, 2);
                WriteAttributeValue("", 4244, "/images/news/", 4244, 13, true);
#nullable restore
#line 97 "C:\Users\user\Desktop\ReposKodcamp\RepoKodcamp\Dev\Kodcamp\Kodcamp\Views\Home\CalculatePercentage.cshtml"
WriteAttributeValue("", 4257, item.ImageUrl, 4257, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("alt", " alt=\"", 4272, "\"", 4278, 0);
                EndWriteAttribute();
                WriteLiteral(">\n                                    <h4><a");
                BeginWriteAttribute("href", " href=\"", 4323, "\"", 4349, 2);
                WriteAttributeValue("", 4330, "/haberler/", 4330, 10, true);
#nullable restore
#line 98 "C:\Users\user\Desktop\ReposKodcamp\RepoKodcamp\Dev\Kodcamp\Kodcamp\Views\Home\CalculatePercentage.cshtml"
WriteAttributeValue("", 4340, item.Url, 4340, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 98 "C:\Users\user\Desktop\ReposKodcamp\RepoKodcamp\Dev\Kodcamp\Kodcamp\Views\Home\CalculatePercentage.cshtml"
                                                                 Write(item.Title);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a></h4>\n                                    <time datetime=\"2020-01-01\">");
#nullable restore
#line 99 "C:\Users\user\Desktop\ReposKodcamp\RepoKodcamp\Dev\Kodcamp\Kodcamp\Views\Home\CalculatePercentage.cshtml"
                                                           Write(item.DateCreated);

#line default
#line hidden
#nullable disable
                WriteLiteral("</time>\n                                </div>\n");
#nullable restore
#line 101 "C:\Users\user\Desktop\ReposKodcamp\RepoKodcamp\Dev\Kodcamp\Kodcamp\Views\Home\CalculatePercentage.cshtml"
                            }

#line default
#line hidden
#nullable disable
                WriteLiteral("\n\n                        </div><!-- End sidebar recent posts-->\n\n                        <h3 style=\"margin-top:45px;\" class=\"sidebar-title\">Etiketler</h3>\n                        <div class=\"sidebar-item tags\">\n                            <ul>\n");
#nullable restore
#line 109 "C:\Users\user\Desktop\ReposKodcamp\RepoKodcamp\Dev\Kodcamp\Kodcamp\Views\Home\CalculatePercentage.cshtml"
                                 foreach (var item in tags)
                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    <li><a style=\"cursor:pointer;\" href=\"/sorular\">");
#nullable restore
#line 111 "C:\Users\user\Desktop\ReposKodcamp\RepoKodcamp\Dev\Kodcamp\Kodcamp\Views\Home\CalculatePercentage.cshtml"
                                                                              Write(item.Key);

#line default
#line hidden
#nullable disable
                WriteLiteral(" (");
#nullable restore
#line 111 "C:\Users\user\Desktop\ReposKodcamp\RepoKodcamp\Dev\Kodcamp\Kodcamp\Views\Home\CalculatePercentage.cshtml"
                                                                                         Write(item.Value);

#line default
#line hidden
#nullable disable
                WriteLiteral(")</a></li>\n");
#nullable restore
#line 112 "C:\Users\user\Desktop\ReposKodcamp\RepoKodcamp\Dev\Kodcamp\Kodcamp\Views\Home\CalculatePercentage.cshtml"
                                }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                            </ul>
                        </div><!-- End sidebar tags-->






                    </div><!-- End sidebar -->

                </div><!-- End blog sidebar -->

            </div>

        </div>
    </section>

    <!-- Modal -->
    <div class=""modal fade"" id=""myModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalCenterTitle"" aria-hidden=""true"">
        <div class=""modal-dialog modal-dialog-centered"" role=""document"">
            <div class=""modal-content"">
                <div class=""modal-header"">
                    <h5 class=""modal-title"" id=""exampleModalLongTitle"">Bilgilendirme</h5>
                    <button onclick=""hidePopUp();"" type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                        <span aria-hidden=""true"">&times;</span>
                    </button>
                </div>
                <div class=""modal-body"">
                    Kodunuz geçersizdir.
                </div>
                <div class=""modal-footer"">
");
                WriteLiteral(@"                    <button onclick=""hidePopUp(); return false;"" type=""button"" class=""btn btn-primary"">Tekrar Dene</button>
                    <button onclick=""location.href='/'; return false;"" type=""button"" class=""btn btn-success"">Anasayfa</button>
                </div>
            </div>
        </div>
    </div>

    <script src=""/js/yuzdeHesaplama.js""></script>
    <script src=""https://code.jquery.com/jquery-3.3.1.slim.min.js"" integrity=""sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo"" crossorigin=""anonymous""></script>
    <script src=""https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/js/bootstrap.min.js"" integrity=""sha384-JjSmVgyd0p3pXB1rRibZUAYoIIy6OrQ6VrjIEaFf/nJGzIxFDsf4x0xIM+B07jRM"" crossorigin=""anonymous""></script>

    <script src=""/js/channels.js""></script>
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
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Kodcamp.Models.VMModels.VMChannels> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
