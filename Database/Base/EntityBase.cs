using System;

namespace Database.Base
{
    public abstract class EntityBase
    {
        public string Id { get; set; }
    }

    public static class EntityExtension
    {
        public static U Map<T, U>(this T entity, Func<T, U> mapper)
        {
            return mapper(entity);
        }
    }
}
