using isa3.Data.Common;

namespace isa3.Data.Others
{
    public class EquipmentData : BaseData
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int AmountAvailable { get; set; }
        public int AmountInUsing { get; set; }

        // võiks teha nii, et näeb mitu on kasutusel ja mitu on saadaval

        // TODO: mõelda mis propertyd veel võiksid olla
    }
}
