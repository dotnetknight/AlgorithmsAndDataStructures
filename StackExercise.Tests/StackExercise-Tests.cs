namespace StackExercise.Tests
{
    public class Tests
    {
        [Test]
        [TestCase("abcd", "dcba")]
        [TestCase("zxcv", "vcxz")]
        [TestCase("lkjh", "hjkl")]
        public void ReverseString_ReversesGivenString_ReturnsReversedString(string stringToBeReversed, string reversedString)
        {
            var solution = new StackExercise();
            
            var characters = stringToBeReversed.ToCharArray();
            var reversed = solution.ReverseString(characters).ToString();

            Assert.That(reversed, Is.EqualTo(reversedString));
        }
    }
}