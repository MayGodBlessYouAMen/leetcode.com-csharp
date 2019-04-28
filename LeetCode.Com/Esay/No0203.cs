using LeetCode.Com.Com;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Com.Esay
{
    /// <summary>
    /// [203] Remove Linked List Elements
    /// </summary>
    public class No0203
    {

        public ListNode RemoveElements(ListNode head, int val)
        {
            if (head == null) return null;    //别忘记检查null

            ListNode _head = null;
            ListNode node = null;

            if (head.val != val)
            {
                _head = new ListNode(head.val);
                node = _head;
            }

            while (head.next != null)
            {
                head = head.next;
                if (head.val == val) continue;

                if (_head == null)
                {
                    _head = new ListNode(head.val);
                    node = _head;
                }
                else
                {
                    //错误写法
                    //node = node.next;
                    //node = new ListNode(head.val);
                   
                    //正确写法
                    node.next = new ListNode(head.val); 
                    node = node.next;
                }
            }

            return _head;
        }
    }
}
