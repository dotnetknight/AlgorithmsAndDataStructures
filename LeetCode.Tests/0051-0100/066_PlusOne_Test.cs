using LeetCode._0051_0100;

namespace LeetCode.Tests._0051_0100
{
    public class _066_PlusOne_Test
    {
        [Test]
        [TestCase(new int[] { 1, 2, 3 }, new int[] { 1, 2, 4 })]
        [TestCase(new int[] { 4, 3, 2, 1 }, new int[] { 4, 3, 2, 2 })]
        [TestCase(new int[] { 9 }, new int[] { 1, 0 })]
        [TestCase(new int[] { 9, 9, 9 }, new int[] { 1, 0, 0, 0 })]
        [TestCase(new int[] { 0 }, new int[] { 1 })]
        public void PlusOneTest(int[] input, int[] expectedResult)
        {
            var solution = new _066_PlusOne();
            var result = solution.PlusOne(input);
            CollectionAssert.AreEqual(expectedResult, result);
        }
    }
}