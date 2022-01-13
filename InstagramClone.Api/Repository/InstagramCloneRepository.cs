using InstagramClone.Api.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Dapper;

namespace InstagramClone.Api.Repository
{
    public class InstagramCloneRepository : IInstagramCloneRepository
    {
        private readonly IDbConnection db;

        public InstagramCloneRepository(IDbConnection db)
        {
            this.db = db;
        }

        public async Task<List<User>> GetUsers()
        {
            return (await db.QueryAsync<User>(
                "SELECT * FROM dbo.Users")).ToList();
        }

        public async Task<User> GetUser(int userId)
        {
            return (await db.QuerySingleAsync<User>(
                "SELECT * FROM dbo.Users WHERE Id = @userId",
                new { userId }));
        }

        public async Task CreateUser(string username, string email, string forename, string surname, int age, decimal rating)
        {
            await db.ExecuteScalarAsync<int>(
                "INSERT INTO dbo.Users (Username, Email, Forename, Surname, Age, Rating) VALUES " +
                                        "(@Username, @Email, @Forename, @Surname, @Age, @Rating)", new
                                        {
                                            username,
                                            email,
                                            forename,
                                            surname,
                                            age,
                                            rating
                                        });
        }

        public async Task<Post> GetPost(int postId)
        {
            return (await db.QuerySingleAsync<Post>(
                "SELECT * FROM dbo.Posts WHERE Id = @postId",
                new { postId }));
        }

        public async Task<List<Post>> GetUserPosts(int userId)
        {
            return (await db.QueryAsync<Post>(
                "SELECT * FROM dbo.Posts WHERE UserId = @userId",
                new { userId })).ToList();
        }

        public async Task CreatePost(int userId, byte[] image, string caption)
        {
            await db.ExecuteScalarAsync<int>(
                "INSERT INTO dbo.Posts (UserId, Image, Caption) VALUES " +
                                        "@UserId, @Image, @Caption)", new
                                        {
                                            userId,
                                            image,
                                            caption
                                        });
        }

        public async Task DeletePost(int postId)
        {
            await db.ExecuteScalarAsync<int>(
                "DELETE FROM dbo.Posts WHERE Id = @postId",
                new { postId });
        }

        public Task<Comment> GetComment(int commentId)
        {
            throw new NotImplementedException();
        }

        public Task<List<Comment>> GetUserComments(int userId)
        {
            throw new NotImplementedException();
        }

        public Task CreateComment(int postId, int authorId, string message)
        {
            throw new NotImplementedException();
        }

        public Task DeleteComment(int commentId)
        {
            throw new NotImplementedException();
        }
    }
}
