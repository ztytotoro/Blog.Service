using Microsoft.EntityFrameworkCore;
using Server.Base;
using Server.Models;

namespace Server.DataAccess
{
    public partial class BlogContext : DbContext
    {
        public DbSet<Visitor> Visitor { get; set; }
    }
}

namespace Server.Models
{
    public enum GenderType
    {
        Female,
        Male
    }

    public enum FieldType
    {
        FrontEnd,
        FullStack
    }

    public class Visitor : BaseEntity
    {
        public string NickName { get; set; }
        public GenderType Gender { get; set; }
        public int Age { get; set; }
        public FieldType Field { get; set; }
        public string Email { get; set; }
    }
}
