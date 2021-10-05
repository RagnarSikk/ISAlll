using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using isa3.Domain.Common;
using isa3.Domain.People;

namespace isa3.Domain.Others
{
    public class Payment : Base
    {
        public Athlete Athlete { get; set; }
    }
}
