using FinalProject.Application.Services;
using FinalProject.Application.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SpotiPie.Application.Contracts;
using System.Security.Claims;
using FinalProject.Domain.Entities;
using FinalProject.Application.Contracts;
namespace FinalProject.Controllers
{

    [ApiController]
    [Route("api/user")]
    public class UserController(IUserService userService, IAuthService authService) : ControllerBase
    {

        // Logs in a user
        [AllowAnonymous]
        [HttpPost("login")]
        public async Task<IActionResult> Login(string email, string password)
        {
            // Attempt to log in with provided email and password
            var user = await authService.LoginWithHttpContext(email, password);
            return Ok("You logged in!");
        }

        // Retrieves all users (accessible to Admin only)
        [Authorize(Roles = "Admin")]
        [HttpGet("all")]
        public async Task<IActionResult> GetAll()
        {
            // Retrieve all users asynchronously
            var userDtos = await userService.GetAllAsync().ConfigureAwait(false);

            return Ok(userDtos);
        }

        // Retrieves data of the currently authenticated user
        [Authorize]
        [HttpGet("my-data")]
        public IActionResult GetUserData()
        {
            // Retrieve user data for the current user
            var userId = HttpContext.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            if (string.IsNullOrEmpty(userId))
            {
                return Unauthorized("no");
            }

            var userData = userService.GetUserByIdAsync(userId);

            if (userData == null)
            {
                return NotFound();
            }

            return Ok(userData);
        }

        // Creates a new user (accessible to Admin only)
        [Authorize(Roles = "Admin")]
        [HttpPost]
        public async Task<IActionResult> CreateUser(UserCreateDto userCreate)
        {
            // Create a new user asynchronously
            var newUser = await userService.CreateUserAsync(userCreate);

            return Ok("Added");
        }
    }

}
