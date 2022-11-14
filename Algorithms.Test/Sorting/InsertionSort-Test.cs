using Algorithms.Sorting;
using Algorithms.Test.TestCaseData;

namespace Algorithms.Test.Sorting
{
    public class InsertionSort_Test
    {
        [Test]
        [TestCaseSource(typeof(EmptyIntegerArrayTestCaseData))]
        public void InsertionSort_HasEmptyArray_ReturnsEmptyArray(int[] array)
        {
            var solution = new InsertionSort();

            var sortedArray = solution.Sort(array);
            Assert.That(sortedArray, Is.Empty);
        }

        [Test]
        [TestCaseSource(typeof(IntegerArrayTestCaseData))]
        public void InsertionSort_HasArrayToPerformBubbleSort_ReturnsSortedArray(int[] array)
        {
            var solution = new InsertionSort();
            var sortedArray = solution.Sort(array);

            Assert.That(sortedArray, Is.Ordered);
        }
    }
}