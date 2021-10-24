using isa3.Aids.Random;

namespace isa3.Tests {
    public abstract class ClassTests<TBaseClass> : BaseClassTests<TBaseClass> {
        protected override object createObject() => GetRandom.Object(type);
    }
}
