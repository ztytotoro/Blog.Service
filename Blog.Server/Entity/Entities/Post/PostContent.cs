using Common.Enums;
using Database.Base;

namespace Database.Entities
{
    public class PostContent : EntityBase
    {
        public string PostId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public Language Language { get; set; }
    }
}
