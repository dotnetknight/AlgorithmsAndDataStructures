namespace LeetCode._1251_1300
{
    //https://leetcode.com/submissions/detail/814662881/
    //https://leetcode.com/submissions/detail/814663765/
    public class _1290_ConvertBinaryNumberInALinkedListToInteger
    {
        public int GetDecimalValue(ListNode head)
        {
            uint result = 0;
            while (head != null)
            {
                result <<= 1;
                result += (uint)head.val;
                head = head.next;
            }

            return (int)result;
        }
    }
}