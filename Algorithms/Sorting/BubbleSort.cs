namespace Algorithms.Sorting
{
    public class BubbleSort
    {
        // Best: O(n) time | O(1) space - When list is already sorted
        // Average: O(n^2) time | O(1) space
        // Worst: O(n^2) time | O(1) space
        public int[] Sort(int[] array)
        {
            if (array.Length == 0)
            {
                return Array.Empty<int>();
            }

            bool isSorted = false;
            int counter = 0;

            while (!isSorted)
            {
                isSorted = true;
                
                for (int i = 0; i < array.Length - 1 - counter; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        BaseSwap.SwapIntegers(i, i + 1, array);
                        isSorted = false;
                    }
                }

                counter++;
            }

            return array;
        }
    }
}