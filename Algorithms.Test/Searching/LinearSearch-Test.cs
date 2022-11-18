using Algorithms.Searching;
using Algorithms.Test.TestCaseData;

namespace Algorithms.Test.Searching
{
    public class LinearSearch_Test
    {
        [Test]
        [TestCaseSource(typeof(LinearSearchValidTestCaseData))]
        public void LinearSearch_HasValidListAndIndex_ReturnsIndex(int[] array, int target, int index)
        {
            var solution = new LinearSearch();
            var itemIndex = solution.Search(array, target);

            Assert.That(itemIndex, Is.EqualTo(index));
        }

        [Test]
        [TestCaseSource(typeof(LinearSearchInValidTestCaseData))]
        public void LinearSearch_HasValidListAndInvalidIndex_ReturnsMinusOne(int[] array, int target)
        {
            var solution = new LinearSearch();
            var itemIndex = solution.Search(array, target);

            Assert.That(itemIndex, Is.EqualTo(-1));
        }
    }
}