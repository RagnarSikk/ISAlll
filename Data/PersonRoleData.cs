using isa3.Data.Common;
using isa3.Data.PeopleData;
using System;

namespace isa3.Data
{
    public class PersonRoleData : PersonData
    {
        
        public DateTime HireDate { get; set; }
        public string certifications { get; set; }

        // Coach, Nutritionist, Therapist, Psychologist should def have HireDate in common
        // What about Admins, do we hire them? Athletes, do we hire them? mby should rename "HireDate" 
        // => Date when a Person joined the club => They all have that in common.

        // for example: public DateTime HireTime {  get; set;}

        // 
    }
}
