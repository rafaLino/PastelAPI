using System.Collections.Generic;
using System.Threading.Tasks;

namespace PastelAPISolution.Application.Service.Interfaces
{
    public interface IApplicationServiceBase<TViewModel, TInput> where TViewModel : class where TInput : class
    {

        Task<int> AddAsync(TInput input);

        Task DeleteAsync(int id);

        Task UpdateAsync(int id, TInput input);

        Task<IEnumerable<TViewModel>> GetAsync();

        Task<TViewModel> GetAsync(int id);
    }
}
