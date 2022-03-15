using System;
using System.Collections.Generic;
using Kodcamp.Models.EntityModels;

namespace Kodcamp.Models.VMModels
{
    public class VMIndex
    {
        public List<EntityNews> AllNews { get; set; }
        public List<EntityNews> Programming { get; set; }
        public List<EntityNews> Hardware { get; set; }
        public List<EntityNews> OperatingSystems { get; set; }
        public List<EntityNews> Technology { get; set; }
        public List<EntityNews> Articles { get; set; }
        public List<EntityNews> Lessons { get; set; }
    }
}
