using Algorithms.Sorting;
using Algorithms.Test.TestCaseData;

namespace Algorithms.Test.Sorting
{
    public class MergeSort_Test
    {
        [Test]
        [TestCaseSource(typeof(IntegerArrayTestCaseData))]
        public void MergeSort_ArrayLengthIsEqualOrLessThanOne_ReturnsArray(int[] array)
        {
            var solution = new MergeSort();
            var arrayLengthBeforeCallingSort = array.Length;

            var sortedArray = solution.Sort(array);
            var arrayLengthAfterCallingSort = sortedArray.Length;

            Assert.That(arrayLengthBeforeCallingSort, Is.EqualTo(arrayLengthAfterCallingSort));
            Assert.That(sortedArray, Is.Ordered);
        }
    }
}