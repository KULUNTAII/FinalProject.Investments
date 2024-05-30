using FinalProject.Domain.Entities;
using FinalProject.Domain.Repositories;
using FinalProject.Infrastructure.Data.Repositories.Abstractions;
using System.Linq.Expressions;

public class UserRepository(AppDbContext dbContext)
    : BaseRepository<User>(dbContext), IUserRepository
    {
    };
