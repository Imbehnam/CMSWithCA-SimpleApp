﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.Infrastructure.Data.Entities.Infrastructure.Data.Entity.Core.Domains
{
    public class PostTag
    {
        public long TagId { get; set; }
        public Tag Tag { get; set; }

        public long PostId { get; set; }
        public Post Post { get; set; }

    }
}
