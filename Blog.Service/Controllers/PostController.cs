using Blog.Service.Base;
using Common.Enums;
using DataManager;
using DataTransfer;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Blog.Service.Controllers
{
    public class PostController : BaseController
    {
        private readonly PostManager _postManager;

        public PostController(PostManager postManager)
        {
            _postManager = postManager;
        }

        [HttpGet]
        public IEnumerable<PostDto> GetAll(Language language)
        {
            return _postManager.GetAllPosts(language);
        }

        [HttpPost]
        public IActionResult AddPost(AddPostDto dto)
        {
            return Ok(dto);
        }

        [HttpPost("Content")]
        public IActionResult AddPostContent(AddPostContentDto dto)
        {
            return Ok(dto);
        }
    }
}