using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinalProject.Domain.Abstractions;
using FinalProject.Domain.Entities;

namespace FinalProject.Domain.Repositories
{
    public interface IProjectRepository : IRepository<Project>
    {
        Task<Project> FindByNameAsync(string name);
        Task<Project> Report(string report);
        Task<Project> Comment(string comment);
        Task<Project> AddToFavorites(string id);
    }
}
