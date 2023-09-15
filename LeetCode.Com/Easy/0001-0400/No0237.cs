using LeetCode.Com.Com;

namespace LeetCode.Com.Easy
{
    /// <summary>
    /// [237] Delete Node in a Linked List
    /// </summary>
    public class No0237
    {
        public void DeleteNode(ListNode node)
        {
            //题目没有给定整个链表的变量，只给个要删除的节点，那么把要删除的节点赋值为next，并指向next的next即可
            node.val = node.next.val;
            node.next = node.next.next;
        }
    }
}
