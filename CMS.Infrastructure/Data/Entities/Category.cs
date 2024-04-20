
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CMS.Infrastructure.Data.Entities
{
    public class Category : Base
    {
        public string Title { get; set; }
        public string Slug { get; set; }
    }

    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.ToTable("Categories");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Title).HasMaxLength((int)ContextEnums.TitleMaxLength);
            builder.Property(x=>x.Slug).HasMaxLength((int)ContextEnums.PostContentMaxLength);
        }
    }
}