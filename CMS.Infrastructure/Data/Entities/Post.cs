using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CMS.Infrastructure.Data.Entities
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

    public class PostConfiguration : IEntityTypeConfiguration<Post>
    {
        public void Configure(EntityTypeBuilder<Post> builder)
        {
            builder.ToTable("Posts");

            builder.HasKey(x => x.Id);

            builder.Property(x=>x.Title).HasMaxLength((int)ContextEnums.TitleMaxLength);
            builder.Property(x=>x.Content).HasMaxLength((int)ContextEnums.PostContentMaxLength);
        }
    }
}
