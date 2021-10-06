using isa3.Aids.Random;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace isa3.Tests
{
    public abstract class ClassTests<TClass, TBaseClass> : 
        BaseClassTests<TClass, TBaseClass> where TClass : class
    {
        protected override TClass createObject() => GetRandom.Object<TClass>();
    }
}
