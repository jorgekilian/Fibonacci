using NUnit.Framework;

namespace FibonacciSpecs {
    public class Tests {
        [SetUp]
        public void Setup() {
        }

        [Test]
        public void calculate_first_element() {
            var expected = 0;

            var number = Fibonacci.Run(0);

            Assert.AreEqual(expected,number);
        }
    }

    public class Fibonacci {
        public static int Run(int i) {
            return 0;
        }
    }
}