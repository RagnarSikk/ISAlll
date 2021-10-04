using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using isa3.Data.Common;

namespace isa3.Data
{
    public class MembershipData : BaseData
    {
        public string AthleteId { get; set; }
        public string PaymentId { get; set; } //Kas see ei peaks ehk minema PaymentData alla?
        //TODO: Erinevad valikud (3) membershippide vahel
    }
}
