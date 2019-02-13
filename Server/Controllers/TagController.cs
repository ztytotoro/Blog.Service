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
    public class TagController : BaseController<BlogContext, Tag>
    {
        public TagController(BlogContext context) : base(context, context.Tag)
        {
        }

        [HttpGet]
        public override ActionResult<IEnumerable<Tag>> Get()
        {
            return Ok(_table.Include(x => x.PostTags).ThenInclude(x => x.Post).Select(t => new
            {
                t.Id,
                t.Name,
                Posts = t.PostTags.Select(p => p.Post).ToList()
            }).ToList());
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public override ActionResult<Tag> Get(int id)
        {
            try
            {
                return Ok(_table.Where(x => x.Id == id).Include(x => x.PostTags).ThenInclude(x => x.Post).FirstOrDefault());
            }
            catch (Exception e)
            {
                return NotFound(e.Message);
            }
        }
    }
}