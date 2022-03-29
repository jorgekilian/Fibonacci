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

        [Test]
        public void calculate_fourth_element() {
            var expected = 2;

            var number = Fibonacci.Run(3);

            Assert.AreEqual(expected, number);
        }

        [Test]
        public void calculate_fifth_element() {
            var expected = 3;

            var number = Fibonacci.Run(4);

            Assert.AreEqual(expected, number);
        }
    }

    public class Fibonacci {
        public static int Run(int position) {
            if (position == 0) return 0;
            if (position == 1) return 1;
            return Run(position - 1) + Run(position - 2);
        }
    }
}