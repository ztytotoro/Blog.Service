using Database.Base;
using System.Collections.Generic;

namespace Database.Entities
{
    public class Author : IdentifiedEntity<AuthorInfo>
    {
        public List<Post> Posts { get; set; }
    }
}
