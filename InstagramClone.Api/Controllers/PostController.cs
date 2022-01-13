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
    public class PostController : ControllerBase
    {
        private readonly IPostLogic postLogic;

        public PostController(IPostLogic postLogic)
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
        public async Task CreatePost(int userId, string image, string caption)
        {
            byte[] imageByteFormat = Convert.FromBase64String(image);
            await postLogic.CreatePost(userId, imageByteFormat, caption);
        }

        [HttpDelete]
        public async Task DeletePost(int postId)
        {
            await postLogic.DeletePost(postId);
        }
    }
}
