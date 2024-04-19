namespace CMS.Core.Domains
{
    public class Category : Base
    {
        public string Title { get; set; }
        public string Content { get; set; }

        public ICollection<Post> Posts { get; set; }
    }
}