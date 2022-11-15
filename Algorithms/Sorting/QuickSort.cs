namespace Algorithms.Sorting
{
    public class QuickSort
    {
        // Best: O(nlog(n)) time | O(log(n)) space
        // Average: O(nlog(n)) time | O(log(n)) space
        // Worst: O(n^2) time | O(log(n)) space
        public int[] Sort(int[] array)
        {
            Sort(array, 0, array.Length - 1);
            return array;
        }

        private void Sort(int[] array, int startIdx, int endIdx)
        {
            if (startIdx >= endIdx)
            {
                return;
            }

            int pivotIdx = startIdx;
            int leftIdx = startIdx + 1;
            int rightIdx = endIdx;

            while (rightIdx >= leftIdx)
            {
                if (array[leftIdx] > array[pivotIdx] && array[rightIdx] < array[pivotIdx])
                {
                    BaseSwap.SwapIntegers(leftIdx, rightIdx, array);
                }

                if (array[leftIdx] <= array[pivotIdx])
                {
                    leftIdx += 1;
                }

                if (array[rightIdx] >= array[pivotIdx])
                {
                    rightIdx -= 1;
                }
            }

            BaseSwap.SwapIntegers(pivotIdx, rightIdx, array);

            bool leftSubarrayIsSmaller = rightIdx - 1 - startIdx < endIdx - (rightIdx + 1);
            if (leftSubarrayIsSmaller)
            {
                Sort(array, startIdx, rightIdx - 1);
                Sort(array, rightIdx + 1, endIdx);
            }
            else
            {
                Sort(array, rightIdx + 1, endIdx);
                Sort(array, startIdx, rightIdx - 1);
            }
        }
    }
}