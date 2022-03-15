using System;
using System.Collections.Generic;
using System.Linq;
using Kodcamp.Models.AnswerQuestion;
using Kodcamp.Models.EntityModels;
using Kodcamp.Models.Forum;

namespace Kodcamp.Models.VMModels
{
    public class VMQuestionCategoryTags
    {
        public List<ModelQuestion> Questions { get; set; }
        public List<ModelQuestionCategories> QuestionCategories { get; set; }
        public IOrderedEnumerable<KeyValuePair<string, int>> TagsKeyValue { get; set; }
        public List<EntityNews> News { get; set; }
        public List<EntitySubject> Subjects { get; set; }
    }
}
