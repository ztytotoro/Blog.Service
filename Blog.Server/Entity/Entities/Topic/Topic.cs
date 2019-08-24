using Database.Base;
using System.Collections.Generic;
using System.Linq;

namespace Database.Entities
{
    public class Topic : IdentifiedEntity<TopicInfo>
    {
        public string ParentId { get; set; }

        public Topic Parent { get; set; }
        public List<Topic> Children { get; set; }

        private List<PostTopic> PostTopics { get; set; }
        public List<Post> Posts => PostTopics.Select(x => x.Post).ToList();
    }
}
