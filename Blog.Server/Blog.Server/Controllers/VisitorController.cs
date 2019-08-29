using Blog.Server.Base;
using DataTransfer;
using Microsoft.AspNetCore.Mvc;

namespace Blog.Server.Controllers
{
    public class VisitorController : BaseController
    {
        [HttpPost]
        public IActionResult Visit(VisitDto dto)
        {
            if (dto != null)
            {
                dto.IP = Request.HttpContext.Connection.RemoteIpAddress.ToString();
                return Ok(dto);
            }
            return BadRequest();
        }
    }
}