using Microsoft.EntityFrameworkCore.Query;
using System.Collections.Generic;

namespace Database.Base
{
    public abstract class IdentifiedEntity<TInfo> : EntityBase where TInfo : I18nEntity
    {
        public string IdentityName { get; set; }

        public List<TInfo> Contents { get; set; }
    }
}
