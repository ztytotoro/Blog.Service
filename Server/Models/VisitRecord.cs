using System;
using Microsoft.EntityFrameworkCore;
using Server.Base;
using Server.Models;

namespace Server.DataAccess
{
    public partial class BlogContext : DbContext
    {
        public DbSet<VisitRecord> VisitRecord { get; set; }
    }
}

namespace Server.Models
{
    public class VisitRecord : BaseEntity
    {
        public string Ip { get; set; }
        public string Mac { get; set; }
        public int? VisitorId { get; set; }
        public DateTime VisitTime { get; set; }
        public string VisitPath { get; set; }
        public int TimeOfStay { get; set; }

        public Visitor Visitor { get; set; }
    }
}
