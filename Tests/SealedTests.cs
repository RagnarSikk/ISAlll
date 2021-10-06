using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace isa3.Tests
{
    public abstract class SealedTests<TClass, BaseClass> : ClassTests<TClass, BaseClass>
        where TClass : class
    {
        [TestMethod] public void IsSealed() => isTrue(type.IsSealed);
    }
}
