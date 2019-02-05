using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Server.Model
{
    public class Post
    {
        // ID
        public int Id { get; set; }
        // 标题
        public string Title { get; set; }
        // 作者
        public string Author { get; set; }
        // 创建时间
        public DateTime? CreateTime { get; set; }
        // 修改时间
        public DateTime? UpdateTime { get; set; }
        // 正文
        public string Content { get; set; }
    }
}
