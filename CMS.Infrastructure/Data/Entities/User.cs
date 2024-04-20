using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace CMS.Infrastructure.Data.Entities
{
    public class User : Base
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
    }

    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("Users");

            builder.HasKey(c => c.Id);

            builder.Property(x => x.FirstName).HasMaxLength((int)ContextEnums.NameMaxLength);
            builder.Property(x => x.LastName).HasMaxLength((int)ContextEnums.NameMaxLength);
            builder.Property(x => x.Email).HasMaxLength((int)ContextEnums.EmailMaxLength);
            builder.Property(x => x.Phone).HasMaxLength((int)ContextEnums.PhoneMaxLength);
            builder.Property(x => x.Password).HasMaxLength((int)ContextEnums.PasswordMaxLength);
        }
    }
}
