using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using isa3.Domain.Common;
using isa3.Domain.People;

namespace isa3.Domain
{
    public class Service : Base
    {
        public Nutritionist Nutritionist { get; set; }
        public Coach Coach { get; set; }
    }
}
