
namespace isa3.Domain.Common {

    public interface IUniqueEntity : IEntity {

        string Id { get; }

    }

    public interface IUniqueEntity<out TData> : IUniqueEntity, IEntity<TData> { }

}
