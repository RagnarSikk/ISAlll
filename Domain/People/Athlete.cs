using System.Collections.Generic;

namespace isa3.Domain.People
{
    public class Athlete : PersonRole
    {
        public List<Training> Trainings { get; }
        public List<Service> Services { get; }
        public Payment Payment { get; set; }
        public Membership Membership { get; set; }
    }
}
