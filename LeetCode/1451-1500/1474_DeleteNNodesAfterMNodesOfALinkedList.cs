//https://leetcode.com/submissions/detail/358299314/

namespace LeetCode
{
    public class _1474_DeleteNNodesAfterMNodesOfALinkedList
    {
        public ListNode DeleteNodes(ListNode head, int m, int n)
        {
            var dummy = new ListNode(-1);
            dummy.next = head;

            var curr = dummy;
            while (curr != null)
            {
                int keep = m, remove = n;
                while (keep-- > 0 && curr != null)
                {
                    curr = curr.next;
                }
                while (remove-- > 0 && curr != null && curr.next != null)
                {
                    curr.next = curr.next.next;
                }
            }

            return dummy.next;
        }
    }
}