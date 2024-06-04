using FinalProject.Application.Services.Interfaces.UnitOfWork;

namespace FinalProject.Infrastructure.Data;

public class UnitOfWork(AppDbContext dbContext) : IUnitOfWork
{
    public Task SaveChangesAsync()
    {
        return dbContext.SaveChangesAsync();
    }


}
