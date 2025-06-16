using Microsoft.EntityFrameworkCore;
using SmartChef_API.Entities;

namespace SmartChef_API.Context
{
    public class SmartChefDBContext:DbContext
    {
        public DbSet<Recipe> Recipe { get; set; }
        public SmartChefDBContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           
        }

    }
}
