#pragma checksum "C:\Users\user\Desktop\ReposKodcamp\RepoKodcamp\Dev\Kodcamp\Kodcamp\Views\Profile\ProfileQuestions.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f5ce4214bbebf79b274c6bee9e800b7ad6cd72a1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Profile_ProfileQuestions), @"mvc.1.0.view", @"/Views/Profile/ProfileQuestions.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f5ce4214bbebf79b274c6bee9e800b7ad6cd72a1", @"/Views/Profile/ProfileQuestions.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2b5280ab63654a7920e1468f98e11c2ed5684db1", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Profile_ProfileQuestions : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Kodcamp.Models.VMModels.VMProfile>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("d-none d-md-inline-block form-inline ms-auto me-0 me-md-3 my-2 my-md-0"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "0", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("sb-nav-fixed"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\user\Desktop\ReposKodcamp\RepoKodcamp\Dev\Kodcamp\Kodcamp\Views\Profile\ProfileQuestions.cshtml"
  
    var questions = Model.Questions;
    var profile = Model.Profile;
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<!DOCTYPE html>\n<html lang=\"en\">\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f5ce4214bbebf79b274c6bee9e800b7ad6cd72a15487", async() => {
                WriteLiteral(@"
    <meta charset=""utf-8"" />
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"" />
    <meta name=""viewport"" content=""width=device-width, initial-scale=1, shrink-to-fit=no"" />
    <title>Sorular</title>
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f5ce4214bbebf79b274c6bee9e800b7ad6cd72a16862", async() => {
                WriteLiteral(@"
    <nav class=""sb-topnav navbar navbar-expand navbar-dark bg-dark"">
        <!-- Navbar Brand-->
        <a class=""navbar-brand ps-3"" href=""/"">Siteye Dön</a>
        <!-- Sidebar Toggle-->
        <button class=""btn btn-link btn-sm order-1 order-lg-0 me-4 me-lg-0"" id=""sidebarToggle"" href=""#!""><i class=""fas fa-bars""></i></button>
        <!-- Navbar Search-->
        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f5ce4214bbebf79b274c6bee9e800b7ad6cd72a17502", async() => {
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
                    <div class=""sb-sidenav-menu"">
                        <div class=""nav"">
                            <div class=""sb-sidenav-menu-heading"">Profil</div>
                            <a class=""nav-link"" href=""/profile"">
                                <");
                WriteLiteral(@"div class=""sb-nav-link-icon""><i class=""fas fa-tachometer-alt""></i></div>
                                Genel Bakış
                            </a>
                            <a class=""nav-link"" href=""/profile/AddPhoto"">
                                <div class=""sb-nav-link-icon""><i class=""fas fa-tachometer-alt""></i></div>
                                Profil Fotoğrafı
                            </a>
                            <div class=""sb-sidenav-menu-heading"">Sozluk</div>
                            <a class=""nav-link"" href=""/profile/topics"">
                                <div class=""sb-nav-link-icon""><i class=""fas fa-tachometer-alt""></i></div>
                                 Başlıklar
                            </a>
                            <a class=""nav-link"" href=""/Profile/Entries"">
                                <div class=""sb-nav-link-icon""><i class=""fas fa-tachometer-alt""></i></div>
                                Entryler
                            </a>
                           ");
                WriteLiteral(@" <div class=""sb-sidenav-menu-heading"">Soru Cevap</div>
                            <a class=""nav-link"" href=""/Profile/Questions"">
                                <div class=""sb-nav-link-icon""><i class=""fas fa-tachometer-alt""></i></div>
                                Sorularım
                            </a>

                            <div class=""sb-sidenav-menu-heading"">Etkileşim</div>
                            <a class=""nav-link collapsed"" href=""#"" data-bs-toggle=""collapse"" data-bs-target=""#collapseLayouts"" aria-expanded=""false"" aria-controls=""collapseLayouts"">
                                <div class=""sb-nav-link-icon""><i class=""fas fa-columns""></i></div>
                                Sorular
                                <div class=""sb-sidenav-collapse-arrow""><i class=""fas fa-angle-down""></i></div>
                            </a>
                            <div class=""collapse"" id=""collapseLayouts"" aria-labelledby=""headingOne"" data-bs-parent=""#sidenavAccordion"">
                              ");
                WriteLiteral(@"  <nav class=""sb-sidenav-menu-nested nav"">
                                    <a class=""nav-link"" href=""layout-static.html"">Cevaplanan</a>
                                    <a class=""nav-link"" href=""layout-sidenav-light.html"">Cevaplanmayan</a>
                                </nav>
                            </div>
                        </div>
                    </div>
                </div>
                <div class=""sb-sidenav-footer"">
                    <div class=""small""> ");
#nullable restore
#line 92 "C:\Users\user\Desktop\ReposKodcamp\RepoKodcamp\Dev\Kodcamp\Kodcamp\Views\Profile\ProfileQuestions.cshtml"
                                   Write(profile.Username);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</div>

                </div>
            </nav>
        </div>
        <div id=""layoutSidenav_content"">
            <main>
                <div class=""container-fluid px-4"">
                    <h2 class=""mt-4"">Sorularım</h2>
                    <ol class=""breadcrumb mb-4"">
                        <li class=""breadcrumb-item""><a href=""/profile"">Profil Yönetimi</a></li>
                        <li class=""breadcrumb-item active"">Sorularım</li>
                    </ol>
                    <div class=""card mb-4"">
                        <div class=""card-header"">
                            <i class=""fas fa-table me-1""></i>
                            Genel Bakış
                        </div>




                        <div class=""card-body"">
                            <table id=""datatablesSimple"">
                                <thead>
                                    <tr>
                                        <th>Detay</th>
                                        <th>Oluşturulma Tarihi</th>

         ");
                WriteLiteral("                               <th>Beğeni</th>\n                                        <th>Eleştiri</th>\n                                        <th>Yorum</th>\n\n                                        <th>Sorun Çözüldü mü?</th>\n\n");
                WriteLiteral("                                    </tr>\n                                </thead>\n\n                                <tbody>\n");
#nullable restore
#line 132 "C:\Users\user\Desktop\ReposKodcamp\RepoKodcamp\Dev\Kodcamp\Kodcamp\Views\Profile\ProfileQuestions.cshtml"
                                      
                                        for (int i = 0; i < questions.Count; i++)
                                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                            <tr>\n                                                <td>");
#nullable restore
#line 136 "C:\Users\user\Desktop\ReposKodcamp\RepoKodcamp\Dev\Kodcamp\Kodcamp\Views\Profile\ProfileQuestions.cshtml"
                                               Write(questions[i].Title);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n                                                <td>");
#nullable restore
#line 137 "C:\Users\user\Desktop\ReposKodcamp\RepoKodcamp\Dev\Kodcamp\Kodcamp\Views\Profile\ProfileQuestions.cshtml"
                                               Write(questions[i].DateCreated);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n                                                \n                                                <td>");
#nullable restore
#line 139 "C:\Users\user\Desktop\ReposKodcamp\RepoKodcamp\Dev\Kodcamp\Kodcamp\Views\Profile\ProfileQuestions.cshtml"
                                               Write(questions[i].LikeCount);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n                                                <td>");
#nullable restore
#line 140 "C:\Users\user\Desktop\ReposKodcamp\RepoKodcamp\Dev\Kodcamp\Kodcamp\Views\Profile\ProfileQuestions.cshtml"
                                               Write(questions[i].Unlike);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n                                                <td>");
#nullable restore
#line 141 "C:\Users\user\Desktop\ReposKodcamp\RepoKodcamp\Dev\Kodcamp\Kodcamp\Views\Profile\ProfileQuestions.cshtml"
                                               Write(questions[i].Answers.Count());

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n\n                                                <td>\n                                                    <select id=\"isSolvedOption\"");
                BeginWriteAttribute("onchange", " onchange=\"", 7321, "\"", 7365, 3);
                WriteAttributeValue("", 7332, "ChangeStatus(\'", 7332, 14, true);
#nullable restore
#line 144 "C:\Users\user\Desktop\ReposKodcamp\RepoKodcamp\Dev\Kodcamp\Kodcamp\Views\Profile\ProfileQuestions.cshtml"
WriteAttributeValue("", 7346, questions[i].Id, 7346, 16, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 7362, "\');", 7362, 3, true);
                EndWriteAttribute();
                WriteLiteral(" class=\"form-select\">\n");
#nullable restore
#line 145 "C:\Users\user\Desktop\ReposKodcamp\RepoKodcamp\Dev\Kodcamp\Kodcamp\Views\Profile\ProfileQuestions.cshtml"
                                                          
                                                            if (questions[i].IsSolved == "1")
                                                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f5ce4214bbebf79b274c6bee9e800b7ad6cd72a118308", async() => {
                    WriteLiteral(" Hayır ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                                                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f5ce4214bbebf79b274c6bee9e800b7ad6cd72a119595", async() => {
                    WriteLiteral(" Evet ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n");
#nullable restore
#line 150 "C:\Users\user\Desktop\ReposKodcamp\RepoKodcamp\Dev\Kodcamp\Kodcamp\Views\Profile\ProfileQuestions.cshtml"
                                                            }
                                                            else
                                                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f5ce4214bbebf79b274c6bee9e800b7ad6cd72a121615", async() => {
                    WriteLiteral(" Hayır ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                                                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f5ce4214bbebf79b274c6bee9e800b7ad6cd72a123225", async() => {
                    WriteLiteral(" Evet ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n");
#nullable restore
#line 155 "C:\Users\user\Desktop\ReposKodcamp\RepoKodcamp\Dev\Kodcamp\Kodcamp\Views\Profile\ProfileQuestions.cshtml"
                                                            }
                                                        

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                                                    </select>\n                                                </td>\n                                                \n                                            </tr>\n");
#nullable restore
#line 162 "C:\Users\user\Desktop\ReposKodcamp\RepoKodcamp\Dev\Kodcamp\Kodcamp\Views\Profile\ProfileQuestions.cshtml"
                                        }
                                    

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
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
        </div>
    </div>


    <!-- Button trigger modal -->
    <button type=""button"" class=""btn btn-primary"" data-toggle=""modal"" data-target=""#exampleModal"">
        Launch demo modal
    </button>

");
#nullable restore
#line 192 "C:\Users\user\Desktop\ReposKodcamp\RepoKodcamp\Dev\Kodcamp\Kodcamp\Views\Profile\ProfileQuestions.cshtml"
      
        for (int i = 0; i < questions.Count; i++)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <!-- Modal -->\n            <div class=\"modal fade\"");
                BeginWriteAttribute("id", " id=\"", 9708, "\"", 9742, 2);
                WriteAttributeValue("", 9713, "exampleModal-", 9713, 13, true);
#nullable restore
#line 196 "C:\Users\user\Desktop\ReposKodcamp\RepoKodcamp\Dev\Kodcamp\Kodcamp\Views\Profile\ProfileQuestions.cshtml"
WriteAttributeValue("", 9726, questions[i].Id, 9726, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
                <div class=""modal-dialog"" role=""document"">
                    <div class=""modal-content"">
                        <div class=""modal-header"">
                            <h5 class=""modal-title"" id=""exampleModalLabel"">Modal title</h5>
                            <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                                <span aria-hidden=""true"">&times;</span>
                            </button>
                        </div>
                        <div class=""modal-body"">
                            ");
#nullable restore
#line 206 "C:\Users\user\Desktop\ReposKodcamp\RepoKodcamp\Dev\Kodcamp\Kodcamp\Views\Profile\ProfileQuestions.cshtml"
                       Write(questions[i].Title);

#line default
#line hidden
#nullable disable
                WriteLiteral(@" başlığını silmek istediğinizden emin misiniz ?
                        </div>
                        <div class=""modal-footer"">
                            <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Vazgeç</button>
                            <button");
                BeginWriteAttribute("onclick", " onclick=\"", 10698, "\"", 10769, 3);
                WriteAttributeValue("", 10708, "window.location.href=\'/Profile/Topic/Delete/", 10708, 44, true);
#nullable restore
#line 210 "C:\Users\user\Desktop\ReposKodcamp\RepoKodcamp\Dev\Kodcamp\Kodcamp\Views\Profile\ProfileQuestions.cshtml"
WriteAttributeValue("", 10752, questions[i].Id, 10752, 16, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 10768, "\'", 10768, 1, true);
                EndWriteAttribute();
                WriteLiteral(" type=\"button\" class=\"btn btn-danger\">SİL</button>\n                        </div>\n                    </div>\n                </div>\n            </div>\n");
#nullable restore
#line 215 "C:\Users\user\Desktop\ReposKodcamp\RepoKodcamp\Dev\Kodcamp\Kodcamp\Views\Profile\ProfileQuestions.cshtml"
        }
    

#line default
#line hidden
#nullable disable
                WriteLiteral(@"


    <script src=""https://code.jquery.com/jquery-3.2.1.slim.min.js"" integrity=""sha384-KJ3o2DKtIkvYIK3UENzmM7KCkRr/rE9/Qpg6aAZGJwFDMVNA/GpGFF93hXpG5KkN"" crossorigin=""anonymous""></script>
    <script src=""https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/js/bootstrap.min.js"" integrity=""sha384-JZR6Spejh4U02d8jOt6vLEHfe/JQGiRRSQQxSfFWpi1MquVdAyjUar5+76PVCmYl"" crossorigin=""anonymous""></script>

    <script src=""https://cdn.jsdelivr.net/npm/bootstrap@5.1.0/dist/js/bootstrap.bundle.min.js"" crossorigin=""anonymous""></script>
    <script src=""/profile/js/scripts.js""></script>

    <script src=""/js/profileQuestion.js""></script>
    <script src=""/profile/js/dataTableGok.js""></script>
    <script src=""/profile/js/datatables-simple-demo.js""></script>

");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n</html>s\n");
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
