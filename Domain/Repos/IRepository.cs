namespace isa3.Domain.Repos
{
    public interface IRepository<T> : ICrudMethods<T>, ISorting, ISearching, IPaging {


    }
}
