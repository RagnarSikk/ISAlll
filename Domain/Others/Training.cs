using isa3.Domain.Common;
using isa3.Domain.People;
using System.Collections.Generic;

namespace isa3.Domain.Others {
    public class Training : Base {
        public List<Coach> Coaches { get; }
        public List<Athlete> Athletes { get; }
        public List<Equipment> Equipments { get; }
        public void AddCoach(Coach c, Administrator a) { }
        public void RemoveCoach(Coach c, Administrator a) { }
    }
}
