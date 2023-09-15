using LeetCode.Com.Com;
using System.Collections.Generic;

namespace LeetCode.Com.Easy
{
    /// <summary>
    /// No.501 Find Mode in Binary Search Tree
    /// </summary>
    public class No0501
    {
        /*
            思路:二叉查找树，中序遍历，可以完成值从小到大的遍历。
         */

        /// <summary>
        /// 数量最多的那个值放入此数组
        /// </summary>
        List<int> resList = new List<int>();

        /// <summary>
        /// 当前值
        /// </summary>
        int currentValue = int.MaxValue;

        /// <summary>
        /// 当前值计数
        /// </summary>
        int currentCount = -1;

        /// <summary>
        /// 上一个数量最多的值计数
        /// </summary>
        int preMaxCount = 0;

        public int[] FindMode(TreeNode root)
        {
            //递归遍历
            InorderTraversal(root);

            //最后一个currentValue的次数，递归函数中后续没有节点和它比较，所以还在在这里比较一次
            if (currentCount > preMaxCount)
            {
                resList.Clear();
                resList.Add(currentValue);
            }
            else if (currentCount == preMaxCount)
            {
                resList.Add(currentValue);
            }
            else
            {
                //啥也不做
            }

            return resList.ToArray();
        }

        /// <summary>
        /// 递归处理中序遍历
        /// </summary>
        /// <param name="node"></param>
        public void InorderTraversal(TreeNode node)
        {
            if (node == null)
            {
                return;
            }

            //左子树递归
            InorderTraversal(node.left);

            //节点value判断
            if (node.val != currentValue)
            {
                if (currentCount > preMaxCount)
                {
                    //数量比前一个最大数量大，先清空再添加
                    resList.Clear();
                    resList.Add(currentValue);
                    preMaxCount = currentCount;
                }
                else if (currentCount == preMaxCount)
                {
                    //数量相同时，加在数组后面
                    resList.Add(currentValue);
                }
                else
                {
                    //无操作
                }

                //currentValue改变时，重新计数
                currentValue = node.val;
                currentCount = 1;
            }
            else
            {
                //currentValue未改变，直接计数+1
                currentCount++;
            }

            //右子树递归
            InorderTraversal(node.right);
        }
    }
}
