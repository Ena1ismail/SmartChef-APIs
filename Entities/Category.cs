using System.ComponentModel.DataAnnotations;

namespace SmartChef_API.Entities
{
    public class Category:ParentEntity
    {

        [Required, MaxLength(50)]
        public string Name { get; set; }
    }
}
