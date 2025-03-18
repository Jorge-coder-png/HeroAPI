﻿namespace HeroApi.Models
{
    public class Hero
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string HeroName { get; set; } = string.Empty;
        public string? City { get; set; }
        public int? Age { get; set; }
    }
}