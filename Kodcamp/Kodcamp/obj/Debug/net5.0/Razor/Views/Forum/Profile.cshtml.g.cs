#pragma checksum "C:\Users\user\Desktop\ReposKodcamp\RepoKodcamp\Dev\Kodcamp\Kodcamp\Views\Forum\Profile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a114342451c793c5b3b52942e16860bceb723c27"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Forum_Profile), @"mvc.1.0.view", @"/Views/Forum/Profile.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a114342451c793c5b3b52942e16860bceb723c27", @"/Views/Forum/Profile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2b5280ab63654a7920e1468f98e11c2ed5684db1", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Forum_Profile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Kodcamp.Models.VMModels.VMProfile>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("d-none d-md-inline-block form-inline ms-auto me-0 me-md-3 my-2 my-md-0"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("sb-nav-fixed"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\user\Desktop\ReposKodcamp\RepoKodcamp\Dev\Kodcamp\Kodcamp\Views\Forum\Profile.cshtml"
  
    var topics = Model.Subjects;
    var messages = Model.Messages;
    var profile = Model.Profile;
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<!DOCTYPE html>\n<html lang=\"en\">\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a114342451c793c5b3b52942e16860bceb723c274738", async() => {
                WriteLiteral("\n    <meta charset=\"utf-8\" />\n    <meta http-equiv=\"X-UA-Compatible\" content=\"IE=edge\" />\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1, shrink-to-fit=no\" />\n    <meta name=\"description\"");
                BeginWriteAttribute("content", " content=\"", 419, "\"", 429, 0);
                EndWriteAttribute();
                WriteLiteral(" />\n    <meta name=\"author\"");
                BeginWriteAttribute("content", " content=\"", 457, "\"", 467, 0);
                EndWriteAttribute();
                WriteLiteral(@" />
    <title>Profil</title>
    <link href=""https://cdn.jsdelivr.net/npm/simple-datatables@latest/dist/style.css"" rel=""stylesheet"" />
    <link href=""/profile/css/styles.css"" rel=""stylesheet"" />
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/font-awesome/5.15.3/js/all.min.js"" crossorigin=""anonymous""></script>
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
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a114342451c793c5b3b52942e16860bceb723c276602", async() => {
                WriteLiteral(@"
    <nav class=""sb-topnav navbar navbar-expand navbar-dark bg-dark"">
        <!-- Navbar Brand-->
        <a class=""navbar-brand ps-3"" href=""/"">Siteye Dön</a>
        <!-- Sidebar Toggle-->
        <button class=""btn btn-link btn-sm order-1 order-lg-0 me-4 me-lg-0"" id=""sidebarToggle"" href=""#!""><i class=""fas fa-bars""></i></button>
        <!-- Navbar Search-->
        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a114342451c793c5b3b52942e16860bceb723c277242", async() => {
                    WriteLiteral(@"
            <div class=""input-group"">
                <input class=""form-control"" type=""text"" placeholder=""Ara..."" aria-label=""Search for..."" aria-describedby=""btnNavbarSearch"" />
                <button class=""btn btn-primary"" id=""btnNavbarSearch"" type=""button""><i class=""fas fa-search""></i></button>
            </div>
        ");
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
                WriteLiteral(@"
        <!-- Navbar-->
        <ul class=""navbar-nav ms-auto ms-md-0 me-3 me-lg-4"">
            <li class=""nav-item dropdown"">
                <a class=""nav-link dropdown-toggle"" id=""navbarDropdown"" href=""#"" role=""button"" data-bs-toggle=""dropdown"" aria-expanded=""false""><i class=""fas fa-user fa-fw""></i></a>
                <ul class=""dropdown-menu dropdown-menu-end"" aria-labelledby=""navbarDropdown"">
                    <li><a class=""dropdown-item"" href=""/profile/logout"">Logout</a></li>
                </ul>
            </li>
        </ul>
    </nav>
    <div id=""layoutSidenav"">
        <div id=""layoutSidenav_nav"">
            <nav class=""sb-sidenav accordion sb-sidenav-dark"" id=""sidenavAccordion"">
                <div class=""sb-sidenav-menu"">
                    <div class=""nav"">
                        <div class=""sb-sidenav-menu-heading"">Profil</div>
                        <a class=""nav-link"" href=""index.html"">
                            <div class=""sb-nav-link-icon""><i class=""fas fa-tachometer-alt""></i><");
                WriteLiteral(@"/div>
                            Anasayfa
                        </a>
                        <div class=""sb-sidenav-menu-heading"">Kategoriler</div>
                        <a class=""nav-link"" href=""index.html"">
                            <div class=""sb-nav-link-icon""><i class=""fas fa-tachometer-alt""></i></div>
                            Başlıklar
                        </a>
                        <a class=""nav-link"" href=""index.html"">
                            <div class=""sb-nav-link-icon""><i class=""fas fa-tachometer-alt""></i></div>
                            Entryler
                        </a>
                        <div class=""sb-sidenav-menu-heading"">Etkileşim</div>
                        <a class=""nav-link collapsed"" href=""#"" data-bs-toggle=""collapse"" data-bs-target=""#collapseLayouts"" aria-expanded=""false"" aria-controls=""collapseLayouts"">
                            <div class=""sb-nav-link-icon""><i class=""fas fa-columns""></i></div>
                            Sorular
                        ");
                WriteLiteral(@"    <div class=""sb-sidenav-collapse-arrow""><i class=""fas fa-angle-down""></i></div>
                        </a>
                        <div class=""collapse"" id=""collapseLayouts"" aria-labelledby=""headingOne"" data-bs-parent=""#sidenavAccordion"">
                            <nav class=""sb-sidenav-menu-nested nav"">
                                <a class=""nav-link"" href=""layout-static.html"">Cevaplanan</a>
                                <a class=""nav-link"" href=""layout-sidenav-light.html"">Cevaplanmayan</a>
                            </nav>
                        </div>

                        <div class=""collapse"" id=""collapsePages"" aria-labelledby=""headingTwo"" data-bs-parent=""#sidenavAccordion"">
                            <nav class=""sb-sidenav-menu-nested nav accordion"" id=""sidenavAccordionPages"">
                                <a class=""nav-link collapsed"" href=""#"" data-bs-toggle=""collapse"" data-bs-target=""#pagesCollapseAuth"" aria-expanded=""false"" aria-controls=""pagesCollapseAuth"">
                      ");
                WriteLiteral(@"              Authentication
                                    <div class=""sb-sidenav-collapse-arrow""><i class=""fas fa-angle-down""></i></div>
                                </a>
                                <div class=""collapse"" id=""pagesCollapseAuth"" aria-labelledby=""headingOne"" data-bs-parent=""#sidenavAccordionPages"">
                                    <nav class=""sb-sidenav-menu-nested nav"">
                                        <a class=""nav-link"" href=""login.html"">Login</a>
                                        <a class=""nav-link"" href=""register.html"">Register</a>
                                        <a class=""nav-link"" href=""password.html"">Forgot Password</a>
                                    </nav>
                                </div>
                                <a class=""nav-link collapsed"" href=""#"" data-bs-toggle=""collapse"" data-bs-target=""#pagesCollapseError"" aria-expanded=""false"" aria-controls=""pagesCollapseError"">
                                    Error
                    ");
                WriteLiteral(@"                <div class=""sb-sidenav-collapse-arrow""><i class=""fas fa-angle-down""></i></div>
                                </a>
                                <div class=""collapse"" id=""pagesCollapseError"" aria-labelledby=""headingOne"" data-bs-parent=""#sidenavAccordionPages"">
                                    <nav class=""sb-sidenav-menu-nested nav"">
                                        <a class=""nav-link"" href=""401.html"">401 Page</a>
                                        <a class=""nav-link"" href=""404.html"">404 Page</a>
                                        <a class=""nav-link"" href=""500.html"">500 Page</a>
                                    </nav>
                                </div>
                            </nav>
                        </div>

                    </div>
                </div>
                <div class=""sb-sidenav-footer"">
                    <div class=""small"">Logged in as:</div>
                    Start Bootstrap
                </div>
            </nav>
        </div>
 ");
                WriteLiteral(@"       <div id=""layoutSidenav_content"">
            <main>
                <div class=""container-fluid px-4"">
                    <h1 class=""mt-4"">Profil Yönetimi</h1>
                    <div class=""row"">
                        <div class=""col-xl-3 col-md-6"">
                            <div class=""card bg-primary text-white mb-4"">
                                <div class=""card-body"">Başlıklarım</div>
                                <div class=""card-footer d-flex align-items-center justify-content-between"">
                                    <a class=""small text-white stretched-link"" href=""#"">Detay Görüntüle</a>
                                    <div class=""small text-white""><i class=""fas fa-angle-right""></i></div>
                                </div>
                            </div>
                        </div>
                        <div class=""col-xl-3 col-md-6"">
                            <div class=""card bg-warning text-white mb-4"">
                                <div class=""card-body"">Gö");
                WriteLiteral(@"nderilerim</div>
                                <div class=""card-footer d-flex align-items-center justify-content-between"">
                                    <a class=""small text-white stretched-link"" href=""#"">Detay Görüntüle</a>
                                    <div class=""small text-white""><i class=""fas fa-angle-right""></i></div>
                                </div>
                            </div>
                        </div>
                        <div class=""col-xl-3 col-md-6"">
                            <div class=""card bg-success text-white mb-4"">
                                <div class=""card-body"">Cevaplanan Sorularım</div>
                                <div class=""card-footer d-flex align-items-center justify-content-between"">
                                    <a class=""small text-white stretched-link"" href=""#"">Detay Görüntüle</a>
                                    <div class=""small text-white""><i class=""fas fa-angle-right""></i></div>
                                </div>
     ");
                WriteLiteral(@"                       </div>
                        </div>
                        <div class=""col-xl-3 col-md-6"">
                            <div class=""card bg-danger text-white mb-4"">
                                <div class=""card-body"">Cevaplanmayan Sorularım</div>
                                <div class=""card-footer d-flex align-items-center justify-content-between"">
                                    <a class=""small text-white stretched-link"" href=""#"">Detay Görüntüle</a>
                                    <div class=""small text-white""><i class=""fas fa-angle-right""></i></div>
                                </div>
                            </div>
                        </div>
                    </div>
                    
                    <div class=""card mb-4"">
                        <div class=""card-header"">
                            <i class=""fas fa-table me-1""></i>
                           Genel Bakış
                        </div>
                        <div class=""card-body"">");
                WriteLiteral(@"
                            <table id=""datatablesSimple"">
                                <thead>
                                    <tr>
                                        <th>Başlıklarım</th>
                                        <th>Mesajlarım</th>
                                        <th>Sorularım</th>
                                        <th>Cevaplanan Sorularım</th>
                                        <th>Cevaplanmayan Sorularım</th>
                                        <th>Sisteme Girişlerim</th>
                                    </tr>
                                </thead>
                                <tfoot>
                                    <tr>
                                        <th>");
#nullable restore
#line 175 "C:\Users\user\Desktop\ReposKodcamp\RepoKodcamp\Dev\Kodcamp\Kodcamp\Views\Forum\Profile.cshtml"
                                       Write(topics.Count);

#line default
#line hidden
#nullable disable
                WriteLiteral("</th>\n                                        <th>");
#nullable restore
#line 176 "C:\Users\user\Desktop\ReposKodcamp\RepoKodcamp\Dev\Kodcamp\Kodcamp\Views\Forum\Profile.cshtml"
                                       Write(messages.Count);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</th>
                                        <th>0</th>
                                        <th>0</th>
                                        <th>0</th>
                                        <th>02.01.2022</th>
                                    </tr>
                                </tfoot>
                                <tbody>
                                    <tr>
                                        <td>");
#nullable restore
#line 185 "C:\Users\user\Desktop\ReposKodcamp\RepoKodcamp\Dev\Kodcamp\Kodcamp\Views\Forum\Profile.cshtml"
                                       Write(topics.Count);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n                                        <td>");
#nullable restore
#line 186 "C:\Users\user\Desktop\ReposKodcamp\RepoKodcamp\Dev\Kodcamp\Kodcamp\Views\Forum\Profile.cshtml"
                                       Write(messages.Count);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</td>
                                        <td>0</td>
                                        <td>0</td>
                                        <td>0</td>
                                        <td>02.01.2022</td>
                                    </tr>
                                </tbody>
                            </table>
                        </div>
                    </div>
                </div>
            </main>
            <footer class=""py-4 bg-light mt-auto"">
                <div class=""container-fluid px-4"">
                    <div class=""d-flex align-items-center justify-content-between small"">
                        <div class=""text-muted"">Copyright &copy; Your Website 2021</div>
                        <div>
                            <a href=""#"">Privacy Policy</a>
                            &middot;
                            <a href=""#"">Terms &amp; Conditions</a>
                        </div>
                    </div>
                </div>
            </footer>
       ");
                WriteLiteral(@" </div>
    </div>
    <script src=""https://cdn.jsdelivr.net/npm/bootstrap@5.1.0/dist/js/bootstrap.bundle.min.js"" crossorigin=""anonymous""></script>
    <script src=""profile/js/scripts.js""></script>
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/Chart.js/2.8.0/Chart.min.js"" crossorigin=""anonymous""></script>
    <script src=""profile/assets/demo/chart-area-demo.js""></script>
    <script src=""profile/assets/demo/chart-bar-demo.js""></script>
    <script src=""https://cdn.jsdelivr.net/npm/simple-datatables@latest"" crossorigin=""anonymous""></script>
    <script src=""profile/js/datatables-simple-demo.js""></script>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n</html>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Kodcamp.Models.VMModels.VMProfile> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
