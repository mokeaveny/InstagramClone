using InstagramClone.App.Integrations;
using InstagramClone.App.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace InstagramClone.App.Controllers
{
    public class PostsController : Controller
    {
        private readonly IInstagramCloneApiClient apiClient;

        public PostsController(IInstagramCloneApiClient apiClient)
        {
            this.apiClient = apiClient;
        }

        public async Task<IActionResult> Index(int userId)
        {
            var posts = await apiClient.GetUserPosts(userId);
            if (posts.Any() == false)
            {
                return Redirect("Posts/NoPosts");
            }
            else
            {
                return View(posts);
            }
        }

        public IActionResult CreatePage(int userId)
        {
            PartialPost newPost = new PartialPost();
            newPost.UserId = userId;
            return View(newPost);
        }
        public async Task Create(int userId, IFormFile imageFile, string caption)
        {
            await uploadFile(imageFile);

            string uploadedDBPath = "images//" + Path.GetFileName(imageFile.FileName);
            await apiClient.CreatePost(userId, uploadedDBPath, caption);
        }

        public async Task Delete(int postId, string imagePath)
        {
            await apiClient.DeletePost(postId, imagePath);
        }

        public async Task uploadFile(IFormFile imageFile)
        {
            string fileName = Path.GetFileName(imageFile.FileName);
            string uploadFilePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot//images", fileName);
            var fileStream = new FileStream(uploadFilePath, FileMode.Create);
            await imageFile.CopyToAsync(fileStream);
        }

        public IActionResult NoPosts()
        {
            return View();
        }
    }
}
