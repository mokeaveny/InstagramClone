using InstagramClone.App.Integrations;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InstagramClone.App.Controllers
{
    public class CommentsController : Controller
    {
        private readonly IInstagramCloneApiClient apiClient;

        public CommentsController(IInstagramCloneApiClient apiClient)
        {
            this.apiClient = apiClient;
        }

        public async Task<IActionResult> Index(int postId)
        {
            var comments = await apiClient.GetPostComments(postId);
            return View(comments);
        }
    }
}
