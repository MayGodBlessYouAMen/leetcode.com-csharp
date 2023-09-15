using LeetCode.Com.Com;

namespace LeetCode.Com.Easy
{
    /// <summary>
    /// Convert Binary Number in a Linked List to Integer
    /// </summary>
    public class No1290
    {
        /*
            解题思路：A(1) = head.val;  S(n+1) = S(n) * 2 + A(n) 
         */
        public int GetDecimalValue(ListNode head)
        {
            //第一个节点
            int sum = head.val;

            //从第二个节点开始遍历
            var node = head.next;
            while (node != null)
            {
                sum = sum * 2 + node.val;
                node = node.next;
            }

            return sum;
        }
    }
}
