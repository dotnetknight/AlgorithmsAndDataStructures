using LeetCode._1351_1400;

namespace LeetCode.Tests._1351_1400
{
    public class _1365_HowManyNumbersAreSmallerThanTheCurrentNumber_Test
    {
        [Test]
        [TestCase(new int[] { 8, 1, 2, 2, 3 }, new int[] { 4, 0, 1, 1, 3 })]
        [TestCase(new int[] { 6, 5, 4, 8 }, new int[] { 2, 1, 0, 3 })]
        [TestCase(new int[] { 7, 7, 7, 7 }, new int[] { 0, 0, 0, 0 })]
        [TestCase(new int[] { 5, 0, 10, 0, 10, 6 }, new int[] { 2, 0, 4, 0, 4, 3 })]
        public void SmallerNumbersThanCurrent_Test(int[] nums, int[] expected)
        {
            var solution = new _1365_HowManyNumbersAreSmallerThanTheCurrentNumber();
            var result = solution.SmallerNumbersThanCurrent(nums);
            CollectionAssert.AreEquivalent(result, expected);
        }
    }
}