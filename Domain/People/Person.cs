using System.Collections.Generic;
using isa3.Domain.Common;

namespace isa3.Domain.People
{
    public class Person : Base
    {
        public List<PersonRole> Roles { get; }
    }
}
