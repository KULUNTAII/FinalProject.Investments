namespace FinalProject.Application.Services.Interfaces.UnitOfWork;

public interface IUnitOfWork
{
    Task SaveChangesAsync();
}
