using LeetCode._0751_0800;

namespace LeetCode.Tests._0751_0800
{
    public class _0771_JewelsAndStones_Test
    {
        [Test]
        [TestCase("aA", "aAAbbbb", 3)]
        [TestCase("z", "ZZ", 0)]
        [TestCase("abcd", "ABabCPOddcKa", 6)]
        public void NumJewelsInStonesTest(string jewels, string stones, int stonesThatAreAlsoJewels)
        {
            var solution = new _0771_JewelsAndStones();
            var result = solution.NumJewelsInStones(jewels, stones);

            Assert.That(result, Is.EqualTo(stonesThatAreAlsoJewels));
        }
    }
}