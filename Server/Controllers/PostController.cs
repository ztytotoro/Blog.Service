using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Server.Models;
using Server.DataAccess;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Server.Base;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Server.Controllers
{
    public class PostController : BaseController<BlogContext, Post>
    {
        public PostController(BlogContext context) : base(context, context.Post)
        {
        }
        // GET: api/<controller>
        [HttpGet]
        public override ActionResult<IEnumerable<Post>> Get()
        {
            return Ok(_table.Include(x => x.Tags).ToList());
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public override ActionResult<Post> Get(int id)
        {
            return Ok(_table.Where(x => x.Id == id).Include(x => x.Tags).Include(x => x.Comments).Include(x => x.Histories).FirstOrDefault());
        }
    }
}
