namespace FinalProject.Application.Services.Interfaces
{
    public interface IAuthService
    {
        Task<User> LoginWithHttpContext(string email, string password);
        Task<User> GetCurrentLoggedInUser();
    }
}
