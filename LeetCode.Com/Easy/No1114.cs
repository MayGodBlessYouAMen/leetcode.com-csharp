using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Com.Easy
{
    /// <summary>
    /// Print in Order
    /// </summary>
    public class No1114
    {
        /*
            解题思路：三个线程分别调用123三个方法，input给定了三个方法调用顺序，
                    要求不论input顺序如何，最终输出结果都是firstsecondthird
         */

        public No1114()
        {
            Init();
        }

        public void Init()
        {
            _Step = 0;
            //Console.WriteLine("0");
        }

        /// <summary>
        /// 当前进度 1,2,3
        /// </summary>
        private int _Step = 0;

        public void First(Action printFirst)
        {
            //Console.WriteLine("1 wait");

            //sleep等待
            while (_Step != 0)
            {
                System.Threading.Thread.Sleep(100);
            }

            //Console.WriteLine("1 in");

            // printFirst() outputs "first". Do not change or remove this line.
            printFirst();

            //修改进度
            _Step = 1;
        }

        public void Second(Action printSecond)
        {
            //Console.WriteLine("2 wait");

            //sleep等待
            while (_Step != 1)
            {
                System.Threading.Thread.Sleep(100);
            }

            //Console.WriteLine("2 in");

            // printSecond() outputs "second". Do not change or remove this line.
            printSecond();

            //修改进度
            _Step = 2;
        }

        public void Third(Action printThird)
        {

            //Console.WriteLine("3 wait");
            //sleep等待
            while (_Step != 2)
            {
                System.Threading.Thread.Sleep(100);
            }

            //Console.WriteLine("3 in");

            // printThird() outputs "third". Do not change or remove this line.
            printThird();

            //修改进度
            _Step = 3;
        }
    }
}
