using Database.Base;
using System.Collections.Generic;

namespace Database.Entities
{
    public class Author : IdentifiedEntity
    {
        public List<AuthorInfo> Infos { get; set; }
        public List<Post> Posts { get; set; }
    }
}
