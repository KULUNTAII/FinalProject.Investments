using FinalProject.Application.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using FinalProject.Application.Contracts;
using SpotiPie.Application.Contracts;
namespace FinalProject.Controllers
{

    [ApiController]
    [Route("api/users")]
    public class UserController(IUserService userService, IAuthService authService) : ControllerBase
    {

        // Logs in a user
        [AllowAnonymous]
        [HttpPost("login")]
        public async Task<IActionResult> Login(UserCredentialsDto loginRequest)
        {
            var user = await authService.LoginWithHttpContext(loginRequest.Email!, loginRequest.Password!);
            return Ok("You logged in!");
        }
        // Retrieves all users (accessible to Admin only)
        //[Authorize(Roles = "Admin")]
        [HttpGet("all")]
        public async Task<IActionResult> GetAll()
        {
            // Retrieve all users asynchronously
            var userDtos = await userService.GetAllAsync().ConfigureAwait(false);

            return Ok(userDtos);
        }

        // Retrieves data of the currently authenticated user
        //[Authorize]
        [HttpGet("my-data")]
        public IActionResult GetUserData()
        {
            var userId = HttpContext.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            if (string.IsNullOrEmpty(userId))
            {
                return Unauthorized("No user ID found.");
            }

            if (!int.TryParse(userId, out int userIdInt))
            {
                return BadRequest("Invalid user ID.");
            }

            var userData = userService.GetUserByIdAsync(userIdInt);

            if (userData == null)
            {
                return NotFound();
            }

            return Ok(userData);
        }

        // Creates a new user (accessible to Admin only)
        //[Authorize(Roles = "Admin")]
        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> Register(UserCreateDto userCreate)
        {
            // Create a new user asynchronously
            var newUser = await userService.CreateUserAsync(userCreate);

            return Ok("Added");
        }
    }

}
