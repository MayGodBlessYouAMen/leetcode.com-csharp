using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Com.Com
{
    public static class ExtendMethod
    {

        /// <summary>
        /// 链表添加节点
        /// </summary>
        /// <param name="node"></param>
        /// <param name="x"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Array数组文字打印
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static string ToConsoleString(this Array arr)
        {
            if (arr == null || arr.Length == 0)
            {
                return "[]";
            }

            StringBuilder sb = new StringBuilder();
            sb.Append("[");
            for (int i = 0; i < arr.Length; i++)
            {
                if (i > 0)
                {
                    sb.Append(",");
                }
                sb.Append(arr.GetValue(i).ToString());
            }
            sb.Append("]");

            return sb.ToString();
        }
    }
}
