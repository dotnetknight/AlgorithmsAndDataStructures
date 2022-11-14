using System.Collections;

namespace Algorithms.Test.TestCaseData
{
    public class EmptyIntegerArrayTestCaseData : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return Array.Empty<int>();
        }
    }
}