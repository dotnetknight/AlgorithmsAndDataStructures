using System.Collections;

namespace Algorithms.Test.TestCaseData
{
    public class LinearSearchValidTestCaseData : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[] { new int[] { 1, 2, 3, 4 }, 1, 0 };
            yield return new object[] { new int[] { 5, 6, 7, 8 }, 8, 3 };
        }
    }
}