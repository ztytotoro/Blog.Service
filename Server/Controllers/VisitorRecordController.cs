using Server.Base;
using Server.DataAccess;
using Server.Models;

namespace Server.Controllers
{
    public class VisitorRecordController : BaseController<BlogContext, VisitRecord>
    {
        public VisitorRecordController(BlogContext context) : base(context, context.VisitRecord)
        {
        }
    }
}