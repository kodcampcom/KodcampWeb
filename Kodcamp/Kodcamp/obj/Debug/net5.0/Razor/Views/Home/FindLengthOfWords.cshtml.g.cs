#pragma checksum "C:\Users\user\Desktop\ReposKodcamp\RepoKodcamp\Dev\Kodcamp\Kodcamp\Views\Home\FindLengthOfWords.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7f1839a01e2510bdebf1d6dd1fa4803c300bda47"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_FindLengthOfWords), @"mvc.1.0.view", @"/Views/Home/FindLengthOfWords.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7f1839a01e2510bdebf1d6dd1fa4803c300bda47", @"/Views/Home/FindLengthOfWords.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2b5280ab63654a7920e1468f98e11c2ed5684db1", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_FindLengthOfWords : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Kodcamp.Models.VMModels.VMChannels>
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\user\Desktop\ReposKodcamp\RepoKodcamp\Dev\Kodcamp\Kodcamp\Views\Home\FindLengthOfWords.cshtml"
  
    var newsList = Model.NewsList;
    var tags = Model.TagsKeyValue;
    double result = Convert.ToDouble(ViewData["Result"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7f1839a01e2510bdebf1d6dd1fa4803c300bda473829", async() => {
                WriteLiteral(@"
    <section id=""breadcrumbs"" class=""breadcrumbs"">
        <div class=""container"">

            <div class=""d-flex justify-content-between align-items-center"">

                <ol>
                    <li><a href=""/"">Anasayfa</a></li>
                    <li>Kelime Sayısı Hesaplama</li>
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
                                    <h4> Metindeki Kelime Sayısını Hesapla </h4>
                                </div>
                                <br />

                                <h5>Metninizi yazın ya da kopyalayın</h5>
      ");
                WriteLiteral("                          <textarea style=\"height:240px;\"");
                BeginWriteAttribute("value", " value=\"", 1264, "\"", 1272, 0);
                EndWriteAttribute();
                WriteLiteral(@" id=""duzeltilecekTxt"" class=""form-control"" placeholder=""Metninizi buraya yazın""></textarea>

                                <br />


                                <div class=""d-flex justify-content-center"" style=""margin-top:5%;"">
                                    <button onclick=""getLengthOfText();"" style=""width:300px; cursor:pointer;"" type=""submit"" class=""btn btn-success center"">KELİME SAYISINI BUL</button>
                                </div>
                                <br />
                                <hr />
                                <br />

                                <div id=""divResult2"" class=""alert alert-dark"" role=""alert"" style=""text-align:center;"">
                                    <h6> Hesaplama yapılırken sadece 'tek' boşluk karakterleri dikkate alınmaktadır. Paragraf boşlukları dikkate alınmaz.  </h6>
                                </div>

                                <div id=""divResult1"" class=""alert alert-success d-none"" role=""alert"" style=""text-align:center;"">
 ");
                WriteLiteral(@"                                   <h3 id=""duzenlenenTxt"" class=""d-none"">  </h3>
                                </div>

                            </div>
                        </div>



                    </article><!-- End blog entry -->


                </div><!-- End blog entries list -->

                <div class=""col-lg-4"">

                    <div class=""sidebar"">

                        <div class=""sidebar-item "">
                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7f1839a01e2510bdebf1d6dd1fa4803c300bda476956", async() => {
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
#line 95 "C:\Users\user\Desktop\ReposKodcamp\RepoKodcamp\Dev\Kodcamp\Kodcamp\Views\Home\FindLengthOfWords.cshtml"
                             foreach (var item in newsList)
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <div class=\"post-item clearfix\">\n                                    <img");
                BeginWriteAttribute("src", " src=\"", 4336, "\"", 4369, 2);
                WriteAttributeValue("", 4342, "/images/news/", 4342, 13, true);
#nullable restore
#line 98 "C:\Users\user\Desktop\ReposKodcamp\RepoKodcamp\Dev\Kodcamp\Kodcamp\Views\Home\FindLengthOfWords.cshtml"
WriteAttributeValue("", 4355, item.ImageUrl, 4355, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("alt", " alt=\"", 4370, "\"", 4376, 0);
                EndWriteAttribute();
                WriteLiteral(">\n                                    <h4><a");
                BeginWriteAttribute("href", " href=\"", 4421, "\"", 4447, 2);
                WriteAttributeValue("", 4428, "/haberler/", 4428, 10, true);
#nullable restore
#line 99 "C:\Users\user\Desktop\ReposKodcamp\RepoKodcamp\Dev\Kodcamp\Kodcamp\Views\Home\FindLengthOfWords.cshtml"
WriteAttributeValue("", 4438, item.Url, 4438, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 99 "C:\Users\user\Desktop\ReposKodcamp\RepoKodcamp\Dev\Kodcamp\Kodcamp\Views\Home\FindLengthOfWords.cshtml"
                                                                 Write(item.Title);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a></h4>\n                                    <time datetime=\"2020-01-01\">");
#nullable restore
#line 100 "C:\Users\user\Desktop\ReposKodcamp\RepoKodcamp\Dev\Kodcamp\Kodcamp\Views\Home\FindLengthOfWords.cshtml"
                                                           Write(item.DateCreated);

#line default
#line hidden
#nullable disable
                WriteLiteral("</time>\n                                </div>\n");
#nullable restore
#line 102 "C:\Users\user\Desktop\ReposKodcamp\RepoKodcamp\Dev\Kodcamp\Kodcamp\Views\Home\FindLengthOfWords.cshtml"
                            }

#line default
#line hidden
#nullable disable
                WriteLiteral("\n\n                        </div><!-- End sidebar recent posts-->\n\n                        <h3 style=\"margin-top:45px;\" class=\"sidebar-title\">Etiketler</h3>\n                        <div class=\"sidebar-item tags\">\n                            <ul>\n");
#nullable restore
#line 110 "C:\Users\user\Desktop\ReposKodcamp\RepoKodcamp\Dev\Kodcamp\Kodcamp\Views\Home\FindLengthOfWords.cshtml"
                                 foreach (var item in tags)
                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    <li><a style=\"cursor:pointer;\" href=\"/sorular\">");
#nullable restore
#line 112 "C:\Users\user\Desktop\ReposKodcamp\RepoKodcamp\Dev\Kodcamp\Kodcamp\Views\Home\FindLengthOfWords.cshtml"
                                                                              Write(item.Key);

#line default
#line hidden
#nullable disable
                WriteLiteral(" (");
#nullable restore
#line 112 "C:\Users\user\Desktop\ReposKodcamp\RepoKodcamp\Dev\Kodcamp\Kodcamp\Views\Home\FindLengthOfWords.cshtml"
                                                                                         Write(item.Value);

#line default
#line hidden
#nullable disable
                WriteLiteral(")</a></li>\n");
#nullable restore
#line 113 "C:\Users\user\Desktop\ReposKodcamp\RepoKodcamp\Dev\Kodcamp\Kodcamp\Views\Home\FindLengthOfWords.cshtml"
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
