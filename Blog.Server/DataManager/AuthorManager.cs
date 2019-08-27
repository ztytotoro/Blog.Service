using Common.Enums;
using Database;
using Database.Base;
using DataManager.Base;
using DataTransfer;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace DataManager
{
    public class AuthorManager : ManagerBase
    {
        public AuthorManager(BlogContext context) : base(context) { }

        public AuthorDto GetPostAuthor(string postId, Language language)
        {
            return _context.Posts.Include(p => p.Author).SingleOrDefault(p => p.Id == postId).Author.Map(a => new AuthorDto
            {
                Id = a.Id,
                Name = a.Contents.GetByLanguage(language).Name
            });
        }
    }
}
