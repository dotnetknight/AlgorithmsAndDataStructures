using LeetCode._0001_0050;

namespace LeetCode.Tests._0001_0050
{
    public class _017_LetterCombinationsOfAPhoneNumber_Test
    {
        [Test]
        public void LetterCombinationsTest()
        {
            var solution = new _017_LetterCombinationsOfAPhoneNumber();
            var result = solution.LetterCombinations("23");

            Assert.That(result, Has.Count.EqualTo(9));
            Assert.That(result.Contains("ad"));
            Assert.That(result.Contains("ae"));
            Assert.That(result.Contains("af"));
            Assert.That(result.Contains("bd"));
            Assert.That(result.Contains("be"));
            Assert.That(result.Contains("bf"));
            Assert.That(result.Contains("cd"));
            Assert.That(result.Contains("ce"));
            Assert.That(result.Contains("cf"));
        }

        [Test]
        public void LetterCombinationsTest_2()
        {
            var solution = new _017_LetterCombinationsOfAPhoneNumber();
            var result = solution.LetterCombinations("234");

            Assert.That(result, Has.Count.EqualTo(27));
        }

        [Test]
        public void LetterCombinationsTest_HasEmptyString()
        {
            var solution = new _017_LetterCombinationsOfAPhoneNumber();
            var result = solution.LetterCombinations(string.Empty);

            Assert.That(result, Is.Empty);
        }

        [Test]
        public void LetterCombinationsTest_EndsWithZero()
        {
            var solution = new _017_LetterCombinationsOfAPhoneNumber();
            var result = solution.LetterCombinations("20");

            Assert.That(result.Count, Is.EqualTo(3));
            Assert.That(result.Contains("a0"), Is.True);
            Assert.That(result.Contains("b0"), Is.True);
            Assert.That(result.Contains("c0"), Is.True);
        }

        [Test]
        public void LetterCombinationsTest_OnlyHaveZeros()
        {
            var solution = new _017_LetterCombinationsOfAPhoneNumber();
            var result = solution.LetterCombinations("0000");

            Assert.That(result.Count, Is.EqualTo(1));
        }

        [Test]
        public void LetterCombinationsTest_HasNine()
        {
            var solution = new _017_LetterCombinationsOfAPhoneNumber();

            var result = solution.LetterCombinations("9");
            Assert.That(result.Count, Is.EqualTo(4));
            Assert.Multiple(() =>
            {
                Assert.That(result.Contains("w"), Is.True);
                Assert.That(result.Contains("x"), Is.True);
                Assert.That(result.Contains("y"), Is.True);
                Assert.That(result.Contains("z"), Is.True);
            });

            result = solution.LetterCombinations("29");
            Assert.Multiple(() =>
            {
                Assert.That(result, Has.Count.EqualTo(12));
                Assert.That(result.Contains("aw"), Is.True);
                Assert.That(result.Contains("ax"), Is.True);
                Assert.That(result.Contains("ay"), Is.True);
                Assert.That(result.Contains("az"), Is.True);
                Assert.That(result.Contains("bw"), Is.True);
                Assert.That(result.Contains("bx"), Is.True);
                Assert.That(result.Contains("by"), Is.True);
                Assert.That(result.Contains("bz"), Is.True);
                Assert.That(result.Contains("cw"), Is.True);
                Assert.That(result.Contains("cx"), Is.True);
                Assert.That(result.Contains("cy"), Is.True);
                Assert.That(result.Contains("cz"), Is.True);
            });
        }
    }
}