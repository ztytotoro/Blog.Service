using Database.Base;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Database.Entities
{
    public class PostHistory : EntityBase
    {
        public string PostContentId { get; set; }
        public int Version { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime EditTime { get; set; }
        public string EditorId { get; set; }

        public Author Editor { get; set; }
    }
}
