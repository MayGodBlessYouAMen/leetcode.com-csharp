using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Com.Com
{
    // Definition for singly-linked list.
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }

        public override string ToString()
        {
            if (this == null)
            {
                return "";
            }
            string s = val.ToString();
            ListNode node = this;
            while (node.next != null)
            {
                node = node.next;
                s += "->" + node.val.ToString();
            }

            return s;
        }
    }
}
