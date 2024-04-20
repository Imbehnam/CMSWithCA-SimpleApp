using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace CMS.Core.Domains
{
    public class Post : Base
    {
        public string Title { get; set; }
        public string Content { get; set; }


        public long CategoryId { get; set; }
        public virtual Category Category { get; set; }

        public ICollection<Comment> Comments { get; set; }

        public ICollection<PostTag> PostTags { get; set; }
    }
}
