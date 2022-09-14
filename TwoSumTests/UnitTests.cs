using TwoNum;

namespace TwoSumTests
{
    public class Tests
    {
        [Test]
        [TestCase(new int[] { 2, 3, 4 }, 5, new int[] { 0, 1 })]
        [TestCase(new int[] { 2, 7, 11, 15 }, 9, new int[] { 0, 1 })]
        [TestCase(new int[] { 3, 2, 4 }, 6, new int[] { 1, 2 })]
        [TestCase(new int[] { 3, 3 }, 6, new int[] { 0, 1 })]
        public void TwoNumberSumTest(int[] list, int target, int[] expected)
        {
            var result = TwoNumberSum.TwoSum(list, target);
            CollectionAssert.AreEqual(expected, result);
        }
    }
}