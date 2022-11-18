using System.Collections;

namespace Algorithms.Test.TestCaseData
{
    public class SearchTestCaseData : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[] { new int[] { 1, 2, 3, 4 }, 1, 0 };
            yield return new object[] { new int[] { 5, 6, 7, 8 }, 8, 3 };
            yield return new object[] { new int[] { 1, 2, 3, 4 }, 5, -1 };
            yield return new object[] { new int[] { 5, 6, 7, 8 }, 9, -1 };
        }
    }
}