
using FinalProject.Domain.Entities;
using FinalProject.Domain.Repositories;
using System.Data.Entity;

namespace FinalProject.Infrastructure.Data.Repositories;

public class UserRepository(AppDbContext dbContext) : IUserRepository
{
    public void Add(User user)
    {
        dbContext.Users.Add(user);
    }

    public Task<User?> GetByLoginAsync(string login)
    {
        return dbContext.Users
            .AsNoTracking()
            .FirstOrDefaultAsync(u => u.Login == login);
    }
}
