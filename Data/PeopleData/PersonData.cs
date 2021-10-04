using System;
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
        public string Gender { get; set; }  
        public DateTime? DateOfBirth { get; set; }
       

    }
}
