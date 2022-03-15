#pragma checksum "C:\Users\user\Desktop\ReposKodcamp\RepoKodcamp\Dev\Kodcamp\Kodcamp\Views\Forum\Entries.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "87835c7d3af8e8b9d145429060e3a5b66fa8626b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Forum_Entries), @"mvc.1.0.view", @"/Views/Forum/Entries.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"87835c7d3af8e8b9d145429060e3a5b66fa8626b", @"/Views/Forum/Entries.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2b5280ab63654a7920e1468f98e11c2ed5684db1", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Forum_Entries : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Kodcamp.Models.VMModels.VMForumTopicMessages>
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
#line 2 "C:\Users\user\Desktop\ReposKodcamp\RepoKodcamp\Dev\Kodcamp\Kodcamp\Views\Forum\Entries.cshtml"
  
    var topics = Model.Subjects;
    var messages = Model.Messages;
    var tags = Model.TagsKeyValue;
    var newsList = Model.NewsList;

    string subjectId = ViewData["SubjectId"].ToString();
    string subjectName = ViewData["SubjectName"].ToString();

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "87835c7d3af8e8b9d145429060e3a5b66fa8626b3914", async() => {
                WriteLiteral(@"
    <style>
        .changeColor:hover {
            background-color: #BDD2B6;
        }
        .p3Font {
            font-family: ""Lucida Console"", ""Courier New"", monospace;
        }
    </style>

    <section id=""breadcrumbs"" class=""breadcrumbs"">
        <div class=""container"">

            <div class=""d-flex justify-content-between align-items-center"">
                <ol>
                    <li><a href=""/"">Anasayfa</a></li>
                    <li><a href=""/sozluk"">Sözlük</a></li>
                    <li>");
#nullable restore
#line 29 "C:\Users\user\Desktop\ReposKodcamp\RepoKodcamp\Dev\Kodcamp\Kodcamp\Views\Forum\Entries.cshtml"
                   Write(subjectName);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</li>
                </ol>
            </div>
        </div>
    </section>

    <section id=""blog"" class=""blog"">
        <div class=""container"" data-aos=""fade-up"">

            <div class=""row"">
                <div class=""col-lg-8 entries"">
                    <article class=""entry entry-single"">
                        <div class=""row"" style=""margin-left: 0.1vw; margin-right: 0.1vw; margin-bottom: 1vh;"">
                            <div class=""d-flex justify-content-center"">
                                <h1 style=""font-size: 25px; color:#F65C28"">");
#nullable restore
#line 43 "C:\Users\user\Desktop\ReposKodcamp\RepoKodcamp\Dev\Kodcamp\Kodcamp\Views\Forum\Entries.cshtml"
                                                                      Write(subjectName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h1>\n                            </div>\n\n                        </div>\n\n");
#nullable restore
#line 48 "C:\Users\user\Desktop\ReposKodcamp\RepoKodcamp\Dev\Kodcamp\Kodcamp\Views\Forum\Entries.cshtml"
                          
                            foreach (var item in messages)
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                <span class=""list-group-item list-group-item-action d-flex gap-3 py-3"" aria-current=""true"" style=""border:none;"">
                                                            <div style=""min-width:100%;"">
                                                                <h2 class=""mb-0 opacity-45 p3Font"" style=""font-size:17px;"">");
#nullable restore
#line 53 "C:\Users\user\Desktop\ReposKodcamp\RepoKodcamp\Dev\Kodcamp\Kodcamp\Views\Forum\Entries.cshtml"
                                                                                                                      Write(item.Detail);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</h2>
                                                                <br />
                                                                <span class=""float-right"" style=""float:left;"">
                                                                    <button style=""border:none; background-color:transparent;""");
                BeginWriteAttribute("onclick", " onclick=\"", 2301, "\"", 2373, 5);
                WriteAttributeValue("", 2311, "window.location.href=\'/Dictionary/", 2311, 34, true);
#nullable restore
#line 56 "C:\Users\user\Desktop\ReposKodcamp\RepoKodcamp\Dev\Kodcamp\Kodcamp\Views\Forum\Entries.cshtml"
WriteAttributeValue("", 2345, subjectId, 2345, 10, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 2355, "/AddLike/", 2355, 9, true);
#nullable restore
#line 56 "C:\Users\user\Desktop\ReposKodcamp\RepoKodcamp\Dev\Kodcamp\Kodcamp\Views\Forum\Entries.cshtml"
WriteAttributeValue("", 2364, item.Id, 2364, 8, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 2372, "\'", 2372, 1, true);
                EndWriteAttribute();
                WriteLiteral(">\n                                                                        <i style=\"width:30px; height:30px;\" class=\"bi bi-arrow-up-square\"></i>\n                                                                        ");
#nullable restore
#line 58 "C:\Users\user\Desktop\ReposKodcamp\RepoKodcamp\Dev\Kodcamp\Kodcamp\Views\Forum\Entries.cshtml"
                                                                   Write(item.LikeCount);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                                                    </button>
                                                                </span>

                                                                <span class=""float-right opacity-50 text-nowrap"" style=""float:right; margin-left: auto; margin-right: 0px; font-size:14px;"">   <b style=""color:#F65C28""> ");
#nullable restore
#line 62 "C:\Users\user\Desktop\ReposKodcamp\RepoKodcamp\Dev\Kodcamp\Kodcamp\Views\Forum\Entries.cshtml"
                                                                                                                                                                                                                    Write(item.WriterUserName);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </b> &nbsp; &nbsp; <span style=\"color: #2B2321\">  ");
#nullable restore
#line 62 "C:\Users\user\Desktop\ReposKodcamp\RepoKodcamp\Dev\Kodcamp\Kodcamp\Views\Forum\Entries.cshtml"
                                                                                                                                                                                                                                                                                           Write(item.DateTimeFormatted);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </span> </span>\n                                                            </div>\n                                </span>\n");
#nullable restore
#line 65 "C:\Users\user\Desktop\ReposKodcamp\RepoKodcamp\Dev\Kodcamp\Kodcamp\Views\Forum\Entries.cshtml"
                            }
                        

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                        <button");
                BeginWriteAttribute("onclick", " onclick=\"", 3281, "\"", 3345, 3);
                WriteAttributeValue("", 3291, "window.location.href=\'/Dictionary/AddEntry/", 3291, 43, true);
#nullable restore
#line 68 "C:\Users\user\Desktop\ReposKodcamp\RepoKodcamp\Dev\Kodcamp\Kodcamp\Views\Forum\Entries.cshtml"
WriteAttributeValue("", 3334, subjectId, 3334, 10, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 3344, "\'", 3344, 1, true);
                EndWriteAttribute();
                WriteLiteral(" class=\"btn btn-outline-warning col-4 col-sm-4 col-md-4 col-lg-2 col-xl-2 float-left\" type=\"button\" style=\"margin-top: 2vh; color: #F65C28;\">\n                            Mesaj Yaz\n                        </button>\n\n");
                WriteLiteral(@"
                        <div class=""d-flex justify-content-center"" style=""margin-top:10vh; margin-bottom:2vh;"">
                            <a href=""/sozluk"">
                                <h6 style=""color: #D6704F"">Diğer Başlıklara Göz Atın</h6>
                            </a>
                            
                        </div>

");
#nullable restore
#line 81 "C:\Users\user\Desktop\ReposKodcamp\RepoKodcamp\Dev\Kodcamp\Kodcamp\Views\Forum\Entries.cshtml"
                         foreach (var item in topics)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <a");
                BeginWriteAttribute("href", " href=\"", 4074, "\"", 4098, 2);
                WriteAttributeValue("", 4081, "/sozluk/", 4081, 8, true);
#nullable restore
#line 83 "C:\Users\user\Desktop\ReposKodcamp\RepoKodcamp\Dev\Kodcamp\Kodcamp\Views\Forum\Entries.cshtml"
WriteAttributeValue("", 4089, item.Url, 4089, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"list-group-item list-group-item-action d-flex gap-3 py-3 selectLink changeColor\" aria-current=\"true\"");
                BeginWriteAttribute("id", " id=\"", 4207, "\"", 4225, 2);
                WriteAttributeValue("", 4212, "link-", 4212, 5, true);
#nullable restore
#line 83 "C:\Users\user\Desktop\ReposKodcamp\RepoKodcamp\Dev\Kodcamp\Kodcamp\Views\Forum\Entries.cshtml"
WriteAttributeValue("", 4217, item.Id, 4217, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("style", " style=\"", 4226, "\"", 4234, 0);
                EndWriteAttribute();
                WriteLiteral(">\n                                <div class=\"d-flex gap-2 w-100 justify-content-between\">\n                                    <div style=\"min-width:100%;\">\n                                        <h6 class=\"selectEntry\"");
                BeginWriteAttribute("id", " id=\"", 4455, "\"", 4473, 2);
                WriteAttributeValue("", 4460, "titl-", 4460, 5, true);
#nullable restore
#line 86 "C:\Users\user\Desktop\ReposKodcamp\RepoKodcamp\Dev\Kodcamp\Kodcamp\Views\Forum\Entries.cshtml"
WriteAttributeValue("", 4465, item.Id, 4465, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" style=\"font-size:14px;\">");
#nullable restore
#line 86 "C:\Users\user\Desktop\ReposKodcamp\RepoKodcamp\Dev\Kodcamp\Kodcamp\Views\Forum\Entries.cshtml"
                                                                                                      Write(item.Title);

#line default
#line hidden
#nullable disable
                WriteLiteral(" <span style=\"color: #798777\"> (");
#nullable restore
#line 86 "C:\Users\user\Desktop\ReposKodcamp\RepoKodcamp\Dev\Kodcamp\Kodcamp\Views\Forum\Entries.cshtml"
                                                                                                                                                 Write(item.CommentCount);

#line default
#line hidden
#nullable disable
                WriteLiteral(") </span> </h6>\n                                        <span class=\"float-right opacity-50 text-nowrap\" style=\"float:right; margin-left: auto; margin-right: 0px; font-size:11px;\"> ");
#nullable restore
#line 87 "C:\Users\user\Desktop\ReposKodcamp\RepoKodcamp\Dev\Kodcamp\Kodcamp\Views\Forum\Entries.cshtml"
                                                                                                                                                                Write(item.Comments.First().DateTimeFormatted);

#line default
#line hidden
#nullable disable
                WriteLiteral(" <b> ");
#nullable restore
#line 87 "C:\Users\user\Desktop\ReposKodcamp\RepoKodcamp\Dev\Kodcamp\Kodcamp\Views\Forum\Entries.cshtml"
                                                                                                                                                                                                             Write(item.WriterUserName);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </b> </span>\n                                    </div>\n                                </div>\n                            </a>\n");
#nullable restore
#line 91 "C:\Users\user\Desktop\ReposKodcamp\RepoKodcamp\Dev\Kodcamp\Kodcamp\Views\Forum\Entries.cshtml"
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"


                        <div class=""b-example-divider""></div>


                    </article>


                </div>

                <div class=""col-lg-4"">

                    <div class=""sidebar"">

                        <div class=""sidebar-item "">
                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "87835c7d3af8e8b9d145429060e3a5b66fa8626b16339", async() => {
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
                WriteLiteral("\n                        </div>\n\n                        <h3 style=\"margin-top:45px;\" class=\"sidebar-title\">Son Gönderiler</h3>\n                        <div class=\"sidebar-item recent-posts\">\n");
#nullable restore
#line 115 "C:\Users\user\Desktop\ReposKodcamp\RepoKodcamp\Dev\Kodcamp\Kodcamp\Views\Forum\Entries.cshtml"
                             foreach (var item in newsList)
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <div class=\"post-item clearfix\">\n                                    <a");
                BeginWriteAttribute("href", " href=\"", 5813, "\"", 5839, 2);
                WriteAttributeValue("", 5820, "/haberler/", 5820, 10, true);
#nullable restore
#line 118 "C:\Users\user\Desktop\ReposKodcamp\RepoKodcamp\Dev\Kodcamp\Kodcamp\Views\Forum\Entries.cshtml"
WriteAttributeValue("", 5830, item.Url, 5830, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" style=\"cursor:pointer;\">\n                                        <img");
                BeginWriteAttribute("src", " src=\"", 5910, "\"", 5943, 2);
                WriteAttributeValue("", 5916, "/images/news/", 5916, 13, true);
#nullable restore
#line 119 "C:\Users\user\Desktop\ReposKodcamp\RepoKodcamp\Dev\Kodcamp\Kodcamp\Views\Forum\Entries.cshtml"
WriteAttributeValue("", 5929, item.ImageUrl, 5929, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("alt", " alt=\"", 5944, "\"", 5961, 1);
#nullable restore
#line 119 "C:\Users\user\Desktop\ReposKodcamp\RepoKodcamp\Dev\Kodcamp\Kodcamp\Views\Forum\Entries.cshtml"
WriteAttributeValue("", 5950, item.Title, 5950, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\n                                    </a>\n                                    <h4><a");
                BeginWriteAttribute("href", " href=\"", 6047, "\"", 6073, 2);
                WriteAttributeValue("", 6054, "/Haberler/", 6054, 10, true);
#nullable restore
#line 121 "C:\Users\user\Desktop\ReposKodcamp\RepoKodcamp\Dev\Kodcamp\Kodcamp\Views\Forum\Entries.cshtml"
WriteAttributeValue("", 6064, item.Url, 6064, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 121 "C:\Users\user\Desktop\ReposKodcamp\RepoKodcamp\Dev\Kodcamp\Kodcamp\Views\Forum\Entries.cshtml"
                                                                 Write(item.Title);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a></h4>\n                                    <time datetime=\"2020-01-01\">");
#nullable restore
#line 122 "C:\Users\user\Desktop\ReposKodcamp\RepoKodcamp\Dev\Kodcamp\Kodcamp\Views\Forum\Entries.cshtml"
                                                           Write(item.DateCreated);

#line default
#line hidden
#nullable disable
                WriteLiteral("</time>\n                                </div>\n");
#nullable restore
#line 124 "C:\Users\user\Desktop\ReposKodcamp\RepoKodcamp\Dev\Kodcamp\Kodcamp\Views\Forum\Entries.cshtml"
                            }

#line default
#line hidden
#nullable disable
                WriteLiteral("                        </div>\n                        \n                        <h3 style=\"margin-top:45px;\" class=\"sidebar-title\">Etiketler</h3>\n                        <div class=\"sidebar-item tags\">\n                            <ul>\n");
#nullable restore
#line 130 "C:\Users\user\Desktop\ReposKodcamp\RepoKodcamp\Dev\Kodcamp\Kodcamp\Views\Forum\Entries.cshtml"
                                 foreach (var item in tags)
                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    <li><a style=\"cursor:pointer;\" href=\"/sorular\">");
#nullable restore
#line 132 "C:\Users\user\Desktop\ReposKodcamp\RepoKodcamp\Dev\Kodcamp\Kodcamp\Views\Forum\Entries.cshtml"
                                                                              Write(item.Key);

#line default
#line hidden
#nullable disable
                WriteLiteral(" (");
#nullable restore
#line 132 "C:\Users\user\Desktop\ReposKodcamp\RepoKodcamp\Dev\Kodcamp\Kodcamp\Views\Forum\Entries.cshtml"
                                                                                         Write(item.Value);

#line default
#line hidden
#nullable disable
                WriteLiteral(")</a></li>\n");
#nullable restore
#line 133 "C:\Users\user\Desktop\ReposKodcamp\RepoKodcamp\Dev\Kodcamp\Kodcamp\Views\Forum\Entries.cshtml"
                                }

#line default
#line hidden
#nullable disable
                WriteLiteral("                            </ul>\n                        </div>\n\n                    </div>\n                </div>\n            </div>\n        </div>\n    </section>\n    <script src=\"/js/entryList.js\"></script>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Kodcamp.Models.VMModels.VMForumTopicMessages> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
