using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Com.Com
{
    public static class ExtendMethod
    {

        /// <summary>
        /// 链表末尾添加值
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
        /// 链表末尾添加链表（两个链表合并）
        /// </summary>
        /// <param name="node"></param>
        /// <param name="x"></param>
        /// <returns></returns>
        public static ListNode AddListNode(this ListNode node, ListNode node2)
        {
            if (node == null)
            {
                return node2;
            }

            if (node2 == null)
            {
                return node;
            }

            ListNode t = node;
            while (t.next != null)
            {
                t = t.next;
            }
            t.next = node2;

            return node;
        }

        /// <summary>
        /// 链表长度。提交leetcode时这个方法不方便提交，只能用于测试时。
        /// </summary>
        /// <param name="Node"></param>
        /// <returns></returns>
        public static int Length(this ListNode node)
        {
            if (node == null)
            {
                return 0;
            }
            int length = 0;
            while (node != null)
            {
                length++;
                node = node.next;
            }
            return length;
        }

        /// <summary>
        /// 扩展方法。打印链表所有元素(用->连接)。可以处理为null时的情况
        /// </summary>
        /// <returns></returns>
        public static string ToConsoleString(this ListNode head)
        {
            if (head == null)
            {
                return "null";
            }
            string s = head.val.ToString();
            ListNode node = head;
            while (node.next != null)
            {
                node = node.next;
                s += "->" + node.val.ToString();
            }

            return s;
        }

        ///// <summary>
        ///// Array数组文字打印
        ///// </summary>
        ///// <param name="arr"></param>
        ///// <returns></returns>
        //public static string ToConsoleString(this Array arr)
        //{
        //    if (arr == null || arr.Length == 0)
        //    {
        //        return "[]";
        //    }

        //    StringBuilder sb = new StringBuilder();
        //    sb.Append("[");
        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        if (i > 0)
        //        {
        //            sb.Append(",");
        //        }
        //        sb.Append(arr.GetValue(i).ToString());
        //    }
        //    sb.Append("]");

        //    return sb.ToString();
        //}

        /// <summary>
        /// IList<T>打印
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static string ToConsoleString<T>(this IList<T> arr)
        {
            if (arr == null || arr.Count == 0)
            {
                return "[]";
            }

            StringBuilder sb = new StringBuilder();
            sb.Append("[");
            for (int i = 0; i < arr.Count; i++)
            {
                if (i > 0)
                {
                    sb.Append(",");
                }

                //Console.WriteLine(typeof(T) is IList<object>);
                //Console.WriteLine(typeof(T) is IList<string>);
                //Console.WriteLine(typeof(T) is List<object>);
                //Console.WriteLine(typeof(T) is List<string>);
                //Console.WriteLine(typeof(T) == typeof(List<object>));
                //Console.WriteLine(typeof(T) == typeof(List<string>));
                //Console.WriteLine(typeof(T) == typeof(IList<object>));
                //Console.WriteLine(typeof(T) == typeof(IList<string>));   //true
                //Console.WriteLine(typeof(IList<object>).IsAssignableFrom(typeof(T)));
                //Console.WriteLine(typeof(IList<string>).IsAssignableFrom(typeof(T)));
                //Console.WriteLine(typeof(List<string>).IsAssignableFrom(typeof(T)));   //true

                if (typeof(T).Name == "IList`1")
                {
                    //这里是为了处理IList<IList<Tvalue>>这种情况
                    var list1 = arr[i] as IList<string>;
                    if (list1 != null)
                    {
                        sb.Append(list1.ToConsoleString());
                    }
                    else
                    {
                        var list2 = arr[i] as IList<int>;
                        sb.Append(list2.ToConsoleString());
                    }
                }
                else
                {
                    sb.Append(arr[i].ToString());
                }
            }
            sb.Append("]");

            return sb.ToString();
        }

        /// <summary>
        /// 前序遍历
        /// </summary>
        /// <param name="treeNode"></param>
        /// <returns></returns>
        public static string ToConsoleString(this TreeNode treeNode)
        {
            List<string> list = new List<string>();
            ToConsoleString(treeNode, list);
            return $"[{string.Join(",", list.ToArray())}]";
        }

        private static void ToConsoleString(TreeNode treeNode, List<string> list)
        {
            if (treeNode != null)
            {
                list.Add(treeNode.val.ToString());
                //左右同时为null时不操作
                if (!(treeNode.left == null && treeNode.right == null))
                {
                    if (treeNode.left == null)
                    {
                        list.Add("null");
                    }
                    else
                    {
                        ToConsoleString(treeNode.left, list);
                    }

                    if (treeNode.right == null)
                    {
                        //右子树为null时不用打印
                        list.Add("null");
                    }
                    else
                    {
                        ToConsoleString(treeNode.right, list);
                    }
                }
            }
        }

        /// <summary>
        /// 矩阵转string输出
        /// </summary>
        /// <param name="matrix"></param>
        /// <returns></returns>
        public static string ToConsoleString(this int[][] matrix)
        {
            List<string> list = new List<string>();
            for (int i = 0; i < matrix.Length; i++)
            {
                var array = matrix[i];
                var str = $"[{string.Join(",", array)}]";
                list.Add(str);
            }

            return $"[{string.Join(",", list.ToArray())}]";
        }
    }
}
