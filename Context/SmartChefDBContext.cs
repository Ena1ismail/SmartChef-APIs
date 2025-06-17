using Microsoft.EntityFrameworkCore;
using SmartChef_API.Entities;

namespace SmartChef_API.Context
{
    public class SmartChefDBContext:DbContext
    {
        public DbSet<Category> Category { get; set; }
        public DbSet<Recipe> Recipe { get; set; }
        public DbSet<Ingredient> Ingredient { get; set; }
        public DbSet<Rating> Rating { get; set; }
        public DbSet<RecipeRequest> RecipeRequest { get; set; }
        public DbSet<RecipeStep> RecipeStep{ get; set; }

        public DbSet<Tip> Tip { get; set; }
        public DbSet<User> User { get; set; }

        public SmartChefDBContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           
        }

    }
}
