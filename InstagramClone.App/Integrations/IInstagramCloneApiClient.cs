using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InstagramClone.App.Models;

namespace InstagramClone.App.Integrations
{
    public interface IInstagramCloneApiClient
    {
        Task<IEnumerable<User>> GetUsers();
        Task<User> GetUser(int userId);
        Task CreateUser(string username, string email, string forename, string surname, int age, decimal rating);
        //Task<Post> GetPost(int postId);
        //Task<IEnumerable<Post>> GetUserPosts(int userId);
        //Task CreatePost(int userId, byte[] image, string caption);
        //Task DeletePost(int postId);
        //Task<Comment> GetComment(int commentId);
        //Task<IEnumerable<Comment>> GetUserComments(int userId);
        //Task CreateComment(int postId, int authorId, string message);
        //Task DeleteComment(int commentId);
    }
}
