using Microsoft.VisualStudio.TestTools.UnitTesting;
using Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace isa3.Tests.Data
{
    [TestClass]
    public class BaseDataTests
    {
        [TestMethod]
        public void CanCreateTest() => Assert.IsNotNull(new BaseData());

        [TestMethod]
        public void InheritedFrom() =>
                    Assert.IsInstanceOfType(new BaseData().GetType().BaseType, typeof(object));
        

        [TestMethod]
        public void IdTest() {
            var a = 123;
            var o = new BaseData();
            o.Id = 123;
            Assert.AreEqual(a, o.Id);
        }

        [TestMethod]
        public void ValidToTest() { Assert.Inconclusive(); }
        [TestMethod]
        public void ValidFromTest() { Assert.Inconclusive(); }

    }
}
