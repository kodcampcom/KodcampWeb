using System;
namespace Kodcamp.Models.Forum
{
    public class EntityUser
    {
        public string Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string DateCreated { get; set; }
        public string PhotoUrl { get; set; }
    }

    public class ModelUser
    {
        public string Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string UserSubjects { get; set; }
        public string UserComments { get; set; }
        public string PhotoUrl { get; set; }
        public string DateCreated { get; set; }
    }
}
