using isa3.Data.Common;
using System;
using System.ComponentModel.DataAnnotations;

namespace isa3.Data.People {
    public class PersonData : NamedEntityData {
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
