namespace DataStructures.Tests
{
    public class Stacks_Tests
    {
        [Test]
        [TestCase("abcd", "dcba")]
        [TestCase("zxcv", "vcxz")]
        [TestCase("lkjh", "hjkl")]
        public void ReverseString_ReversesGivenString_ReturnsReversedString(string stringToBeReversed, string reversedString)
        {
            var solution = new Stacks();

            var characters = stringToBeReversed.ToCharArray();
            var reversed = solution.ReverseString(characters).ToString();

            Assert.That(reversed, Is.EqualTo(reversedString));
        }
    }
}