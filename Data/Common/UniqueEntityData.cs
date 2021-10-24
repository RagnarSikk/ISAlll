using System;

namespace isa3.Data.Common {
    public abstract class UniqueEntityData : PeriodData {
        public string Id { get; set; } = Guid.NewGuid().ToString();
    }
}
