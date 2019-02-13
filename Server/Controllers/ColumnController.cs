using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Server.Base;
using Server.DataAccess;
using Server.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Server.Controllers
{
    public class ColumnController : BaseController<BlogContext, Column>
    {
        public ColumnController(BlogContext context) : base(context, context.Column)
        {
        }

        [HttpGet]
        public override ActionResult<IEnumerable<Column>> Get()
        {
            return Ok(_table.Include(x => x.Posts).ToList());
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public override ActionResult<Column> Get(int id)
        {
            try
            {
                return Ok(_table.Where(x => x.Id == id).Include(x => x.Posts).FirstOrDefault());
            }
            catch (Exception e)
            {
                return NotFound(e.Message);
            }
        }
    }
}