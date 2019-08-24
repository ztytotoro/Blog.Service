using System.ComponentModel.DataAnnotations;

namespace Database.Entities
{
    public class PostColumn
    {
        [Key]
        public string ColumnId { get; set; }
        public string PostId { get; set; }

        public Column Column { get; set; }

        public Post Post { get; set; }
    }
}
