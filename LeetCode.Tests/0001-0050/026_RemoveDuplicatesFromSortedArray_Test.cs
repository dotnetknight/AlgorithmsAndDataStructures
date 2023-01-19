using LeetCode._0001_0050;

namespace LeetCode.Tests._0001_0050
{
    public class _026_RemoveDuplicatesFromSortedArray_Test
    {
        [Test]
        [TestCase(new int[] { 1, 1, 2 }, 2)]
        [TestCase(new int[] { 1 }, 1)]
        [TestCase(new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 }, 5)]
        public void RemoveDuplicates(int[] input, int expectedResult)
        {
            var solution = new _026_RemoveDuplicatesFromSortedArray();
            var result = solution.RemoveDuplicates(input);

            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}