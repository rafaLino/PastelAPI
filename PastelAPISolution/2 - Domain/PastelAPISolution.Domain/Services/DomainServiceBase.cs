using PastelAPISolution.Domain.Core.Models;
using PastelAPISolution.Domain.Interfaces;
using PastelAPISolution.Domain.Interfaces.Service;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PastelAPISolution.Domain.Services
{
    public abstract class DomainServiceBase<TEntity> : IDomainServiceBase<TEntity> where TEntity : Entity
    {
        private IRepositoryBase<TEntity> _repository;

        public DomainServiceBase(IRepositoryBase<TEntity> repository)
        {
            _repository = repository;
        }

        public virtual async Task<int> AddAsync(TEntity entity)
        {
          return await _repository.AddAsync(entity);
            
            
        }

        public virtual async Task DeleteAsync(TEntity entity)
        {
            await _repository.DeleteAsync(entity);
        }

        public virtual async Task<IEnumerable<TEntity>> GetAsync()
        {
           return await _repository.GetAsync();
        }

        public virtual async Task<TEntity> GetAsync(int id)
        {
            return await _repository.GetAsync(id);
        }

        public virtual async Task UpdateAsync(TEntity entity)
        {
            await _repository.UpdateAsync(entity);
        }
    }
}
