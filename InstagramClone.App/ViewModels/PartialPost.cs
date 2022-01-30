using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InstagramClone.App.ViewModels
{
    public class PartialPost
    {
        public int UserId { get; set; }
        public IFormFile ImageFile { get; set; }
        public string Caption { get; set; }
    }
}
