﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.Models
{
    public class Login
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public Role RoleName { get; set; }

        public enum Role { User, Employee, Manager }


    }
}
