using LeetCode._0001_0050;

namespace LeetCode.Tests._0001_0050
{
    public class _008_StringToInteger_Test
    {
        [Test]
        [TestCase("123", 123)]
        [TestCase("-1", -1)]
        [TestCase("0", 0)]
        [TestCase("2147483647", int.MaxValue)]
        [TestCase("   123", 123)]
        [TestCase("   ", 0)]
        [TestCase("", 0)]
        [TestCase("123abc", 123)]
        [TestCase("  -2247483648abc", int.MinValue)]
        [TestCase("  2247483647abc", int.MaxValue)]
        public void MyAtoi_HasValidString_ReturnsConvertedStringToInteger(string s, int expectedResult)
        {
            var solution = new _008_StringToInteger_ATOI();
            var result = solution.MyAtoi(s);

            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}
