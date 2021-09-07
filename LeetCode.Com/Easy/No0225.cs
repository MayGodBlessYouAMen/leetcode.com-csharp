using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Com.Easy
{
    /// <summary>
    /// 使用队列实现栈功能
    /// </summary>
    public class No0225
    {
        private Queue<int> _queue = new Queue<int>();

        /** Initialize your data structure here. */
        public No0225()
        {

        }

        /** Push element x onto stack. */
        public void Push(int x)
        {
            int count = _queue.Count;
            _queue.Enqueue(x);
            //将前面的元素拿出来重新扔到x后面
            for (int i = 0; i < count; i++)
            {
                int top = _queue.Dequeue();
                _queue.Enqueue(top);
            }
        }

        /** Removes the element on top of the stack and returns that element. */
        public int Pop()
        {
            return _queue.Dequeue();
        }

        /** Get the top element. */
        public int Top()
        {
            return _queue.Peek();
        }

        /** Returns whether the stack is empty. */
        public bool Empty()
        {
            return _queue.Count <= 0;
        }
    }
}
