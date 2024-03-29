﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AM.Data.Models
{
    public class User : EntityBaseAuth<int>
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}