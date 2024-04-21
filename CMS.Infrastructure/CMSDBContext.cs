using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CMS.Infrastructure.Data.Entities;
using Microsoft.EntityFrameworkCore.Design;

namespace CMS.Infrastructure
{
    /// <summary>
    /// Project DBContext Class
    /// </summary>
    public class CMSDBContext : DbContext
    {
        #region DBSets Region

        public DbSet<Post> Posts { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<PostTag> PostTags { get; set; }


        #endregion

        public CMSDBContext(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            /***
             * Here we apply configuration of each database tables
             * @ also we can use reflection to apply configurations without applying here but in this project simply apply here
             */
            modelBuilder.ApplyConfiguration(new PostConfiguration());
            modelBuilder.ApplyConfiguration(new CommentConfiguration());
            modelBuilder.ApplyConfiguration(new TagConfiguration());
            modelBuilder.ApplyConfiguration(new CategoryConfiguration());
            modelBuilder.ApplyConfiguration(new PostTagConfiguration());
            modelBuilder.ApplyConfiguration(new UserConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }

    /// <summary>
    /// DBContext creating configuration
    /// </summary>
    public class BloggingCMSDBContextFactory : IDesignTimeDbContextFactory<CMSDBContext>
    {
        public CMSDBContext CreateDbContext(string[] args)
        {
            var optionBuilder = new DbContextOptionsBuilder<CMSDBContext>();
            optionBuilder.UseSqlServer(@"Server=.;Database=CMSDB;Trusted_Connection=True;TrustServerCertificate=True");

            return new CMSDBContext(optionBuilder.Options);
        }
    }
}
