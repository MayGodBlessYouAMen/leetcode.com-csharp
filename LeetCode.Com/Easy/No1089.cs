using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Com.Easy
{
    /// <summary>
    /// Duplicate Zeros
    /// </summary>
    public class No1089
    {
        /*
            解题思路：新建一个list，遍历arr，将元素加入list，碰到0加两次。最后将list的值写回arr
         */
        public void DuplicateZeros(int[] arr)
        {
            List<int> list = new List<int>();
            foreach (var item in arr)
            {
                if (list.Count >= arr.Length) break; 

                list.Add(item);

                if (list.Count >= arr.Length) break;

                //0要加2次
                if (item == 0)
                {
                    list.Add(item);
                }

            }

            //list写回arr
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = list[i];
            }
        }
    }
}
