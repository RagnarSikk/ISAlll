using System;
using System.Collections.Generic;
using isa3.Data.Common;

namespace isa3.Data.Others
{
    public class TrainingData : BaseData
    {
        public string Name { get; set; }
        public string Description { get; set; }
        //public DateTime? ValidFrom { get; set; } // kestvus? kas nii sobib ?
        //public DateTime? ValidTo { get; set; } // BaseDatas on olemas juba ValidFrom ja ValidTo, ehk seda pole vaja?
        public string LocationOfTraining { get; set; }
        public List<string> AvailableEquipment { get; set; } //Todo: Kuidas panna kirja, mis
        public int MaxNumberOfAthletes { get; set; }         //varustus ja kui palju on kasutuseks olemas?
        public int MinNumberOfAthletes { get; set; }
        public int NumberOfAthletes { get; set; }
        public int NumberOfCoachesRequired { get; set; }

    }
}
