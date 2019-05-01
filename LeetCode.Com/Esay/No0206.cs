using LeetCode.Com.Com;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Com.Esay
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
