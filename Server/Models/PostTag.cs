using Microsoft.EntityFrameworkCore;
using Server.Models;

namespace Server.DataAccess
{
    public partial class BlogContext : DbContext
    {
        public DbSet<PostTag> PostTag { get; set; }
    }
}

namespace Server.Models
{
    public class PostTag
    {
        public int PostId { get; set; }
        public int TagId { get; set; }
    }
}
