/**************************************************************
 * 创建时间：2023-09-20 14:05:43
 * 创建人：  akalin
 * 创建说明：
***************************************************************/

using LeetCode.Com.Com;
using System.Collections.Generic;

namespace LeetCode.Com.Easy
{
    /// <summary>
    /// Average of Levels in Binary Tree
    /// </summary>
    public class No0637
    { 
        public IList<double> AverageOfLevels(TreeNode root)
        {
            //定义变量记录每一层数据之和
            List<LevelData> levelDataList = new List<LevelData>();

            Traverse(root, ref levelDataList, 0);

            //处理数据
            var list = new List<double>();
            foreach (var item in levelDataList)
            {
                list.Add(item.Sum / item.Count);
            }
            return list;
        }
         
        class LevelData
        {
            /// <summary>
            /// 层数据和
            /// </summary>
            public double Sum { get; set; }

            /// <summary>
            /// 层数据计数
            /// </summary>
            public int Count { get; set; }

            public LevelData(int sum, int count)
            {
                this.Sum = sum;
                this.Count = count;
            }
        }

        /// <summary>
        /// 二叉树遍历
        /// </summary>
        private void Traverse(TreeNode root, ref List<LevelData> levelDataList, int depth)
        {
            if (root == null) return;

            //root --> 值加入第depth层
            while (levelDataList.Count < depth + 1)
            {
                levelDataList.Add(new LevelData(0, 0));
            }
            levelDataList[depth].Sum += root.val;
            levelDataList[depth].Count++;

            //left
            if (root.left != null)
            {
                Traverse(root.left, ref levelDataList, depth + 1);
            }

            //right
            if (root.right != null)
            {
                Traverse(root.right, ref levelDataList, depth + 1);
            }
        }
    }
}
