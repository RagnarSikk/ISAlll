using isa3.Domain.Common;
using System.Collections.Generic;

namespace isa3.Domain.People {
    public class Person : Base {
        public List<PersonRole> Roles { get; }
    }
}
