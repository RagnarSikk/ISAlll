using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class BaseData
    {
        public int Id { get; set; }
        public DateTime? ValidFrom { get; set; }
        public DateTime? ValidTo { get; set; }
    }
    public class PersonRoleData : BaseData
    {
        public int PersonId { get; set; }
    }
    public class PersonData : BaseData
    {
        [StringLength(50)] public string LastName { get; set; }
        [StringLength(50)] public string FirstMidName { get; set; }
        public string FullName => LastName + " " + FirstMidName;
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
    }
    public class AthleteData : PersonRoleData
    {
        public double Weight { get; set; }
        public double Height { get; set; }
        public double? Credit { get; set;}
    }
    public class CoachData : PersonRoleData
    {
        public DateTime HireDate { get; set; }
    }
    public class NutritionistData : PersonRoleData
    {
        public DateTime HireDate { get; set; }
    }
    public class AdminstratorData : PersonRoleData
    {
    } 
    public class SportClubData : BaseData
    {
    }
    public class TrainingData : BaseData
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime? ValidFrom { get; set; } // kestvus? kas nii sobib ?
        public DateTime? ValidTo { get; set; }
        public int MaxNumberOfAthletes { get; set; }

    }
    public class ServicesData : BaseData
    {
        public string Name { get; set; }
        public double Cost { get; set; }
    }
}
