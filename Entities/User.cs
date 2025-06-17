using System.ComponentModel.DataAnnotations;

namespace SmartChef_API.Entities
{
    public class User:ParentEntity
    {
        [Required, MaxLength(100)]
        public string Name { get; set; }

        [Required, MaxLength(150), EmailAddress]
        public string Email { get; set; }

        [Required]
        public string PasswordHash { get; set; }

        [Range(1, 80)]
        public int Age { get; set; }

        [Required, MaxLength(10)]
        public string Gender { get; set; }
    }
}
