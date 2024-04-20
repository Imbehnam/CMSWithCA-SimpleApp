using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CMS.Infrastructure.Data.Entities
{
    public class PostTag : Base
    {
        public long TagId { get; set; }
        public Tag Tag { get; set; }

        public long PostId { get; set; }
        public Post Post { get; set; }

    }

    public class PostTagConfiguration : IEntityTypeConfiguration<PostTag>
    {
        public void Configure(EntityTypeBuilder<PostTag> builder)
        {
            builder.ToTable("PostTags");

            builder.HasKey(x => x.Id);

            builder.HasOne(c => c.Post).WithMany(c => c.PostTags);
            builder.HasOne(c => c.Tag).WithMany(c => c.PostTags);
        }
    }
}
