namespace Algorithms
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
                        Swap(i, i + 1, array);
                        isSorted = false;
                    }
                }
                counter++;
            }

            return array;
        }

        private static void Swap(int i, int j, int[] array)
        {
            (array[i], array[j]) = (array[j], array[i]);
        }
    }
}