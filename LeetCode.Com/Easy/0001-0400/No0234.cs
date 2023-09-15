using LeetCode.Com.Com;
using System.Collections.Generic;

namespace LeetCode.Com.Easy
{
    /// <summary>
    /// Palindrome Linked List
    /// </summary>
    public class No0234
    {
        /**
         * Definition for singly-linked list.
         * public class ListNode {
         *     public int val;
         *     public ListNode next;
         *     public ListNode(int val=0, ListNode next=null) {
         *         this.val = val;
         *         this.next = next;
         *     }
         * }
         */

        public bool IsPalindrome(ListNode head)
        {
            if (head == null)
            {
                return false;
            }

            List<int> list = new List<int>();

            while (head != null)
            {
                list.Add(head.val);
                head = head.next;
            }

            for (int i = 0; i < list.Count / 2; i++)
            {
                if (list[i] != list[list.Count - 1 - i])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
