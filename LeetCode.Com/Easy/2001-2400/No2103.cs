namespace LeetCode.Com.Easy
{
    /// <summary>
    /// Rings and Rods
    /// </summary>
    public class No2103
    {
        /*
            解题思路：0-9上定义容量为3的数组，分别代表是否有RGB，环放置结束之后再遍历0-9

            rings.length == 2 * n
            1 <= n <= 100
            rings[i] where i is even is either 'R', 'G', or 'B' (0-indexed).
            rings[i] where i is odd is a digit from '0' to '9' (0-indexed).
         */
        public int CountPoints(string rings)
        {
            int[][] rods = new int[10][];
            for (int i = 0; i <= 9; i++)
            {
                rods[i] = new int[] { 0, 0, 0 };  //RGB
            }

            int n = rings.Length / 2;
            for (int i = 0; i < n; i++)
            {
                int index = int.Parse(rings[i * 2 + 1].ToString());
                switch (rings[i * 2])
                {
                    case 'R':
                        rods[index][0] = 1;
                        break;
                    case 'G':
                        rods[index][1] = 1;
                        break;
                    case 'B':
                        rods[index][2] = 1;
                        break;
                    default:
                        break;
                }
            }

            int count = 0;
            for (int i = 0; i <= 9; i++)
            {
                if (rods[i][0] == 1 && rods[i][1] == 1 && rods[i][2] == 1)
                {
                    count++;
                }
            }

            return count;
        }
    }
}
