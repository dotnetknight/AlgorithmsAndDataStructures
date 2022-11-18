using Algorithms.Searching;
using Algorithms.Test.TestCaseData;

namespace Algorithms.Test.Searching
{
    public class BinarySearch_Test
    {
        [Test]
        [TestCaseSource(typeof(SearchTestCaseData))]
        public void BinarySearchRecursive_HasList_ReturnsIndex(int[] array, int target, int index)
        {
            var solution = new BinarySearch();
            var itemIndex = solution.BinarySearchRecursive(array, target);

            Assert.That(itemIndex, Is.EqualTo(index));
        }

        [Test]
        [TestCaseSource(typeof(SearchTestCaseData))]
        public void BinarySearchIterative_HasList_ReturnsIndex(int[] array, int target, int index)
        {
            var solution = new BinarySearch();
            var itemIndex = solution.BinarySearchIterative(array, target);

            Assert.That(itemIndex, Is.EqualTo(index));
        }
    }
}