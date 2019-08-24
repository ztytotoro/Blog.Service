using Common.Enums;
using Database.Base;

namespace Database.Entities
{
    public class AuthorInfo : EntityBase
    {
        public string AuthorId { get; set; }
        public string Name { get; set; }
        public Language Language { get; set; }
    }
}
