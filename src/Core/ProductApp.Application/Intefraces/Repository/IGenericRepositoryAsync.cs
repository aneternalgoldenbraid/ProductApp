using ProductApp.Domain.Common;

namespace ProductApp.Application.Intefraces.Repository
{
    public interface IGenericRepositoryAsync<T> where T : BaseEntity 
    {
        Task<List<T>> GetAllAsync();

        Task<T> GetByIdAysyn(Guid id);

        Task<T> AddAsync(T entity);
    }
}
