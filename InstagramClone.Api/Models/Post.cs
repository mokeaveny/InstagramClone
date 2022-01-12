using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InstagramClone.Api.Models
{
    public class Post
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public byte[] Image { get; set; }
        public string Caption { get; set; }
    }
}
