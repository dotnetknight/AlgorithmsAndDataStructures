namespace Algorithms.Searching
{
    public class LinearSearch
    {
        // Best: O(1) time | O(1) space
        // Average: O(n) time | O(1) space
        // Worst: O(n) time | O(1) space
        public int Search(int[] array, int target)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == target)
                {
                    return i;
                }
            }

            return -1;
        }
    }
}