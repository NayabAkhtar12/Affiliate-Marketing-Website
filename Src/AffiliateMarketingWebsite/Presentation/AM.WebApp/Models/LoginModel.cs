﻿namespace AM.WebApp.Models{
    public class LoginModel
    {
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; }= string.Empty;

        public bool Rememberme { get; set; }
    }
}