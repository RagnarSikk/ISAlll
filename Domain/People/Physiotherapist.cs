using isa3.Domain.Common;
using isa3.Domain.Others;
using System.Collections.Generic;

namespace isa3.Domain.People {
    public class Physiotherapist : Base {
        public List<Service> PhysioServiceList { get; set; }
    }
}