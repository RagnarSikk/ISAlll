using System.Collections.Generic;

namespace isa3.Domain.People
{
    public class Coach : PersonRole
    {
        public List<Training> Trainings { get; }
        public List<Service> Services { get; set; }
    }
}
