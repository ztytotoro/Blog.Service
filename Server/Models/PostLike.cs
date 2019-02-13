using Microsoft.EntityFrameworkCore;
using Server.Base;
using Server.Models;

namespace Server.DataAccess
{
    public partial class BlogContext : DbContext
    {
        public DbSet<PostLike> PostLike { get; set; }
    }
}

namespace Server.Models
{
    public class PostLike : BaseEntity
    {
        public int PostId { get; set; }
        public int? VisitorId { get; set; }

        public Post Post { get; set; }
        public Visitor Visitor { get; set; }
    }
}
