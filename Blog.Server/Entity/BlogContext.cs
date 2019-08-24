using Database.Entities;
using Microsoft.EntityFrameworkCore;

namespace Database
{
    public class BlogContext : DbContext
    {
        public BlogContext(DbContextOptions<BlogContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Topic>(entity =>
            {
                entity
                    .HasMany(e => e.Children)
                    .WithOne(e => e.Parent)
                    .HasForeignKey(e => e.ParentId);
            });

            modelBuilder.Entity<PostTopic>()
                .HasKey(t => new { t.PostId, t.TopicId });
        }

        #region Author
        public DbSet<Author> Authors { get; set; }
        public DbSet<AuthorInfo> AuthorInfos { get; set; }
        #endregion

        #region Column
        public DbSet<Column> Columns { get; set; }
        public DbSet<ColumnInfo> ColumnInfos { get; set; }
        public DbSet<PostColumn> PostColumns { get; set; }
        #endregion

        #region Post
        public DbSet<Post> Posts { get; set; }
        public DbSet<PostContent> PostContents { get; set; }
        public DbSet<PostHistory> PostHistories { get; set; }
        #endregion

        #region Topic
        public DbSet<Topic> Topics { get; set; }
        public DbSet<TopicInfo> TopicInfos { get; set; }
        public DbSet<PostTopic> PostTopics { get; set; }
        #endregion
    }
}
