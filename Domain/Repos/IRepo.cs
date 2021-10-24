using System.Collections.Generic;
using System.Threading.Tasks;


namespace isa3.Domain.Repos {
    public interface IRepo<T> {
        Task<List<T>> Get();
        Task<T> Get(int? id);
        Task Delete(int? id);
        Task Add(T obj);
        Task Update(T obj);
        T GetById(int? id);
    }
}
