using Database.Base;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Database.Entities
{
    public class Post : IdentifiedEntity<PostContent>
    {
    }
}
