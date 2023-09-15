namespace LeetCode.Com.Com
{
    // Definition for singly-linked list.
    public class ListNode
    {
        public int val;
        public ListNode next;

        public ListNode(int val)
        {
            this.val = val;
        }

        public ListNode(int val, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }

        /// <summary>
        /// 重写方法。打印链表所有元素(用->连接)。无法处理为null时的情况
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            if (this == null)
            {
                return "null";
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
