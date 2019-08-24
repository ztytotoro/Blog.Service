using Common.Enums;
using Database.Base;

namespace Database.Entities
{
    public class AuthorInfo : I18nEntity
    {
        public string AuthorId { get; set; }
        public string Name { get; set; }
    }
}
