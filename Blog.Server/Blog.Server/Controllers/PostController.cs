using Common.Enums;
using Database;
using DataTransfer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Blog.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostController : ControllerBase
    {
        private readonly BlogContext _context;
        public PostController(BlogContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<PostDto> GetAll(Language language)
        {
            return _context.Posts.Include(p => p.Contents).OrderByDescending(p => p.CreateTime).Select(p => new PostDto
            {
                Id = p.Id,
                Title = p.Contents.SingleOrDefault(pc => pc.Language == language).Title,
                CreateTime = p.CreateTime
            });
        }
    }
}