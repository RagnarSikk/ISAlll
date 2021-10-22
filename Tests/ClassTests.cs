using isa3.Aids.Random;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace isa3.Tests
{
    public abstract class ClassTests<TBaseClass> : BaseClassTests<TBaseClass>
    {
        protected override object createObject() => GetRandom.Object(type);
    }
}
