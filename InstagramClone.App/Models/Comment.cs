using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InstagramClone.App.Models
{
    public class Comment
    {
        public Comment(int postId, int authorId, string message)
        {
            this.PostId = postId;
            this.AuthorId = authorId;
            this.Message = message;
        }
        public int Id { get; set; }
        public int PostId { get; set; }
        public int AuthorId { get; set; }
        public string Message { get; set; }
    }
}
