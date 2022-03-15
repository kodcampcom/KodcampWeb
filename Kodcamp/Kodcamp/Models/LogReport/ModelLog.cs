using System;
namespace Kodcamp.Models.LogReport
{
    public class ModelLog
    {
        public string Id { get; set; }
        public string NewsId { get; set; }
        public string DateTime { get; set; }
        public string Type { get; set; } // haber, indirim, yuzde
        public string Title { get; set; }
    }

    public class ModelLogPlus
    {
        public string Id { get; set; }
        public string NewsId { get; set; }
        public string DateTime { get; set; }
        public string Title { get; set; }
        public string Type { get; set; } // haber, indirim, yuzde, soru
    }
}
