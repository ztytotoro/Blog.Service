using Common.Enums;
using Database.Base;

namespace Database.Entities
{
    public class ColumnInfo : I18nEntity
    {
        public string ColumnId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
