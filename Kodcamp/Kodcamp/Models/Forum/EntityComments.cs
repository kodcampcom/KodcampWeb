using System;
namespace Kodcamp.Models.Forum
{
    public class EntityComments
    {
        public string Id { get; set; }
        public string SubjectId { get; set; }
        public string WriterUserName { get; set; }
        public string DateCreated { get; set; }
        public string Title { get; set; }
        public string Detail { get; set; }
        public string IsApproved { get; set; }
        public string Type { get; set; } // Type:0 Sözlük, 1 Forum
        public string Url { get; set; }
    }
    public class ModelEntryMessage
    {
        public string Id { get; set; }
        public string SubjectId { get; set; }
        public string WriterUserName { get; set; }
        public string DateCreated { get; set; }
        public string Title { get; set; }
        public string Detail { get; set; }
        public string IsApproved { get; set; }
        public int LikeCount { get; set; }
        public string Type { get; set; } // Type:0 Sözlük, 1 Forum
        public string DateTimeFormatted { get; set; }
        public string Url { get; set; }
    }
}
