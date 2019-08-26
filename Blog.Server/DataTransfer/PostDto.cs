using DataTransfer.Base;
using System;

namespace DataTransfer
{
    public class PostDto : DtoBase
    {
        public string Title { get; set; }
        public DateTime CreateTime { get; set; }
    }
}
