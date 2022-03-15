using System;
namespace Kodcamp.Models.Interaction
{
    public class EntityInteraction
    {
        public string Id { get; set; }
        public string NewsId { get; set; }
        public string InteractionType { get; set; }
        public string DateCreated { get; set; }
    }

    public class ModelInteraction
    {
        public string Id { get; set; }
        public string NewsId { get; set; }
        public string InteractionType { get; set; }
        public string DateCreated { get; set; }
    }

    public enum InteractionTypes
    {
        Like = 1,
        Unlike = 2,
        Smile = 3,
        Coding = 4,
        Viewed = 5
        //int some = InteractionTypes.Like
    }
}
