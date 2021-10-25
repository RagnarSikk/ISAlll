using isa3.Data.Others;
using isa3.Domain.Common;

namespace isa3.Domain.Others {
    public sealed class Membership : DefinedEntity<MembershipData> {
        public Membership(MembershipData d) : base(d) { }
        //public Payment Payment { get; set; }
        //public Athlete Athlete { get; set; }
    }
}
