namespace FinalProject.Application.Services.Interfaces
{
    public interface IAuthService
    {
        Task<User> LoginWithHttpContext(string login, string password);
        Task<User> GetCurrentLoggedInUser();
    }
}
