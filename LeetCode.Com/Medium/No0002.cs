using LeetCode.Com.Com;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Com.Medium
{
    /// <summary>
    /// Add Two Numbers
    /// </summary>
    public class No0002
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            return AddTwoNumbers(l1, l2, 0);
        }

        private ListNode AddTwoNumbers(ListNode l1, ListNode l2, int carry)
        {
            if (l1 == null && l2 == null && carry == 0)
            {
                return null;
            }
            int val = 0;
            if (l1 != null)
            {
                val += l1.val;
            }
            if (l2 != null)
            {
                val += l2.val;
            }
            val += carry;
            carry = val / 10;
            val = val % 10;
            ListNode node = new ListNode(val);

            if (l1 == null && l2 == null)
            {
                node.next = AddTwoNumbers(null, null, carry);
                return node;
            }
            if (l1 == null)
            {
                node.next = AddTwoNumbers(null, l2.next, carry);
                return node;
            }
            if (l2 == null)
            {
                node.next = AddTwoNumbers(l1.next, null, carry);
                return node;
            }

            node.next = AddTwoNumbers(l1.next, l2.next, carry);
            return node;
        }
    }
}
