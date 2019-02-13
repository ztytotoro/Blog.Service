using Microsoft.EntityFrameworkCore;
using Server.Base;
using Server.Models;
using System.Collections.Generic;

namespace Server.DataAccess
{
    public partial class BlogContext : DbContext
    {
        public DbSet<Column> Column { get; set; }
    }
}

namespace Server.Models
{
    public class Column : BaseEntity
    {
        public string Name { get; set; }

        public List<Post> Posts { get; set; }
    }
}
