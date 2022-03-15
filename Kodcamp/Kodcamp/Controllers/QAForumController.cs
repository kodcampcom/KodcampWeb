using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Kodcamp.EntityNetwork;
using Kodcamp.Helper;
using Kodcamp.Models.AnswerQuestion;
using Kodcamp.Models.EntityModels;
using Kodcamp.Models.Forum;
using Kodcamp.Models.Session;
using Kodcamp.Models.VMModels;
using System.Threading;
using Kodcamp.Models.ModelSystem;

namespace Kodcamp.Controllers
{
    public class QAForumController : Controller
    {
        #region Session

        NetworkEntity nEntity = new NetworkEntity();
        HelperMethods hM = new HelperMethods();
        public void SetSession(string name, string pass)
        {
            HttpContext.Session.SetString("username", name);
            HttpContext.Session.SetString("password", pass);
        }
        public ModelSession GetSession()
        {
            ModelSession session = new ModelSession();
            if (!string.IsNullOrEmpty(HttpContext.Session.GetString("username"))) session.Username = HttpContext.Session.GetString("username");
            if (!string.IsNullOrEmpty(HttpContext.Session.GetString("password"))) session.Password = HttpContext.Session.GetString("password");

            return session;
        }

        public bool CheckSession()
        {
            ModelSession session = GetSession();
            List<ModelUser> users = nEntity.GetUser();
            users = users.Where(u => u.Username == session.Username && u.Password == session.Password).ToList();
            if (users != null && users.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string GetSystemInfo()
        {
            SystemInfo info = nEntity.GetSystemInfo().Response as SystemInfo;
            return info.Status;
        }
        #endregion

        #region Question
        [HttpGet("Sorular")]
        public IActionResult Questions()
        {
            string infoSystem = GetSystemInfo();
            if (infoSystem == "0") return RedirectToAction("ComingSoon", "Home");

            List<ModelQuestion> questions = nEntity.GetQuestionsOnlyQuestion().Response as List<ModelQuestion>; // yavaş sayılır
            questions = questions.OrderByDescending(w => w.DateCreated).ToList();

            IOrderedEnumerable<KeyValuePair<string, int>> tags = nEntity.GetQuestionTagsWithList(modelQuestions: questions); // çok yavaş
            List<ModelQuestionCategories> questionCategories = nEntity.GetQuestionCategoriesWithList(entityQuestions: questions).Response as List<ModelQuestionCategories>;
            List<EntityNews> news = nEntity.GetNews();
            news = news.Take(10).ToList();

            VMQuestionCategoryTags vM = new VMQuestionCategoryTags();
            vM.QuestionCategories = questionCategories;
            vM.Questions = questions;
            vM.TagsKeyValue = tags;
            vM.News = news;

            ViewData["Title"] = "Soru Cevap Forumu";
            ViewData["Description"] = "Yazılım ve Teknoloji Hakkında Kodlama nedir, nasıl yapılır, bug ve hatalar nasıl çözülür sorularına cevaplar bulabilirsiniz.";
            ViewData["HeaderTitle"] = "Kodcamp Soru Cevap Forumu";

            return View(vM);
        }

        [HttpGet("Questions/AddQuestion")]
        public IActionResult AddQuestion()
        {
            #region Session Check Fill User

            if (!CheckSession()) return RedirectToAction("Login", "Forum", new { urlType = "questions", urlId = "-1" });
            ModelSession session = GetSession();

            ModelUser user = new ModelUser();
            if (session != null)
            {
                user = nEntity.GetUser().Where(u => u.Username == session.Username).FirstOrDefault();
            }
            else
            {
                return RedirectToAction("Login", "Forum", new { urlType = "questions", urlId = "-1" });
            }

            #endregion

            List<ModelQuestionCategories> questionCategories = nEntity.GetQuestionCategories().Response as List<ModelQuestionCategories>;

            return View(questionCategories);
        }

        [HttpPost("Questions/AddQuestion")]
        public IActionResult AddQuestion(string title, string detail, string tags, string categoryId)
        {
            #region Session Check Fill User

            if (!CheckSession()) return RedirectToAction("Login", "Forum");
            ModelSession session = GetSession();

            ModelUser user = new ModelUser();
            if (session != null)
            {
                user = nEntity.GetUser().Where(u => u.Username == session.Username).FirstOrDefault();
            }
            else
            {
                return RedirectToAction("Login", "Forum");
            }

            #endregion

            string[] tagList = tags.Split(",");
            for (int i = 0; i < tagList.Length; i++)
            {
                tagList[i] = tagList[i].Replace(" ", "");
            }
            tags = "";
            for (int i = 0; i < tagList.Length; i++)
            {
                tags += "/" + tagList[i] + "/";
            }

            string url = hM.ConvertTitleToId(title);
            List<EntityQuestion> questions = nEntity.GetAllQuestions().Response as List<EntityQuestion>;
            for (int i = 0; i < questions.Count; i++)
            {
                if (questions[i].Url == url)
                {
                    url = url + "-2";
                }
            }

            nEntity.AddQuestion(title: title, userId: user.Id, detail: detail, tags: tags, categoryId: categoryId, url: url);

            return RedirectToAction("Questions", "QAForum");
        }
        #endregion

        #region Answer
        // Soruya verilen cevaplar
        [HttpGet("Sorular/{url}")]
        public IActionResult QuestionDetail(string url = "")
        {
            string infoSystem = GetSystemInfo();
            if (infoSystem == "0") return RedirectToAction("ComingSoon", "Home");

            string userId = "";
            #region Session Check Fill User
            ModelSession session = GetSession();
            ModelUser user = new ModelUser();
            if (session != null && session.Username != null)
            {
                user = nEntity.GetUser().Where(u => u.Username == session.Username).FirstOrDefault();
                userId = user.Id;
            }
            else
            {
                userId = "Anonim";
            }

            #endregion

            List<ModelQuestion> questions = nEntity.GetQuestions().Response as List<ModelQuestion>;
            IOrderedEnumerable<KeyValuePair<string, int>> tags = nEntity.GetQuestionTagsWithList(modelQuestions: questions);
            List<ModelQuestionCategories> questionCategories = nEntity.GetQuestionCategoriesWithList(entityQuestions: questions).Response as List<ModelQuestionCategories>;

            List<EntityNews> news = nEntity.GetNews();
            news = news.Take(10).ToList();

            questions = questions.Where(w => w.Url == url).ToList();
            string qId = questions[0].Id;

            VMQuestionCategoryTags vM = new VMQuestionCategoryTags();
            vM.QuestionCategories = questionCategories;
            vM.Questions = questions;
            vM.TagsKeyValue = tags;
            vM.News = news;

            //Zaman kaybını önlemek için thread kullanıldı. 
            Thread threadLog = new Thread(() => nEntity.AddAnswerInteraction(qId: qId, aId: "", type: "0", userId: userId));
            Thread.CurrentThread.IsBackground = true;
            threadLog.Start();

            Thread threadLog2 = new Thread(() => nEntity.AddLog(news[0].Id, title: questions[0].Title, type: "sorular"));
            Thread.CurrentThread.IsBackground = true;
            threadLog2.Start();

            //nEntity.AddAnswerInteraction(qId: qId, aId: "", type: "0", userId: userId); // Görüntülenme sayısı log
            //nEntity.AddLog(news[0].Id, title: questions[0].Title, type: "sorular"); // Genel sistem logu

            ViewData["Title"] = "KodCamp - " + questions[0].Title;
            ViewData["Description"] = "Yazılım ve Teknoloji Hakkında Soruların Cevapları ve Detayları";
            ViewData["HeaderTitle"] = "Soru - Cevap | " + questions[0].Title;

            return View(vM);
        }

        // Soruya cevap ekleme
        [HttpGet("Questions/{qId}/Add/Answer")]
        public IActionResult AddAnswer(string qId = "", string detail = "", string mainAnswerId = "")
        {
            #region Session Check Fill User

            if (!CheckSession()) return RedirectToAction("Login", "Forum", new { urlType = "questionsDetail", urlId = qId });
            ModelSession session = GetSession();

            ModelUser user = new ModelUser();
            if (session != null)
            {
                user = nEntity.GetUser().Where(u => u.Username == session.Username).FirstOrDefault();
            }
            else
            {
                return RedirectToAction("Login", "Forum", new { urlType = "questionsDetail", urlId = qId });
            }

            #endregion

            nEntity.AddAnswer(qId: qId, userId: user.Id, detail: detail, mainAnswerId: mainAnswerId);

            List<EntityQuestion> questions = nEntity.GetAllQuestions().Response as List<EntityQuestion>;
            questions = questions.Where(w => w.Id == qId).ToList();
            string url = questions[0].Url;

            return RedirectToAction("QuestionDetail", "QAForum", new { url = url });
        }
        #endregion

        #region QA Helpers
        // Kullanıcıların sorulara verdikleri tepkiler. Görüntüleme, beğenme, beğenmeme
        [HttpGet("Questions/{qId}/{aId}/{type}")]
        public IActionResult AddInteractionToAnswer(string qId = "", string aId = "", string type = "")
        {
            #region Session Check Fill User

            if (!CheckSession()) return RedirectToAction("Login", "Forum", new { urlType = "questionsDetail", urlId = qId });
            ModelSession session = GetSession();

            ModelUser user = new ModelUser();
            if (session != null)
            {
                user = nEntity.GetUser().Where(u => u.Username == session.Username).FirstOrDefault();
            }
            else
            {
                return RedirectToAction("Login", "Forum", new { urlType = "questionsDetail", urlId = qId });
            }

            #endregion

            nEntity.AddAnswerInteraction(qId: qId, aId: aId, type: type, userId: user.Id);

            List<EntityQuestion> questions = nEntity.GetAllQuestions().Response as List<EntityQuestion>;
            questions = questions.Where(w => w.Id == qId).ToList();
            string url = questions[0].Url;

            return RedirectToAction("QuestionDetail", "QAForum", new { url = url });
        }
        #endregion
    }
}
