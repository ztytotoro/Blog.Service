using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Server.Model;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Server.Controllers
{
    [Route("api/[controller]")]
    public class PostController : Controller
    {
        // GET: api/<controller>
        [HttpGet]
        public IEnumerable<Post> Get()
        {
            return new Post[] {
                new Post
                {
                    Id = 0,
                    Title = "Hello World!",
                    Author = "Yarn",
                    Content = ""
                },
                new Post
                {
                    Id = 1,
                    Title = "Primary C++",
                    Author = "Yarn",
                    Content = ""
                }
            };
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
