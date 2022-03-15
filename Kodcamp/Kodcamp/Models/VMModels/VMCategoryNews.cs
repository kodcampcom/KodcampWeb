using System;
using System.Collections.Generic;
using Kodcamp.Models.EntityModels;

namespace Kodcamp.Models.VMModels
{
    public class VMCategoryNews
    {
        public List<EntityCategory> Categories { get; set; }
        public List<EntityNews> News { get; set; }
        public List<EntityCategory> MainCategories { get; set; }
    }
}
