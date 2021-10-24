using isa3.Data.Common;

namespace isa3.Data.Others {
    public class TrainingData : BaseData {
        public string Name { get; set; }
        public string Description { get; set; }
        public string LocationOfTraining { get; set; }
        public string AvailableEquipment { get; set; } //Todo: Kuidas panna kirja, mis
        public int MaxNumberOfAthletes { get; set; }         //varustus ja kui palju on kasutuseks olemas?
        public int MinNumberOfAthletes { get; set; }
        public int NumberOfAthletes { get; set; }
        public int NumberOfCoachesRequired { get; set; }

    }
}
