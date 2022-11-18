using Algorithms.Searching;
using Algorithms.Test.TestCaseData;

namespace Algorithms.Test.Searching
{
    public class LinearSearch_Test
    {
        [Test]
        [TestCaseSource(typeof(SearchTestCaseData))]
        public void LinearSearch_HasList_ReturnsIndex(int[] array, int target, int index)
        {
            var solution = new LinearSearch();
            var itemIndex = solution.Search(array, target);

            Assert.That(itemIndex, Is.EqualTo(index));
        }
    }
}