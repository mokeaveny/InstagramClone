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
    public class UserLogic : IUserLogic
    {
        private readonly IInstagramCloneRepository repo;
        private readonly ILogger<UserLogic> logger;
        public UserLogic(IInstagramCloneRepository repo, ILogger<UserLogic> logger)
        {
            this.repo = repo;
            this.logger = logger;
        }
        public async Task<IEnumerable<User>> GetUsers()
        {
            logger.LogInformation("Getting Users...");

            return await repo.GetUsers();
        }
        public async Task<User> GetUser(int userId)
        {
            logger.LogInformation("Getting User with userId = " + userId);

            return await repo.GetUser(userId);
        }
        public async Task CreateUser(string username, string email, string forename, string surname, int age, decimal rating)
        {
            logger.LogInformation("Creating a new user!");

            await repo.CreateUser(username, email, forename, surname, age, rating);
        }
        public async Task UpdateUser(int userId, string username, string email, string forename, string surname, int age, decimal rating)
        {
            logger.LogInformation("Updating the user!");
            await repo.UpdateUser(userId, username, email, forename, surname, age, rating);
        }
    }
}
