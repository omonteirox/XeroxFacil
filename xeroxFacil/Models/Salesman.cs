﻿namespace xeroxFacil.Models
{
    public class Salesman : Entity
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public Salesman(string name, string email, string password)
        {
            Name = name;
            Email = email;
            Password = password;
        }
    }
}