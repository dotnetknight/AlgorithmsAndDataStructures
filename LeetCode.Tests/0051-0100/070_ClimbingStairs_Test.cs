using LeetCode._0051_0100;

namespace LeetCode.Tests._0051_0100
{
    public class _070_ClimbingStairs_Test
    {
        [Test]
        [TestCase(0, 0)]
        [TestCase(1, 1)]
        [TestCase(2, 2)]
        [TestCase(4, 5)]
        [TestCase(5, 8)]
        [TestCase(7, 21)]
        public void MySqrt(int n, int expectedResult)
        {
            var solution = new _070_ClimbingStairs();
            var result = solution.ClimbStairs(n);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}