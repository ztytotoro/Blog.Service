using Common.Enums;
using System.Collections.Generic;
using System.Linq;

namespace Database.Base
{
    public abstract class I18nEntity : EntityBase
    {
        public Language Language { get; set; }
    }

    public static class I18nEntityExtension {
        public static T GetByLanguage<T>(this IEnumerable<T> list, Language language) where T : I18nEntity
        {
            return list.FirstOrDefault(x => x.Language == language);
        }
    }
}
