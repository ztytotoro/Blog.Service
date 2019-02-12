using Server.Base;
using Server.DataAccess;
using Server.Models;

namespace Server.Controllers
{
    public class PostHistory : BaseController<BlogContext, Visitor>
    {
        public PostHistory(BlogContext context) : base(context, context.Visitor)
        {
        }
    }
}