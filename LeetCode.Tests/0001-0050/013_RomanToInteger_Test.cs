using LeetCode._0001_0050;

namespace LeetCode.Tests._0001_0050
{
    public class _013_RomanToInteger_Test
    {
        [Test]
        [TestCase("I", 1)]
        [TestCase("II", 2)]
        [TestCase("IV", 4)]
        [TestCase("V", 5)]
        [TestCase("VI", 6)]
        [TestCase("IX", 9)]
        [TestCase("LXXIV", 74)]
        [TestCase("XC", 90)]
        [TestCase("L", 50)]
        [TestCase("DCCXLIV", 744)]
        [TestCase("CM", 900)]
        [TestCase("MMCDXCIV", 2494)]
        [TestCase("M", 1000)]
        [TestCase("MMXLVIII", 2048)]
        public void RomanToInteger_HasValidRomanNumeral_ReturnsInteger(string s, int expectedResult)
        {
            var solution = new _013_RomanToInteger();
            var result = solution.RomanToInt(s);

            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}