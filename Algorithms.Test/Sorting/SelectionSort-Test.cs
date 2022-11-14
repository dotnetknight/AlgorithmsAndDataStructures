using Algorithms.Sorting;
using Algorithms.Test.TestCaseData;

namespace Algorithms.Test.Sorting
{
    public class SelectionSort_Test
    {
        [Test]
        [TestCaseSource(typeof(IntegerArrayTestCaseData))]
        public void SelectionSort_HasArrayToPerformSelectionSort_ReturnsSortedArray(int[] array)
        {
            var solution = new SelectionSort();
            var sortedArray = solution.Sort(array);

            Assert.That(sortedArray, Is.Ordered);
        }

        [Test]
        [TestCaseSource(typeof(EmptyIntegerArrayTestCaseData))]
        public void SelectionSort_HasEmptyArray_ReturnsEmptyArray(int[] array)
        {
            var solution = new SelectionSort();

            var sortedArray = solution.Sort(array);
            Assert.That(sortedArray, Is.Empty);
        }
    }
}