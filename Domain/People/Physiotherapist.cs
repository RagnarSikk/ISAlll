using isa3.Domain.Others;
using System.Collections.Generic;
using isa3.Domain.Common;

namespace isa3.Domain.People
{
    public class Physiotherapist : Base
    {
        public List<Service> PhysioServiceList { get; set; }
    }
}