using isa3.Domain.Others;
using System.Collections.Generic;

namespace isa3.Domain.People {
    public class Nutritionist : PersonRole {
        public List<Service> Services { get; set; }
    }
}
