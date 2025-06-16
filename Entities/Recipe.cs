namespace SmartChef_API.Entities
{
    public class Recipe:ParentEntity
    {
      
        
            public string Name { get; set; }
            public string ImageUrl { get; set; }
            public double Rating { get; set; }
            public int Views { get; set; }
            public int CategoryId { get; set; }
        

    }
}
