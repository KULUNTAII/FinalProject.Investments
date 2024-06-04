using FinalProject.Domain.Entities;
using FinalProject.Infrastructure.Data.Repositories.Abstractions;

public class UserRepository(AppDbContext dbContext)
    : BaseRepository<User>(dbContext), IUserRepository
    {
    };
