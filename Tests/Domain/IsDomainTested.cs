using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace isa3.Tests.Domain {
    [TestClass]
    public class IsDomainTested : AssemblyTests {
        protected override string assembly => "isa3.Domain";
        [TestMethod]
        public void IsCommonTested()
            => isAllTested(assembly, nameSpace("Common"));
        [TestMethod]
        public void IsOthersTested()
            => isAllTested(assembly, nameSpace("Others"));
        [TestMethod]
        public void IsPeopleTested()
            => isAllTested(assembly, nameSpace("People"));

    }
}
