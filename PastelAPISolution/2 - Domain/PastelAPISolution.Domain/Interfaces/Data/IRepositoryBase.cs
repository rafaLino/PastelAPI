using PastelAPISolution.Domain.Core.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PastelAPISolution.Domain.Interfaces
{
    public interface IRepositoryBase<TEntity> where TEntity : Entity
    {

        Task<int> AddAsync(TEntity entity);

        Task DeleteAsync(TEntity entity);

        Task UpdateAsync(TEntity entity);

        Task<IEnumerable<TEntity>> GetAsync();

        Task<TEntity> GetAsync(int id);

    }
}
