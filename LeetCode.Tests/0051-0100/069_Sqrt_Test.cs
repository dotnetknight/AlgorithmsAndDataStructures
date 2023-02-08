using LeetCode._0051_0100;

namespace LeetCode.Tests._0051_0100
{
    public class _069_Sqrt_Test
    {
        [Test]
        [TestCase(-1, -1)]
        [TestCase(1, 1)]
        [TestCase(0, 0)]
        [TestCase(int.MaxValue, 46340)]
        [TestCase(4, 2)]
        public void MySqrt(int x, int expectedResult)
        {
            var solution = new _069_Sqrt();
            var result = solution.MySqrt(x);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}