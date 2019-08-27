using Common.Enums;
using Database;
using Database.Base;
using Database.Entities;
using DataManager.Base;
using DataTransfer;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace DataManager
{
    public class PostManager : ManagerBase
    {
        private readonly TopicManager _topicManager;
        private readonly ColumnManger _columnManger;
        private readonly AuthorManager _authorManager;

        public PostManager(BlogContext context, TopicManager topicManager, ColumnManger columnManger, AuthorManager authorManager) : base(context)
        {
            _topicManager = topicManager;
            _columnManger = columnManger;
            _authorManager = authorManager;
        }

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
            var post = GetPost(id);
            var content = GetPostContent(post, language);

            return new PostDetailDto
            {
                Id = post.Id,
                Title = content.Title,
                CreateTime = post.CreateTime,
                UpdateTime = content.LastUpdated,
                Content = content.Content,
                Author = _authorManager.GetPostAuthor(post.Id, language),
                Column = _columnManger.GetPostColumn(post.Id, language),
                Topics = _topicManager.GetPostTopics(post.Id, language)
            };
        }

        public Post GetPost(string id)
        {
            return _context.Posts
                .Include(p => p.Contents)
                .SingleOrDefault(x => x.Id == id);
        }

        public PostContent GetPostContent(string id, Language language)
        {
            return _context.Posts
                .Include(p => p.Contents)
                .SingleOrDefault(x => x.Id == id).Contents.GetByLanguage(language);
        }

        public PostContent GetPostContent(Post post, Language language)
        {
            return post.Contents.GetByLanguage(language);
        }
    }
}
