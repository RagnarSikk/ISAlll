using System;
using System.Collections.Generic;

namespace isa3.Domain
{
    public class Base
    {
    }
    
    public class PersonRole
    {
        public Person Person { get; set; }
    }
    public class Person : Base
    {
        public List<PersonRole> Roles { get; }
    }
    public class Athlete : PersonRole
    {
        public List<Training> Trainings { get; }
        public List<Service> Services { get; }
        public Payment Payment { get; set; }
        public Membership Membership { get; set; }
    }
    public class Coach : PersonRole
    {
        public List<Training> Trainings { get; }
        public List<Service> Services { get; set; }
    }
    public class Nutritionist : PersonRole
    {
        public List<Service> Services { get; set; }
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
        public List<Equipment> Equipments { get; }

        public void AddNewTraining(Training t, Coach c, Adminstrator a) { throw new NotImplementedException();}
        public void AddCoach ( Coach c, Adminstrator a) { }
        public void RemoveCoach ( Coach c, Adminstrator a) { }
    }
    public class Training : Base
    {
        public List<Coach> Coaches { get; }
        public List<Athlete> Athletes { get; }
        public List<Equipment> Equipments { get; }
        public void AddCoach ( Coach c, Adminstrator a) { }
        public void RemoveCoach(Coach c, Adminstrator a) { }
    }
    public class Service : Base
    {
        public Nutritionist Nutritionist { get; set; }
    }
    public class Equipment : Base
    {
        public Training Training { get; set; }
    }
    public class Payment : Base
    {
        public Athlete Athlete { get; set; }
    }
    public class Membership : Base 
    {
        public Payment Payment { get; set; }
        public Athlete Athlete { get; set; }
    }
}
