using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace isa3.Tests.Data
{
    public class BaseTests<TObject, TBaseObject> where TObject: new()
    {
        protected TObject obj { get; private set; }
        [TestInitialize]
        public void TestInitialize() => obj = new TObject();

        [TestMethod]
        public void CanCreateTest() => Assert.IsNotNull(obj);
        [TestMethod]
        public void InInheritedFrom() => Assert.IsInstanceOfType(obj, typeof(TBaseObject));
    }
}
