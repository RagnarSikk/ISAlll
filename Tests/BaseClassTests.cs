using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace isa3.Tests {
    public abstract class BaseClassTests<TBaseClass> : BaseTests {
        protected object obj {
            get => objUnderTests;
            set => objUnderTests = value;
        }
        protected abstract object createObject();
        protected virtual Type getBaseClass() => typeof(TBaseClass);

        [TestInitialize]
        public virtual void TestInitialize() {
            type = getTestableClassType();
            obj = createObject();
        }
        [TestMethod] public void CanCreateTest() => Assert.IsNotNull(createObject());
        [TestMethod] public void IsInheritedTest() => areEqual(getBaseClass(), type.BaseType);
    }
}