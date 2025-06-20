using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SmartChef_API.DTOs.Request;
using SmartChef_API.Interfaces;

namespace SmartChef_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuth _appService;
        public AuthController (IAuth auth)
        {
            _appService = auth;
        }
        [HttpPost("[action]")]
        public async Task<IActionResult> SignUp(SignUpInputDTO input)
        {
            try
            {
                var response = await _appService.SignUp(input);
                return Ok(response);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
