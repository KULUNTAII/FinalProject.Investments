using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Domain.Abstractions
{
    public interface IRepository<TEntity>
    : IReadRepository<TEntity>, IWriteRepository<TEntity>
    where TEntity : Entity;
}
