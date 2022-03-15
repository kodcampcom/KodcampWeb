using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Kodcamp.EntityNetwork;
using Kodcamp.Helper;
using Kodcamp.Models.EntityModels;
using Kodcamp.Models.LogReport;
using Kodcamp.Models.ModelSystem;
using Kodcamp.Models.Session;
using Kodcamp.Models.VMModels;
using System.IO;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Processing;

namespace Kodcamp.Controllers
{
    public class AdminController : Controller
    {
        #region Classes, Objects, Methods
        NetworkEntity nEntity = new NetworkEntity();
        HelperMethods hM = new HelperMethods();
        #endregion

        #region Session
        public void SetSession(string name, string pass)
        {
            HttpContext.Session.SetString("name", name);
            HttpContext.Session.SetString("pass", pass);
        }
        public ModelSession GetSession()
        {
            ModelSession session = new ModelSession();
            if (!string.IsNullOrEmpty(HttpContext.Session.GetString("name"))) session.Username = HttpContext.Session.GetString("name");
            if (!string.IsNullOrEmpty(HttpContext.Session.GetString("pass"))) session.Password = HttpContext.Session.GetString("pass");
            
            return session;
        }

        public bool CheckSession()
        {
            string password = DateTime.Now.Day.ToString() + "gklp" + DateTime.Now.Month.ToString();
            ModelSession session = GetSession();
            return session.Username == "gok" && session.Password == password ? true : false;
        }
        #endregion

        #region Login
        [HttpGet("Management/Login")]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost("Management/Login")]
        public IActionResult Login(string username ="", string password ="")
        {
            string passwordSession = DateTime.Now.Day.ToString() + "gklp" + DateTime.Now.Month.ToString();

            if (username == "gok" && password == passwordSession)
            {
                SetSession(username, password);
                return RedirectToAction("Management", "Admin");
            }
            else
            {
                return RedirectToAction("Login", "Admin");
            }
        }

        #endregion

        #region Management Index
        // Index
        [HttpGet("mng/sys/kodcamptr")]
        public IActionResult Management()
        {
            if (!CheckSession()) return RedirectToAction("Login", "Admin"); 
            return View();
        }
        #endregion

        #region Category
        [HttpGet("Management/Category")]
        public IActionResult Category()
        {
            if (!CheckSession()) return RedirectToAction("Login", "Admin");

            VMAdminCategory vM = new VMAdminCategory();
            vM.Categories = nEntity.GetCategoryList();
            vM.MainCategories = vM.Categories.Where(w => w.MainCategory == "0").ToList();
            
            return View(vM);
        }

        [HttpGet("Management/Category/Add")]
        public IActionResult AddCategory()
        {
            if (!CheckSession()) return RedirectToAction("Login", "Admin");

            VMAdminCategory vM = new VMAdminCategory();
            vM.Categories = nEntity.GetCategoryList();
            vM.MainCategories = vM.Categories.Where(w => w.MainCategory == "0").ToList();

            return View(vM);
        }

        [HttpPost("Management/Category/Add")]
        public IActionResult AddCategory(string name = "", string mainCategory = "", string isMainCategory = "")
        {
            if (!CheckSession()) return RedirectToAction("Login", "Admin");

            if (isMainCategory == "1") mainCategory = "0";

            EntityCategory category = new EntityCategory();
            category.Name = name;
            category.MainCategory = mainCategory;
            category.ImageUrl = "";
            category.Id = hM.GenerateId(4);
            category.CategoryUrl = hM.ConvertTitleToId(category.Name);

            nEntity.AddCategory(category);

            return RedirectToAction("Category", "Admin");
        }

        #endregion

        #region News

        [HttpGet("Management/news")]
        public IActionResult News()
        {
            if (!CheckSession()) return RedirectToAction("Login", "Admin");

            List<EntityNews> news = new List<EntityNews>();
            news = nEntity.GetNews();

            List<Comment> comments = new List<Comment>();
            comments = nEntity.GetComment();
            for (int i = 0; i < news.Count; i++)
            {
                news[i].Comments = comments.Where(w => w.NewsId == news[i].Id).ToList();
            }

            return View(news);
        }

        [HttpGet("Management/news/Add")]
        public IActionResult AddNews()
        {
            if (!CheckSession()) return RedirectToAction("Login", "Admin");

            VMAdminCategory vM = new VMAdminCategory();
            vM.Categories = nEntity.GetCategoryList();
            vM.MainCategories = vM.Categories.Where(w => w.MainCategory == "0").ToList();

            return View(vM);
        }

        [HttpPost("Management/news/Add")]
        public IActionResult AddNews(string title = "", string detailHeader = "", string articleHeader = "", string detail = "", string mainCategory = "", string subCategory = "", string imageUrl = "", IFormFile image = null, IFormFile imageDetail1 = null, IFormFile imageDetail2 =null, IFormFile imageDetail3 = null)
        {
            if (!CheckSession()) return RedirectToAction("Login", "Admin");

            string imgName = "";
            string imgDetail1Name = "";
            string imgDetail2Name = "";
            string imgDetail3Name = "";

            if (image != null) imgName = hM.ImageUploadToRoot(image, "news", title);
            if (imageDetail1 != null) imgDetail1Name = hM.ImageUploadToRoot(imageDetail1, "news", title+"detay1");
            if (imageDetail2 != null) imgDetail2Name = hM.ImageUploadToRoot(imageDetail2, "news", title+"detay2");
            if (imageDetail3 != null) imgDetail3Name = hM.ImageUploadToRoot(imageDetail3, "news", title+"detay3");
            
            EntityNews news = new EntityNews();
            news.Title = title;
            news.DetailHeader = detailHeader;
            news.Detail = detail;
            news.MainCategoryIds = mainCategory;
            news.CategoryIds = subCategory;
            news.ImageUrl = imgName;
            news.Id = hM.GenerateId(6);
            news.DateCreated = DateTime.Now.ToString("yy.MM.dd HH:mm:ss");
            news.ArticleDetail = articleHeader;
            news.Url = hM.ConvertTitleToId(title);
            news.ImageUrlDetail1 = imgDetail1Name;
            news.ImageUrlDetail2 = imgDetail2Name;
            news.ImageUrlDetail3 = imgDetail3Name;
            nEntity.AddNews(news);

            return RedirectToAction("News", "Admin");
        }

        [HttpGet("Management/news/{newsId}/update")]
        public IActionResult UpdateNews(string newsId = "")
        {
            if (!CheckSession()) return RedirectToAction("Login", "Admin");

            List<EntityNews> news = nEntity.GetNews();
            news = news.Where(w => w.Id == newsId).ToList();

            return View(news);
        }

        [HttpPost("Management/news/{newsId}/update")]
        public IActionResult UpdateNews(string title = "", string detailHeader = "", string detail = "", IFormFile image = null, string newsId = "", string codeTxt = "", IFormFile imageDetail1 = null, IFormFile imageDetail2 = null, IFormFile imageDetail3 = null)
        {
            if (!CheckSession()) return RedirectToAction("Login", "Admin");

            string imgName = "";
            string imgDetail1Name = "";
            string imgDetail2Name = "";
            string imgDetail3Name = "";

            if (image != null) imgName = hM.ImageUploadToRoot(image, "news", title);
            if (imageDetail1 != null) imgDetail1Name = hM.ImageUploadToRoot(imageDetail1, "news", title + "detay1");
            if (imageDetail2 != null) imgDetail2Name = hM.ImageUploadToRoot(imageDetail2, "news", title + "detay2");
            if (imageDetail3 != null) imgDetail3Name = hM.ImageUploadToRoot(imageDetail3, "news", title + "detay3");

            //// resize sixlabors
            //string fileName = pathName;
            //string customRoot = "wwwroot/images/news/";
            //string customRootNew = "wwwroot/images/mini-news/";
            //var path = Path.Combine(Directory.GetCurrentDirectory(), customRoot, fileName);
            //var pathNew = Path.Combine(Directory.GetCurrentDirectory(), customRootNew, fileName);
            //using var image2 = Image.Load(image.OpenReadStream());
            //image2.Mutate(x => x.Resize(96, 96));
            //image2.Save(pathNew);

            List<EntityNews> newsList = nEntity.GetNews().Where(w => w.Id == newsId).ToList();

            EntityNews news = newsList[0];

            news.Title = title;
            news.DetailHeader = detailHeader;
            news.Detail = detail;
            news.Url = hM.ConvertTitleToId(title);
            news.Code = codeTxt;
            if (imgName != "") news.ImageUrl = imgName;
            if (imgDetail1Name != "") news.ImageUrlDetail1 = imgDetail1Name;
            if (imgDetail2Name != "") news.ImageUrlDetail2 = imgDetail2Name;
            if (imgDetail3Name != "") news.ImageUrlDetail3 = imgDetail3Name;
            nEntity.UpdateNews(news);

            return RedirectToAction("News", "Admin");
        }

        [HttpGet("Management/news/delete/{id}")]
        public IActionResult DeleteNews(string id = "")
        {
            nEntity.DeleteNews(id);

            return RedirectToAction("News", "Admin");
        }

        #endregion

        #region Comment
        [HttpGet("Management/news/comment/approve/{id}/{type}")]
        public IActionResult ApproveComment(string id = "", string type = "")
        {
            if (!CheckSession()) return RedirectToAction("Login", "Admin");

            List<Comment> comments = nEntity.GetComment();
            Comment comment = comments.Where(c => c.Id == id).FirstOrDefault();
            comment.Approved = type;
            nEntity.UpdateComment(comment);

            return RedirectToAction("News", "Admin");
        }

        #endregion

        #region Log Report
        [HttpGet("Management/Logs")]
        public IActionResult Logs(string id = "", string type = "")
        {
            if (!CheckSession()) return RedirectToAction("Login", "Admin");
            List<ModelLogPlus> logs = nEntity.GetLogs();
            logs = logs.OrderByDescending(w => w.DateTime).ToList();
            List<EntityNews> news = nEntity.GetNews();

            VMLogNews vM = new VMLogNews();
            vM.Logs = logs;
            vM.News = news;

            return View(vM);
        }

        [HttpGet("Management/Contact")]
        public IActionResult Contact(string id = "", string type = "")
        {
            if (!CheckSession()) return RedirectToAction("Login", "Admin");

            List<Contact> contacts = nEntity.GetContacts();
            contacts = contacts.OrderByDescending(w => w.DateCreated).ToList();

            return View(contacts);
        }
        #endregion

        #region System
        
        [HttpGet("/detay/genel/test")]
        public IActionResult SystemInfoDetayTest()
        {
            #region Session Check Fill User
            if (!CheckSession()) return RedirectToAction("Login", "Forum");
            ModelSession session = GetSession();
            #endregion

            return View();
        }

        [HttpPost("/detay/genel/test")]
        public IActionResult SystemInfoDetayTest(string test1 = "")
        {
            #region Session Check Fill User
            if (!CheckSession()) return RedirectToAction("Login", "Forum");
            ModelSession session = GetSession();
            #endregion

            string type = "";
            test1 = test1.ToLower();
            if (test1 == "aç" || test1 == "ac")
            {
                type = "1";
            }
            if (test1 == "kapat")
            {
                type = "0";
            }

            SystemInfo system = nEntity.GetSystemInfo().Response as SystemInfo;
            system.Status = type;

            nEntity.UpdateSystem(system);

            return RedirectToAction("Management", "Admin");
        }
        #endregion
    }
}
