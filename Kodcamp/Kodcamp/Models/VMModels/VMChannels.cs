using System;
using System.Collections.Generic;
using System.Linq;
using Kodcamp.Models.AnswerQuestion;
using Kodcamp.Models.EntityModels;
using Kodcamp.Models.Forum;

namespace Kodcamp.Models.VMModels
{
    public class VMChannels
    {
        public List<ModelQuestionCategories> QuestionCategories { get; set; }
        public IOrderedEnumerable<KeyValuePair<string, int>> TagsKeyValue { get; set; }
        public List<EntityNews> NewsList { get; set; }
        public List<EntityQuestion> Questions { get; set; }
        public List<EntitySubject> Subjects { get; set; }
        public List<EntityCategory> Categories { get; set; }
    }
}
