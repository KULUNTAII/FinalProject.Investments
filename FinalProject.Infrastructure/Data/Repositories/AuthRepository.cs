using FinalProject.Domain.Entities;
using FinalProject.Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace FinalProject.Infrastructure.Data.Repositories
{
    public class AuthRepository : IAuthRepository
    {
        private readonly AppDbContext _dbContext;

        public AuthRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Task<User?> GetUserByEmailAsync(string email)
        {
            return _dbContext.Users.FirstOrDefaultAsync(u => u.Email == email);
        }
    }
}
