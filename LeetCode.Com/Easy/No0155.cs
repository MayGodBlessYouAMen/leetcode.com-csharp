using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Com.Easy
{
    /// <summary>
    /// [155] Min Stack  
    /// </summary>
    public class No0155
    {
        #region 使用一个List，超时。 优化：增加一个保存最小值的list,AC
        /// <summary>
        /// 存放栈数据
        /// </summary>
        private List<int> _list = null;

        /// <summary>
        /// 增加一个list用来存储前i个元素的最小值，长度与数据list保持一致
        /// </summary>
        private List<int> _listMin = null;

        public No0155()
        {
            _list = new List<int>();
            _listMin = new List<int>();
        }

        /// <summary>
        /// 入栈
        /// </summary>
        /// <param name="x"></param>
        public void Push(int x)
        {
            _list.Add(x);

            if (_listMin.Count <=0)
            {
                _listMin.Add(x);
            }
            else
            {
                //_listMin[_listMin.count - 1]是前i个里的最小值，与x相比，较小的那个插入_listMin
                if (_listMin[_listMin.Count - 1] < x)
                {
                    _listMin.Add(_listMin[_listMin.Count - 1]);
                }
                else
                {
                    _listMin.Add(x);
                }
            }

        }

        /// <summary>
        /// 出栈
        /// (插入和删除端为栈顶。)
        /// </summary>
        public void Pop()
        {
            if (_list.Count == 0)
            {
                return;
            }

            _list.RemoveAt(_list.Count - 1);

            //同步移除
            _listMin.RemoveAt(_listMin.Count - 1);
        }

        /// <summary>
        /// 获取栈顶元素
        /// </summary>
        /// <returns></returns>
        public int Top()
        {
            if (_list.Count == 0)
            {
                return 0;
            }

            return _list[_list.Count - 1];
        }

        /// <summary>
        /// 获取最小值
        /// </summary>
        /// <returns></returns>
        public int GetMin()
        {
            if (_list.Count == 0)
            {
                return 0;
            }

            #region 题目要求所有方法返回时间恒定，应该是要求O(1),排序会超时
            //int[] arr = _list.ToArray<int>();
            //Array.Sort(arr);
            //return arr[0];
            #endregion

            #region 增加最小值list后
            return _listMin[_listMin.Count - 1];
            #endregion
        }
        #endregion
    }
}
