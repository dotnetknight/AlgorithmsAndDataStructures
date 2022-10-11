using LeetCode._1101_1150;

namespace LeetCode.Tests._1101_1150
{
    public class _1108_DefangingAnIPAddress_Test
    {
        [Test]
        [TestCase("1.1.1.1", "1[.]1[.]1[.]1")]
        [TestCase("255.100.50.0", "255[.]100[.]50[.]0")]
        public void DefangingAnIPAddress(string ip, string expectedResult)
        {
            var solution = new _1108_DefangingAnIPAddress();
            var result = solution.DefangIPaddr(ip);

            Assert.That(expectedResult, Is.EqualTo(result));
        }
    }
}