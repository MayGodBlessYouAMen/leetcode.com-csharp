using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Com.Easy
{
    /// <summary>
    /// Kth Largest Element in a Stream
    /// </summary>
    internal class No0703
    {
        /*
            解题思路：
                题意：构造函数初始化一个数组，以及k
                每次执行Add方法时，添加一个数字到数组中，并返回数组中第K大的数字
                条件中保证k对应的值一定是存在的。所以不做k值校验
         */

        private int _k;
        private List<int> _list;

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="k"></param>
        /// <param name="nums"></param>
        //public KthLargest(int k, int[] nums)
        public No0703(int k, int[] nums)
        {
            this._k = k;
            _list = new List<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                AddValWithNoReturn(nums[i]);
            }
        }

        public int Add(int val)
        {
            AddValWithNoReturn(val);

            //根据题意，此处不用做k值合法性校验，直接返回对应值即可
            return _list[_list.Count - _k];
        }

        /// <summary>
        /// 插入val，升序排列
        /// </summary>
        /// <param name="val"></param>
        private void AddValWithNoReturn(int val)
        {
            //列表为空时，直接添加
            if (_list.Count == 0)
            {
                _list.Add(val);
                return;
            }

            //比最小值小，插入头部
            if (_list[0] >= val)
            {
                _list.Insert(0, val);
                return;
            }

            //比最大值大，插入末尾
            if (_list[_list.Count - 1] < val)
            {
                _list.Add(val);
                return;
            }

            int i = 0;
            int j = _list.Count - 1;
            int mid = (i + j) / 2;
            while (i < j)
            {
                if (i == j || i + 1 == j)
                {
                    _list.Insert(j, val);
                    break;
                }

                mid = (i + j) / 2;

                if (_list[mid] < val)
                {
                    i = mid;
                    continue;
                }

                if (_list[mid] > val)
                {
                    j = mid;
                    continue;
                }

                if (_list[mid] == val)
                {
                    _list.Insert(mid, val);
                    break;
                } 
            }

        }

    }
}
