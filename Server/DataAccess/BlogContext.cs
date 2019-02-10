using Microsoft.EntityFrameworkCore;
using Server.Models;

namespace Server.DataAccess
{
    public partial class BlogContext : DbContext
    {
        public BlogContext(DbContextOptions<BlogContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PostTag>()
                .HasKey(pt => new
                {
                    pt.PostId,
                    pt.TagId
                });
        }
    }
}
