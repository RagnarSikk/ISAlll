using isa3.Data.Common;
using System.Collections.Generic;

namespace isa3.Data.Others {
    public class MembershipData : BaseData {
        public string Description { get; set; }
        public List<string> Memberships { get; set; }
        // public string PaymentId { get; set; }
        //Kas see ei peaks ehk minema PaymentData alla?
        //TODO: Erinevad valikud (3) membershippide vahel
    }
}
