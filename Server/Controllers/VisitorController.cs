using Microsoft.AspNetCore.Mvc;
using Server.Base;
using Server.DataAccess;
using Server.Models;

namespace Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VisitorController : BaseController<BlogContext, Visitor>
    {
        public VisitorController(BlogContext context) : base(context, context.Visitor)
        {
        }
    }
}