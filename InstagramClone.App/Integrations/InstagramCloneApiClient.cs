using InstagramClone.App.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace InstagramClone.App.Integrations
{
    public class InstagramCloneApiClient : IInstagramCloneApiClient
    {
        private readonly HttpClient httpClient;

        public InstagramCloneApiClient(HttpClient httpClient, IConfiguration config)
        {
            this.httpClient = httpClient;
            this.httpClient.BaseAddress = new Uri(config.GetValue<string>("InstagramCloneApiUrl"));
        }

        public async Task<IEnumerable<User>> GetUsers()
        {
            var requestUri = "users";

            return await httpClient.GetFromJsonAsync<List<User>>(requestUri);
        }

        public async Task<User> GetUser(int userId)
        {
            var requestUri = "Users/id?userId=" + userId;
            return await httpClient.GetFromJsonAsync<User>(requestUri);
        }

        public async Task CreateUser(string username, string email, string forename, string surname, int age, decimal rating)
        {
            User newUser = new User(username, email, forename, surname, age, rating);
            Console.WriteLine(newUser.Id);
            var requestUri = "Users?username=" + username +
                "&email=" + email +
                "&forename=" + forename +
                "&surname=" + username +
                "&age=" + age +
                "&rating=" + rating;

            await httpClient.PostAsJsonAsync<User>(requestUri, newUser);
        }

        public async Task UpdateUser(int userId, string username, string email, string forename, string surname, int age, decimal rating)
        {
            var requestUri = "Users?userId=" + userId +
                "&username=" + username +
                "&email=" + email +
                "&forename=" + forename +
                "&surname=" + username +
                "&age=" + age +
                "&rating=" + rating;
            Console.WriteLine(requestUri);
            User currentUser = await GetUser(userId);
            await httpClient.PutAsJsonAsync<User>(requestUri, currentUser);
        }
        public async Task<Post> GetPost(int postId)
        {
            var requestUri = "Posts/postId?postId=" + postId;
            return await httpClient.GetFromJsonAsync<Post>(requestUri);
        }
        public async Task<IEnumerable<Post>> GetUserPosts(int userId)
        {
            var requestUri = "Posts/userId?userId=" + userId;
            return await httpClient.GetFromJsonAsync<List<Post>>(requestUri);
        }
        public async Task CreatePost(int userId, string imagePath, string caption)
        {
            var requestUri = "Posts?userId=" + userId + 
                "&imagePath=" + imagePath +
                "&caption=" + caption;
            Post newPost = new Post(userId, imagePath, caption);
            await httpClient.PostAsJsonAsync<Post>(requestUri, newPost);
        }
        public async Task DeletePost(int postId, string imagePath)
        {
            DeleteStoredImage(imagePath);

            var requestUri = "Posts?postId=" + postId;
            await httpClient.DeleteAsync(requestUri);
        }

        public async Task<Comment> GetComment(int commentId)
        {
            var requestUri = "Comments/commentId?commentId=" + commentId;
            return await httpClient.GetFromJsonAsync<Comment>(requestUri);
        }

        public async Task<IEnumerable<Comment>> GetUserComments(int userId)
        {
            var requestUri = "Comments/userId?userId=" + userId;
            return await httpClient.GetFromJsonAsync<List<Comment>>(requestUri);
        }

        public async Task<IEnumerable<Comment>> GetPostComments(int postId)
        {
            var requestUri = "Comments/postId?postId=" + postId;
            return await httpClient.GetFromJsonAsync<List<Comment>>(requestUri);
        }

        public async Task CreateComment(int postId, int authorId, string message)
        {
            Comment newComment = new Comment(postId, authorId, message);

            var requestUri = "Comments?postId=" + postId +
                "&authorId=" + authorId +
                "&message=" + message;

            await httpClient.PostAsJsonAsync<Comment>(requestUri, newComment);
        }

        public async Task DeleteComment(int commentId)
        {
            var requestUri = "Comments?commentId=" + commentId;
            await httpClient.DeleteAsync(requestUri);
        }

        public void DeleteStoredImage(string imagePath)
        {
            string deleteFilePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot//", imagePath);
            File.Delete(deleteFilePath);
        }
    }
}
