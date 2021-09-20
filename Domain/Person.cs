using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Base
    {
    }
    
    public class PersonRole
    {
        public int PersonId { get; set; }
    }
    public class Person : Base
    {
        public List<PersonRole> Roles { get; }
    }
    public class Athlete : PersonRole
    {
    }
    public class Coach : PersonRole
    {
    }
    public class Nutritionist : PersonRole
    {
    }
    public class Adminstrator : PersonRole
    {
    }
    public class SportClub : Base
    {
        public List<Coach> Coaches { get; }
        public List<Nutritionist> Nutritionists { get; }
        public List<Athlete> Athletes { get; }
        public List<Adminstrator> Adminstrator { get; }
        public List<Training> Trainings { get; }
        public List<Service> Services { get; }

        public void AddNewTraining(Training t, Coach c, Adminstrator a) { throw new NotImplementedException();}
        public void AddCoach ( Coach c, Adminstrator a) { }
        public void RemoveCoach ( Coach c, Adminstrator a) { }
    }
    public class Training : Base
    {
        public List<Coach> Coaches { get; }
        public List<Athlete> Athletes { get; }
        public void AddCoach ( Coach c, Adminstrator a) { }
        public void RemoveCoach(Coach c, Adminstrator a) { }
    }
    public class Service : Base
    {
    }
}
