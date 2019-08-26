using Database.Base;

namespace Database.Entities
{
    public class TopicInfo : I18nEntity
    {
        public string TopicId { get; set; }
        public string Name { get; set; }
    }
}
