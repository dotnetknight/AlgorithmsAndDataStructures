namespace Algorithms
{
    public class SelectionSort
    {
        // Best: O(n^2) time | O(1) space
        // Average: O(n^2) time | O(1) space
        // Worst: O(n^2) time | O(1) space
        public int[] Sort(int[] array)
        {
            if (array.Length == 0)
            {
                return Array.Empty<int>();
            }

            int startIdx = 0;
            while (startIdx < array.Length - 1)
            {
                int smallestIdx = startIdx;
                
                for (int i = startIdx + 1; i < array.Length; i++)
                {
                    if (array[smallestIdx] > array[i])
                    {
                        smallestIdx = i;
                    }
                }

                Swap(startIdx, smallestIdx, array);
                startIdx++;
            }

            return array;
        }

        public void Swap(int i, int j, int[] array)
        {
            (array[i], array[j]) = (array[j], array[i]);
        }
    }
}