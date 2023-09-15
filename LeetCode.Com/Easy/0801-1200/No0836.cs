namespace LeetCode.Com.Easy
{
    /// <summary>
    /// Rectangle Overlap
    /// </summary>
    internal class No0836
    {
        /*
            解题思路：判断两个长方形是否有重叠。
                     可以先判断两个长方形无重叠的情况，如果不满足即是有重叠。
                     
                注意：只有边和点的重叠不算重叠。
         */
        public bool IsRectangleOverlap(int[] rec1, int[] rec2)
        {
            if (IsNotRectangleOverlap(rec1, rec2))
            {
                return false;
            }

            return true;
        }

        /// <summary>
        /// 不重合的情况
        /// </summary>
        /// <param name="rec1"></param>
        /// <param name="rec2"></param>
        /// <returns></returns>
        private bool IsNotRectangleOverlap(int[] rec1, int[] rec2)
        {
            if (IsOnLeft(rec1, rec2))
            {
                return true;
            }

            if (IsOnRigth(rec1, rec2))
            {
                return true;
            }

            if (IsOnTop(rec1, rec2))
            {
                return true;
            }

            if (IsOnBottom(rec1, rec2))
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// 左边:1的右侧边x坐标小于2的左侧边x坐标
        /// </summary>
        /// <param name="rec1"></param>
        /// <param name="rec2"></param>
        /// <returns></returns>
        private bool IsOnLeft(int[] rec1, int[] rec2)
        {
            if (rec1[2] <= rec2[0])
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// 右边:1的左侧边x坐标大于2的右侧边x坐标
        /// </summary>
        /// <param name="rec1"></param>
        /// <param name="rec2"></param>
        /// <returns></returns>
        private bool IsOnRigth(int[] rec1, int[] rec2)
        {
            if (rec1[0] >= rec2[2])
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// 上边:1的下侧边y坐标大于2的上侧边y坐标
        /// </summary>
        /// <param name="rec1"></param>
        /// <param name="rec2"></param>
        /// <returns></returns>
        private bool IsOnTop(int[] rec1, int[] rec2)
        {
            if (rec1[1] >= rec2[3])
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// 下边:1的上侧边y坐标小于2的下侧边y坐标
        /// </summary>
        /// <param name="rec1"></param>
        /// <param name="rec2"></param>
        /// <returns></returns>
        private bool IsOnBottom(int[] rec1, int[] rec2)
        {
            if (rec1[3] <= rec2[1])
            {
                return true;
            }
            return false;
        }
    }
}
