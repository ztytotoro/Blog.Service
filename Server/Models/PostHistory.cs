using System;
using Microsoft.EntityFrameworkCore;
using Server.Base;
using Server.Models;

namespace Server.DataAccess
{
    public partial class BlogContext : DbContext
    {
        public DbSet<PostHistory> PostHistory { get; set; }
    }
}

namespace Server.Models
{
    public class PostHistory : BaseEntity
    {
        public int PostId { get; set; }
        public DateTime EditTime { get; set; }
        public string Content { get; set; }
    }
}
