using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CMS.Infrastructure.Data.Entities
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

    public class CommentConfiguration : IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> builder)
        {
            builder.ToTable("Comments");

            builder.HasKey(c => c.Id);

            builder.Property(x => x.Title).HasMaxLength((int)ContextEnums.TitleMaxLength);
            builder.Property(x => x.Content).HasMaxLength((int)ContextEnums.CommentContentMaxLength);
            builder.Property(x => x.EmailAddress).HasMaxLength((int)ContextEnums.EmailMaxLength);
            builder.Property(x => x.FirstName).HasMaxLength((int)ContextEnums.NameMaxLength);
            builder.Property(x => x.LastName).HasMaxLength((int)ContextEnums.NameMaxLength);


            builder.HasOne(x => x.Post).WithMany(c => c.Comments);
        }
    }
}