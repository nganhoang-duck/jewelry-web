﻿using System;
using System.Collections.Generic;

namespace Shop.Model.Entities
{
    public partial class PostTag
    {
        public int? PostId { get; set; }
        public int? TagId { get; set; }

        public virtual Post? Post { get; set; }
        public virtual Tag? Tag { get; set; }
    }
}
