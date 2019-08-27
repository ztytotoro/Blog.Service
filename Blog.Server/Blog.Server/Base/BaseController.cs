using Database;
using Microsoft.AspNetCore.Mvc;

namespace Blog.Server.Base
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaseController : ControllerBase
    {
        protected readonly BlogContext _context;
        public BaseController(BlogContext context)
        {
            _context = context;
        }
    }
}
