
using LeetCode._0001_0050;

namespace LeetCode.Tests._0001_0050
{
    public class _007_ReverseInteger_Test
    {
        [Test]
        [TestCase(123, 321)]
        [TestCase(-1, -1)]
        [TestCase(0, 0)]
        [TestCase(1534236469, 0)]
        public void Reverse_HasString_ReversesInteger(int x, int expectedResult)
        {
            var solution = new _007_ReverseInteger();
            var result = solution.Reverse(x);

            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}