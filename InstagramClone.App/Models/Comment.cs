using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InstagramClone.App.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public int PostId { get; set; }
        public int AuthorId { get; set; }
        public string Message { get; set; }
    }
}
