using System;

namespace Data
{
    public class TrainingData : BaseData
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime? ValidFrom { get; set; } // kestvus? kas nii sobib ?
        public DateTime? ValidTo { get; set; }
        public int MaxNumberOfAthletes { get; set; }

    }
}
