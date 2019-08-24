using DataTransfer.Base;
using System.Collections.Generic;

namespace DataTransfer
{
    public class TopicTreeDto : DtoBase
    {
        public string Name { get; set; }
        public List<TopicTreeDto> Children { get; set; }
    }
}
