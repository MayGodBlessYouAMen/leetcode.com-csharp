using System.Collections.Generic;

namespace LeetCode.Com.Easy
{
    public class No0232
    {
        /** Initialize your data structure here. */
        public No0232()
        {

        }

        #region 超时了
        ///// <summary>
        ///// 主栈，按队列顺序排列
        ///// </summary>
        //private Stack<int> _mainStack = new Stack<int>();

        ///// <summary>
        ///// 缓存栈
        ///// </summary>
        //private Stack<int> _tempStack = new Stack<int>();

        ///** Push element x to the back of queue. */
        //public void Push(int x)
        //{
        //    //主栈出栈，压入缓存栈
        //    while (_mainStack.Count > 0)
        //    {
        //        _tempStack.Push(_mainStack.Pop());
        //    }

        //    //x压入主栈
        //    _mainStack.Push(x);

        //    //缓存栈出栈，返回主栈
        //    while (_tempStack.Count > 0)
        //    {
        //        _tempStack.Push(_tempStack.Pop());
        //    }

        //}

        ///** Removes the element from in front of queue and returns that element. */
        //public int Pop()
        //{
        //    return _mainStack.Pop();
        //}

        ///** Get the front element. */
        //public int Peek()
        //{
        //    return _mainStack.Peek();
        //}

        ///** Returns whether the queue is empty. */
        //public bool Empty()
        //{
        //    return _mainStack.Count <= 0;
        //}
        #endregion

        #region 新方法
        /// <summary>
        /// 负责输入
        /// </summary>
        private Stack<int> _inStack = new Stack<int>();

        /// <summary>
        /// 负责输出
        /// </summary>
        private Stack<int> _outStack = new Stack<int>();

        /** Push element x to the back of queue. */
        public void Push(int x)
        {
            _inStack.Push(x);
        }

        /** Removes the element from in front of queue and returns that element. */
        public int Pop()
        {
            //如果out栈为空，则将in栈所有数据拿过来
            if (_outStack.Count <= 0)
            {
                while (_inStack.Count > 0)
                {
                    _outStack.Push(_inStack.Pop());
                }
            }
            return _outStack.Pop();
        }

        /** Get the front element. */
        public int Peek()
        {
            //如果out栈为空，则将in栈所有数据拿过来
            if (_outStack.Count <= 0)
            {
                while (_inStack.Count > 0)
                {
                    _outStack.Push(_inStack.Pop());
                }
            }
            return _outStack.Peek();
        }

        /** Returns whether the queue is empty. */
        public bool Empty()
        {
            return _inStack.Count <= 0 && _outStack.Count <= 0;
        }
        #endregion

    }
}
