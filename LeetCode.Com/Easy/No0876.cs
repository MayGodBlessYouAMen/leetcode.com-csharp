using LeetCode.Com.Com;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Com.Easy
{
    /// <summary>
    /// Middle of the Linked List
    /// </summary>
    internal class No0876
    {
        /*
            解题思路:因为链表不知道长度，所以要遍历一遍才知道中点在哪里。

            注意：如果有两个中间节点：返回第二个
         */
        public ListNode MiddleNode(ListNode head)
        {
            int count = 0;

            //遍历计算链表长度
            ListNode node = head;
            while (node != null)
            {
                count++;
                node = node.next;
            }

            //计算中间点index（从1开始）
            int midIndex = count / 2 + 1;

            //再遍历找中点
            node = head;
            count = 0;
            while (node != null)
            {
                count++;

                if (count == midIndex)
                {
                    break;
                }

                node = node.next;
            }

            return node;

        }
    }
}
