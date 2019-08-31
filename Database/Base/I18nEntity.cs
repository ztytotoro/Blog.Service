using Common.Enums;

namespace Database.Base
{
    public abstract class I18nEntity : EntityBase
    {
        public Language Language { get; set; }
    }
}
