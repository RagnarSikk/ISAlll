using isa3.Data.Common;
using System;

namespace isa3.Domain.Common {

    public abstract class Entity<TData> : ValueObject<TData>, IEntity<TData> where TData : PeriodData, new() {


        protected internal Entity(TData d = null) : base(d) { }

        public virtual DateTime ValidFrom => Data?.ValidFrom ?? UnspecifiedValidFrom;

        public virtual DateTime ValidTo => Data?.ValidTo ?? UnspecifiedValidTo;
    }

}
