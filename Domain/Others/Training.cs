using isa3.Data.Others;
using isa3.Domain.Common;
using isa3.Domain.People;
using System.Collections.Generic;

namespace isa3.Domain.Others {
    public sealed class Training : DefinedEntity<TrainingData> {
        public Training(TrainingData d) : base(d) { }
        public string Description => Data?.Description ?? Unspecified;
        public string LocationOfTraining => Data?.LocationOfTraining ?? Unspecified;
        public string AvailableEquipment => Data?.AvailableEquipment ?? Unspecified;
        public int MaxNumberOfAthletes => Data?.MaxNumberOfAthletes ?? UnspecifiedInteger;
        public int MinNumberOfAthletes => Data?.MinNumberOfAthletes ?? UnspecifiedInteger;
        public int NumberOfAthletes => Data?.NumberOfAthletes ?? UnspecifiedInteger;
        public int NumberOfCoachesRequired => Data?.NumberOfCoachesRequired ?? UnspecifiedInteger;
        public List<Coach> Coaches { get; }
        public List<Athlete> Athletes { get; }
        public List<Equipment> Equipments { get; }
        public void AddCoach(Coach c, Administrator a) { }
        public void RemoveCoach(Coach c, Administrator a) { }
    }
}
