using isa3.Domain.Common;
using isa3.Domain.Others;
using System.Collections.Generic;

namespace isa3.Domain.People {
    public class Therapist : Base {
        public List<Service> TherapistServiceList { get; set; }
    }
}