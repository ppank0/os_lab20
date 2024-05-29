using Counter;

namespace Tests
{
    [TestClass]
    public class EvenNumbersCounterTest
    {
        [TestMethod]
        public void EvenNumbersCounter_ZeroEven()
        {
            int[] numbers = { 1, 7, 3, 5 };
            var result = EvenNumbersCounter.CountEvenNumbers(numbers);
            Assert.AreEqual(4, numbers.Length);
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void EvenNumbersCounter_OneEven()
        {
            int[] numbers = { 1, 2, 3, 5 };
            var result = EvenNumbersCounter.CountEvenNumbers(numbers);
            Assert.AreEqual(4, numbers.Length);
            Assert.AreEqual(1, result);
        }
        [TestMethod]
        public void EvenNumbersCounter_TwoEven()
        {
            int[] numbers = { 1, 2, 3, 4 };
            var result = EvenNumbersCounter.CountEvenNumbers(numbers);
            Assert.AreEqual(4, numbers.Length);
            Assert.AreEqual(2, result);
        }
        [TestMethod]
        public void EvenNumbersCounter_ThreeEven()
        {
            int[] numbers = { 6, 2, 3, 4 };
            var result = EvenNumbersCounter.CountEvenNumbers(numbers);
            Assert.AreEqual(4, numbers.Length);
            Assert.AreEqual(3, result);
        }
        [TestMethod]
        public void EvenNumbersCounter_FourEven()
        {
            int[] numbers = { 8, 2, 6, 4 };
            var result = EvenNumbersCounter.CountEvenNumbers(numbers);
            Assert.AreEqual(4, numbers.Length);
            Assert.AreEqual(4, result);
        }
        [TestMethod]
        public void EvenNumbersCounter_FourZero()
        {
            int[] numbers = { 0, 0, 0, 0 };
            var result = EvenNumbersCounter.CountEvenNumbers(numbers);
            Assert.AreEqual(4, numbers.Length);
            Assert.AreEqual(4, result);
        }
        [TestMethod]
        public void EvenNumbersCounter_FourMaxEvenValue()
        {
            int[] numbers = { int.MaxValue-1, int.MaxValue-1, int.MaxValue - 1, int.MaxValue - 1 };
            var result = EvenNumbersCounter.CountEvenNumbers(numbers);
            Assert.AreEqual(4, numbers.Length);
            Assert.AreEqual(4, result);
        }

        [TestMethod]
        public void EvenNumbersCounter_FourMaxValue()
        {
            int[] numbers = { int.MaxValue, int.MaxValue, int.MaxValue, int.MaxValue};
            var result = EvenNumbersCounter.CountEvenNumbers(numbers);
            Assert.AreEqual(4, numbers.Length);
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void EvenNumbersCounter_FourMinEvenValue()
        {
            int[] numbers = { int.MinValue, int.MinValue, int.MinValue, int.MinValue};
            var result = EvenNumbersCounter.CountEvenNumbers(numbers);
            Assert.AreEqual(4, numbers.Length);
            Assert.AreEqual(4, result);
        }

        [TestMethod]
        public void EvenNumbersCounter_OneNoneven_ThreeZero()
        {
            int[] numbers = { 7, 0, 0, 0 };
            var result = EvenNumbersCounter.CountEvenNumbers(numbers);
            Assert.AreEqual(4, numbers.Length);
            Assert.AreEqual(3, result);
        }

    }
}