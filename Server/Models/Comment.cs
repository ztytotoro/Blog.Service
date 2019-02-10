using Microsoft.EntityFrameworkCore;
using Server.Base;
using Server.Models;

namespace Server.DataAccess
{
    public partial class BlogContext : DbContext
    {
        public DbSet<Comment> Comment { get; set; }
    }
}

namespace Server.Models
{
    public class Comment : BaseEntity
    {
        public int PostId { get; set; }
        public string Content { get; set; }
        public string Visitor { get; set; }
    }
}
