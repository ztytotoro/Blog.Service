using Database;

namespace DataManager.Base
{
    public class ManagerBase
    {
        protected readonly BlogContext _context;
        public ManagerBase(BlogContext context)
        {
            _context = context;
        }
    }
}
