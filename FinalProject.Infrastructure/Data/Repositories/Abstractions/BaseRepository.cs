using FinalProject.Domain.Abstractions;
using FinalProject.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace FinalProject.Infrastructure.Data.Repositories.Abstractions
{
    public class BaseRepository<TEntity> : IRepository<TEntity> where TEntity : Entity
    {
        private readonly AppDbContext _dbContext;

        public BaseRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        protected AppDbContext DbContext => _dbContext;

        public Task<List<TEntity>> GetAllAsync()
        {
            return _dbContext.Set<TEntity>().AsNoTracking().ToListAsync();
        }

        public Task<TEntity?> GetByIdAsync(int id)
        {
            return _dbContext.Set<TEntity>().AsNoTracking()
                .FirstOrDefaultAsync(e => e.Id == id);
        }

        public void Add(TEntity entity)
        {
            _dbContext.Add(entity);
        }

        public void Update(TEntity entity)
        {
            _dbContext.Update(entity);
        }

        public void Remove(TEntity entity)
        {
            _dbContext.Remove(entity);
        }

        public async Task<bool> AnyAsync(Expression<Func<TEntity, bool>> predicate)
        {
            return await _dbContext.Set<TEntity>().AnyAsync(predicate);
        }
    }
}
