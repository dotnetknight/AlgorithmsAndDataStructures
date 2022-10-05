//https://leetcode.com/submissions/detail/815414222/

namespace LeetCode._0851_0900
{
    public class _0876_MiddleOfTheLinkedList
    {
        public ListNode MiddleNode(ListNode head)
        {
            var fast = head;
            var slow = head;

            while (fast != null && fast.next != null)
            {
                fast = fast.next.next;
                slow = slow.next;
            }

            return slow;
        }
    }
}