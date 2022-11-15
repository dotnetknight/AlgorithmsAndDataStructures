using Algorithms.Sorting;

namespace Algorithms.Test.Sorting
{
    public class BaseSwap_Test
    {
        static readonly object[] BaseSwapTestCaseData =
            {
                new object[] { 0, 1, new int[] { 1, 2, 3, 4 } },
                new object[] { 2, 3, new int[] { 10, 24, 18, 9 } },
                new object[] { 2, 5, new int[] { -2, -4, 5, 3, 0, 1, 41 } }
            };

        [Test]
        [TestCaseSource(nameof(BaseSwapTestCaseData))]
        public void SwapIntegers_HasArray_SwapsElementsInArray(int i, int j, int[] array)
        {
            var iIndexValue = array[i];
            var jIndexValue = array[j];

            BaseSwap.SwapIntegers(i, j, array);

            Assert.Multiple(() =>
            {
                Assert.That(array[i], Is.EqualTo(jIndexValue));
                Assert.That(array[j], Is.EqualTo(iIndexValue));
            });
        }
    }
}