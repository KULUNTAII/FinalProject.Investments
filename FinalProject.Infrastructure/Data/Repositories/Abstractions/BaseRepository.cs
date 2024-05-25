using FinalProject.Domain.Abstractions;
using Microsoft.EntityFrameworkCore;

namespace FinalProject.Infrastructure.Data.Repositories.Abstractions
{

    public class BaseRepository<TEntity>(AppDbContext dbContext)
            : IRepository<TEntity> where TEntity : Entity
    {
        protected AppDbContext DbContext => dbContext;

        public Task<List<TEntity>> GetAllAsync()
        {
            return dbContext.Set<TEntity>().AsNoTracking().ToListAsync();
        }

        public Task<TEntity?> GetByIdAsync(int id)
        {
            return dbContext.Set<TEntity>().AsNoTracking()
                .FirstOrDefaultAsync(e => e.Id == id);
        }

        public void Add(TEntity entity)
        {
            dbContext.Add(entity);
        }

        public void Update(TEntity entity)
        {
            dbContext.Update(entity);
        }

        public void Remove(TEntity entity)
        {
            dbContext.Remove(entity);
        }
    }

}
