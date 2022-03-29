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

        [Test]
        public void calculate_second_element() {
            var expected = 1;

            var number = Fibonacci.Run(1);

            Assert.AreEqual(expected, number);
        }

        [Test]
        public void calculate_third_element() {
            var expected = 1;

            var number = Fibonacci.Run(2);

            Assert.AreEqual(expected, number);
        }
    }

    public class Fibonacci {
        public static int Run(int position) {
            if (position > 0 ) return 1;
            return 0;
        }
    }
}