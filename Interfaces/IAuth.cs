using SmartChef_API.DTOs.Request;
using SmartChef_API.DTOs.Response;

namespace SmartChef_API.Interfaces
{
    public interface IAuth
    {
        Task<string> SignUp(SignUpInputDTO Input);
        Task<string> LogIn(LogInInputDTO Input);

    }
}
