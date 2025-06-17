using System.ComponentModel.DataAnnotations;

namespace SmartChef_API.Entities
{
    public class RecipeRequest:ParentEntity
    {
        [Required, MaxLength(100)]
        public string Name { get; set; }

        [MaxLength(300)]
        public string? Description { get; set; }

        [MaxLength(255)]
        public string? ImageUrl { get; set; }

        [Required]
        public int CategoryId { get; set; }

        [Required]
        public int UserId { get; set; }

    }
}
