using LeetCode._1501_1550;

namespace LeetCode.Tests._1501_1550
{
    public class _1512_NumberOfGoodPairs_Test
    {
        [Test]
        [TestCase(new int[] { 1, 2, 3, 1, 1, 3 }, 4)]
        [TestCase(new int[] { 1, 1, 1, 1 }, 6)]
        [TestCase(new int[] { 1, 2, 3 }, 0)]
        public void NumberOfGoodPairs_Test(int[] nums, int expected)
        {
            var solution = new _1512_NumberOfGoodPairs();
            var result = solution.NumIdenticalPairs(nums);

            Assert.That(result, Is.EqualTo(expected));
        }
    }
}