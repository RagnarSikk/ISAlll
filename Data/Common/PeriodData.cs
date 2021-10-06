using System;

namespace isa3.Data.Common
{
    public abstract class PeriodData : BaseEntity
    {
        public DateTime? From { get; set; }
        public DateTime? To { get; set; }
    }
}