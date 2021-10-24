using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace isa3.Tests {
    public abstract class SealedTests<BaseClass> : ClassTests<BaseClass> {
        [TestMethod] public void IsNotSealed() => isFalse(type.IsSealed);
    }
}
