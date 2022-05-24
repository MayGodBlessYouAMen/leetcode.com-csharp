using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Com.Easy
{
    /// <summary>
    /// Design HashSet
    /// </summary>
    public class No0705
    { 
        /*
            解题思路：直接申请容量为10^6+1的数组。如果有数字，则标记为1

            0 <= key <= 10^6
            At most 10^4 calls will be made to add, remove, and contains.
         */

        //public MyHashSet()
        public No0705()
        {

        }

        int[] array = new int[1000001];

        public void Add(int key)
        {
            array[key] = 1;
        }

        public void Remove(int key)
        {
            array[key] = 0;
        }

        public bool Contains(int key)
        {
            return array[key] == 1;
        }
    }
}
