namespace MedianofTwoSortedArrays
{
    public class MedianOfTwoSortedArrays
    {
        public static double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            var result = new List<int>(nums1);
            result.AddRange(nums2);
            result.Sort();

            var resultCount = result.Count;
            var l = (int)Math.Floor((decimal)(resultCount / 2));

            if (resultCount % 2 != 0)
            {
                return result[l];
            }
            else
            {
                return (double)(result[l - 1] + result[l]) / 2;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter nums1 :");
            int[] nums1 = Array.ConvertAll(Console.ReadLine().Trim().Split(','), Convert.ToInt32);

            Console.WriteLine("Enter nums2 :");
            int[] nums2 = Array.ConvertAll(Console.ReadLine().Trim().Split(','), Convert.ToInt32);

            Console.WriteLine(FindMedianSortedArrays(nums1, nums2));
        }
    }
}