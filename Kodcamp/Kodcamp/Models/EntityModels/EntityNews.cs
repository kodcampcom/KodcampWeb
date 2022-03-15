using System;
using System.Collections.Generic;

namespace Kodcamp.Models.EntityModels
{
    public class EntityNews
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string DetailHeader { get; set; }
        public string Detail { get; set; }
        public string CategoryIds { get; set; } // Gideceği alt başlık
        public string MainCategoryIds { get; set; }
        public string ImageUrl { get; set; }
        public List<Comment> Comments { get; set; }
        public string DateCreated { get; set; }
        public int ViewedCount { get; set; } = 0;
        public string ArticleDetail { get; set; }
        public string Type { get; set; }
        public string Url { get; set; }
        public string Code { get; set; }
        public string ImageUrlDetail1 { get; set; }
        public string ImageUrlDetail2 { get; set; }
        public string ImageUrlDetail3 { get; set; }

        public string LikeCount { get; set; }
        public string UnlikeCount { get; set; }
        public string SmileCount { get; set; }
        public string CoderCount { get; set; }
    }

    public class ModelNews
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string DetailHeader { get; set; }
        public string Detail { get; set; }
        public string CategoryIds { get; set; } // Gideceği alt başlık
        public string MainCategoryIds { get; set; }
        public string ImageUrl { get; set; }
        public List<Comment> Comments { get; set; }
        public string DateCreated { get; set; }
        public int ViewedCount { get; set; } = 0;
        public string DateTimeFormatted { get; set; }
        public string ArticleDetail { get; set; }
        public string Type { get; set; }
        public string Url { get; set; }
        public string Code { get; set; }

        public string LikeCount { get; set; }
        public string UnlikeCount { get; set; }
        public string SmileCount { get; set; }
        public string CoderCount { get; set; }

        public string ImageUrlDetail1 { get; set; }
        public string ImageUrlDetail2 { get; set; }
        public string ImageUrlDetail3 { get; set; }
    }

    public class Comment
    {
        public string Id { get; set; }
        public string Text { get; set; }
        public string NickName { get; set; }
        public string NewsId { get; set; }
        public string Approved { get; set; } // "0" onaylanmamış, 1 onaylanmış
    }

}
