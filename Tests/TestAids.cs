using isa3.Aids.Random;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace isa3.Tests
{
    public abstract class TestAids : TestAssertions
    {
        protected object objUnderTests;
        protected void isProperty<T>(bool isNullable = true) {
            var t = objUnderTests?.GetType();
            var n = getPropertyFromTheTestName(nameof(isProperty));
            var pi = t?.GetProperty(n.ToString()); // n on object aga kuidas sa automaatselt stringi ka kasutada saaks?
            isNotNull(pi,
                $"The class {t} does not have a property {n}");
            isTrue(pi.CanRead, $"The property {n} does not have a getter");
            isTrue(pi.CanWrite, $"The property {n} does not have a setter");
            var expectedValue = GetRandom.Value(typeof(T));
            pi.SetValue(objUnderTests, expectedValue);
            var actual = pi.GetValue(objUnderTests);
            areEqual(expectedValue, actual, $"For the property {n}.");
            if (!isNullable) return;
            pi.SetValue(objUnderTests, null);
            isNull(pi.GetValue(objUnderTests), $"Can not set null for the property {n}.");
        }//Todo: Refacto this method
        protected void isProperty<T>(T expectedValue)
        {
            var t = objUnderTests?.GetType();
            var n = getPropertyFromTheTestName(nameof(isProperty));
            var pi = t?.GetProperty(n.ToString()); // n on object aga kuidas sa automaatselt stringi ka kasutada saaks?
            isNotNull(pi,
                $"The class {t} does not have a property {n}");
            isTrue(pi.CanRead, $"The property {n} does not have a getter");
            var actual = pi.GetValue(objUnderTests);
            areEqual(expectedValue, actual, $"For the property {n}.");
        } //Todo: Refacto this method

        private object getPropertyFromTheTestName(string methodName)
        {
            var stack = new StackTrace();
            var i = getFrameIndex(stack, methodName);
            return nextMethodName(stack, i);
        }

        private int getFrameIndex(StackTrace stack, string methodName)
        {
            int index = -1;
            for (var i = 0; i<stack.FrameCount -1; i++)
            {
                var n = stack.GetFrame(i)?.GetMethod()?.Name;
                if (n == methodName) index = i;
                else if (index > -1 && n != methodName) break;
            }
            return index;
        }

        private string nextMethodName(StackTrace stack, int frameIndex)
        {
            var i = frameIndex;
            for (i += 1; i < stack.FrameCount - 1; i++)
            {
                var n = stack.GetFrame(i)?.GetMethod()?.Name;
                if (n is "MoveNext" or "Start") continue;
                return n?.Replace("Test", string.Empty);
            }
            return string.Empty;
        }
    }
}
