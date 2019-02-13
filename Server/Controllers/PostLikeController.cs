using Server.Base;
using Server.DataAccess;
using Server.Models;

namespace Server.Controllers
{
    public class PostLikeController : BaseController<BlogContext, PostLike>
    {
        public PostLikeController(BlogContext context) : base(context, context.PostLike)
        {
        }
    }
}