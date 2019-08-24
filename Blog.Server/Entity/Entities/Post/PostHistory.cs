using Database.Base;
using System;

namespace Database.Entities
{
    public class PostHistory : EntityBase
    {
        public string PostContentId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime EditTime { get; set; }
        public string EditorId { get; set; }

        public Author Editor { get; set; }
    }
}
