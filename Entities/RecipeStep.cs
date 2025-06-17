using System.ComponentModel.DataAnnotations;

namespace SmartChef_API.Entities
{
    public class RecipeStep:ParentEntity
    {
        [Required, MaxLength(300)]
        public string Description { get; set; }

        [Range(1, int.MaxValue)]
        public int Order { get; set; }

        [Required]
        public int RecipeId { get; set; }
    }
}
