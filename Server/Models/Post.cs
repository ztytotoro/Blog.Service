using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Server.Base;
using Server.Models;

namespace Server.DataAccess
{
    public partial class BlogContext : DbContext
    {
        public DbSet<Post> Post { get; set; }
    }
}

namespace Server.Models
{
    public class Post : BaseEntity
    {
        // 标题
        public string Title { get; set; }
        // 作者
        public string Author { get; set; }
        // 创建时间
        public DateTime? CreateTime { get; set; }
        // 修改时间
        public DateTime? LastEditTime { get; set; }
        // 正文
        public string Content { get; set; }

        public List<Tag> Tags { get; set; }
        public List<Comment> Comments { get; set; }
        public List<PostHistory> Histories { get; set; }
    }
}
