using Common.Enums;
using DataTransfer;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Blog.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<PostDto> GetAll(Language language)
        {
            return new List<PostDto>();
        }
    }
}