#pragma checksum "C:\Users\user\Desktop\Kodcamp\Kodcamp\Views\Admin\News.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "68d73a8511b6debad82774aec6a44411777cfe2b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_News), @"mvc.1.0.view", @"/Views/Admin/News.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"68d73a8511b6debad82774aec6a44411777cfe2b", @"/Views/Admin/News.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2b5280ab63654a7920e1468f98e11c2ed5684db1", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_News : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Kodcamp.Models.EntityModels.EntityNews>>
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\user\Desktop\Kodcamp\Kodcamp\Views\Admin\News.cshtml"
  
    Layout = null;
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\user\Desktop\Kodcamp\Kodcamp\Views\Admin\News.cshtml"
    var news = Model;

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<!doctype html>\n<html lang=\"en\">\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "68d73a8511b6debad82774aec6a44411777cfe2b3561", async() => {
                WriteLiteral("\n    <meta charset=\"utf-8\">\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1\">\n    <meta name=\"description\"");
                BeginWriteAttribute("content", " content=\"", 272, "\"", 282, 0);
                EndWriteAttribute();
                WriteLiteral(@">
    <meta name=""author"" content=""Mark Otto, Jacob Thornton, and Bootstrap contributors"">
    <meta name=""generator"" content=""Hugo 0.88.1"">
    <title>Dashboard Template ?? Bootstrap v5.1</title>

    <link rel=""canonical"" href=""https://getbootstrap.com/docs/5.1/examples/dashboard/"">

    <!-- Bootstrap core CSS -->
    <link href=""/assets/dist/css/bootstrap.min.css"" rel=""stylesheet"">

    <style>
      .bd-placeholder-img {
        font-size: 1.125rem;
        text-anchor: middle;
        -webkit-user-select: none;
        -moz-user-select: none;
        user-select: none;
      }

      ");
#nullable restore
#line 31 "C:\Users\user\Desktop\Kodcamp\Kodcamp\Views\Admin\News.cshtml"
  Write("@media");

#line default
#line hidden
#nullable disable
                WriteLiteral(" (min-width: 768px) {\n        .bd-placeholder-img-lg {\n          font-size: 3.5rem;\n        }\n      }\n    </style>\n\n\n    <!-- Custom styles for this template -->\n    <link href=\"/css/dashboard.css\" rel=\"stylesheet\">\n");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "68d73a8511b6debad82774aec6a44411777cfe2b5858", async() => {
                WriteLiteral(@"

    <header class=""navbar navbar-dark sticky-top bg-dark flex-md-nowrap p-0 shadow"">
        <a class=""navbar-brand col-md-3 col-lg-2 me-0 px-3"" href=""/"">Siteye D??n</a>
        <button class=""navbar-toggler position-absolute d-md-none collapsed"" type=""button"" data-bs-toggle=""collapse"" data-bs-target=""#sidebarMenu"" aria-controls=""sidebarMenu"" aria-expanded=""false"" aria-label=""Toggle navigation"">
            <span class=""navbar-toggler-icon""></span>
        </button>
        <input class=""form-control form-control-dark w-100"" type=""text"" placeholder=""Search"" aria-label=""Search"">
        <div class=""navbar-nav"">
            <div class=""nav-item text-nowrap"">
                <a class=""nav-link px-3"" href=""#"">Sign out</a>
            </div>
        </div>
    </header>

    <div class=""container-fluid"">
        <div class=""row"">
            <nav id=""sidebarMenu"" class=""col-md-3 col-lg-2 d-md-block bg-light sidebar collapse"">
                <div class=""position-sticky pt-3"">
                    <ul class=""nav fl");
                WriteLiteral(@"ex-column"">
                        <li class=""nav-item"">
                            <a class=""nav-link active"" aria-current=""page"" href=""/Management"">
                                <span data-feather=""home""></span>
                                Anasayfa
                            </a>
                        </li>
                        <li class=""nav-item"">
                            <a class=""nav-link"" href=""/Management/Category"">
                                <span data-feather=""file""></span>
                                Kategoriler
                            </a>
                        </li>
                        <li class=""nav-item"">
                            <a class=""nav-link"" href=""/Management/News"">
                                <span data-feather=""shopping-cart""></span>
                                Haberler
                            </a>
                        </li>
                    </ul>

                    
                </div>
            </nav>

            <mai");
                WriteLiteral(@"n class=""col-md-9 ms-sm-auto col-lg-10 px-md-4"" id=""mainId"">
                <div class=""d-flex justify-content-between flex-wrap flex-md-nowrap align-items-center pt-3 pb-2 mb-3 border-bottom"">
                    <h1 class=""h2"">Kategori Y??netimi</h1>

                    <div class=""btn-toolbar mb-2 mb-md-0"">
                        <div class=""btn-group me-2"">
                            <button type=""button"" class=""btn btn-sm btn-outline-secondary"">Share</button>
                            <button type=""button"" class=""btn btn-sm btn-outline-secondary"">Export</button>
                        </div>
                        <button type=""button"" class=""btn btn-sm btn-outline-secondary dropdown-toggle"">
                            <span data-feather=""calendar""></span>
                            This week
                        </button>
                    </div>
                </div>
                <br />

                <div class=""d-flex"">
                    <h4>Haberler</h4>
                    <bu");
                WriteLiteral(@"tton type=""button"" onclick=""location.href='/Management/News/Add'"" ; style=""margin-left:80%;"" class=""btn btn-success"">Haber Ekle</button>
                </div>


                <div class=""table-responsive"">
                    <table class=""table table-striped table-hover"">
                        <thead>
                            <tr>
                                <th scope=""col"">Ba??l??k</th>
                                <th scope=""col"">Image</th>
                                <th scope=""col"">Yorumlar</th>
                                <th scope=""col""></th>
                            </tr>
                        </thead>
                        <tbody id=""tstId"">


");
#nullable restore
#line 122 "C:\Users\user\Desktop\Kodcamp\Kodcamp\Views\Admin\News.cshtml"
                             for (int i = 0; i < news.Count; i++)
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <tr>\n                                    <td>");
#nullable restore
#line 125 "C:\Users\user\Desktop\Kodcamp\Kodcamp\Views\Admin\News.cshtml"
                                   Write(news[i].Title);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n                                    <td>\n                                        <img");
                BeginWriteAttribute("src", " src=\"", 5159, "\"", 5195, 2);
                WriteAttributeValue("", 5165, "/images/news/", 5165, 13, true);
#nullable restore
#line 127 "C:\Users\user\Desktop\Kodcamp\Kodcamp\Views\Admin\News.cshtml"
WriteAttributeValue("", 5178, news[i].ImageUrl, 5178, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" style=\"width: 55px; height: 55px; \" />\n                                    </td>\n                                    <td>\n");
#nullable restore
#line 130 "C:\Users\user\Desktop\Kodcamp\Kodcamp\Views\Admin\News.cshtml"
                                          
                                            if (news[i].Comments.Count() > 0)
                                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                <input type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 5554, "\"", 5573, 1);
#nullable restore
#line 133 "C:\Users\user\Desktop\Kodcamp\Kodcamp\Views\Admin\News.cshtml"
WriteAttributeValue("", 5562, news[i].Id, 5562, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("id", " id=\"", 5574, "\"", 5585, 2);
                WriteAttributeValue("", 5579, "cat-", 5579, 4, true);
#nullable restore
#line 133 "C:\Users\user\Desktop\Kodcamp\Kodcamp\Views\Admin\News.cshtml"
WriteAttributeValue("", 5583, i, 5583, 2, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\n                                                <button");
                BeginWriteAttribute("id", " id=\"", 5645, "\"", 5656, 2);
                WriteAttributeValue("", 5650, "btn-", 5650, 4, true);
#nullable restore
#line 134 "C:\Users\user\Desktop\Kodcamp\Kodcamp\Views\Admin\News.cshtml"
WriteAttributeValue("", 5654, i, 5654, 2, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" onclick=\"GetSubCategories(this.id);\" type=\"button\" class=\"btn btn-secondary\">\n                                                    Yorumlar ( ");
#nullable restore
#line 135 "C:\Users\user\Desktop\Kodcamp\Kodcamp\Views\Admin\News.cshtml"
                                                          Write(news[i].Comments.Count());

#line default
#line hidden
#nullable disable
                WriteLiteral(" )\n                                                </button>\n");
#nullable restore
#line 137 "C:\Users\user\Desktop\Kodcamp\Kodcamp\Views\Admin\News.cshtml"


                                            }
                                            else
                                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                <span> Bekleyen Yorum Yok.</span>\n");
#nullable restore
#line 143 "C:\Users\user\Desktop\Kodcamp\Kodcamp\Views\Admin\News.cshtml"
                                            }
                                        

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                                    </td>\n                                    <td>\n                                        <a data-toggle=\"modal\" data-target=\"#exampleModal-");
#nullable restore
#line 148 "C:\Users\user\Desktop\Kodcamp\Kodcamp\Views\Admin\News.cshtml"
                                                                                     Write(i);

#line default
#line hidden
#nullable disable
                WriteLiteral("\"");
                BeginWriteAttribute("href", " href=\"", 6375, "\"", 6382, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"btn btn-danger\"> S??L </a>\n                                    </td>\n                                    <td>\n                                        <a");
                BeginWriteAttribute("href", " href=\"", 6542, "\"", 6584, 3);
                WriteAttributeValue("", 6549, "/Management/news/", 6549, 17, true);
#nullable restore
#line 151 "C:\Users\user\Desktop\Kodcamp\Kodcamp\Views\Admin\News.cshtml"
WriteAttributeValue("", 6566, news[i].Id, 6566, 11, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 6577, "/update", 6577, 7, true);
                EndWriteAttribute();
                WriteLiteral(" class=\"btn btn-danger\"> G??NCELLE </a>\n                                    </td>\n                                </tr>\n");
                WriteLiteral("                                <div class=\"modal fade\"");
                BeginWriteAttribute("id", " id=\"", 6760, "\"", 6780, 2);
                WriteAttributeValue("", 6765, "exampleModal-", 6765, 13, true);
#nullable restore
#line 155 "C:\Users\user\Desktop\Kodcamp\Kodcamp\Views\Admin\News.cshtml"
WriteAttributeValue("", 6778, i, 6778, 2, false);

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
                                                <b> ");
#nullable restore
#line 165 "C:\Users\user\Desktop\Kodcamp\Kodcamp\Views\Admin\News.cshtml"
                                               Write(news[i].Title);

#line default
#line hidden
#nullable disable
                WriteLiteral(@" </b> haberini silmek istedi??inizden emin misiniz ?
                                            </div>
                                            <div class=""modal-footer"">
                                                <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">HAYIR</button>
                                                <button");
                BeginWriteAttribute("onclick", " onclick=\"", 8018, "\"", 8087, 4);
                WriteAttributeValue("", 8028, "window.location.href=\'/Management/news/delete/", 8028, 46, true);
#nullable restore
#line 169 "C:\Users\user\Desktop\Kodcamp\Kodcamp\Views\Admin\News.cshtml"
WriteAttributeValue("", 8074, news[i].Id, 8074, 11, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 8085, "\'", 8085, 1, true);
                WriteAttributeValue(" ", 8086, "", 8087, 1, true);
                EndWriteAttribute();
                WriteLiteral(" type=\"button\" class=\"btn btn-danger\">EVET</button>\n                                            </div>\n                                        </div>\n                                    </div>\n                                </div>\n");
#nullable restore
#line 174 "C:\Users\user\Desktop\Kodcamp\Kodcamp\Views\Admin\News.cshtml"
                            }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                        </tbody>
                    </table>
                </div>

                <br />

                <div class=""table-responsive"" id=""tableSubCategory"">

                </div>
            </main>
        </div>
    </div>


    

    <script>
        var news = ");
#nullable restore
#line 192 "C:\Users\user\Desktop\Kodcamp\Kodcamp\Views\Admin\News.cshtml"
              Write(Html.Raw(Json.Serialize(news)));

#line default
#line hidden
#nullable disable
                WriteLiteral(@";

    </script>

    <script src=""https://code.jquery.com/jquery-3.3.1.slim.min.js"" integrity=""sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo"" crossorigin=""anonymous""></script>
    <script src=""https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/js/bootstrap.min.js"" integrity=""sha384-JjSmVgyd0p3pXB1rRibZUAYoIIy6OrQ6VrjIEaFf/nJGzIxFDsf4x0xIM+B07jRM"" crossorigin=""anonymous""></script>

    <script src=""/assets/dist/js/bootstrap.bundle.min.js""></script>
    <script src=""/js/adminNews.js""></script>

    <script src=""https://cdn.jsdelivr.net/npm/feather-icons@4.28.0/dist/feather.min.js"" integrity=""sha384-uO3SXW5IuS1ZpFPKugNNWqTZRRglnUJK6UAZ/gxOX80nxEkN9NcGZTftn6RzhGWE"" crossorigin=""anonymous""></script>
    <script src=""https://cdn.jsdelivr.net/npm/chart.js@2.9.4/dist/Chart.min.js"" integrity=""sha384-zNy6FEbO50N+Cg5wap8IKA4M/ZnLJgzc6w2NqACZaK0u0FXfOWRRJOnQtpZun8ha"" crossorigin=""anonymous""></script>
    <script src=""/js/dashboard.js""></script>
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
            WriteLiteral("\n</html>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Kodcamp.Models.EntityModels.EntityNews>> Html { get; private set; }
    }
}
#pragma warning restore 1591
