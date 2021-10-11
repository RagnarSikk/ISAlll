using isa3.Domain.Others;
using System.Collections.Generic;

namespace isa3.Domain.People
{
    public class Athlete : PersonRole
    {
        public List<Training> Trainings { get; set; }
        public List<Service> Services { get; set; }
        public Payment Payment { get; set; }
        public Membership Membership { get; set; }
    }
}
