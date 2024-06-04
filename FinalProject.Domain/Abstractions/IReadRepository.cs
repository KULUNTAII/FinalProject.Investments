using System.Linq.Expressions;

namespace FinalProject.Domain.Abstractions
{
    public interface IReadRepository<TEntity> where TEntity : Entity
    {
        Task<TEntity?> GetByIdAsync(int id);
        Task<List<TEntity>> GetAllAsync();
        Task<bool> AnyAsync(Expression<Func<TEntity, bool>> predicate); // Новый метод

    }
}
