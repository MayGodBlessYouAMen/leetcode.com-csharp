using LeetCode.Com.Com;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Com.Easy
{
    /// <summary>
    /// Intersection of Two Linked Lists
    /// </summary>
    public class No0160
    {
        public ListNode GetIntersectionNode(ListNode headA, ListNode headB)
        {
            if (headA == null || headB == null)
            {
                return null;
            }

            int lengthA = GetLength(headA);
            int lengthB = GetLength(headB);
            ListNode nodea = lengthA > lengthB ? headA : headB;
            ListNode nodeb = lengthA > lengthB ? headB : headA;

            for (int i = 0; i < Math.Abs(lengthA - lengthB); i++)
            {
                nodea = nodea.next;
            }
            //skipA,skipB是什么鬼？ -->初始化链表时，skip位置之后的为两链表公共部分
            //注意两个链表比较的是地址相同的子链，不是简单的值相等。
            while (nodea != null && nodeb != null && nodea != nodeb)
            {
                nodea = nodea.next;
                nodeb = nodeb.next;
            }

            return nodea == null ? null : nodea;
        }

        /// <summary>
        /// 获取链表长度
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        public int GetLength(ListNode head)
        {
            if (head == null)
            {
                return 0;
            }
            int length = 0;
            var node = head;
            while (node != null)
            {
                length++;
                node = node.next;
            }
            return length;
        }
    }
}
