namespace TwoNum
{
    public class TwoNumberSum
    {
        public static int[] TwoSum(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length - 1; i++)
            {
                int firstNum = nums[i];
                for (int j = i + 1; j < nums.Length; j++)
                {
                    int secondNum = nums[j];
                    if (firstNum + secondNum == target)
                    {
                        return new int[] { i, j };
                    }
                }
            }
            return Array.Empty<int>();
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter numbers:");
            int[]? nums = Array.ConvertAll(Console.ReadLine().Trim().Split(','), Convert.ToInt32);

            Console.WriteLine("Enter target:");
            int target = Convert.ToInt32(Console.ReadLine());

            var result = TwoSum(nums, target);

            foreach (var r in result)
            {
                Console.Write(r.ToString() + " ");
            }
        }
    }
}