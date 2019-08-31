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
    public class TopicManager : ManagerBase
    {
        public TopicManager(BlogContext context) : base(context) { }

        public List<TopicDto> GetPostTopics(string postId, Language language)
        {
            return _context.PostTopics.Where(pt => pt.PostId == postId).Include(pt => pt.Topic).Select(pt => new TopicDto
            {
                Id = pt.Topic.Id,
                Name = pt.Topic.GetLocalizedContent(language).Name
            }).ToList();
        }
    }
}
