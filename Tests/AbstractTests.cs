using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace isa3.Tests {
    public abstract class AbstractTests<TBaseClass> : BaseClassTests<TBaseClass> {
        [TestMethod] public void IsAbstract() => Assert.IsTrue(type.IsAbstract);

    }
}
