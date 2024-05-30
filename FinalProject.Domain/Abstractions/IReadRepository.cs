using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Domain.Abstractions
{
    public interface IReadRepository<TEntity> where TEntity : Entity
    {
        Task<TEntity?> GetByIdAsync(int id);
        Task<List<TEntity>> GetAllAsync();
        Task<bool> AnyAsync(Expression<Func<TEntity, bool>> predicate); // Новый метод

    }
}
