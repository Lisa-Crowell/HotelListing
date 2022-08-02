using HotelListing.API.QueryParameters;

namespace HotelListing.API.Contracts;

public interface IGenericRepository<T> where T : class
{
    Task<T> GetAsync(int? id);
    Task<List<T>> GetAllAsync();
    Task<PagedResult<TResult>> GetAllAsync<TResult>(QueryParameters.QueryParameters queryParameters);
    Task<T> AddAsync(T entity);
    Task UpdateAsync(T entity);
    Task DeleteAsync(int id);
    Task<bool> Exists(int id);
}
