using FinalProject.Domain.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Authentication;
using System.Security.Claims;

namespace FinalProject.Application.Services
{
    public class AuthService : IAuthService
    {
        private readonly IAuthRepository _authRepository;
        private readonly IPasswordManager _passwordManager;
        private readonly HttpContext _httpContext;

        public AuthService(IAuthRepository authRepository, IHttpContextAccessor accessor, IPasswordManager passwordManager)
        {
            _authRepository = authRepository;

            if (accessor.HttpContext is null)
            {
                throw new ArgumentException(nameof(accessor.HttpContext));
            }

            _httpContext = accessor.HttpContext;
            _passwordManager = passwordManager;
        }

        public async Task<User> LoginWithHttpContext(string email, string password)
        {
            var user = await _authRepository.GetUserByEmailAsync(email);
            if (user == null)
            {
                throw new UnauthorizedAccessException("Invalid email or password");
            }

            if (!_passwordManager.VerifyPassword(password, user.PasswordHash))
            {
                throw new UnauthorizedAccessException("Invalid email or password");
            }

            var claims = new Claim[]
            {
        new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
        new Claim(ClaimTypes.Email, user.Email),
        new Claim(ClaimTypes.Role, user.Role.ToString()),
            };

            var identity = new ClaimsIdentity(claims, "Cookies");
            var principal = new ClaimsPrincipal(identity);

            await _httpContext.SignInAsync(principal);

            return user;
        }
    }
}
