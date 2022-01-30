using InstagramClone.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InstagramClone.Api.Repository
{
    public interface IInstagramCloneRepository
    {
        Task<List<User>> GetUsers();
        Task<User> GetUser(int userId);
        Task CreateUser(string username, string email, string forename, string surname, int age, decimal rating);
        Task UpdateUser(int userId, string username, string email, string forename, string surname, int age, decimal rating);
        Task<Post> GetPost(int postId);
        Task<List<Post>> GetUserPosts(int userId);
        Task CreatePost(int userId, string imagePath, string caption);
        Task DeletePost(int postId);
        Task<Comment> GetComment(int commentId);
        Task<List<Comment>> GetUserComments(int userId);
        Task CreateComment(int postId, int authorId, string message);
        Task DeleteComment(int commentId);
    }
}
