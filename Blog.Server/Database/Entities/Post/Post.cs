using Database.Base;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Database.Entities
{
    public class Post : IdentifiedEntity<PostContent>
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime CreateTime { get; set; }
        public string AuthorId { get; set; }

        public Author Author { get; set; }
    }
}
