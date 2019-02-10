using Server.Base;
using Server.DataAccess;
using Server.Models;

namespace Server.Controllers
{
    public class CommentController : BaseController<BlogContext, Comment>
    {
        public CommentController(BlogContext context) : base(context, context.Comment)
        {
        }
    }
}