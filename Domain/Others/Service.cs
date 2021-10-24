using isa3.Domain.Common;
using isa3.Domain.People;

namespace isa3.Domain.Others {
    public class Service : Base {
        public Nutritionist Nutritionist { get; set; }
        public Therapist Therapist { get; set; }
        public Physiotherapist Physiotherapist { get; set; }

    }
}
