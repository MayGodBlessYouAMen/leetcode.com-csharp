namespace LeetCode.Com.Easy
{
    /// <summary>
    /// Final Value of Variable After Performing Operations
    /// </summary>
    public class No2011
    {
        /*
            解题思路：水题，略
         */
        public int FinalValueAfterOperations(string[] operations)
        {
            int res = 0;
            foreach (var item in operations)
            {
                switch (item)
                {
                    case "++X":
                    case "X++":
                        res++;
                        break;
                    case "--X":
                    case "X--":
                        res--;
                        break;
                    default:
                        break;
                }
            }

            return res;
        }
    }
}
