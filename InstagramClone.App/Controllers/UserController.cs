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
    }
}
