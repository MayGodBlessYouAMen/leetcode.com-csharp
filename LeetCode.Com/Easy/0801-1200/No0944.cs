namespace LeetCode.Com.Easy
{
    /// <summary>
    /// [944]  Delete Columns to Make Sorted
    /// </summary>
    public class No0944
    {
        public int MinDeletionSize(string[] A)
        {
            /*
                思路：遍历。比较每列是否满足非递减排序。不满足的count+1，最后返回count
             */
            if (A == null || A.Length == 0) return 0;
            int count = 0;
            for (int i = 0; i < A[0].Length; i++)     //遍历所有列
            {
                for (int j = 0; j < A.Length - 1; j++)    //遍历第j列中的元素
                {
                    if (A[j][i] > A[j + 1][i])
                    {
                        count++; //递减,+1
                        break;
                    }
                }
            }

            return count;
        }
    }
}
