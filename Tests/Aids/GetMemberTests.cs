using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using isa3.Aids.Reflections;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace isa3.Tests.Aids
{
    [TestClass]
    public class GetMemberTests
    {

        private readonly string stringField = null;
        private string stringProperty { get; } = null;

        [TestMethod]
        public void NameTestField()
            => Assert.AreEqual("stringField",
                GetMember.Name<GetMemberTests>(x => x.stringField));
        [TestMethod]
        public void NameTestProperty()
            => Assert.AreEqual("stringProperty",
                GetMember.Name<GetMemberTests>(x => x.stringProperty));
        [TestMethod]
        public void NameTestFunction()
            => Assert.AreEqual("ToString",
                GetMember.Name<object>(x => x.ToString()));
        [TestMethod]
        public void NameTestMethod()
            => Assert.AreEqual("NameTestMethod",
                GetMember.Name<GetMemberTests>(x => x.NameTestMethod()));
    }
}
