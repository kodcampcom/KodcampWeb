#pragma checksum "C:\Users\user\Desktop\Kodcamp\Kodcamp\Views\Home\Applications.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3324c0c52fdf7a3b8337a43cf7d3f03d1b287ca6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Applications), @"mvc.1.0.view", @"/Views/Home/Applications.cshtml")]
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
#line 1 "C:\Users\user\Desktop\Kodcamp\Kodcamp\Views\_ViewImports.cshtml"
using Kodcamp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\user\Desktop\Kodcamp\Kodcamp\Views\_ViewImports.cshtml"
using Kodcamp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3324c0c52fdf7a3b8337a43cf7d3f03d1b287ca6", @"/Views/Home/Applications.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2b5280ab63654a7920e1468f98e11c2ed5684db1", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Applications : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<style>\r\n    .p3Font {\r\n        font-family: \"Lucida Console\", \"Courier New\", monospace;\r\n    }\n</style>\n\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3324c0c52fdf7a3b8337a43cf7d3f03d1b287ca63165", async() => {
                WriteLiteral(@"
    <main id=""main"">
        <section id=""breadcrumbs"" class=""breadcrumbs"">
            <div class=""container"">

                <div class=""d-flex justify-content-between align-items-center"">
                    <ol>
                        <li><a href=""/"">Anasayfa</a></li>
                        <li>Uygulamalar</li>
                    </ol>

                </div>

            </div>
        </section>

        <section id=""services"" class=""services"">
            <div class=""container"">
                <div class=""row"">
                    <div class=""col-lg-4 col-md-6"">
                        <div class=""icon-box"" style=""height:250px; cursor:pointer;"" onclick=""window.location.href='/uygulamalar/yuzde-hesaplama'"">
                            <div class=""icon""><i class=""bi bi-percent""></i></div>
                            <h2 class=""title p3Font"" style=""font-size:19px;""><a href=""/uygulamalar/yuzde-hesaplama"">Yüzde Hesaplama</a></h2>
                            <p class=""description"">Kodcamp yüzde h");
                WriteLiteral(@"esaplama uygulamamızı kullanarak istediğiniz sayının istediğiniz yüzdesini bulabilirsiniz. Hem tam sayılar hem de kesirli sayılar için çalışmaktadır. Hesaplamada hata tespit ederseniz bize bildirmenizi çok isteriz. Dilerseniz mail gönderebilir, dilerseniz soru-cevap alanından bildirebilirsiniz.</p>
                        </div>
                    </div>
                    <div class=""col-lg-4 col-md-6"">
                        <div class=""icon-box"" style=""height:250px; cursor:pointer;"" onclick=""window.location.href='/uygulamalar/indirim-hesaplama'"">
                            <div class=""icon""><i class=""bi bi-cart-plus""></i></div>
                            <h2 class=""title p3Font""><a href=""/uygulamalar/indirim-hesaplama"">İndirim Hesaplama</a></h2>
                            <p class=""description"">Kodcamp indirim hesaplama uygulamamızı kullanarak istediğiniz ürünün fiyatını ve indirim miktarını girerek toplam indirim tutarını ve indirimli son fiyatın bilgisini elde edebilirsiniz. Hata tespit eder");
                WriteLiteral(@"seniz lütfen bizimle paylaşmaktan çekinmeyin.</p>
                        </div>
                    </div>
                    <div class=""col-lg-4 col-md-6"">
                        <div class=""icon-box"" style=""height:250px; cursor:pointer;"" onclick=""window.location.href='/uygulamalar/ortalama-hesapla'"">
                            <div class=""icon""><i class=""bi bi-calculator-fill""></i></div>
                            <h4 class=""title p3Font""><a href=""/uygulamalar/ortalama-hesapla"">Ortalama Hesaplama</a></h4>
                            <p class=""description"">Kodcamp ortalama hesaplama uygulamamız ile ilgili dersinizi notlarını girerek ortalamanızı öğrenebilirsiniz. Girdiğiniz notların ağırlık toplamı %100 olmalıdır. Hesaplamada yanlışlık tespit ederseniz lütfen iletişime geçin.</p>
                        </div>
                    </div>
                    <div class=""col-lg-4 col-md-6"">
                        <div class=""icon-box"" style=""height:250px; cursor:pointer;"" onclick=""window.locat");
                WriteLiteral(@"ion.href='/uygulamalar/kelime-sayisi-hesapla'"">
                            <div class=""icon""><i class=""bi bi-card-text""></i></div>
                            <h3 class=""title p3Font"" style=""font-size:19px;""><a href=""/uygulamalar/kelime-sayisi-hesapla"">Kelime Sayısı Hesaplama</a></h3>
                            <p class=""description"">Kodcamp kelime sayısı hesapla uygulamamız ile istediğiniz yazı ya da metindeki yaklaşık kelime sayısını hesaplayabilirsiniz. Hesaplama işlemi kelimeler arasındaki tek boşluk karakterlerinine göre çalışmaktadır. Paragraf boşlukları dahil edilmez.</p>
                        </div>
                    </div>
                    <div class=""col-lg-4 col-md-6"">
                        <div class=""icon-box"" style=""height:250px; cursor:pointer;"" onclick=""window.location.href='/uygulamalar/kelime-karakter-degistirme'"">
                            <div class=""icon""><i class=""bi bi-blockquote-left""></i></div>
                            <h4 class=""title p3Font"" style=""font-size");
                WriteLiteral(@":19px;""><a href=""/uygulamalar/kelime-karakter-degistirme"">Kelime Değiştirme</a></h4>
                            <p class=""description"">Kodcamp kelime değiştirme uygulaması ile istediğiniz içeriğin, metin ya da yazı olabilir içinden değiştirmek istediğiniz ya da yanlış yazılmış kelimeyi doğrusu ile değiştirebilirsiniz. Ya da boşluk karakteri bırakarak kelimeyi silebilirsiniz.</p>
                        </div>
                    </div>
                    <div class=""col-lg-4 col-md-6"">
                        <div class=""icon-box"" style=""height:250px; cursor:pointer;"" onclick=""window.location.href='/uygulamalar/channels/-1'"">
                            <div class=""icon""><i class=""bi bi-chat-dots""></i></div>
                            <h4 class=""title p3Font"" style=""font-size:19px;""><a href=""/uygulamalar/channels/-1"">Tartışma Kanalları</a></h4>
                            <p class=""description"">Tartışma kanalları ile dilediğiniz konu hakkında diğer kullanıcılarla anlık olarak konuşabilirsiniz. Tart");
                WriteLiteral(@"ışma kanalları uygulamamız sadece premium üyeler için geçerlidir. Premium üyelik kodu ile giriş sağlanır.</p>
                        </div>
                    </div>
                </div>

            </div>
        </section>
     
        

    </main>

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
            WriteLiteral("\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
