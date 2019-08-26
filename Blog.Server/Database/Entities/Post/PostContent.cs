using Database.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Database.Entities
{
    public class PostContent : I18nEntity
    {
        public string PostId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime LastUpdated { get; set; }

        public List<PostHistory> Histories { get; set; }
    }
}
