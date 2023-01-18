namespace LeetCode._0001_0050
{
    public class _021_MergeTwoSortedLists
    {
        public ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            var dummy = new ListNode(-1);
            var current = dummy;

            while (list1 != null && list2 != null)
            {
                if (list1.val <= list2.val)
                {
                    current = current.next = list1;
                    list1 = list1.next;
                }
                else
                {
                    current = current.next = list2;
                    list2 = list2.next;
                }
            }

            current.next = list1 ?? list2;
            return dummy.next;
        }
    }
}