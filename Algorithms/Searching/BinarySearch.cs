namespace Algorithms.Searching
{
    public class BinarySearch
    {
        // O(log(n)) time | O(log(n)) space
        public int BinarySearchRecursive(int[] array, int target)
        {
            return RecursiveSearch(array, target, 0, array.Length - 1);
        }

        private int RecursiveSearch(int[] array, int target, int left, int right)
        {
            if (left > right)
            {
                return -1;
            }

            int middle = (left + right) / 2;
            int potentialMatch = array[middle];

            if (target == potentialMatch)
            {
                return middle;
            }
            else if (target < potentialMatch)
            {
                return RecursiveSearch(array, target, left, middle - 1);
            }
            else
            {
                return RecursiveSearch(array, target, middle + 1, right);
            }
        }


        // O(log(n)) time | O(1) space
        public int BinarySearchIterative(int[] array, int target)
        {
            return Search(array, target, 0, array.Length - 1);
        }

        private int Search(int[] array, int target, int left, int right)
        {
            while (left <= right)
            {
                int middle = (left + right) / 2;
                int potentialMatch = array[middle];

                if (target == potentialMatch)
                {
                    return middle;
                }
                else if (target < potentialMatch)
                {
                    right = middle - 1;
                }
                else
                {
                    left = middle + 1;
                }
            }

            return -1;
        }
    }
}