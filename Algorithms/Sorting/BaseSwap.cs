namespace Algorithms.Sorting
{
    public static class BaseSwap
    {
        public static void SwapIntegers(int i, int j, int[] array)
        {
            (array[i], array[j]) = (array[j], array[i]);
        }
    }
}