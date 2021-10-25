using isa3.Data.Others;
using isa3.Domain.Common;

namespace isa3.Domain.Others {
    public sealed class Equipment : NamedEntity<EquipmentData> {
        public Equipment(EquipmentData d) : base(d) { }
        public string Description => Data?.Description ?? Unspecified;
        public int AmountAvailable => Data?.AmountAvailable ?? UnspecifiedInteger;
        public int AmountInUsing => Data?.AmountInUsing ?? UnspecifiedInteger;
        //public Training Training { get; set; }
    }
}
