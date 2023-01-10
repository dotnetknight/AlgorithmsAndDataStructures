namespace LeetCode._0201_0250
{
    public class _0206_ReverseLinkedList
    {
        public ListNode ReverseList(ListNode head)
        {
            // O(n) time | O(1) space
            var dummyHead = new ListNode(-1);

            var current = head;
            while (current != null)
            {
                var next = current.next;

                current.next = dummyHead.next;
                dummyHead.next = current;

                current = next;
            }

            return dummyHead.next;
        }
    }
}