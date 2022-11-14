using Algorithms.Sorting;
using System.Collections;

namespace Algorithms.Test.Sorting
{
    public class SelectionSortTestCaseData : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new int[] { 2, 22 };
            yield return new int[] { 1, 2, 3 };
            yield return new int[] { 3, 12, 23, 5, 0, 50 };
            yield return new int[] { -2, 4, 55, 23, 3, 1, 40 };
        }
    }

    public class SelectionSort_Test
    {
        [Test]
        [TestCaseSource(typeof(SelectionSortTestCaseData))]
        public void SelectionSort_HasArrayToPerformSelectionSort_ReturnsSortedArray(int[] array)
        {
            var solution = new SelectionSort();
            var sortedArray = solution.Sort(array);

            Assert.That(sortedArray, Is.Ordered);
        }

        [Test]
        public void SelectionSort_HasEmptyArray_ReturnsEmptyArray()
        {
            var solution = new SelectionSort();
            var array = Array.Empty<int>();

            var sortedArray = solution.Sort(array);
            Assert.That(sortedArray, Is.Empty);
        }
    }
}