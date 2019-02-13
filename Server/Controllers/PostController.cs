﻿using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Server.Models;
using Server.DataAccess;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Server.Base;
using System;

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
            return Ok(_table.Include(x => x.PostTags).ThenInclude(x => x.Tag).Include(x => x.VisitRecords).Select(p => new
            {
                p.Id,
                p.Author,
                p.Title,
                p.CreateTime,
                p.LastEditTime,
                CommentsCount = p.Comments.Count,
                VisitCount = p.VisitRecords.Count,
                Tags = p.PostTags.Select(t => t.Tag.Name)
            }).ToList());
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public override ActionResult<Post> Get(int id)
        {
            try
            {
                return Ok(_table.Where(x => x.Id == id).Include(x => x.PostTags).Include(x => x.Comments).Include(x => x.Histories).FirstOrDefault());
            }
            catch (Exception e)
            {
                return NotFound(e.Message);
            }
        }
    }
}
