namespace SmartChef_API.DTOs.Request
{
    public class SignUpInputDTO
    {
        public string Email {  get; set; }
        public string Password { get; set; }
        public string Name  { get; set; }

        public int Age { get; set; }
        public string Gender { get; set; }
    }
}
