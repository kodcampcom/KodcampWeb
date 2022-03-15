using System;
using System.Collections.Generic;
using Kodcamp.Models.AnswerQuestion;
using Kodcamp.Models.Forum;

namespace Kodcamp.Models.VMModels
{
    public class VMProfile
    {
        public List<ModelSubject> Subjects { get; set; }
        public List<ModelEntryMessage> Messages { get; set; }
        public ModelUser Profile { get; set; }

        public List<ModelQuestion> Questions { get; set; }
        public List<ModelAnswer> Answers { get; set; }
    }
}
