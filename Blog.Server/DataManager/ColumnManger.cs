using Common.Enums;
using Database;
using Database.Base;
using DataManager.Base;
using DataTransfer;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace DataManager
{
    public class ColumnManger : ManagerBase
    {
        public ColumnManger(BlogContext context) : base(context) { }

        public ColumnDto GetPostColumn(string postId, Language language)
        {
            return _context.PostColumns
                .Include(pc => pc.Column)
                    .ThenInclude(c => c.Contents)
                .SingleOrDefault(pc => pc.PostId == postId).Column.Contents.GetByLanguage(language).Map(c => new ColumnDto
                {
                    Id = c.Id,
                    Name = c.Name
                });
        }
    }
}
