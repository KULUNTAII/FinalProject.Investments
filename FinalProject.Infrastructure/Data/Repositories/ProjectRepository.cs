using FinalProject.Domain.Entities;
using FinalProject.Domain.Repositories;
using FinalProject.Infrastructure.Data.Repositories.Abstractions;

namespace FinalProject.Infrastructure.Data.Repositories
{
    public class ProjectRepository(AppDbContext dbContext)
    : BaseRepository<Project>(dbContext), IProjectRepository
    {
    };
}
