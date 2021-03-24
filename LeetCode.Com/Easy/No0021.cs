using LeetCode.Com.Com;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Com.Easy
{
    /// <summary>
    /// Merge Two Sorted Lists
    /// </summary>
    public class No0021
    {
        public ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            ListNode l3 = null;
            ListNode t1 = l1;
            ListNode t2 = l2;
            while (t1 != null || t2 != null)
            {
                if (t1 != null && t2 == null)
                {
                    l3 = AddNode(l3, t1.val);

                    t1 = t1.next;
                    continue;
                }

                if (t1 == null && t2 != null)
                {
                    l3 = AddNode(l3, t2.val);


                    t2 = t2.next;
                    continue;
                }

                if (t1.val <= t2.val)
                {
                    l3 = AddNode(l3, t1.val);

                    t1 = t1.next;
                    continue;
                }
                else
                {
                    if (t1.val > t2.val)
                    {
                        l3 = AddNode(l3, t2.val);

                        t2 = t2.next;
                        continue;
                    }
                }
            }

            return l3;
        }

        public ListNode AddNode(ListNode node, int x)
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
