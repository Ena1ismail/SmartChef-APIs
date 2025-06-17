using System.ComponentModel.DataAnnotations;

namespace SmartChef_API.Entities
{
    public class Rating:ParentEntity
    {
        [Required]
        public int UserId { get; set; }

        [Required]
        public  int  RecipeId { get; set; }

        [Range(1, 5)]
        public int? Stars { get; set; }
    }
}
