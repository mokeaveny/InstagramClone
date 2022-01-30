using InstagramClone.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InstagramClone.Api.Interfaces
{
    public interface IPostLogic
    {
        Task<Post> GetPost(int postId);
        Task<IEnumerable<Post>> GetUserPosts(int userId);
        Task CreatePost(int userId, string imagePath, string caption);
        Task DeletePost(int postId);
    }
}
