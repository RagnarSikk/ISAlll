using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class BaseData
    {
        public int Id { get; set; }
    }
    public class PersonRoleData : BaseData
    {
        public int PersonId { get; set; }
    }
    public class PersonData : BaseData
    {
    }
    public class AthleteData : PersonRoleData
    {
    }
    public class CoachData : PersonRoleData
    {
    }
    public class NutritionistData : PersonRoleData
    {
    }
    public class AdminstratorData : PersonRoleData
    {
    }
    public class TrainingData : BaseData
    {
    }
    public class ServicesData : BaseData
    {
    }
}
