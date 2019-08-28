using Blog.Server.Base;
using Common.Enums;
using DataManager;
using DataTransfer;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Blog.Server.Controllers
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
    }
}