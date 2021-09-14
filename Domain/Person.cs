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
    public class Training : Base
    {
    }
    public class Service : Base
    {
    }
}
