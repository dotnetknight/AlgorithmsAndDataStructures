using System.Collections;

namespace Algorithms.Test.TestCaseData
{
    public class LinearSearchInValidTestCaseData : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[] { new int[] { 1, 2, 3, 4 }, 5 };
            yield return new object[] { new int[] { 5, 6, 7, 8 }, 9 };
        }
    }
}