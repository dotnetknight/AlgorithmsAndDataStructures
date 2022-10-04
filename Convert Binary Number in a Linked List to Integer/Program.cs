namespace Program
{
    // https://leetcode.com/submissions/detail/814663765/


    public class Solution
    {
        public int GetDecimalValueHelper(ListNode head, int acc)
        {
            if (head == null)
            {
                return acc;
            }
            return GetDecimalValueHelper(head.next, head.val + acc * 2);
        }

        public int GetDecimalValue(ListNode head)
        {
            if (head == null)
            {
                return 0;
            }
            var acc = 0;
            while (head != null)
            {
                acc = head.val + acc * 2;
                head = head.next;
            }
            return acc;
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {

        }
    }
}