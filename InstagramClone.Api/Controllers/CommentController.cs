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
    public class CommentController : ControllerBase
    {
        private readonly ICommentLogic commentLogic;

        public CommentController(ICommentLogic commentLogic)
        {
            this.commentLogic = commentLogic;
        }

        [HttpGet("commentId")]
        public async Task<Comment> GetComment(int commentId)
        {
            return await commentLogic.GetComment(commentId);
        }

        [HttpGet("userId")]
        public async Task<IEnumerable<Comment>> GetUserComments(int userId)
        {
            return await commentLogic.GetUserComments(userId);
        }

        [HttpPost]
        public async Task CreateComment(int postId, int authorId, string message)
        {
            await commentLogic.CreateComment(postId, authorId, message);
        }

        [HttpDelete("commentId")]
        public async Task DeleteComment(int commentId)
        {
            await commentLogic.DeleteComment(commentId);
        }

    }
}
