using isa3.Domain.Common;
using isa3.Domain.People;

namespace isa3.Domain.Others {
    public class Membership : Base {
        public Payment Payment { get; set; }
        public Athlete Athlete { get; set; }
    }
}
