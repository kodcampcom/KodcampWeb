using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Kodcamp.EntityNetwork;
using Kodcamp.Helper;
using Kodcamp.Models.AnswerQuestion;
using Kodcamp.Models.EntityModels;
using Kodcamp.Models.Forum;
using Kodcamp.Models.Response;
using Kodcamp.Models.Session;
using Kodcamp.Models.VMModels;
using System.Threading;
using Kodcamp.Models.ModelSystem;

namespace Kodcamp.Controllers
{
    public class ForumController : Controller
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

        #region Login - Register

        [HttpGet("Forum/Login/{urlType}/{urlId}")]
        public IActionResult Login(string urlType = "", string urlId = "")
        {
            string infoSystem = GetSystemInfo();
            if (infoSystem == "0") return RedirectToAction("ComingSoon", "Home");

            ViewData["urlType"] = urlType;
            ViewData["urlId"] = urlId;
            return View(nEntity.GetResponse());
        }

        [HttpPost("Forum/Login/{urlType}/{urlId}")]
        public IActionResult Login(string userName = "", string password = "", string urlType = "", string urlId = "")
        {
            string infoSystem = GetSystemInfo();
            if (infoSystem == "0") return RedirectToAction("ComingSoon", "Home");

            password = hM.Hash256(password);
            List<ModelUser> users = nEntity.GetUser();
            users = users.Where(u => u.Username == userName).ToList();
            if (users != null && users.Count > 0 && users[0].Password == password)
            {
                SetSession(userName, password);
                if (urlType == "-1")
                {
                    return RedirectToAction("Profile", "Profile");
                }
                else if (urlType == "questions")
                {
                    return RedirectToAction("Questions", "QAForum");
                }
                else if (urlType == "questionsDetail")
                {
                    return RedirectToAction("QuestionDetail", "QAForum", new { qId = urlId });
                }

                else
                {
                    return RedirectToAction("Profile", "Profile");
                }
                
            }
            else
            {
                ViewData["urlType"] = urlType;
                ViewData["urlId"] = urlId;

                ModelResponse modelResponse = new ModelResponse();
                modelResponse.Status = 2;
                modelResponse.StatusDetail = "Hatalı kullanıcı adı ya da şifre.";
                return View(modelResponse);
            }
        }

        [HttpGet("Forum/Register")]
        public IActionResult Register()
        {
            return View(nEntity.GetResponse());
        }

        [HttpPost("Forum/Register")]
        public IActionResult Register(string userName = "", string password = "")
        {
            password = hM.Hash256(password);
            ModelResponse response = nEntity.AddUser(userName, password);
            if (response.Status == 1) SetSession(userName, password);
            else
            {
                ModelResponse modelResponse = new ModelResponse();
                modelResponse.Status = 2;
                modelResponse.StatusDetail = "Bu kullanıcı adı ile daha önceden üye olunmuş.";
                return View(modelResponse);
            }
            
            return RedirectToAction("Profile", "Profile");
        }

        #endregion

        #region Dictionary

        [HttpGet("Sozluk")]
        public IActionResult EntryList()
        {
            string infoSystem = GetSystemInfo();
            if (infoSystem == "0") return RedirectToAction("ComingSoon", "Home");

            List<ModelSubject> subjects = nEntity.GetTopics().Response as List<ModelSubject>;
            subjects = subjects.OrderByDescending(w => w.DateUpdated).ToList();

            //IOrderedEnumerable<KeyValuePair<string, int>> tags = nEntity.GetQuestionTags();
            List<EntityNews> newsList = nEntity.GetNews();

            VMForumTopicMessages vM = new VMForumTopicMessages();
            vM.Subjects = subjects;
            vM.NewsList = newsList;

            ViewData["Title"] = "KodCamp - Sözlük";
            ViewData["Description"] = "Yazılım Bilişim Teknoloji Güncel Sözlük";

            return View(vM);
        }

        [HttpGet("sozluk/{url}")]
        public IActionResult Entries(string url = "")
        {
            string infoSystem = GetSystemInfo();
            if (infoSystem == "0") return RedirectToAction("ComingSoon", "Home");

            List<ModelSubject> subjects = nEntity.GetTopics().Response as List<ModelSubject>;
            string tId = subjects.Where(w => w.Url == url).First().Id;
            if (subjects != null && subjects.Count > 0)
            {
                if (tId == "-1") tId = subjects[0].Id;
            }
            subjects = subjects.OrderByDescending(w => w.DateUpdated).ToList();
            List<ModelEntryMessage> messages = nEntity.GetMessages().Response as List<ModelEntryMessage>;
            messages = messages.Where(w => w.SubjectId == tId && w.Type == "0").ToList();
            messages = messages.OrderBy(w => w.DateCreated).ToList();

            IOrderedEnumerable<KeyValuePair<string, int>> tags = nEntity.GetQuestionTags();
            List<EntityNews> newsList = nEntity.GetNews();

            VMForumTopicMessages vM = new VMForumTopicMessages();
            vM.Subjects = subjects;
            vM.Messages = messages;
            vM.NewsList = newsList;
            vM.TagsKeyValue = tags;

            

            ViewData["SubjectId"] = "";
            ViewData["SubjectName"] = "";
            if (subjects != null && subjects.Count > 0)
            {
                ViewData["SubjectId"] = tId;
                ViewData["SubjectName"] = subjects.Where(w => w.Id == tId).FirstOrDefault().Title;
            }

            Thread threadLog2 = new Thread(() => nEntity.AddLog(tId, title: subjects.Where(w => w.Id == tId).FirstOrDefault().Title, type: "sozluk"));
            Thread.CurrentThread.IsBackground = true;
            threadLog2.Start();

            ViewData["Title"] = "KodCamp - " + subjects.Where(w => w.Id == tId).FirstOrDefault().Title;
            ViewData["Description"] = "Yazılım Bilişim Teknoloji Güncel Sözlük Detayı";

            return View(vM);
        }

        #region Helpers Dictionary
        [HttpGet("Dictionary/AddTopic")]
        public IActionResult AddDictionaryTopic()
        {
            if (!CheckSession()) return RedirectToAction("Login", "Forum", new { urlType = "-1", urlId = "-1"});
            return View();
        }

        [HttpPost("Dictionary/AddTopic")]
        public IActionResult AddDictionaryTopic(string title = "", string detail = "")
        {
            #region Session Check Fill User

            if (!CheckSession()) return RedirectToAction("Login", "Forum", new { urlType = "-1", urlId = "-1"});
            ModelSession session = GetSession();

            ModelUser user = new ModelUser();
            if (session != null)
            {
                user = nEntity.GetUser().Where(u => u.Username == session.Username).FirstOrDefault();
            }
            else
            {
                return RedirectToAction("Login", "Forum", new { urlType = "-1", urlId = "-1"});
            }
            #endregion

            string url = hM.ConvertTitleToId(title);
            nEntity.AddTopic(writerUserName: user.Username, title: title, detail: detail, type: "0", url: url);

            return RedirectToAction("EntryList", "Forum");
        }

        [HttpGet("Dictionary/AddEntry/{subjectId}")]
        public IActionResult AddDictionaryEntry(string subjectId = "")
        {
            if (!CheckSession()) return RedirectToAction("Login", "Forum", new { urlType = "-1", urlId = "-1"});
            ViewData["SubjectId"] = subjectId;
            return View();
        }

        [HttpPost("Dictionary/AddEntry/{subjectId}")]
        public IActionResult AddDictionaryEntry(string detail = "", string subjectId = "")
        {
            #region Session Check Fill User

            if (!CheckSession()) return RedirectToAction("Login", "Forum", new { urlType = "-1", urlId = "-1"});
            ModelSession session = GetSession();

            ModelUser user = new ModelUser();
            if (session != null)
            {
                user = nEntity.GetUser().Where(u => u.Username == session.Username).FirstOrDefault();
            }
            else
            {
                return RedirectToAction("Login", "Forum", new { urlType = "-1", urlId = "-1"});
            }
            #endregion

            nEntity.AddEntryMessage(writerUserName: user.Username, detail: detail, type: "0", subjectId: subjectId);

            List<EntitySubject> subjects = nEntity.GetAllTopics().Response as List<EntitySubject>;
            subjects = subjects.Where(w => w.Id == subjectId).ToList();
            string url = subjects[0].Url;

            return RedirectToAction("Entries", "Forum", new { url = url });
        }

        [HttpGet("Dictionary/{subjectId}/AddLike/{EntryId}")]
        public IActionResult SendLikeToEntry(string subjectId = "", string entryId = "")
        {
            #region Session Check Fill User

            if (!CheckSession()) return RedirectToAction("Login", "Forum", new { urlType = "-1", urlId = "-1"});
            ModelSession session = GetSession();

            ModelUser user = new ModelUser();
            if (session != null)
            {
                user = nEntity.GetUser().Where(u => u.Username == session.Username).FirstOrDefault();
            }
            else
            {
                return RedirectToAction("Login", "Forum", new { urlType = "-1", urlId = "-1"});
            }
            #endregion

            nEntity.AddLikeToEntry(writerUserId: user.Id, commentId: entryId, type: "1", subjectId: subjectId);

            return RedirectToAction("Entries", "Forum", new { tId = subjectId });
        }
        #endregion

        #endregion
    }
}
