using Common.Enums;
using DataTransfer.Base;
using System.Collections.Generic;

namespace DataTransfer
{
    public class AddPostContentDto
    {
        public string PostId { get; set; }
        public Language Language { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string AuthorId { get; set; }
        public string ColumnId { get; set; }
        public List<string> TopicIds { get; set; }
    }
}
