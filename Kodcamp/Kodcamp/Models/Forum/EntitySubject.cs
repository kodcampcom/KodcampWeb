using System;
using System.Collections.Generic;

namespace Kodcamp.Models.Forum
{
    public class EntitySubject
    {
        public string Id { get; set; }
        public string WriterUserName { get; set; }
        public string DateCreated { get; set; }
        public string Title { get; set; }
        public string Detail { get; set; }
        public string IsApproved { get; set; }
        public string Type { get; set; } // Type:0 Sözlük, 1 Forum
        public string DateUpdated { get; set; }
        public string Url { get; set; }
    }

    public class ModelSubject
    {
        public string Id { get; set; }
        public string WriterUserName { get; set; }
        public string DateCreated { get; set; }
        public string Title { get; set; }
        public string Detail { get; set; }
        public string LikeCount { get; set; }
        public string IsApproved { get; set; }
        public string Type { get; set; }
        public List<ModelEntryMessage> Comments { get; set; }
        public string CommentCount { get; set; }
        public string DateUpdated { get; set; }
        public string Url { get; set; }
    }
}
