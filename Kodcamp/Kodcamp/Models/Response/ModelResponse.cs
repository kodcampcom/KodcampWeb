using System;
namespace Kodcamp.Models.Response
{
    public class ModelResponse
    {
        public int Status { get; set; }
        public string StatusDetail { get; set; }
        public object Response { get; set; }
    }
}
