using LeetCode._2000_2050;

namespace LeetCode.Tests._2000_2050
{
    public class _2011_FinalValueAfterOperations_Test
    {
        [Test]
        [TestCase(new string[] { "--X", "X++", "X++" }, 1)]
        [TestCase(new string[] { "++X", "++X", "X++" }, 3)]
        [TestCase(new string[] { "X++", "++X", "--X", "X--" }, 0)]
        public void FinalValueAfterOperations(string[] operations, int valueAfterOperations)
        {
            var solution = new _2011_FinalValueAfterOperations();
            var result = solution.FinalValueAfterOperations(operations);

            Assert.That(valueAfterOperations, Is.EqualTo(result));
        }
    }
}
