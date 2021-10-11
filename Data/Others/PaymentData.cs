using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using isa3.Data.Common;

namespace isa3.Data.Others
{
    public class PaymentData : BaseData
    {
        public decimal Cost { get; set; }
        public string MembershipId { get; set; } //foreign key 
        //TODO: mis propertyd veel võiksid olla? ja kuidas see ülde hakkab välja nägema
    }
}
