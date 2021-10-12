using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace isa3.Tests
{
    public abstract class AbstractTests<TClass, TBaseClass> :
        BaseClassTests<TClass, TBaseClass> where TClass : class
    {
        [TestMethod] public void IsAbstract() => Assert.IsTrue(type.IsAbstract);

    }
}
