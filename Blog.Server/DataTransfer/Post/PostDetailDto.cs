using System;
using System.Collections.Generic;

namespace DataTransfer
{
    public class PostDetailDto : PostDto
    {
        public string Content { get; set; }
        public DateTime UpdateTime { get; set; }
        public AuthorDto Author { get; set; }
        public AuthorDto Editor { get; set; }
        public ColumnDto Column { get; set; }
        public List<TopicDto> Topics { get; set; }
    }
}
