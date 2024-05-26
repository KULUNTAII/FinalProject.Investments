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
    };
}
