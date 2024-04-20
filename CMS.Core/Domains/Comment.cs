namespace CMS.Infrastructure.Data.Entities.Infrastructure.Data.Entity.Core.Domains
{
    public class Comment : Base
    {
        public string EmailAddress { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Title { get; set; }
        public string Content { get; set; }

        public long PostId { get; set; }
        public Post Post { get; set; }
    }
}