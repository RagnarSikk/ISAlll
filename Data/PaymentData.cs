using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace isa3.Data
{
    public class PaymentData: BaseData
    {
        public decimal Amount { get; set; }
        public DateTime PaymentTime
    }
}
