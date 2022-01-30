using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InstagramClone.App.Models
{
    public class Post
    {
        public Post(int userId, string imagePath, string caption)
        {
            this.UserId = userId;
            this.ImagePath = imagePath;
            this.Caption = caption;
        }
        public int Id { get; set; }
        public int UserId { get; set; }
        public string ImagePath { get; set; }
        public string Caption { get; set; }
    }
}
