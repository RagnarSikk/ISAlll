using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using isa3.Domain.Common;
using isa3.Domain.People;

namespace isa3.Domain
{
    public class Training : Base
    {
        public List<Coach> Coaches { get; }
        public List<Athlete> Athletes { get; }
        public List<Equipment> Equipments { get; }
        public void AddCoach(Coach c, Administrator a) { }
        public void RemoveCoach(Coach c, Administrator a) { }
    }
}
