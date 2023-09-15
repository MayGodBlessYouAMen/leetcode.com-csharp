using LeetCode.Com.Com;

namespace LeetCode.Com.Easy
{
    /// <summary>
    /// [206] Reverse Linked List
    /// </summary>
    public class No0206
    {
        public ListNode ReverseList(ListNode head)
        {
            if (head == null || head.next == null) return head;
            //递归
            ListNode newnode = ReverseList(head.next);
            head.next.next = head;
            head.next = null;

            return newnode;
        }
    }
}
