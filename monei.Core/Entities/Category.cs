﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace monei.Core.Entities
{
    public class Category :EntityBase<int>
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
