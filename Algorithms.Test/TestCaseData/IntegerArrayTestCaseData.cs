using System.Collections;

namespace Algorithms.Test.TestCaseData
{
    public class IntegerArrayTestCaseData : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return Array.Empty<int>();
            yield return new int[] { 2 };
            yield return new int[] { 3, 12, 23, 5, 0, 50 };
            yield return new int[] { -2, 4, 55, 23, 3, 1, 40 };
            yield return new int[] { -2, -42, -4, 18, 7, 95, 98 };
        }
    }
}