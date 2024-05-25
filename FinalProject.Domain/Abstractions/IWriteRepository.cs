using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Domain.Abstractions
{
    public interface IWriteRepository<TEntity> where TEntity : Entity
    {
        void Add(TEntity genre);
        void Update(TEntity genre);
        void Remove(TEntity genre);
    }

}
