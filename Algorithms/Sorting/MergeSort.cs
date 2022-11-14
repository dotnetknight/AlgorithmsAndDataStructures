namespace Algorithms.Sorting
{
    public class MergeSort
    {
        /*
        // Best: O(nlog(n)) time | O(nlog(n)) space
        // Average: O(nlog(n)) time | O(nlog(n)) space
        // Worst: O(nlog(n)) time | O(nlog(n)) space
        public int[] Sort(int[] array)
        {
            if (array.Length <= 1)
            {
                return array;
            }

            int middleIdx = array.Length / 2;
            int[] leftHalf = array.Take(middleIdx).ToArray();
            int[] rightHalf = array.Skip(middleIdx).ToArray();
            return MergeSortedArrays(Sort(leftHalf), Sort(rightHalf));
        }

        private int[] MergeSortedArrays(int[] leftHalf, int[] rightHalf)
        {
            int[] sortedArray = new int[leftHalf.Length + rightHalf.Length];
            int k = 0;
            int i = 0;
            int j = 0;

            while (i < leftHalf.Length && j < rightHalf.Length)
            {
                if (leftHalf[i] <= rightHalf[j])
                {
                    sortedArray[k++] = leftHalf[i++];
                }
                else
                {
                    sortedArray[k++] = rightHalf[j++];
                }
            }

            while (i < leftHalf.Length)
            {
                sortedArray[k++] = leftHalf[i++];
            }

            while (j < rightHalf.Length)
            {
                sortedArray[k++] = rightHalf[j++];
            }

            return sortedArray;
        }
        */




        // Best: O(nlog(n)) time | O(n) space
        // Average: O(nlog(n)) time | O(n) space
        // Worst: O(nlog(n)) time | O(n) space
        public int[] Sort(int[] array)
        {
            if (array.Length <= 1)
            {
                return array;
            }

            int[] auxiliaryArray = (int[])array.Clone();
            Sort(array, 0, array.Length - 1, auxiliaryArray);

            return array;
        }

        public void Sort(
            int[] mainArray,
            int startIdx,
            int endIdx,
            int[] auxiliaryArray)
        {
            if (startIdx == endIdx)
            {
                return;
            }

            int middleIdx = (startIdx + endIdx) / 2;

            Sort(auxiliaryArray, startIdx, middleIdx, mainArray);
            Sort(auxiliaryArray, middleIdx + 1, endIdx, mainArray);
            DoMerge(mainArray, startIdx, middleIdx, endIdx, auxiliaryArray);
        }

        private static void DoMerge(
            int[] mainArray,
            int startIdx,
            int middleIdx,
            int endIdx,
            int[] auxiliaryArray)
        {
            int k = startIdx;
            int i = startIdx;
            int j = middleIdx + 1;

            while (i <= middleIdx && j <= endIdx)
            {
                if (auxiliaryArray[i] <= auxiliaryArray[j])
                {
                    mainArray[k++] = auxiliaryArray[i++];
                }
                else
                {
                    mainArray[k++] = auxiliaryArray[j++];
                }
            }

            while (i <= middleIdx)
            {
                mainArray[k++] = auxiliaryArray[i++];
            }

            while (j <= endIdx)
            {
                mainArray[k++] = auxiliaryArray[j++];
            }
        }
    }
}