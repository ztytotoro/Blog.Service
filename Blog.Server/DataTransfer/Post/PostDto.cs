using DataTransfer.Base;
using System;

namespace DataTransfer
{
    public class PostDto : IdentifiedDto
    {
        public string Title { get; set; }
        public DateTime CreateTime { get; set; }
    }
}
