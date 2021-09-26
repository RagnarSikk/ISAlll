using System.ComponentModel.DataAnnotations;

namespace isa3.Data
{
    public class PersonData : BaseData
    {
        [StringLength(50)] public string LastName { get; set; }
        [StringLength(50)] public string FirstMidName { get; set; }
        public string FullName => LastName + " " + FirstMidName;
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
    }
}
