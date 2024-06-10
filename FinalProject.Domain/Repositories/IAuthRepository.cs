using FinalProject.Domain.Entities;

namespace FinalProject.Domain.Repositories
{
    public interface IAuthRepository
    {
        Task<User?> GetUserByLoginAsync(string email);
    }
}
