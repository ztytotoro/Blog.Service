namespace Database.Entities
{
    public class PostTopic
    {
        public string PostId { get; set; }
        public string TopicId { get; set; }

        public Post Post { get; set; }
        public Topic Topic { get; set; }
    }
}
