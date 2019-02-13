using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Server.Base
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaseController<T, U> : ControllerBase
        where T : DbContext
        where U : BaseEntity
    {
        protected readonly T _context;
        protected readonly DbSet<U> _table;

        public BaseController(T context, DbSet<U> table)
        {
            _context = context;
            _table = table;
        }

        [HttpGet]
        public virtual ActionResult<IEnumerable<U>> Get()
        {
            return Ok(_table.ToList());
        }

        [HttpGet("{id}")]
        public virtual ActionResult<U> Get(int id)
        {
            try
            {
                return Ok(_table.Where(x => x.Id == id).FirstOrDefault());
            }
            catch (Exception e)
            {
                return NotFound(e.Message);
            }
        }

        [Authorize]
        [HttpPost]
        public virtual IActionResult Post(U data)
        {
            try
            {
                _table.Add(data);
                _context.SaveChanges();
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [Authorize]
        [HttpPatch]
        public virtual IActionResult Patch(int id, U data)
        {
            try
            {
                data.Id = id;
                _table.Update(data);
                _context.SaveChanges();
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [Authorize]
        [HttpDelete]
        public virtual IActionResult Delete(int id)
        {
            try
            {
                _table.Remove(_table.Single(t => t.Id == id));
                _context.SaveChanges();
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}