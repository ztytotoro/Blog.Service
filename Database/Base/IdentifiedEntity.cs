using Common.Enums;
using System.Collections.Generic;
using System.Linq;

namespace Database.Base
{
    public abstract class IdentifiedEntity<TInfo> : EntityBase where TInfo : I18nEntity
    {
        public string IdentityName { get; set; }

        public List<TInfo> Contents { get; set; }
    }

    public static class IdentifiedEntity
    {
        public static T GetLocalized<T>(this IEnumerable<T> list, Language language) where T : I18nEntity
        {
            return list.FirstOrDefault(x => x.Language == language) ?? list.FirstOrDefault(x => x.Language == Language.zh_CN);
        }

        public static T GetLocalizedContent<T>(this IdentifiedEntity<T> entity, Language language) where T : I18nEntity
        {
            return entity.Contents.GetLocalized(language);
        }
    }
}
