using Microsoft.EntityFrameworkCore;
using Kodcamp.Models.AnswerQuestion;
using Kodcamp.Models.EntityModels;
using Kodcamp.Models.Forum;
using Kodcamp.Models.Interaction;
using Kodcamp.Models.LogReport;
using Kodcamp.Models.ModelSystem;

namespace Kodcamp.Models
{
    public class Context : DbContext
    {
        public DbSet<EntityCategory> Category { get; set; }
        public DbSet<EntityNews> News { get; set; }
        public DbSet<Comment> Comment { get; set; }
        public DbSet<ModelLog> Logs { get; set; }
        public DbSet<EntityInteraction> Interactions { get; set; }
        //public DbSet<EntityActivity> Activities { get; set; }
        //public DbSet<EntityActivityCategory> ActivitiyCategories { get; set; }

        public DbSet<EntityComments> ForumComments { get; set; }
        public DbSet<EntityForumInteraction> ForumInteractions { get; set; }
        public DbSet<EntitySubject> ForumSubjects { get; set; }
        public DbSet<EntityUser> ForumUser { get; set; }

        public DbSet<EntityQuestion> Questions { get; set; }
        public DbSet<EntityAnswer> Answer { get; set; }
        public DbSet<EntityQAInteraction> QAInteractions { get; set; }
        public DbSet<EntityQuestionCategories> QuestionCategories { get; set; }
        public DbSet<Contact> Contact { get; set; }
        public DbSet<SystemInfo> SystemInfo { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"server=89.252.181.210\MSSQLSERVER2019;database=kodcam72_gok1;User Id=kodcam72_gok-2;Password=Kore20451905-db");
            //kodcam72_gok1
        }
    }
}

// dotnet ef migrations add LogDb1
// dotnet ef database update

//update - database
//add - migration