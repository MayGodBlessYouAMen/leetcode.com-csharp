using LeetCode.Com.Com;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Com.Medium
{
    /// <summary>
    /// Merge Nodes in Between Zeros
    /// </summary>
    public class No2181
    {
        /*
            解题思路:遍历链表,将0之间的点求和,并合并为一个点.去除所有值为0的点。

            The number of nodes in the list is in the range [3, 2 * 105].
            0 <= Node.val <= 1000
            There are no two consecutive nodes with Node.val == 0.
            The beginning and end of the linked list have Node.val == 0.
         */
        public ListNode MergeNodes(ListNode head)
        {

            //从第二个节点开始。
            head = head.next;

            //定义新链表
            ListNode newNode = null;
            ListNode newHead = null;


            int sum = 0;
            while (head != null)
            {
                int currentVal = head.val;
                head = head.next;

                if (currentVal != 0)
                {
                    sum += currentVal;
                    continue;
                }

                {
                    //加入节点
                    if (newNode == null)
                    {
                        newNode = new ListNode(sum);

                        //新链表head赋值
                        newHead = newNode;
                    }
                    else
                    {
                        newNode.next = new ListNode(sum);
                        newNode = newNode.next;
                    }

                    sum = 0;
                }
            }

            return newHead;
        }
    }
}
