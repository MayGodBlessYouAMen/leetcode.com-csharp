using System;

namespace LeetCode.Com.Easy
{
    /// <summary>
    /// Count Good Triplets
    /// </summary>
    public class No1534
    {
        /*
            解题思路:暴力求解    

            3 <= arr.length <= 100
            0 <= arr[i] <= 1000
            0 <= a, b, c <= 1000
         */
        public int CountGoodTriplets(int[] arr, int a, int b, int c)
        {
            int count = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    for (int k = j + 1; k < arr.Length; k++)
                    {
                        if (Math.Abs(arr[i] - arr[j]) <= a &&
                            Math.Abs(arr[j] - arr[k]) <= b &&
                            Math.Abs(arr[i] - arr[k]) <= c)
                        {
                            count++;
                        }
                    }
                }
            }

            return count;
        }
    }
}
