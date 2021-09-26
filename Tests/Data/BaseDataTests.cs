using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using isa3.Data;

namespace isa3.Tests.Data
{
    [TestClass]
    public class BaseDataTests : BaseTests<BaseData, object>
    {

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
