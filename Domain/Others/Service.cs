using isa3.Data.Others;
using isa3.Domain.Common;
using isa3.Domain.People;

namespace isa3.Domain.Others {
    public sealed class Service : DefinedEntity<ServicesData> {
        public Service(ServicesData d) : base(d) { }

        public string Type => Data?.Type ?? Unspecified;
        public double Cost => Data?.Cost ?? UnspecifiedDouble;
        public Nutritionist Nutritionist { get; set; }
        public Therapist Therapist { get; set; }
        public Physiotherapist Physiotherapist { get; set; }

    }
}
