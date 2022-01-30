using InstagramClone.Api.Interfaces;
using InstagramClone.Api.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InstagramClone.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PostsController : ControllerBase
    {
        private readonly IPostLogic postLogic;

        public PostsController(IPostLogic postLogic)
        {
            this.postLogic = postLogic;
        }

        [HttpGet("postId")]
        public async Task<Post> GetPost(int postId)
        {
            return await postLogic.GetPost(postId);
        }

        [HttpGet("userId")]
        public async Task<IEnumerable<Post>> GetUserPosts(int userId)
        {
            return await postLogic.GetUserPosts(userId);
        }

        [HttpPost]
        public async Task CreatePost(int userId, string imagePath, string caption)
        {
            await postLogic.CreatePost(userId, imagePath, caption);
        }

        [HttpDelete]
        public async Task DeletePost(int postId)
        {
            await postLogic.DeletePost(postId);
        }
    }
}
