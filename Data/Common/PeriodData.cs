using System;

namespace isa3.Data.Common {
    public abstract class PeriodData {
        public DateTime? ValidFrom { get; set; }
        public DateTime? ValidTo { get; set; }
    }
}