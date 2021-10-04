using System.ComponentModel.DataAnnotations;
using isa3.Data.Common;

namespace isa3.Data.PeopleData
{
    public class PersonData : BaseData
    {
        [StringLength(50)] public string LastName { get; set; }
        [StringLength(50)] public string FirstMidName { get; set; }
        public string FullName => LastName + " " + FirstMidName;
        // ToDo: Add a Prefered name/nickname
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public int Age { get; set; } //DoB => Age? In case of a birthday, age changes and we should know.

    }
}
