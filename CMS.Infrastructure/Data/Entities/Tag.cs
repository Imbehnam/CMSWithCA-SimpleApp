using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CMS.Infrastructure.Data.Entities
{
    public class Tag : Base
    {
        public string Title { get; set; }

        public ICollection<PostTag> PostTags { get; set; }
    }

    public class TagConfiguration : IEntityTypeConfiguration<Tag>
    {
        public void Configure(EntityTypeBuilder<Tag> builder)
        {
            builder.ToTable("Tags");

            builder.HasKey(x => x.Id);

            builder.Property(x=>x.Title).HasMaxLength((int)ContextEnums.TitleMaxLength);
        }
    }
}
