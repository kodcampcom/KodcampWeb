using System;
namespace Kodcamp.Models.Forum
{
    public class EntityForumInteraction
    {
        public string Id { get; set; }
        public string Type { get; set; } // Comment like : 1, Topic like : 2
        public string UserId { get; set; }
        public string SubjectId { get; set; }
        public string CommentId { get; set; }
    }

    public class ModelForumInteraction
    {
        public string Id { get; set; }
        public string Type { get; set; } // Comment like : 1, Topic like : 2
        public string UserId { get; set; }
        public string SubjectId { get; set; }
        public string CommentId { get; set; }
    }
}
