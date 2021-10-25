using isa3.Data.Common;

namespace isa3.Domain.Common {

    public abstract class UniqueEntity<T> : Entity<T>, IUniqueEntity<T> where T : UniqueEntityData, new() {

        protected internal UniqueEntity(T d = null) : base(d) { }

        public virtual string Id => Data?.Id ?? Unspecified;
    }
}
