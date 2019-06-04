namespace Chat.Data
{

using System.Linq;
using System.Threading.Tasks;

    public interface IRepositorioGenerico<T> where T : class
    {
        IQueryable<T> GetAll();
        Task<T> GetByIdAsync(int id);
        Task CreateAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(T entity);
        Task<bool> ExistsAsync(int id);

    }
}
