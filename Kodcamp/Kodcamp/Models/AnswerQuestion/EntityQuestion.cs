using System;
using System.Collections.Generic;

namespace Kodcamp.Models.AnswerQuestion
{
    public class EntityQuestion
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Detail { get; set; }
        public string UserId { get; set; }
        public string DateCreated { get; set; }
        public string Tags { get; set; }
        public string CategoryId { get; set; }
        public string IsSolved { get; set; }
        public string Url { get; set; }
    }

    public class ModelQuestion
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Detail { get; set; }
        public string UserId { get; set; }
        public string Username { get; set; }
        public string UserPhotoUrl { get; set; }
        public string DateCreated { get; set; }
        public string Tags { get; set; }
        public string[] TagsList { get; set; }
        public string CategoryId { get; set; }
        public int LikeCount { get; set; }
        public int Unlike { get; set; }
        public string TotalLikeCount { get; set; }
        public string ViewedCount { get; set; }
        public string IsSolved { get; set; }
        public string DateTimeFormatted { get; set; }
        public List<ModelAnswer> Answers { get; set; }
        public string Url { get; set; }
    }

    public class EntityAnswer
    {
        public string Id { get; set; }
        public string QuestionId { get; set; }
        public string Detail { get; set; }
        public string UserId { get; set; }
        public string DateCreated { get; set; }
        public string Tags { get; set; }
        public string IsMainAnswer { get; set; } = "0";
        public string MainAswerId { get; set; } = "";
    }

    public class ModelAnswer
    {
        public string Id { get; set; }
        public string QuestionId { get; set; }
        public string Username { get; set; }
        public string UserPhotoUrl { get; set; }
        public string Detail { get; set; }
        public string UserId { get; set; }
        public string DateCreated { get; set; }
        public string Tags { get; set; }
        public int LikeCount { get; set; }
        public int Unlike { get; set; }
        public string TotalLikeCount { get; set; }
        public string ViewedCount { get; set; }
        public string DateTimeFormatted { get; set; }
        public string IsMainAnswer { get; set; } = "0";
        public string MainAswerId { get; set; } = "";
        public List<ModelAnswer> SubAnswers { get; set; }
    }

    public class EntityQAInteraction
    {
        public string Id { get; set; }
        public string QuestionId { get; set; }
        public string AnswerId { get; set; }
        public string UserId { get; set; }
        public string DateCreated { get; set; }
        public string Type { get; set; } // 0: goruntuleme, 1 like, 2 unlike
    }

    public class EntityQuestionCategories
    {
        public string Id { get; set; }
        public string Title { get; set; }
    }

    public class ModelQuestionCategories
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string QuestionCount { get; set; }
    }
}
 