﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace coreAPIServerProject.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
    }
}
