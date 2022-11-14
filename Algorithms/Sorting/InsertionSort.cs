namespace Algorithms.Sorting
{
    public class InsertionSort
    {
        // Best: O(n) time | O(1) space
        // Average: O(n^2) time | O(1) space
        // Worst: O(n^2) time | O(1) space
        public int[] Sort(int[] array)
        {
            if (array.Length == 0)
            {
                return Array.Empty<int>();
            }

            for (int i = 1; i < array.Length; i++)
            {
                int j = i;

                while (j > 0 && array[j] < array[j - 1])
                {
                    BaseSwap.SwapIntegers(j, j - 1, array);
                    j--;
                }
            }

            return array;
        }
    }
}