using Database.Base;
using System;

namespace Database.Entities
{
    public class Post : IdentifiedEntity<PostContent>
    {
        public DateTime CreateTime { get; set; }
        public string AuthorId { get; set; }

        public Author Author { get; set; }
    }
}
