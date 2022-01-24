using InstagramClone.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InstagramClone.Api.Interfaces
{
    public interface IUserLogic
    {
        Task<IEnumerable<User>> GetUsers();
        Task<User> GetUser(int userId);
        Task CreateUser(string username, string email, string forename, string surname, int age, decimal rating);
        Task UpdateUser(int userId, string username, string email, string forename, string surname, int age, decimal rating);
    }
}
