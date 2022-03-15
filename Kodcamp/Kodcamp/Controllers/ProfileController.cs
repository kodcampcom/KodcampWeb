using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Kodcamp.EntityNetwork;
using Kodcamp.Helper;
using Kodcamp.Models.AnswerQuestion;
using Kodcamp.Models.Forum;
using Kodcamp.Models.Session;
using Kodcamp.Models.VMModels;
using System.IO;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Processing;
using Kodcamp.Models.ModelSystem;

namespace Kodcamp.Controllers
{
    public class ProfileController : Controller
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

        #region Profile Index
        [HttpGet("Profile")]
        public IActionResult Profile()
        {
            string infoSystem = GetSystemInfo();
            if (infoSystem == "0") return RedirectToAction("ComingSoon", "Home");

            #region Session Check Fill User

            if (!CheckSession()) return RedirectToAction("Login", "Forum", new { urlType = "-1", urlId = "-1" });
            ModelSession session = GetSession();

            ModelUser user = new ModelUser();
            if (session != null)
            {
                user = nEntity.GetUser().Where(u => u.Username == session.Username).FirstOrDefault();
            }
            else
            {
                return RedirectToAction("Login", "Forum", new { urlType = "-1", urlId = "-1" });
            }
            #endregion

            List<ModelSubject> subjects = nEntity.GetTopics().Response as List<ModelSubject>;
            subjects = subjects.Where(w => w.WriterUserName == user.Username).ToList();
            List<ModelEntryMessage> messages = nEntity.GetMessages().Response as List<ModelEntryMessage>;
            messages = messages.Where(w => w.WriterUserName == user.Username).ToList();

            VMProfile vM = new VMProfile();
            vM.Subjects = subjects;
            vM.Messages = messages;
            vM.Profile = user;

            return View(vM);
        }
        #endregion

        #region Profile Helpers
        // Kullanıcının girdiği mesajı siler.
        [HttpGet("Profile/Entry/Delete/{entryId}")]
        public IActionResult DeleteEntry(string entryId = "")
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

            nEntity.DeleteEntry(entryId);

            return RedirectToAction("ProfileEntries", "Profile");
        }

        // Kullanıcının açtığı başlığı siler.
        [HttpGet("Profile/Topic/Delete/{subjectId}")]
        public IActionResult DeleteTopic(string subjectId = "")
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

            nEntity.DeleteTopic(subjectId);

            return RedirectToAction("ProfileTopics", "Profile");
        }

        // Kullanıcıların çıkış yapmasını sağlar.
        [HttpGet("Profile/Logout")]
        public IActionResult Logout()
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

            HttpContext.Session.Clear();

            return RedirectToAction("Index", "Home");
        }

        // Profil paneli üzerinden kullanıcıların sorularının çözüldüğünü gösterir. 1:çözüldü, 0:çözülmedi.
        [HttpGet("Profile/Questions/ChangeStatus/{questionId}/{status}")]
        public IActionResult ChangeQuestionSolvedStatus(string questionId = "", string status = "")
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

            List<EntityQuestion> questions = nEntity.GetAllQuestions().Response as List<EntityQuestion>;
            questions = questions.Where(w => w.UserId == user.Id && w.Id == questionId).ToList();

            EntityQuestion question = questions[0];
            question.IsSolved = status;
            nEntity.UpdateQuestion(question);

            return RedirectToAction("ProfileQuestions", "Profile");
        }
        #endregion

        #region Profile Topics Dictionary
        
        // Kullanıcıların sözlük alanında açtığı başlıklar
        [HttpGet("Profile/Topics")]
        public IActionResult ProfileTopics()
        {
            string infoSystem = GetSystemInfo();
            if (infoSystem == "0") return RedirectToAction("ComingSoon", "Home");

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

            List<ModelSubject> subjects = nEntity.GetTopics().Response as List<ModelSubject>;
            subjects = subjects.Where(w => w.WriterUserName == user.Username).ToList();

            VMProfile vM = new VMProfile();
            vM.Subjects = subjects;
            vM.Profile = user;

            return View(vM);
        }

        // Kullancıların ilgili sözlük başlığında yazdığı mesajlar, entryler
        [HttpGet("Profile/Entries")]
        public IActionResult ProfileEntries()
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

            List<ModelSubject> subjects = nEntity.GetTopics().Response as List<ModelSubject>;
            subjects = subjects.Where(w => w.WriterUserName == user.Username).ToList();

            List<ModelEntryMessage> messages = nEntity.GetMessages().Response as List<ModelEntryMessage>;
            messages = messages.Where(w => w.WriterUserName == user.Username).ToList();

            for (int i = 0; i < subjects.Count; i++)
            {
                for (int k = 0; k < messages.Count; k++)
                {
                    if (messages[k].SubjectId == subjects[i].Id)
                    {
                        messages[k].Title = subjects[i].Title;
                    }
                }
            }

            for (int i = 0; i < messages.Count; i++)
            {
                if (string.IsNullOrEmpty(messages[i].Title))
                {
                    messages[i].Title = "Bu başlık silinmiş.";
                }
            }


            VMProfile vM = new VMProfile();
            vM.Subjects = subjects;
            vM.Messages = messages;
            vM.Profile = user;

            return View(vM);
        }
        #endregion

        #region Profile Photo and Update
        /// Kullanıcıların resimlerini ekleme ve güncellemesini sağlar.
        [HttpGet("Profile/AddPhoto")]
        public IActionResult UpdateProfile()
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

            return View();
        }

        [HttpPost("Profile/AddPhoto")]
        public IActionResult UpdateProfile(IFormFile image = null)
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

            string pathName = "";
            if (image != null)
            {
                pathName = hM.ImageUploadToRoot(image, "profile", "");
            }

            // resize sixlabors
            string fileName = pathName;
            string customRoot = "wwwroot/images/profile/";
            var path = Path.Combine(Directory.GetCurrentDirectory(), customRoot, fileName);
            using var image2 = Image.Load(image.OpenReadStream());
            image2.Mutate(x => x.Resize(36, 36));
            image2.Save(path);

            nEntity.UpdateProfile(user.Id, pathName);

            return RedirectToAction("Profile", "Profile");
        }
        #endregion

        #region Question
        // Kullanıcıların soruları
        [HttpGet("Profile/Questions")]
        public IActionResult ProfileQuestions()
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

            List<ModelQuestion> questions = nEntity.GetQuestions().Response as List<ModelQuestion>;
            questions = questions.Where(w => w.UserId == user.Id).ToList();

            VMProfile vM = new VMProfile();
            vM.Questions = questions;
            vM.Profile = user;
            return View(vM);
        }
        #endregion
    }
}
