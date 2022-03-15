using System;
using System.Collections.Generic;
using System.Linq;
using Kodcamp.Models.AnswerQuestion;
using Kodcamp.Models.EntityModels;
using Kodcamp.Models.Forum;

namespace Kodcamp.Models.VMModels
{
    public class VMForumTopicMessages
    {
        public List<ModelSubject> Subjects { get; set; }
        public List<ModelEntryMessage> Messages { get; set; }
        public List<ModelQuestionCategories> QuestionCategories { get; set; }
        public IOrderedEnumerable<KeyValuePair<string, int>> TagsKeyValue { get; set; }
        public List<EntityNews> NewsList { get; set; }
    }
}
