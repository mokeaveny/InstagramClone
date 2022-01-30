using InstagramClone.Api.Interfaces;
using InstagramClone.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InstagramClone.Api.Repository;
using Microsoft.Extensions.Logging;

namespace InstagramClone.Api.Domain
{
    public class CommentLogic : ICommentLogic
    {
        private readonly IInstagramCloneRepository repo;
        private readonly ILogger<CommentLogic> logger;
        public CommentLogic(IInstagramCloneRepository repo, ILogger<CommentLogic> logger)
        {
            this.repo = repo;
            this.logger = logger;
        }
        public async Task<Comment> GetComment(int commentId)
        {
            return await repo.GetComment(commentId);
        }
        public async Task<IEnumerable<Comment>> GetUserComments(int userId)
        {
            return await repo.GetUserComments(userId);
        }
        public async Task<IEnumerable<Comment>> GetPostComments(int postId)
        {
            return await repo.GetPostComments(postId);
        }
        public async Task CreateComment(int postId, int authorId, string message)
        {
            await repo.CreateComment(postId, authorId, message);
        }

        public async Task DeleteComment(int commentId)
        {
            await repo.DeleteComment(commentId);
        }
    }
}
