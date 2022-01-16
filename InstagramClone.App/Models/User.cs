﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InstagramClone.App.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Forename { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public decimal Rating { get; set; }
    }
}
