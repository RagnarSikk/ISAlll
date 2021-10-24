using System.Collections.Generic;
using System.Threading.Tasks;

namespace isa3.Domain.Repos
{
    public interface ICrudMethods<T>
    {
        Task<List<T>> Get();
        Task<T> Get(string id);
        Task Delete(string id);
        Task Add(T obj);
        Task Update(T obj);
    }
}