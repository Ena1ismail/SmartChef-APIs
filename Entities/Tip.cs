using System.ComponentModel.DataAnnotations;

namespace SmartChef_API.Entities
{
    public class Tip:ParentEntity
    {
        [Required, MaxLength(200)]
        public string Name { get; set; }

        [Required]
        public int RecipeId { get; set; }
    }
}
