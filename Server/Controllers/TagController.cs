using Server.Base;
using Server.DataAccess;
using Server.Models;

namespace Server.Controllers
{
    public class TagController : BaseController<BlogContext, Tag>
    {
        public TagController(BlogContext context) : base(context, context.Tag)
        {
        }
    }
}