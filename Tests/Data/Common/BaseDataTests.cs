﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using isa3.Data;
using isa3.Data.Common;

namespace isa3.Tests.Data.Common
{
    [TestClass]
    public class BaseDataTests  : SealedTests<BaseData, System.Object>
    {

        [TestMethod]
        public void IdTest()
        {
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
    [TestClass]
    public class BaseEntityTests
    {
    }
    [TestClass]
    public class IUniqueNamedDataTests
    {
    }
    [TestClass]
    public class NamedEntityDataTests
    {
    }
    [TestClass]
    public class PeriodDataTests
    {
    }
    [TestClass]
    public class UniqueEntityDataTests
    {
    }

}
