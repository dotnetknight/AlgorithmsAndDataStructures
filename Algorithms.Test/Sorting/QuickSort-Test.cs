using Algorithms.Sorting;
using Algorithms.Test.TestCaseData;

namespace Algorithms.Test.Sorting
{
    public class QuickSort_Test
    {
        [Test]
        [TestCaseSource(typeof(IntegerArrayTestCaseData))]
        public void QuickSort_HasArrayToPerformQuickSort_SortsArray(int[] array)
        {
            var solution = new QuickSort();
            var sortedArray = solution.Sort(array);

            Assert.That(sortedArray, Is.Ordered);
        }
    }
}