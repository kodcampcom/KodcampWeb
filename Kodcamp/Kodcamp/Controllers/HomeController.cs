using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Kodcamp.EntityNetwork;
using Kodcamp.Models.EntityModels;
using Kodcamp.Models.VMModels;
using Kodcamp.Helper;
using Kodcamp.Models.LogReport;
using Kodcamp.Models.Interaction;
using System.Globalization;
using Kodcamp.Models.AnswerQuestion;
using Kodcamp.Models.Forum;
using System.Net.Mail;
using System.Net;
using Kodcamp.Models.Response;
using Kodcamp.Models.ModelSystem;
using System.Threading;
using Kodcamp.Models;
using RabbitMQ.Client;
using Newtonsoft.Json;
using System.Text;

namespace Kodcamp.Controllers
{
    public class HomeController : Controller
    {
        #region Classes Helpers
        NetworkEntity nEntity = new NetworkEntity();
        HelperMethods hM = new HelperMethods();
        #endregion

        public string GetSystemInfo()
        {
            SystemInfo info = nEntity.GetSystemInfo().Response as SystemInfo;
            return info.Status;
        }

        [HttpGet("Error")]
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            this.HttpContext.Response.StatusCode = 404;
            return View();
        }

        #region Index

        public IActionResult Index()
        {
            string infoSystem = GetSystemInfo();
            if (infoSystem == "0") return RedirectToAction("ComingSoon", "Home");

            List<EntityNews> news = nEntity.GetNews();

            VMIndex vM = new VMIndex();
            vM.Programming = news.Where(w => w.MainCategoryIds == "fSel").ToList();
            if (vM.Programming.Count > 1) vM.Programming = vM.Programming.Take(1).ToList();

            vM.OperatingSystems = news.Where(w => w.MainCategoryIds == "s7ES").ToList();
            if (vM.OperatingSystems.Count > 1) vM.OperatingSystems = vM.OperatingSystems.Take(1).ToList();

            vM.Hardware = news.Where(w => w.MainCategoryIds == "8HBJ").ToList();
            if (vM.Hardware.Count > 1) vM.Hardware = vM.Hardware.Take(1).ToList();

            vM.Technology = news.Where(w => w.MainCategoryIds == "WzJh").ToList();
            if (vM.Technology.Count > 2) vM.Technology = vM.Technology.Take(2).ToList();

            vM.Articles = news.Where(w => w.MainCategoryIds == "D0mN").ToList();
            if (vM.Articles.Count > 2) vM.Articles = vM.Articles.Take(2).ToList();

            vM.Lessons = news.Where(w => w.MainCategoryIds == "egc0").ToList();
            if (vM.Lessons.Count > 2) vM.Lessons = vM.Lessons.Take(2).ToList();

            ViewData["Title"] = "Kodcamp.com - Yazılım, Bilişim ve Teknoloji Kampüsü";
            ViewData["Description"] = "Kodcamp ile teknoloji ve kodlama hakkında haberleri takip edebilir, yazılım eğitimlerimizi inceleyebilir ve dilediğiniz soruyu sorarak cevap bulabilirsiniz.";

            return View(vM);
        }

        #endregion

        #region News

        [HttpGet("Haberler")]
        public IActionResult NewsList()
        {
            List<EntityNews> news = new List<EntityNews>();
            news = nEntity.GetNews();

            List<ModelNews> modelNewsList = new List<ModelNews>();

            for (int i = 0; i < news.Count; i++)
            {
                ModelNews modelNews = new ModelNews();
                modelNews.CategoryIds = news[i].CategoryIds;
                modelNews.Comments = news[i].Comments;
                modelNews.DateCreated = news[i].DateCreated;
                modelNews.Detail = news[i].Detail;
                modelNews.DetailHeader = news[i].DetailHeader;
                modelNews.Id = news[i].Id;
                modelNews.MainCategoryIds = news[i].MainCategoryIds;
                modelNews.Title = news[i].Title;
                modelNews.ViewedCount = news[i].ViewedCount;
                modelNews.ImageUrl = news[i].ImageUrl;
                modelNews.Url = news[i].Url;
                modelNews.LikeCount = news[i].LikeCount;
                modelNews.UnlikeCount = news[i].UnlikeCount;
                modelNews.CoderCount = news[i].CoderCount;
                modelNews.SmileCount = news[i].SmileCount;
                modelNewsList.Add(modelNews);
            }

            ViewData["Title"] = "Güncel Teknoloji Haberleri";
            ViewData["Description"] = "Yazılım Bilişim Teknoloji Kodlama ile ilgili güncel haberler ve makaleler";
            ViewData["HeaderTitle"] = "Kodcamp Güncel Yazılım ve Bilişim Haberleri";

            return View(modelNewsList);
        }

        [HttpGet("Haberler/{url}")]
        public IActionResult NewsDetail(string url = "", string isCommentSent = "", string position = "")
        {
            string infoSystem = GetSystemInfo();
            if (infoSystem == "0") return RedirectToAction("ComingSoon", "Home");

            ViewData["isCommentSent"] = isCommentSent;
            ViewData["Position"] = position;

            List<EntityNews> newsList = nEntity.GetNews();
            List<EntityNews> news = newsList.Where(w => w.Url == url).ToList();
            if (news == null || news.Count == 0)
            {
                return RedirectToAction("NewsList", "Home");
            }
            List<Comment> comments = nEntity.GetComment().Where(c => c.NewsId == news[0].Id && c.Approved == "1").ToList();
            news[0].Comments = comments;

            ModelNews modelNews = new ModelNews();
            modelNews.CategoryIds = news[0].CategoryIds;
            modelNews.Comments = news[0].Comments;
            modelNews.DateCreated = news[0].DateCreated;
            modelNews.Detail = news[0].Detail;
            modelNews.DetailHeader = news[0].DetailHeader;
            modelNews.Id = news[0].Id;
            modelNews.MainCategoryIds = news[0].MainCategoryIds;
            modelNews.Title = news[0].Title;
            modelNews.ViewedCount = news[0].ViewedCount;
            modelNews.ImageUrl = news[0].ImageUrl;
            modelNews.Code = news[0].Code;
            modelNews.Url = news[0].Url;
            modelNews.LikeCount = news[0].LikeCount;
            modelNews.UnlikeCount = news[0].UnlikeCount;
            modelNews.SmileCount = news[0].SmileCount;
            modelNews.CoderCount = news[0].CoderCount;

            DateTime newDate = DateTime.ParseExact(modelNews.DateCreated, "yy.MM.dd HH:mm:ss", CultureInfo.InvariantCulture);
            string year = newDate.Year.ToString();
            string[] months = { "Ocak", "Şubat", "Mart", "Nisan", "Mayıs", "Haziran", "Temmuz", "Ağustos", "Eylül", "Ekim", "Kasım", "Aralık" };
            string month = months[newDate.Month];
            string day = newDate.Day.ToString();
            string hour = modelNews.DateCreated.Split(" ").Last();
            string newFormattedDate = day + " " + month + " " + year + "  " + hour;

            modelNews.DateTimeFormatted = newFormattedDate;

            VMNewsDetailTags vM = new VMNewsDetailTags();
            vM.News = modelNews;
            vM.NewsList = newsList;

            #region Try-CATCH
            //try
            //{
            //    Thread threadLog = new Thread(() => nEntity.AddLog(news[0].Id, title: modelNews.Title, type: "haberler"));
            //    Thread.CurrentThread.IsBackground = true;
            //    threadLog.Start();

            //    Thread threadLog2 = new Thread(() => nEntity.AddInteraction(newsId: news[0].Id, type: "5"));
            //    Thread.CurrentThread.IsBackground = true;
            //    threadLog2.Start();

            //    Thread threadLog3 = new Thread(() => nEntity.AddCountToNews(newsId: news[0].Id));
            //    Thread.CurrentThread.IsBackground = true;
            //    threadLog2.Start();
            //}
            //catch (Exception)
            //{
            //    ViewData["Title"] = "KodCamp - " + vM.News.Title;
            //    ViewData["Description"] = vM.News.DetailHeader;
            //    return View(vM);
            //}
            #endregion

            nEntity.AddLog(news[0].Id, title: modelNews.Title, type: "haberler");

            nEntity.AddInteraction(newsId: news[0].Id, type: "5");

            nEntity.AddCountToNews(newsId: news[0].Id);

            ViewData["Title"] = "KodCamp - " + vM.News.Title;
            ViewData["Description"] = vM.News.DetailHeader;

            return View(vM);
        }

        #region Helpers News

        // Gönderilere haberlere yorum ekleme ( herkes ekleyebilir )
        [HttpGet("News/AddComment")]
        public IActionResult AddComment(string id = "", string commentTxt = "", string nickName = "", string newsId = "")
        {
            Comment comment = new Comment();
            comment.Id = hM.GenerateId(4);
            comment.NickName = nickName;
            comment.Text = commentTxt;
            comment.NewsId = newsId;
            comment.Approved = "0";

            nEntity.AddComment(comment);

            List<EntityNews> news = nEntity.GetNews().Where(w => w.Id == newsId).ToList();

            return RedirectToAction("NewsDetail", "Home", new { url = news[0].Url, isCommentSent = "1" });
        }

        // Interaction, like, smile, unlike
        [HttpGet("News/Interact/{newsId}/{type}/{position}")]
        public IActionResult AddInteract(string newsId = "", string type = "", string position = "")
        {
            List<EntityNews> news = nEntity.GetNews().Where(w => w.Id == newsId).ToList();
            nEntity.AddInteraction(newsId: newsId, type: type);
            return RedirectToAction("NewsDetail", "Home", new { url = news[0].Url, position = position });
        }

        #endregion

        #endregion

        #region Articles

        [HttpGet("Makaleler")]
        public IActionResult Articles()
        {
            List<EntityNews> news = nEntity.GetNews();
            VMQuestionCategoryTags vM = new VMQuestionCategoryTags();
            vM.News = news;

            ViewData["Title"] = "Makale ve Blog Yazıları";
            ViewData["Description"] = "Yazılım ve Bilişim Hakkında Tüm Makaleler ve Blog Yazıları";
            ViewData["HeaderTitle"] = "Kodcamp Yazılım ve Bilişim Makale ve Blog Yazıları";

            return View(vM);
        }

        #endregion

        #region Lessons

        [HttpGet("Egitimler")]
        public IActionResult Lessons()
        {
            List<EntityNews> news = nEntity.GetNews().Where(w => w.MainCategoryIds == "egc0").ToList();

            ViewData["Title"] = "Yazılım Eğitimleri";
            ViewData["Description"] = "Yazılım ve Programlama Hakkında Kod Örnekleri ve Dersler";
            ViewData["HeaderTitle"] = "Kodcamp Yazılım ve Kodlama Eğitimleri";

            return View(news);
        }

        #endregion

        #region Social Media

        [HttpGet("Sosyal")]
        public IActionResult Social()
        {
            List<EntityNews> news = nEntity.GetNews();

            ViewData["Title"] = "Sosyal Medya";
            ViewData["Description"] = "Kodcamp sosyal medya hesaplarını inceleyerek, güncel teknoloji gündemini takip edebilirsiniz.";
            ViewData["HeaderTitle"] = "Kodcamp Sosyal Medya Hesapları";

            return View(news);
        }

        #endregion

        #region Search and Filter News

        [HttpGet("Kategoriler/{categoryUrl}")]
        public IActionResult PageSearchFilterSort(string categoryUrl = "")
        {
            VMCategoryNews vM = new VMCategoryNews();

            List<EntityCategory> categories = new List<EntityCategory>();
            categories = nEntity.GetCategoryList();

            List<EntityNews> news = new List<EntityNews>();
            news = nEntity.GetNews();

            List<ModelLogPlus> logs = new List<ModelLogPlus>();
            logs = nEntity.GetLogs();

            for (int i = 0; i < news.Count; i++)
            {
                for (int k = 0; k < logs.Count; k++)
                {
                    if (news[i].Id == logs[k].NewsId)
                    {
                        news[i].ViewedCount = news[i].ViewedCount + 1;
                    }
                }
            }

            for (int i = 0; i < news.Count; i++) news[i].DetailHeader = news[i].DetailHeader.Length > 80 ? news[i].DetailHeader.Substring(0, 80) + "..." : news[i].DetailHeader;

            vM.News = news;
            vM.Categories = categories;
            vM.MainCategories = categories.Where(w => w.MainCategory == "0").ToList();

            ViewData["Title"] = "Kategoriler";
            ViewData["Description"] = "Kodcamp güncel haber, makale ve blog yazılarını filtreleyerek inceleyebilirsiniz.";
            ViewData["HeaderTitle"] = "Kodcamp Kategoriler ve Filtreleme";

            return View(vM);
        }

        #endregion


        #region Applications

        [HttpGet("Uygulamalar")]
        public IActionResult Applications()
        {

            ViewData["Title"] = "Uygulamalar ve Hesaplama Araçları";
            ViewData["Description"] = "Kodcamp uygulamaları ve hesaplama araçları. Yüzde hesaplama, indirim hesaplama, ortalama hesaplama, kelime tahmin etme özelliklerimizi deneyebilirsiniz.";
            ViewData["HeaderTitle"] = "Kodcamp Hesaplama Araçları ve Uygulamalar";
            return View();
        }

        //Yüzde hesaplama
        [HttpGet("Uygulamalar/Yuzde-Hesaplama")]
        public IActionResult CalculatePercentage()
        {

            IOrderedEnumerable<KeyValuePair<string, int>> tags = nEntity.GetQuestionTags();
            List<EntityNews> news = nEntity.GetNews();

            VMChannels vM = new VMChannels();
            vM.TagsKeyValue = tags;
            vM.NewsList = news;

            ViewData["Title"] = "Yüzde Hesaplama";
            ViewData["Description"] = "Yüzde nasıl hesaplanır sorusuna cevap bularak matematiksel yüzde hesaplama işlemlerini kolayca yapabilirsiniz.";
            ViewData["HeaderTitle"] = "Kodcamp Yüzde Hesaplama Uygulaması";

            nEntity.AddLog(news[0].Id, title: "", type: "yuzde-hesaplama");

            return View(vM);
        }

        // İndirim Hesaplama
        [HttpGet("Uygulamalar/Indirim-Hesaplama")]
        public IActionResult CalculateDiscount()
        {

            IOrderedEnumerable<KeyValuePair<string, int>> tags = nEntity.GetQuestionTags();
            List<EntityNews> news = nEntity.GetNews();

            VMChannels vM = new VMChannels();
            vM.TagsKeyValue = tags;
            vM.NewsList = news;

            ViewData["Title"] = "İndirim Oranı Hesaplama";
            ViewData["Description"] = "Ürünlerin indirim oranını, indirim tutarını ve son fiyatını hesaplayın.";
            ViewData["HeaderTitle"] = "Kodcamp İndirim Hesaplama Uygulaması";

            nEntity.AddLog(news[0].Id, title: "", type: "indirim-hesaplama");

            return View(vM);
        }

        // Karakter ya da kelime değiştirme
        [HttpGet("Uygulamalar/Kelime-Karakter-Degistirme")]
        public IActionResult ChangeText()
        {

            IOrderedEnumerable<KeyValuePair<string, int>> tags = nEntity.GetQuestionTags();
            List<EntityNews> news = nEntity.GetNews();

            VMChannels vM = new VMChannels();
            vM.TagsKeyValue = tags;
            vM.NewsList = news;

            ViewData["Title"] = "Metin Değiştirme";
            ViewData["Description"] = "Metindeki kelime ya da karakterleri değiştirme.";
            ViewData["HeaderTitle"] = "Kodcamp Metindeki Kelimeleri Değiştirme Aracı";

            nEntity.AddLog(news[0].Id, title: "", type: "text-degistirme");

            return View(vM);
        }

        // Kelime sayısı hesaplama
        [HttpGet("Uygulamalar/Kelime-Sayisi-Hesapla")]
        public IActionResult FindLengthOfWords()
        {

            IOrderedEnumerable<KeyValuePair<string, int>> tags = nEntity.GetQuestionTags();
            List<EntityNews> news = nEntity.GetNews();

            VMChannels vM = new VMChannels();
            vM.TagsKeyValue = tags;
            vM.NewsList = news;

            ViewData["Title"] = "Kelime Sayısı Hesapla";
            ViewData["Description"] = "Metin ya da paragraftaki yaklaşık kelime sayısını hesaplama.";
            ViewData["HeaderTitle"] = "Kodcamp Metindeki Kelime Sayısını Tahmin Etme Uygulaması";

            nEntity.AddLog(news[0].Id, title: "", type: "kelime-sayisi");

            return View(vM);
        }

        // Ortalama Hesapla
        [HttpGet("Uygulamalar/ortalama-hesapla")]
        public IActionResult CalculateAverage()
        {

            IOrderedEnumerable<KeyValuePair<string, int>> tags = nEntity.GetQuestionTags();
            List<EntityNews> news = nEntity.GetNews();

            VMChannels vM = new VMChannels();
            vM.TagsKeyValue = tags;
            vM.NewsList = news;

            ViewData["Title"] = "Ortalama Hesapla";
            ViewData["Description"] = "Sınav ve not ortalamalarınızı hesaplayabilirsiniz.";
            ViewData["HeaderTitle"] = "Kodcamp Ders Not Ortalaması Hesaplama Uygulaması";

            nEntity.AddLog(news[0].Id, title: "", type: "ortalama-hesapla");

            return View(vM);
        }

        #region Channels - Chat

        [HttpGet("Chat")]
        public IActionResult Chat()
        {

            return View();
        }

        [HttpGet("Uygulamalar/Channels/{type}")]
        public IActionResult Channels(string type = "1")
        {

            ViewData["Type"] = type;
            List<EntityCategory> categories = nEntity.GetCategoryList();
            categories = categories.Where(w => w.MainCategory == "0").ToList();

            IOrderedEnumerable<KeyValuePair<string, int>> tags = nEntity.GetQuestionTags();
            List<EntityNews> news = nEntity.GetNews();

            VMChannels vM = new VMChannels();
            vM.TagsKeyValue = tags;
            vM.NewsList = news;
            vM.Categories = categories;

            ViewData["Title"] = "Tartışma Kanalları";
            ViewData["Description"] = "Yazılım ve Teknoloji hakkında tartışmalara katılabilirsiniz";

            return View(vM);
        }

        [HttpPost("Uygulamalar/Channels/{type}")]
        public IActionResult Channels(string mainCategory = "", string subCategory = "", string password = "", string type = "")
        {

            string passwordTxt = "Tst-" + DateTime.Now.Day.ToString() + "gklp" + DateTime.Now.Month.ToString();
            List<EntityCategory> categories = nEntity.GetCategoryList();

            VMChannels vM = new VMChannels();
            if (password != passwordTxt)
            {
                categories = categories.Where(w => w.MainCategory == "0").ToList();
                IOrderedEnumerable<KeyValuePair<string, int>> tags = nEntity.GetQuestionTags();
                List<EntityNews> news = nEntity.GetNews();

                vM.TagsKeyValue = tags;
                vM.NewsList = news;
                vM.Categories = categories;
                type = "0";
                ViewData["Type"] = type;
                return View(vM);
            }

            string channelId = mainCategory;
            string channelName = categories.Where(w => w.Id == channelId).FirstOrDefault().Name;

            if (channelName == "Programlama")
            {
                channelName = "programlama";
            }
            if (channelName == "İşletim Sistemleri")
            {
                channelName = "isletimsistemleri";
            }
            if (channelName == "Donanım")
            {
                channelName = "donanim";
            }

            return RedirectToAction("ChannelsChat", "Home", new { channelName = channelName });
        }

        [HttpGet("ChannelsChat/{channelName}")]
        public IActionResult ChannelsChat(string channelName = "")
        {

            List<EntityCategory> categories = nEntity.GetCategoryList();

            VMCategoryNews vM = new VMCategoryNews();
            vM.Categories = categories;
            vM.MainCategories = categories.Where(w => w.MainCategory == "0").ToList();

            ViewData["ChannelName"] = channelName;

            return View(vM);
        }

        #endregion

        #endregion

        #region Contact

        [HttpGet("Iletisim/{type}")]
        public IActionResult Contact(string type = "0")
        {

            ViewData["IsSend"] = type;
            return View();
        }

        [HttpPost("Iletisim/{type}")]
        public IActionResult SendMail(string detail = "", string mailAddress = "", string title = "", string userName = "", string type = "")
        {

            // Mail template
            string path = "wwwroot/mail/mailTemp.txt";
            string mailText = System.IO.File.ReadAllText(path);
            mailText = mailText.Replace("xxxTextxxx", detail);
            mailText = mailText.Replace("xxxTitlexxx", title);
            mailText = mailText.Replace("xxxMailxxx", mailAddress);
            mailText = mailText.Replace("xxxNamexxx", userName);

            SmtpClient sc = new SmtpClient();
            sc.Port = 587;
            sc.Host = "smtp.gmail.com";
            sc.EnableSsl = true;
            sc.Credentials = new NetworkCredential("kodcampsite@gmail.com", "Kore20451905");

            MailMessage mail = new MailMessage();
            mail.From = new MailAddress("kodcampsite@gmail.com");
            mail.To.Add("kodcampcom@gmail.com");
            mail.Subject = "Title";
            mail.IsBodyHtml = true;
            mail.Body = mailText;

            ModelResponse response = nEntity.AddContact(title: title, detail: detail, name: userName, mail: mailAddress);
            if (response.Status == 1) type = "1";

            sc.Send(mail);

            return RedirectToAction("Contact", "Home", new { type = type });
        }

        #endregion

        #region RabbitMQ
        [HttpGet("GetRabbitMQ")]
        public IActionResult GetRabbitMQ()
        {
            RabbitClassMQ rabbitClassMQ = new RabbitClassMQ();
            rabbitClassMQ.Name = "Gok";
            rabbitClassMQ.Surname = "Soy";
            var factory = new ConnectionFactory() { HostName = "localhost" };
            using (IConnection connection = factory.CreateConnection())
            using (IModel channel = connection.CreateModel())
            {
                channel.QueueDeclare(queue: "TestGok",
                    durable: false,
                    exclusive: false,
                    autoDelete: false,
                    arguments: null);
                string message = JsonConvert.SerializeObject(rabbitClassMQ);
                var body = Encoding.UTF8.GetBytes(message);

                channel.BasicPublish(exchange: "",
                    routingKey: "TestGok",
                    basicProperties: null,
                    body: body);

            }


            return View();
        }
        #endregion
    }
}
