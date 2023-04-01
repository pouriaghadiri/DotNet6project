namespace LeaveManagement.Web.Contracts
{
    public interface IGenericRipository<T> where T : class
    {
        Task<T> GetAsync(int? id);
        Task<List<T>> GetAllAsync();
        Task DeleteAsync(int id);
        Task<T> AddAsync(T entity);
        Task<T> UpdateAsync(T entity);
        Task<bool> Exist(int id);

    }
}
