using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using isa3.Domain.Common;
using isa3.Domain.People;

namespace isa3.Domain
{
    public class Membership : Base
    {
        public Payment Payment { get; set; }
        public Athlete Athlete { get; set; }
    }
}
