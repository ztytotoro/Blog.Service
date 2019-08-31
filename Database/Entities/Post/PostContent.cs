using Database.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Database.Entities
{
    public class PostContent : I18nEntity
    {
        /// <summary>
        /// Post Id
        /// </summary>
        public string PostId { get; set; }
        public string AuthorId { get; set; }
        /// <summary>
        /// Post Create Time
        /// </summary>
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime CreateTime { get; set; }
        /// <summary>
        /// Post Version
        /// </summary>
        public int Version { get; set; }
        /// <summary>
        /// Post Title
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// Post Content
        /// </summary>
        public string Content { get; set; }
        /// <summary>
        /// Post Last Update Time
        /// </summary>
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime LastUpdated { get; set; }

        public Author Author { get; set; }
        public List<PostHistory> Histories { get; set; }
    }
}
