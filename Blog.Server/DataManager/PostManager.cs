using Common.Enums;
using Database;
using Database.Base;
using DataManager.Base;
using DataTransfer;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace DataManager
{
    public class PostManager : ManagerBase
    {
        public PostManager(BlogContext context) : base(context) { }

        public IEnumerable<PostDto> GetAllPosts(Language language)
        {
            return _context.Posts.Include(p => p.Contents).OrderByDescending(p => p.CreateTime).Select(p => new PostDto
            {
                Id = p.Id,
                Title = p.Contents.SingleOrDefault(pc => pc.Language == language).Title,
                CreateTime = p.CreateTime
            });
        }

        public PostDetailDto GetPostDetail(string id, Language language)
        {
            var post = _context.Posts.Include(p => p.Contents).SingleOrDefault(x => x.Id == id);
            var content = post.Contents.GetByLanguage(language);
            var column = _context.PostColumns.Include(pc => pc.Column).ThenInclude(c => c.Contents).SingleOrDefault(pc => pc.PostId == post.Id).Column.Contents.GetByLanguage(language);
            var topics = _context.PostTopics.Include(pt => pt.Topic).ThenInclude(t => t.Contents).Where(pt => pt.PostId == post.Id).Select(pt => pt.Topic);
            return new PostDetailDto
            {
                Id = post.Id,
                Title = content.Title,
                CreateTime = post.CreateTime,
                UpdateTime = content.LastUpdated,
                Content = content.Content,
                Author = new AuthorDto
                {
                    Id = post.Author.Id,
                    Name = post.Author.Contents.GetByLanguage(language).Name
                },
                Column = new ColumnDto
                {
                    Id = column.Id,
                    Name = column.Name
                },
                Topics = topics.Select(t => new TopicDto
                {
                    Id = t.Id,
                    Name = t.Contents.GetByLanguage(language).Name
                }).ToList()
            };
        }
    }
}
