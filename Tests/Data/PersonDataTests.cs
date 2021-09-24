using Microsoft.VisualStudio.TestTools.UnitTesting;
using Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tests.Data
{
    [TestClass]
    public class PersonDataTests
    {
        [TestMethod]
        public void CanCreateTest() {
            Assert.IsNotNull(new PersonData()); }

        [TestMethod]
        public void InheritedFrom() =>
                    Assert.IsInstanceOfType(new PersonData().GetType().BaseType, typeof(object));
        [TestMethod]
        public void LastNameTest() { Assert.Inconclusive(); }

        [TestMethod]
        public void FirstNameTest() { Assert.Inconclusive(); }
        [TestMethod]
        public void FullNameTest() { Assert.Inconclusive(); }
        [TestMethod]
        public void EmailTest() { Assert.Inconclusive(); }
        [TestMethod]
        public void PhoneNumberTest() { Assert.Inconclusive(); }
    }
}
