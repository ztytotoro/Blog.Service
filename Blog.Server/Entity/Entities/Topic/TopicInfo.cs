using Common.Enums;
using Database.Base;

namespace Database.Entities
{
    public class TopicInfo : EntityBase
    {
        public string TopicId { get; set; }
        public string Name { get; set; }

        public Language Language { get; set; }
    }
}
