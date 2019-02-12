using Server.Base;
using Server.DataAccess;
using Server.Models;

namespace Server.Controllers
{
    public class VisitorController : BaseController<BlogContext, Visitor>
    {
        public VisitorController(BlogContext context) : base(context, context.Visitor)
        {
        }
    }
}