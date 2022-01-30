using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using InstagramClone.Api.Interfaces;
using InstagramClone.Api.Models;
using InstagramClone.Api.Repository;
using Microsoft.Extensions.Logging;

namespace InstagramClone.Api.Domain
{
    public class PostLogic : IPostLogic
    {
        private readonly IInstagramCloneRepository repo;
        private readonly ILogger<PostLogic> logger;
        public PostLogic(IInstagramCloneRepository repo, ILogger<PostLogic> logger)
        {
            this.repo = repo;
            this.logger = logger;
        }
        public async Task<Post> GetPost(int postId)
        {
           return await repo.GetPost(postId);
        }
        public async Task<IEnumerable<Post>> GetUserPosts(int userId)
        {
            return await repo.GetUserPosts(userId);
        }
        public async Task CreatePost(int userId, string imagePath, string caption)
        {
            await repo.CreatePost(userId, imagePath, caption);
        }

        public async Task DeletePost(int postId)
        {
            await repo.DeletePost(postId);
        }
    }
}
