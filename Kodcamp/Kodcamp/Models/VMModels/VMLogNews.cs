using System;
using System.Collections.Generic;
using Kodcamp.Models.EntityModels;
using Kodcamp.Models.LogReport;

namespace Kodcamp.Models.VMModels
{
    public class VMLogNews
    {
        public List<ModelLogPlus> Logs { get; set; }
        public List<EntityNews> News { get; set; }
    }
}
