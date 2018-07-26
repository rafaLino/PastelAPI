
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using PastelAPISolution.Application.Service.Interfaces;
using PastelAPISolution.Domain.Core.Models;
using PastelAPISolution.Domain.Interfaces.Service;

namespace PastelAPISolution.Application.Service.Services
{
    public abstract class ApplicationServiceBase<TEntity, TViewModel, TInput> : IApplicationServiceBase<TViewModel, TInput>
         where TEntity : Entity
        where TViewModel : class
        where TInput : class
    {

        private IDomainServiceBase<TEntity> _domainService;

        public ApplicationServiceBase(IDomainServiceBase<TEntity> domainService)
        {
            _domainService = domainService;
        }

        public virtual async Task<int> AddAsync(TInput input)
        {
            var entity = Mapper.Map<TEntity>(input);

           int id = await _domainService.AddAsync(entity);

            return id;
        }

        public virtual async Task DeleteAsync(int id)
        {
            var entityViewModel = GetAsync(id);

            var entity = Mapper.Map<TEntity>(entityViewModel);

            await _domainService.DeleteAsync(entity);
        }

        public virtual async Task<IEnumerable<TViewModel>> GetAsync()
        {
            var entities = await _domainService.GetAsync();
            return Mapper.Map<IEnumerable<TViewModel>>(entities);
        }

        public virtual async Task<TViewModel> GetAsync(int id)
        {
            var entity = await _domainService.GetAsync(id);

            return Mapper.Map<TViewModel>(entity);
        }

        public virtual async Task UpdateAsync(int id, TInput input)
        {
            var entity = Mapper.Map<TEntity>(input);
            entity.Id = id;
            await _domainService.UpdateAsync(entity);


        }
    }
}
