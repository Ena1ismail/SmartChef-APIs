using Microsoft.EntityFrameworkCore;
using SmartChef_API.Context;
using SmartChef_API.DTOs.Request;
using SmartChef_API.DTOs.Response;
using SmartChef_API.Entities;
using SmartChef_API.Interfaces;
using SmartChef_API.Helper;
using SmartChef_API.Helper.Validation;


namespace SmartChef_API.Services.AuthServices
{
    public class AuthServices : IAuth
    {
        private readonly SmartChefDBContext _context;
        public AuthServices(SmartChefDBContext dbContext)
        {
            _context = dbContext;
        }
        public Task<string> LogIn(LogInInputDTO Input)
        {
            throw new NotImplementedException();
        }

        public async Task<string> SignUp(SignUpInputDTO Input)
        {
            User person = new User();
            //hashing
            //person.Email = HashingHelper.HashValueWith384(input.Email);
            //person.Password = HashingHelper.HashValueWith384(input.Password);
            //person.UserName = HashingHelper.HashValueWith384(input.Username);
            if (( Validation.IsValidEmail(Input.Email) == false) && ( Validation.IsValidatePassword(Input.Password) == false))
            {
                return "Email or password are not valid ";
            }
            if (Validation.IsValidAge(Input.Age) == false)
            {
                return "ur age must be grather than 16";
            
            }
            if (Validation.IsValidAge(Input.Age) == false)
            {
                return "ur age must be grather than 16";

            }
            if (Validation.IsValidName(Input.Name) == false)
            {
                return "Enter a valid name ";

            }

            {

                person.CreatedBy = "System";
                person.CreationDate = DateTime.Now;
                person.Email = Input.Email;
                person.Age = Input.Age;
                person.Gender = Input.Gender;
                person.PasswordHash = Input.Password;
                person.Name = Input.Name;

                _context.User.Add(person);
                _context.SaveChanges();
                return $"User Regester Successfully +{person.Id}";

            }
        }
    }
}
