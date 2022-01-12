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
    public class UserController : ControllerBase
    {
        private readonly IUserLogic userLogic;

        public UserController(IUserLogic userLogic)
        {
            this.userLogic = userLogic;
        }

        [HttpGet]
        public async Task<IEnumerable<User>> GetUsers()
        {
            return await userLogic.GetUsers();
        }

        [HttpGet("id")]
        public async Task<User> GetUser(int userId)
        {
            return await userLogic.GetUser(userId);
        }

        [HttpPost]
        public async Task CreateUser(string username, string email, string forename, string surname, int age, decimal rating)
        {
            await userLogic.CreateUser(username, email, forename, surname, age, rating);
        }
    }
}
