using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace isa3.Data.Common
{
    public abstract class UniqueEntityData : PeriodData
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
    }
}
