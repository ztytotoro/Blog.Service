using Database.Base;
using System;
using System.Collections.Generic;

namespace Database.Entities
{
    // TODO: Use generic to describe entities that contains i18n content and create a base entity for i18n content like entities
    public class Post : IdentifiedEntity
    {
        public DateTime CreateTime { get; set; }
        public string AuthorId { get; set; }

        public Author Author { get; set; }

        public List<PostContent> Contents { get; set; }
    }
}
