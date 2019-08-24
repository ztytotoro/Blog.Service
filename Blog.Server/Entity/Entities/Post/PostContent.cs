using Common.Enums;
using Database.Base;

namespace Database.Entities
{
    public class PostContent : I18nEntity
    {
        public string PostId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
    }
}
