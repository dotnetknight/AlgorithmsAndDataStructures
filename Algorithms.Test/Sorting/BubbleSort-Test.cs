using Algorithms.Sorting;
using Algorithms.Test.TestCaseData;

namespace Algorithms.Test.Sorting
{
    public class BubbleSort_Tests
    {
        [Test]
        [TestCaseSource(typeof(IntegerArrayTestCaseData))]
        public void BubbleSort_HasArrayToPerformBubbleSort_ReturnsSortedArray(int[] array)
        {
            var solution = new BubbleSort();
            var sortedArray = solution.Sort(array);

            Assert.That(sortedArray, Is.Ordered);
        }

        [Test]
        [TestCaseSource(typeof(EmptyIntegerArrayTestCaseData))]
        public void BubbleSort_HasEmptyArray_ReturnsEmptyArray(int[] array)
        {
            var solution = new BubbleSort();
            
            var sortedArray = solution.Sort(array);
            Assert.That(sortedArray, Is.Empty);
        }
    }
}