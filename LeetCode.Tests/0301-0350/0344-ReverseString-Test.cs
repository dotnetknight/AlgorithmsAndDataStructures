using LeetCode._0301_0350;
using System.Collections;

namespace LeetCode.Tests._0301_0350
{
    public class ReverseStringTestCaseData : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[] { new char[] { 'h', 'e', 'l', 'l', 'o' }, new char[] { 'o', 'l', 'l', 'e', 'h' } };
            yield return new object[] { new char[] { 'b', 'a', 't', 'm', 'a', 'n' }, new char[] { 'n', 'a', 'm', 't', 'a', 'b' } };
        }
    }

    public class _0344_ReverseString_Test
    {
        [Test]
        [TestCaseSource(typeof(ReverseStringTestCaseData))]
        public void ReverseString_HasStringToReverse_ReturnsReversedString(char[] chars, char[] reversedCharacters)
        {
            var solution = new _0344_ReverseString();
            solution.ReverseString(chars);

            CollectionAssert.AreEqual(chars, reversedCharacters);
        }
    }
}