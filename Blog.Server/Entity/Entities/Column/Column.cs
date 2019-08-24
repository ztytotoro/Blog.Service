using Database.Base;
using System.Collections.Generic;
using System.Linq;

namespace Database.Entities
{
    public class Column : IdentifiedEntity
    {
        public List<ColumnInfo> Infos { get; set; }
        private List<PostColumn> PostColumns { get; set; }
        public List<Post> Posts => PostColumns.Select(x => x.Post).ToList();
    }
}
