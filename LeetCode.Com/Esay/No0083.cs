using LeetCode.Com.Com;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Com.Esay
{
    /// <summary>
    /// Remove Duplicates from Sorted List
    /// </summary>
    public class No0083
    {
        public ListNode DeleteDuplicates(ListNode head)
        {
            //testcase: '[]'
            if (head == null) return head;

            ListNode node = head;
            ListNode node2 = head;
            int temp = head.val;
            while (node.next != null)
            {
                node = node.next;
                if (node.val != temp)
                {
                    temp = node.val;
                    node2.next = node;
                    node2 = node2.next;
                }
            }
            node2.next = null;

            return head;
        }
    }
}
