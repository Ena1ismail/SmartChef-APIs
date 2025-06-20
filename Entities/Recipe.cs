namespace SmartChef_API.Entities
{
    public class Recipe:ParentEntity
    {
      
        
            public string Name { get; set; }
            public string ImageUrl { get; set; }
            public int CategoryId { get; set; }
        

    }
}
