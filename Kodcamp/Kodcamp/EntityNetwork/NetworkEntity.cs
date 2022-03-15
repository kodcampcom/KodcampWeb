using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using Kodcamp.Helper;
using Kodcamp.Models.AnswerQuestion;
using Kodcamp.Models.EntityModels;
using Kodcamp.Models.Forum;
using Kodcamp.Models.Interaction;
using Kodcamp.Models.LogReport;
using Kodcamp.Models.ModelSystem;
using Kodcamp.Models.Response;
using Kodcamp.Repository;

namespace Kodcamp.EntityNetwork
{
    public class NetworkEntity
    {
        #region Classes, Objects, Response Methods

        HelperMethods hM = new HelperMethods();
        Repository<EntityCategory> repoCategory = new Repository<EntityCategory>();
        Repository<EntityNews> repoNews = new Repository<EntityNews>();
        Repository<Comment> repoComment = new Repository<Comment>();
        Repository<ModelLog> repoLog = new Repository<ModelLog>();
        Repository<EntityInteraction> repoInteraction = new Repository<EntityInteraction>();
        Repository<EntityUser> repoUser = new Repository<EntityUser>();
        Repository<EntitySubject> repoSubject = new Repository<EntitySubject>();
        Repository<EntityComments> repoEntryMessages = new Repository<EntityComments>();
        Repository<EntityForumInteraction> repoForumInteraction = new Repository<EntityForumInteraction>();
        Repository<EntityQuestion> repoQuestion = new Repository<EntityQuestion>();
        Repository<EntityAnswer> repoAnswer = new Repository<EntityAnswer>();
        Repository<EntityQAInteraction> repoQAInteraction = new Repository<EntityQAInteraction>();
        Repository<EntityQuestionCategories> repoQuestionCategories = new Repository<EntityQuestionCategories>();
        Repository<Contact> repoContact = new Repository<Contact>();
        Repository<SystemInfo> repoSystem = new Repository<SystemInfo>();

        public ModelResponse GetResponse(int status = 1, string statusDetail = "", object responseModel = null)
        {
            ModelResponse response = new ModelResponse();
            response.Status = status;
            response.StatusDetail = statusDetail;
            response.Response = responseModel;

            return response;
        }

        #endregion

        #region Category

        public List<EntityCategory> GetCategoryList()
        {
            List<EntityCategory> categories = repoCategory.GetAll().ToList();
            return categories;
        }

        public void AddCategory(EntityCategory category)
        {
            repoCategory.Add(category);
        }

        #endregion

        #region News

        public List<EntityNews> GetNews()
        {
            List<EntityNews> news = repoNews.GetAll().ToList();
            news = news.OrderByDescending(w => w.DateCreated).ToList();
            return news;
        }

        public void AddNews(EntityNews news)
        {
            repoNews.Add(news);
        }

        public void UpdateNews(EntityNews news)
        {
            repoNews.Update(news);
        }

        public void DeleteNews(string id)
        {
            EntityNews news = repoNews.GetBy(w => w.Id == id);
            repoNews.Remove(news);
        }

        #endregion

        #region Comment News

        public List<Comment> GetComment()
        {
            List<Comment> comments = repoComment.GetAll().ToList();
            return comments;
        }

        public void AddComment(Comment comment)
        {
            repoComment.Add(comment);
        }

        public void UpdateComment(Comment comment)
        {
            repoComment.Update(comment);
        }

        #endregion

        #region Log - Report

        public List<ModelLogPlus> GetLogs()
        {
            List<ModelLog> logs = repoLog.GetAll().ToList();
            List<EntityNews> news = repoNews.GetAll().ToList();

            List<ModelLogPlus> logPlusList = new List<ModelLogPlus>();
            for (int i = 0; i < logs.Count; i++)
            {
                ModelLogPlus logPlus = new ModelLogPlus();

                logPlus.Id = logs[i].Id;
                logPlus.NewsId = logs[i].NewsId;
                logPlus.DateTime = logs[i].DateTime;
                logPlus.Title = logs[i].Title;
                logPlus.Type = logs[i].Type;
                logPlusList.Add(logPlus);
            }

            return logPlusList;
        }

        public void AddLog(string newsId, string type, string title="")
        {
            string dateTime = DateTime.Now.ToString("yy.MM.dd HH:mm:ss");
            ModelLog log = new ModelLog();
            log.Id = hM.GenerateId(10);
            log.DateTime = dateTime;
            log.NewsId = newsId;
            log.Type = type;
            log.Title = title;
            

            repoLog.Add(log);
        }

        #endregion

        #region Contact

        public List<Contact> GetContacts()
        {
            List<Contact> contacts = repoContact.GetAll().ToList();

            return contacts;
        }

        public ModelResponse AddContact(string title, string detail, string name, string mail)
        {
            string dateTime = DateTime.Now.ToString("yy.MM.dd HH:mm:ss");
            Contact contact = new Contact();
            contact.Id = hM.GenerateId(4);
            contact.DateCreated = dateTime;
            contact.Detail = detail;
            contact.Email = mail;
            contact.Name = name;
            contact.Title = title;

            repoContact.Add(contact);

            return GetResponse(responseModel: contact, status: 1);
        }

        #endregion

        #region Interactions (Like, Smile) News

        public List<ModelInteraction> GetInteractions()
        {
            List<EntityInteraction> interactions = repoInteraction.GetAll().ToList();

            List<ModelInteraction> modelInteractions = new List<ModelInteraction>();

            for (int i = 0; i < interactions.Count; i++)
            {
                ModelInteraction modelInteraction = new ModelInteraction();

                modelInteraction.Id = interactions[i].Id;
                modelInteraction.DateCreated = interactions[i].DateCreated;
                modelInteraction.InteractionType = interactions[i].InteractionType;
                modelInteraction.NewsId = interactions[i].NewsId;
                modelInteraction.InteractionType = interactions[i].InteractionType;

                modelInteractions.Add(modelInteraction);
            }

            return modelInteractions;
        }

        public void AddInteraction(string newsId, string type)
        {
            string dateTime = DateTime.Now.ToString("yy.MM.dd HH:mm:ss");

            EntityInteraction interaction = new EntityInteraction();
            interaction.Id = hM.GenerateId(6);
            interaction.DateCreated = dateTime;
            interaction.NewsId = newsId;
            interaction.InteractionType = type;

            repoInteraction.Add(interaction);
        }


        public void AddCountToNews(string newsId)
        {
            List<EntityInteraction> interactions = repoInteraction.GetAll().Where(w=>w.NewsId==newsId).ToList();

            EntityNews news = repoNews.GetAll().Where(w=>w.Id == newsId).FirstOrDefault();
            news.Comments = null;

            news.LikeCount = interactions.Where(w => w.InteractionType == "1").Count().ToString();
            news.UnlikeCount = interactions.Where(w => w.InteractionType == "2").Count().ToString();
            news.SmileCount = interactions.Where(w => w.InteractionType == "3").Count().ToString();
            news.CoderCount = interactions.Where(w => w.InteractionType == "4").Count().ToString();
            news.ViewedCount = interactions.Where(w => w.InteractionType == "5").Count();

            repoNews.Update(news);
        }

        #endregion


        #region User

        public List<ModelUser> GetUser()
        {
            List<EntityUser> entityUsers = repoUser.GetAll().ToList();

            List<ModelUser> modelUsers = new List<ModelUser>();

            for (int i = 0; i < entityUsers.Count; i++)
            {
                ModelUser modelUser = new ModelUser()
                {
                    Id = entityUsers[i].Id,
                    Username = entityUsers[i].Username,
                    Password = entityUsers[i].Password,
                    PhotoUrl = entityUsers[i].PhotoUrl
                };

                modelUsers.Add(modelUser);
            }

            return modelUsers;
        }

        public ModelResponse AddUser(string userName, string password)
        {
            List<ModelUser> modelUsers = GetUser();
            for (int i = 0; i < modelUsers.Count; i++)
            {
                if (modelUsers[i].Username.ToLower() == userName.ToLower())
                {
                    return GetResponse(status: 2, statusDetail: "Bu kullanıcı adı ile daha önceden üye olunmuş.", null);
                }
            }

            EntityUser user = new EntityUser()
            {
                Id = hM.GenerateId(8),
                Username = userName,
                Password = password,
                DateCreated = DateTime.Now.ToString("yy.MM.dd HH:mm:ss"),
                PhotoUrl = "userProfile.webp"
            };

            repoUser.Add(user);
            return GetResponse(responseModel: user);
        }

        public void UpdateProfile(string id, string photoUrl)
        {
            //List<ModelUser> users = GetUser();
            //users = users.Where(w => w.Id == id).ToList();

            //EntityUser user = new EntityUser();
            //user.Id = users[0].Id;
            //user.DateCreated = "";
            //user.Password = users[0].Password;
            //user.PhotoUrl = photoUrl;
            //user.Username = users[0].Username;

            List<EntityUser> entityUsers = repoUser.GetAll().ToList();
            EntityUser entityUser = entityUsers.SingleOrDefault(w => w.Id == id);
            entityUser.PhotoUrl = photoUrl;
            repoUser.Update(entityUser);
        }
        #endregion

        #region Dictionary

        #region Topic, Subject

        public ModelResponse GetTopics()
        {
            List<EntitySubject> entitySubjects = repoSubject.GetAll().ToList();

            List<ModelSubject> modelSubjects = new List<ModelSubject>();

            for (int i = 0; i < entitySubjects.Count; i++)
            {
                ModelSubject modelSubject = new ModelSubject()
                {
                    Id = entitySubjects[i].Id,
                    Title = entitySubjects[i].Title,
                    Detail = entitySubjects[i].Detail,
                    WriterUserName = entitySubjects[i].WriterUserName,
                    DateCreated = entitySubjects[i].DateCreated,
                    IsApproved = entitySubjects[i].IsApproved,
                    Type = entitySubjects[i].Type,
                    DateUpdated = entitySubjects[i].DateUpdated,
                    Comments = new List<ModelEntryMessage>(),
                    Url = entitySubjects[i].Url
                };
                modelSubjects.Add(modelSubject);
            }

            List<ModelEntryMessage> modelmessages = GetMessages().Response as List<ModelEntryMessage>;
            modelmessages = modelmessages.OrderByDescending(w => w.DateCreated).ToList();
            for (int k = 0; k < modelmessages.Count; k++)
            {
                for (int i = 0; i < modelSubjects.Count; i++)
                {
                    if (modelSubjects[i].Id == modelmessages[k].SubjectId)
                    {
                        modelSubjects[i].Comments.Add(modelmessages[k]);
                    }
                }
            }

            for (int i = 0; i < modelSubjects.Count; i++)
            {
                modelSubjects[i].CommentCount = modelSubjects[i].Comments.Count.ToString();
            }

            return GetResponse(responseModel: modelSubjects);
        }

        public ModelResponse GetAllTopics()
        {
            List<EntitySubject> subjects = repoSubject.GetAll().ToList();
            return GetResponse(responseModel: subjects);
        }

        public ModelResponse AddTopic(string writerUserName, string title, string detail, string type, string url)
        {
            EntitySubject subject = new EntitySubject()
            {
                Id = hM.GenerateId(8),
                WriterUserName = writerUserName,
                Title = title,
                DateCreated = DateTime.Now.ToString("yy.MM.dd HH:mm:ss"),
                IsApproved = "0",
                Detail = detail,
                Type = type,
                DateUpdated = DateTime.Now.ToString("yy.MM.dd HH:mm:ss"),
                Url = url
            };

            repoSubject.Add(subject); // Topic Eklendi

            AddEntryMessage(writerUserName: writerUserName, detail: detail, type: type, subjectId: subject.Id); // Topicteki ilk detay da ilk entry olarak eklendi

            return GetResponse(responseModel: repoSubject);
        }

        public void DeleteTopic(string id)
        {
            EntitySubject subject = repoSubject.GetBy(w => w.Id == id);
            repoSubject.Remove(subject);
        }

        public void UpdateTopic(string id)
        {
            List<EntitySubject> entitySubjects = repoSubject.GetAll().ToList();
            entitySubjects = entitySubjects.Where(w => w.Id == id).ToList();

            EntitySubject subject = new EntitySubject();
            subject = entitySubjects[0];

            subject.DateUpdated = DateTime.Now.ToString("yy.MM.dd HH:mm:ss");

            repoSubject.Update(subject);
        }

        #endregion

        #region Dictionary Entry, Message or Comments

        public List<EntityComments> GetAllMessages()
        {
            List<EntityComments> entityMessages = repoEntryMessages.GetAll().ToList();

            return entityMessages;
        }

        public ModelResponse GetMessages()
        {
            List<EntityComments> entityMessages = repoEntryMessages.GetAll().ToList();
            List<ModelEntryMessage> modelmessages = new List<ModelEntryMessage>();

            for (int i = 0; i < entityMessages.Count; i++)
            {
                ModelEntryMessage modelMessage = new ModelEntryMessage()
                {
                    Id = entityMessages[i].Id,
                    SubjectId = entityMessages[i].SubjectId,
                    Title = entityMessages[i].Title,
                    Detail = entityMessages[i].Detail,
                    WriterUserName = entityMessages[i].WriterUserName,
                    DateCreated = entityMessages[i].DateCreated,
                    IsApproved = entityMessages[i].IsApproved,
                    Type = entityMessages[i].Type
                };
                modelmessages.Add(modelMessage);
            }

            List<ModelForumInteraction> modelInteractionLikes = GetEntryLikes().Response as List<ModelForumInteraction>;
            for (int i = 0; i < modelmessages.Count; i++)
            {
                for (int k = 0; k < modelInteractionLikes.Count; k++)
                {
                    modelmessages[i].LikeCount = modelInteractionLikes.Where(w => w.CommentId == modelmessages[i].Id && w.Type == "1").Count();
                }
            }

            for (int i = 0; i < modelmessages.Count; i++)
            {
                DateTime newDate = DateTime.ParseExact(modelmessages[i].DateCreated, "yy.MM.dd HH:mm:ss", CultureInfo.InvariantCulture);
                string year = newDate.Year.ToString();
                string[] months = { "Ocak", "Şubat", "Mart", "Nisan", "Mayıs", "Haziran", "Temmuz", "Ağustos", "Eylül", "Ekim", "Kasım", "Aralık" };
                string month = months[newDate.Month-1];
                string day = newDate.Day.ToString();
                string hour = modelmessages[i].DateCreated.Split(" ").Last();
                string newFormattedDate = day + " " + month + " " + year + "  " + hour;

                modelmessages[i].DateTimeFormatted = newFormattedDate;

            }

            return GetResponse(responseModel: modelmessages);
        }

        public ModelResponse AddEntryMessage(string writerUserName, string detail, string type, string subjectId)
        {
            EntityComments commentMessage = new EntityComments()
            {
                Id = hM.GenerateId(8),
                WriterUserName = writerUserName,
                Title = "",
                DateCreated = DateTime.Now.ToString("yy.MM.dd HH:mm:ss"),
                IsApproved = "0",
                Detail = detail,
                Type = type,
                SubjectId = subjectId
            };

            repoEntryMessages.Add(commentMessage);
            UpdateTopic(subjectId);
            return GetResponse(responseModel: commentMessage);
        }

        public ModelResponse AddLikeToEntry(string writerUserId, string commentId, string type, string subjectId)
        {
            EntityForumInteraction likeInteraction = new EntityForumInteraction()
            {
                Id = hM.GenerateId(8),
                UserId = writerUserId,
                Type = type,
                SubjectId = subjectId,
                CommentId = commentId
            };

            repoForumInteraction.Add(likeInteraction);
            return GetResponse(responseModel: likeInteraction);
        }

        public ModelResponse GetEntryLikes()
        {
            List<EntityForumInteraction> entitynteractionLikes = repoForumInteraction.GetAll().ToList();
            List<ModelForumInteraction> modelInteractionLikes = new List<ModelForumInteraction>();

            for (int i = 0; i < entitynteractionLikes.Count; i++)
            {
                ModelForumInteraction modelInteractionLike = new ModelForumInteraction()
                {
                    Id = entitynteractionLikes[i].Id,
                    SubjectId = entitynteractionLikes[i].SubjectId,
                    Type = entitynteractionLikes[i].Type,
                    UserId = entitynteractionLikes[i].UserId,
                    CommentId = entitynteractionLikes[i].CommentId
                };
                modelInteractionLikes.Add(modelInteractionLike);
            }
            return GetResponse(responseModel: modelInteractionLikes);
        }

        public void DeleteEntry(string id)
        {
            EntityComments entryComment = repoEntryMessages.GetBy(w => w.Id == id);
            repoEntryMessages.Remove(entryComment);
        }

        #endregion

        #endregion

        #region Answer Question

        public ModelResponse GetAllQuestions()
        {
            List<EntityQuestion> entityQuestions = repoQuestion.GetAll().ToList();

            return GetResponse(responseModel: entityQuestions);
        }

        public ModelResponse GetQuestions()
        {
            List<EntityQuestion> entityQuestions = repoQuestion.GetAll().ToList();

            List<ModelQuestion> modelQuestions = new List<ModelQuestion>();

            for (int i = 0; i < entityQuestions.Count; i++)
            {
                ModelQuestion modelQuestion = new ModelQuestion()
                {
                    Id = entityQuestions[i].Id,
                    Title = entityQuestions[i].Title,
                    Detail = entityQuestions[i].Detail,
                    UserId = entityQuestions[i].UserId,
                    DateCreated = entityQuestions[i].DateCreated,
                    IsSolved = entityQuestions[i].IsSolved,
                    Tags = entityQuestions[i].Tags,
                    CategoryId = entityQuestions[i].CategoryId,
                    Url = entityQuestions[i].Url,
                    Answers = new List<ModelAnswer>()
                };
                modelQuestions.Add(modelQuestion);
            }

            List<ModelUser> users = GetUser();
            List<EntityQAInteraction> entityQAInteractions = GetQAInteractions().Response as List<EntityQAInteraction>;
            List<ModelAnswer> modelAnswers = GetAnswers(users: users, entityQAInteractions: entityQAInteractions).Response as List<ModelAnswer>;
            
            
            for (int i = 0; i < modelQuestions.Count; i++)
            {
                for (int k = 0; k < modelAnswers.Count; k++)
                {
                    if (modelQuestions[i].Id == modelAnswers[k].QuestionId)
                    {
                        modelQuestions[i].Answers.Add(modelAnswers[k]);
                    }
                }

                string[] tags = modelQuestions[i].Tags.Split("//");
                modelQuestions[i].TagsList = tags;

                for (int k = 0; k < modelQuestions[i].TagsList.Length; k++)
                {
                    modelQuestions[i].TagsList[k] = modelQuestions[i].TagsList[k].Replace("/", "");
                }

                for (int k = 0; k < entityQAInteractions.Count; k++)
                {
                    modelQuestions[i].LikeCount = entityQAInteractions.Where(w => w.QuestionId == modelQuestions[i].Id && w.Type == "1").Count();
                    modelQuestions[i].Unlike = entityQAInteractions.Where(w => w.QuestionId == modelQuestions[i].Id && w.Type == "2").Count();
                    modelQuestions[i].TotalLikeCount = (modelQuestions[i].LikeCount - modelQuestions[i].Unlike).ToString();

                    modelQuestions[i].ViewedCount = entityQAInteractions.Where(w => w.QuestionId == modelQuestions[i].Id && w.Type == "0").Count().ToString();
                }

                for (int k = 0; k < users.Count; k++)
                {
                    if (modelQuestions[i].UserId == users[k].Id)
                    {
                        modelQuestions[i].Username = users[k].Username;
                        modelQuestions[i].UserPhotoUrl = users[k].PhotoUrl;
                    }
                }

                DateTime newDate = DateTime.ParseExact(modelQuestions[i].DateCreated, "yy.MM.dd HH:mm:ss", CultureInfo.InvariantCulture);
                string year = newDate.Year.ToString();
                string[] months = { "Ocak", "Şubat", "Mart", "Nisan", "Mayıs", "Haziran", "Temmuz", "Ağustos", "Eylül", "Ekim", "Kasım", "Aralık" };
                string month = months[newDate.Month];
                string day = newDate.Day.ToString();
                string hour = modelQuestions[i].DateCreated.Split(" ").Last();
                string newFormattedDate = day + " " + month + " " + year + "  " + hour;
                modelQuestions[i].DateTimeFormatted = newFormattedDate;
            }

            return GetResponse(responseModel: modelQuestions);
        }

        public ModelResponse GetQuestionsOnlyQuestion()
        {
            List<EntityQuestion> entityQuestions = repoQuestion.GetAll().ToList();

            List<ModelQuestion> modelQuestions = new List<ModelQuestion>();

            for (int i = 0; i < entityQuestions.Count; i++)
            {
                ModelQuestion modelQuestion = new ModelQuestion()
                {
                    Id = entityQuestions[i].Id,
                    Title = entityQuestions[i].Title,
                    Detail = entityQuestions[i].Detail,
                    UserId = entityQuestions[i].UserId,
                    DateCreated = entityQuestions[i].DateCreated,
                    IsSolved = entityQuestions[i].IsSolved,
                    Tags = entityQuestions[i].Tags,
                    CategoryId = entityQuestions[i].CategoryId,
                    Url = entityQuestions[i].Url,
                    Answers = new List<ModelAnswer>()
                };
                modelQuestions.Add(modelQuestion);
            }

            List<ModelUser> users = GetUser();
            List<EntityQAInteraction> entityQAInteractions = GetQAInteractions().Response as List<EntityQAInteraction>;

            for (int i = 0; i < modelQuestions.Count; i++)
            {
                string[] tags = modelQuestions[i].Tags.Split("//");
                modelQuestions[i].TagsList = tags;

                for (int k = 0; k < modelQuestions[i].TagsList.Length; k++)
                {
                    modelQuestions[i].TagsList[k] = modelQuestions[i].TagsList[k].Replace("/", "");
                }

                for (int k = 0; k < entityQAInteractions.Count; k++)
                {
                    modelQuestions[i].LikeCount = entityQAInteractions.Where(w => w.QuestionId == modelQuestions[i].Id && w.Type == "1").Count();
                    modelQuestions[i].Unlike = entityQAInteractions.Where(w => w.QuestionId == modelQuestions[i].Id && w.Type == "2").Count();
                    modelQuestions[i].TotalLikeCount = (modelQuestions[i].LikeCount - modelQuestions[i].Unlike).ToString();

                    modelQuestions[i].ViewedCount = entityQAInteractions.Where(w => w.QuestionId == modelQuestions[i].Id && w.Type == "0").Count().ToString();
                }

                for (int k = 0; k < users.Count; k++)
                {
                    if (modelQuestions[i].UserId == users[k].Id)
                    {
                        modelQuestions[i].Username = users[k].Username;
                        modelQuestions[i].UserPhotoUrl = users[k].PhotoUrl;
                    }
                }

                DateTime newDate = DateTime.ParseExact(modelQuestions[i].DateCreated, "yy.MM.dd HH:mm:ss", CultureInfo.InvariantCulture);
                string year = newDate.Year.ToString();
                string[] months = { "Ocak", "Şubat", "Mart", "Nisan", "Mayıs", "Haziran", "Temmuz", "Ağustos", "Eylül", "Ekim", "Kasım", "Aralık" };
                string month = months[newDate.Month];
                string day = newDate.Day.ToString();
                string hour = modelQuestions[i].DateCreated.Split(" ").Last();
                string newFormattedDate = day + " " + month + " " + year + "  " + hour;
                modelQuestions[i].DateTimeFormatted = newFormattedDate;
            }

            return GetResponse(responseModel: modelQuestions);
        }

        public ModelResponse UpdateQuestion(EntityQuestion question)
        {
            repoQuestion.Update(question);

            return GetResponse();
        }

        public ModelResponse GetAnswers(List<ModelUser> users, List<EntityQAInteraction> entityQAInteractions)
        {
            List<EntityAnswer> entityAnswers = repoAnswer.GetAll().ToList();
            List<ModelAnswer> modelAnswers = new List<ModelAnswer>();
            modelAnswers = modelAnswers.OrderByDescending(w => w.TotalLikeCount).ToList();

            for (int i = 0; i < entityAnswers.Count; i++)
            {
                ModelAnswer modelAnswer = new ModelAnswer()
                {
                    Id = entityAnswers[i].Id,
                    QuestionId = entityAnswers[i].QuestionId,
                    Detail = entityAnswers[i].Detail,
                    UserId = entityAnswers[i].UserId,
                    DateCreated = entityAnswers[i].DateCreated,
                    Tags = entityAnswers[i].Tags,
                    MainAswerId = entityAnswers[i].MainAswerId,
                    SubAnswers = new List<ModelAnswer>()
                };
                modelAnswers.Add(modelAnswer);
            }

            for (int i = 0; i < modelAnswers.Count; i++)
            {
                for (int k = 0; k < entityQAInteractions.Count; k++)
                {
                    modelAnswers[i].LikeCount = entityQAInteractions.Where(w => w.AnswerId == modelAnswers[i].Id && w.Type == "1").Count();
                    modelAnswers[i].Unlike = entityQAInteractions.Where(w => w.AnswerId == modelAnswers[i].Id && w.Type == "2").Count();
                    modelAnswers[i].TotalLikeCount = (modelAnswers[i].LikeCount - modelAnswers[i].Unlike).ToString();

                    modelAnswers[i].ViewedCount = entityQAInteractions.Where(w => w.AnswerId == modelAnswers[i].Id && w.Type == "0").Count().ToString();
                }

                for (int k = 0; k < users.Count; k++)
                {
                    if (modelAnswers[i].UserId == users[k].Id)
                    {
                        modelAnswers[i].Username = users[k].Username;
                        modelAnswers[i].UserPhotoUrl = users[k].PhotoUrl;
                    }
                }

                DateTime newDate = DateTime.ParseExact(modelAnswers[i].DateCreated, "yy.MM.dd HH:mm:ss", CultureInfo.InvariantCulture);
                string year = newDate.Year.ToString();
                string[] months = { "Ocak", "Şubat", "Mart", "Nisan", "Mayıs", "Haziran", "Temmuz", "Ağustos", "Eylül", "Ekim", "Kasım", "Aralık" };
                string month = months[newDate.Month];
                string day = newDate.Day.ToString();
                string hour = modelAnswers[i].DateCreated.Split(" ").Last();
                string newFormattedDate = day + " " + month + " " + year + "  " + hour;

                modelAnswers[i].DateTimeFormatted = newFormattedDate;
            }

            List<ModelAnswer> subAnswers = modelAnswers.Where(w => w.MainAswerId != "0").ToList();
            modelAnswers = modelAnswers.Where(w => w.MainAswerId == "0").ToList();

            for (int i = 0; i < modelAnswers.Count; i++)
            {
                for (int k = 0; k < subAnswers.Count; k++)
                {
                    if (subAnswers[k].MainAswerId == modelAnswers[i].Id)
                    {
                        modelAnswers[i].SubAnswers.Add(subAnswers[k]);
                    }
                }
            }

            return GetResponse(responseModel: modelAnswers);
        }

        public ModelResponse GetQAInteractions()
        {
            List<EntityQAInteraction> entityQAInteractions = repoQAInteraction.GetAll().ToList();

            return GetResponse(responseModel: entityQAInteractions);
        }

        public ModelResponse AddQuestion(string title, string userId, string detail, string tags, string categoryId, string url)
        {
            EntityQuestion question = new EntityQuestion()
            {
                Id = hM.GenerateId(8),
                Title = title,
                Detail = detail,
                DateCreated = DateTime.Now.ToString("yy.MM.dd HH:mm:ss"),
                UserId = userId,
                Tags = tags,
                CategoryId = categoryId,
                IsSolved = "0",
                Url = url
            };

            repoQuestion.Add(question); // Topic Eklendi

            return GetResponse(responseModel: repoSubject);
        }

        public ModelResponse GetQuestionCategories()
        {
            List<EntityQuestionCategories> entityQuestionCategories = repoQuestionCategories.GetAll().ToList();
            List<ModelQuestionCategories> modelQuestionCategories = new List<ModelQuestionCategories>();

            for (int i = 0; i < entityQuestionCategories.Count; i++)
            {
                ModelQuestionCategories modelQuestionCategory = new ModelQuestionCategories();
                modelQuestionCategory.Id = entityQuestionCategories[i].Id;
                modelQuestionCategory.Title = entityQuestionCategories[i].Title;
                modelQuestionCategories.Add(modelQuestionCategory);
            }

            List<EntityQuestion> entityQuestions = repoQuestion.GetAll().ToList();
            for (int i = 0; i < entityQuestions.Count; i++)
            {
                for (int k = 0; k < modelQuestionCategories.Count; k++)
                {
                    modelQuestionCategories[k].QuestionCount = entityQuestions.Where(w => w.CategoryId == modelQuestionCategories[k].Id).Count().ToString();
                }
            }

            return GetResponse(responseModel: modelQuestionCategories);
        }

        public ModelResponse GetQuestionCategoriesWithList(List<ModelQuestion> entityQuestions)
        {
            List<EntityQuestionCategories> entityQuestionCategories = repoQuestionCategories.GetAll().ToList();
            List<ModelQuestionCategories> modelQuestionCategories = new List<ModelQuestionCategories>();

            for (int i = 0; i < entityQuestionCategories.Count; i++)
            {
                ModelQuestionCategories modelQuestionCategory = new ModelQuestionCategories();
                modelQuestionCategory.Id = entityQuestionCategories[i].Id;
                modelQuestionCategory.Title = entityQuestionCategories[i].Title;
                modelQuestionCategories.Add(modelQuestionCategory);
            }

            for (int i = 0; i < entityQuestions.Count; i++)
            {
                for (int k = 0; k < modelQuestionCategories.Count; k++)
                {
                    modelQuestionCategories[k].QuestionCount = entityQuestions.Where(w => w.CategoryId == modelQuestionCategories[k].Id).Count().ToString();
                }
            }

            return GetResponse(responseModel: modelQuestionCategories);
        }

        public IOrderedEnumerable<KeyValuePair<string, int>> GetQuestionTags()
        {
            List<ModelQuestion> modelQuestions = GetQuestions().Response as List<ModelQuestion>;
            List<string> allTags = new List<string>();
            for (int i = 0; i < modelQuestions.Count; i++)
            {
                for (int k = 0; k < modelQuestions[i].TagsList.Length; k++)
                {
                    allTags.Add(modelQuestions[i].TagsList[k].ToLower());
                }
            }

            List<string> onlyNames = allTags.Distinct(StringComparer.CurrentCultureIgnoreCase).ToList();

            //Dictionary<string, int> types = new Dictionary<string, int>();

            SortedDictionary<string, int> types = new SortedDictionary<string, int>();
            types.Add("Hepsi", onlyNames.Count);
            for (int i = 0; i < onlyNames.Count; i++)
            {
                int countOfName = allTags.Where(w => w == onlyNames[i]).Count();
                types.Add(onlyNames[i], countOfName);
            }

            IOrderedEnumerable<KeyValuePair<string, int>> pairs = types.OrderByDescending(w => w.Value);

            return pairs;
        }

        public IOrderedEnumerable<KeyValuePair<string, int>> GetQuestionTagsWithList(List<ModelQuestion> modelQuestions)
        {
            List<string> allTags = new List<string>();
            for (int i = 0; i < modelQuestions.Count; i++)
            {
                for (int k = 0; k < modelQuestions[i].TagsList.Length; k++)
                {
                    allTags.Add(modelQuestions[i].TagsList[k].ToLower());
                }
            }

            List<string> onlyNames = allTags.Distinct(StringComparer.CurrentCultureIgnoreCase).ToList();

            //Dictionary<string, int> types = new Dictionary<string, int>();

            SortedDictionary<string, int> types = new SortedDictionary<string, int>();
            types.Add("Hepsi", onlyNames.Count);
            for (int i = 0; i < onlyNames.Count; i++)
            {
                int countOfName = allTags.Where(w => w == onlyNames[i]).Count();
                types.Add(onlyNames[i], countOfName);
            }

            IOrderedEnumerable<KeyValuePair<string, int>> pairs = types.OrderByDescending(w => w.Value);

            return pairs;
        }

        // 0: goruntuleme, 1 like, 2 unlike
        public ModelResponse AddAnswerInteraction(string qId, string aId, string type, string userId)
        {
            EntityQAInteraction qAInteraction = new EntityQAInteraction()
            {
                Id = hM.GenerateId(8),
                QuestionId = qId,
                AnswerId = aId,
                UserId = userId,
                Type = type,
                DateCreated = DateTime.Now.ToString("yy.MM.dd HH:mm:ss")
            };

            List<EntityQAInteraction> entityQAInteractions = GetQAInteractions().Response as List<EntityQAInteraction>;
            entityQAInteractions = entityQAInteractions.Where(w => w.AnswerId == aId && w.QuestionId == qId && w.UserId == userId).ToList();

            if (type == "0")
            {
                repoQAInteraction.Add(qAInteraction);
            }
            else
            {
                if (entityQAInteractions.Count > 0)
                {
                    entityQAInteractions[0].Type = type;
                    repoQAInteraction.Update(entityQAInteractions[0]);
                }
                else
                {
                    repoQAInteraction.Add(qAInteraction);
                }
            }

            

            return GetResponse(responseModel: repoSubject);
        }

        public ModelResponse AddAnswer(string qId, string userId, string detail, string mainAnswerId)
        {
            EntityAnswer answer = new EntityAnswer()
            {
                Id = hM.GenerateId(8),
                QuestionId = qId,
                Detail = detail,
                DateCreated = DateTime.Now.ToString("yy.MM.dd HH:mm:ss"),
                UserId = userId,
                MainAswerId = mainAnswerId
            };

            repoAnswer.Add(answer);

            return GetResponse(responseModel: answer);
        }
        #endregion

        #region System

        public ModelResponse GetSystemInfo()
        {
            List<SystemInfo> system = repoSystem.GetAll().ToList();

            return GetResponse(responseModel: system[0]);
        }

        public ModelResponse UpdateSystem(SystemInfo info)
        {
            repoSystem.Update(info);

            return GetResponse();
        }
        #endregion
    }
}
