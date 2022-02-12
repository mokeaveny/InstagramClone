using InstagramClone.App.Integrations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InstagramClone.App.Controllers
{
    public class UserController : Controller
    {
        private readonly IInstagramCloneApiClient apiClient;

        public UserController(IInstagramCloneApiClient apiClient)
        {
            this.apiClient = apiClient;
        }

        public async Task<IActionResult> Index()
        {
            var users = await apiClient.GetUsers();
            return View(users);
        }

        public async Task<IActionResult> Details(int userId)
        {
            var user = await apiClient.GetUser(userId);
            return View(user);
        }

        public async Task<IActionResult> Edit(int userId)
        {
            var user = await apiClient.GetUser(userId);
            return View(user);
        }

        public IActionResult CreatePage()
        {
            return View();
        }

        public async Task Create(string username, string email, string forename, string surname, int age, decimal rating)
        {
            await apiClient.CreateUser(username, email, forename, surname, age, rating);
        }

        public async Task Update(int userId, string username, string email, string forename, string surname, int age, decimal rating)
        {
            await apiClient.UpdateUser(userId, username, email, forename, surname, age, rating);
        }
    }
}