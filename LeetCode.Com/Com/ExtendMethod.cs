using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Com.Com
{
    public static class ExtendMethod
    {
        public static ListNode AddNode(this ListNode node, int x)
        {
            if (node == null)
            {
                return new ListNode(x);
            }

            ListNode t = node;
            while (t.next != null)
            {
                t = t.next;
            }
            t.next = new ListNode(x);

            return node;
        }
    }
}
