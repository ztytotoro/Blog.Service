using Common.Enums;
using Database.Base;

namespace Database.Entities
{
    public class ColumnInfo : EntityBase
    {
        public string ColumnId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Language Language { get; set; }
    }
}
