using Microsoft.EntityFrameworkCore;
using Server.Base;
using Server.Models;
using System.Collections.Generic;

namespace Server.DataAccess
{
    public partial class BlogContext : DbContext
    {
        public DbSet<Tag> Tag { get; set; }
    }
}

namespace Server.Models
{
    public class Tag : BaseEntity
    {
        public string Name { get; set; }

        public List<PostTag> PostTags { get; set; }
    }
}
