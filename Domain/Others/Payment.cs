using isa3.Data.Others;
using isa3.Domain.Common;

namespace isa3.Domain.Others {
    public sealed class Payment : NamedEntity<PaymentData> {
        public Payment(PaymentData d) : base(d) { }
        public decimal Cost => Data?.Cost ?? UnspecifiedDecimal;
        public string MembershipId => Data?.MembershipId ?? Unspecified;
        //public Athlete Athlete { get; set; }
    }
}
