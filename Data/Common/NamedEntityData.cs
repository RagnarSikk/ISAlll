using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace isa3.Data.Common
{
    public abstract class NamedEntityData : UniqueEntityData, IUniqueNamedData
    {
        public string Code { get; set; }
        public string Name { get; set; }
    }
}
