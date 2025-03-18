using Microsoft.EntityFrameworkCore;
using HeroApi.Models;

namespace HeroApi.Data
{
    public class HeroContext : DbContext
    {
        public HeroContext(DbContextOptions<HeroContext> options) : base(options) { }

        public DbSet<Hero> Heroes { get; set; }
    }
}